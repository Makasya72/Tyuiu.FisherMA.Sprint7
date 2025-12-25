using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Tyuiu.FisherMA.Sprint7.Project.V9.Lib;
using System.Drawing.Drawing2D;

namespace Tyuiu.FisherMA.Sprint7.Project.V9
{
    public partial class Form1 : Form
    {
        private DataService dataService_FMA = new DataService();
        private DataTable videoTable_FMA;
        private DataView videoView_FMA;
        private int editIndex = -1;

        public Form1() => InitializeComponent();

        private void buttonLoadCsv_FMA_Click(object sender, EventArgs e)
        {
            videoTable_FMA = dataService_FMA.LoadFromCsv("videoclips.csv");
            videoView_FMA = new DataView(videoTable_FMA);
            dataGridViewVideoCatalog_FMA.DataSource = videoView_FMA;
            UpdateStats();
            panelChart_FMA.Invalidate();
        }

        private void buttonSaveCsv_FMA_Click(object sender, EventArgs e)
        {
            if (videoTable_FMA == null) return;
            dataService_FMA.SaveToCsv(videoTable_FMA, "videoclips.csv");
            MessageBox.Show("Сохранено");
        }

        private void buttonAddRecord_FMA_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxDuration_FMA.Text, out int dur) ||
                !double.TryParse(textBoxCost_FMA.Text, out double cost))
            {
                MessageBox.Show("Ошибка ввода числовых данных");
                return;
            }

            if (editIndex >= 0)
            {
                DataRow r = videoTable_FMA.Rows[editIndex];
                r["Code"] = textBoxCode_FMA.Text;
                r["Date"] = dateTimePickerRecordDate_FMA.Value;
                r["Duration"] = dur;
                r["Theme"] = textBoxTheme_FMA.Text;
                r["Cost"] = cost;
                r["Actor"] = textBoxActorName_FMA.Text;
                r["Role"] = textBoxActorRole_FMA.Text;
                editIndex = -1;
            }
            else
            {
                videoTable_FMA.Rows.Add(
                    textBoxCode_FMA.Text,
                    dateTimePickerRecordDate_FMA.Value,
                    dur,
                    textBoxTheme_FMA.Text,
                    cost,
                    textBoxActorName_FMA.Text,
                    textBoxActorRole_FMA.Text
                );
            }

            UpdateStats();
            panelChart_FMA.Invalidate();
        }

        private void dataGridViewVideoCatalog_FMA_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            editIndex = e.RowIndex;
            if (editIndex < 0) return;
            DataRow r = videoTable_FMA.Rows[editIndex];
            textBoxCode_FMA.Text = r["Code"].ToString();
            dateTimePickerRecordDate_FMA.Value = (DateTime)r["Date"];
            textBoxDuration_FMA.Text = r["Duration"].ToString();
            textBoxTheme_FMA.Text = r["Theme"].ToString();
            textBoxCost_FMA.Text = r["Cost"].ToString();
            textBoxActorName_FMA.Text = r["Actor"].ToString();
            textBoxActorRole_FMA.Text = r["Role"].ToString();
        }

        private void buttonSearch_FMA_Click(object sender, EventArgs e)
        {
            videoView_FMA.RowFilter = $"Actor LIKE '%{textBoxSearchActor_FMA.Text}%'";
            panelChart_FMA.Invalidate();
        }

        private void buttonReset_FMA_Click(object sender, EventArgs e)
        {
            textBoxSearchActor_FMA.Clear();
            videoView_FMA.RowFilter = "";
            videoView_FMA.Sort = "";
            comboBoxSort_FMA.SelectedIndex = 0;
            panelChart_FMA.Invalidate();
        }

        private void comboBoxSort_FMA_SelectedIndexChanged(object sender, EventArgs e)
        {
            videoView_FMA.Sort = comboBoxSort_FMA.SelectedIndex switch
            {
                1 => "Cost ASC",
                2 => "Cost DESC",
                3 => "Duration ASC",
                4 => "Duration DESC",
                5 => "Date ASC",
                6 => "Date DESC",
                _ => ""
            };
            panelChart_FMA.Invalidate();
        }

        private void UpdateStats()
        {
            labelCount_FMA.Text = $"Количество: {videoTable_FMA.Rows.Count}";
            labelSum_FMA.Text = $"Сумма: {dataService_FMA.SumCost(videoTable_FMA):0}";
            labelAvg_FMA.Text = $"Среднее: {dataService_FMA.AverageCost(videoTable_FMA):0}";
            labelMin_FMA.Text = $"Min: {dataService_FMA.MinCost(videoTable_FMA):0}";
            labelMax_FMA.Text = $"Max: {dataService_FMA.MaxCost(videoTable_FMA):0}";
        }

        private void panelChart_FMA_Paint(object sender, PaintEventArgs e)
        {
            if (videoView_FMA == null || videoView_FMA.Count == 0) return;

            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.Clear(Color.White);

            var values = videoView_FMA.Cast<DataRowView>()
                .Select(r => Convert.ToDouble(r["Cost"])).ToList();

            double max = values.Max();
            int width = panelChart_FMA.Width - 60;
            int height = panelChart_FMA.Height - 40;

            for (int i = 0; i < values.Count; i++)
            {
                int barHeight = (int)(values[i] / max * height);
                Rectangle rect = new Rectangle(50 + i * 50, height - barHeight + 20, 35, barHeight);
                g.FillRectangle(Brushes.SteelBlue, rect);
                g.DrawRectangle(Pens.Black, rect);
            }
        }
    }
}
