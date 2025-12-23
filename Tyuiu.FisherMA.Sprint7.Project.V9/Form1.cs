using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Tyuiu.FisherMA.Sprint7.Project.V9.Lib;

namespace Tyuiu.FisherMA.Sprint7.Project.V9
{
    public partial class Form1 : Form
    {
        private readonly DataService dataService_FMA = new DataService();
        private DataTable videoTable_FMA;
        private DataView videoView_FMA; 


        public Form1() { InitializeComponent(); }

        private void buttonLoadCsv_FMA_Click(object sender, EventArgs e)
        {
            videoTable_FMA = dataService_FMA.LoadFromCsv("videoclips.csv");
            videoView_FMA = new DataView(videoTable_FMA);
            dataGridViewVideoCatalog_FMA.DataSource = videoView_FMA;
            UpdateStatistics_FMA();
            panelChart_FMA.Invalidate();
        }

        private void buttonSaveCsv_FMA_Click(object sender, EventArgs e)
        {
            if (videoTable_FMA == null) return;
            dataService_FMA.SaveToCsv(videoTable_FMA, "videoclips.csv");
            MessageBox.Show("Файл сохранён");
        }

        private void buttonAddRecord_FMA_Click(object sender, EventArgs e)
        {
            if (videoTable_FMA == null) return;

            videoTable_FMA.Rows.Add(
                textBoxCode_FMA.Text,
                dateTimePickerRecordDate_FMA.Value,
                int.Parse(textBoxDuration_FMA.Text),
                textBoxTheme_FMA.Text,
                double.Parse(textBoxCost_FMA.Text),
                textBoxActorName_FMA.Text,
                textBoxActorRole_FMA.Text
            );

            UpdateStatistics_FMA();
            panelChart_FMA.Invalidate();
        }

        private void UpdateStatistics_FMA()
        {
            if (videoTable_FMA == null) return;
            labelCount_FMA.Text = $"Количество: {videoTable_FMA.Rows.Count}";
            labelSum_FMA.Text = $"Сумма: {dataService_FMA.SumCost(videoTable_FMA)}";
            labelAvg_FMA.Text = $"Среднее: {dataService_FMA.AverageCost(videoTable_FMA)}";
            labelMin_FMA.Text = $"Min: {dataService_FMA.MinCost(videoTable_FMA)}";
            labelMax_FMA.Text = $"Max: {dataService_FMA.MaxCost(videoTable_FMA)}";
        }

        private void panelChart_FMA_Paint(object sender, PaintEventArgs e)
        {
            if (videoTable_FMA == null || videoTable_FMA.Rows.Count == 0) return;

            Graphics g = e.Graphics;
            g.Clear(Color.White);

            double maxCost = videoTable_FMA.AsEnumerable().Max(r => r.Field<double>("Cost"));
            int barWidth = Math.Max(panelChart_FMA.Width / videoTable_FMA.Rows.Count, 10);
            int chartHeight = panelChart_FMA.Height - 20;

            for (int i = 0; i < videoTable_FMA.Rows.Count; i++)
            {
                double cost = videoTable_FMA.Rows[i].Field<double>("Cost");
                int barHeight = (int)(cost / maxCost * chartHeight);

                Rectangle rect = new Rectangle(
                    i * barWidth + 5,
                    panelChart_FMA.Height - barHeight - 10,
                    barWidth - 10,
                    barHeight
                );

                g.FillRectangle(Brushes.SteelBlue, rect);
                g.DrawRectangle(Pens.Black, rect);
            }
        }

        private void buttonApplyFilter_FMA_Click(object sender, EventArgs e)
        {
            if (videoView_FMA == null) return;

            string filterText = textBoxSearch_FMA.Text.Trim().Replace("'", "''");
            string filterTheme = comboBoxFilter_FMA.SelectedItem.ToString();

            string filter = "";

            if (!string.IsNullOrEmpty(filterText))
            {
                filter += $"Theme LIKE '%{filterText}%' OR Actor LIKE '%{filterText}%'";
            }

            if (filterTheme != "Все")
            {
                if (!string.IsNullOrEmpty(filter)) filter += " AND ";
                filter += $"Theme = '{filterTheme}'";
            }

            videoView_FMA.RowFilter = filter;
        }
    }
}
