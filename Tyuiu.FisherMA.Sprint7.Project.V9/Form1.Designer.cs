namespace Tyuiu.FisherMA.Sprint7.Project.V9
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView dataGridViewVideoCatalog_FMA;
        private System.Windows.Forms.Button buttonLoadCsv_FMA;
        private System.Windows.Forms.Button buttonSaveCsv_FMA;
        private System.Windows.Forms.Button buttonAddRecord_FMA;

        private System.Windows.Forms.TextBox textBoxCode_FMA;
        private System.Windows.Forms.TextBox textBoxDuration_FMA;
        private System.Windows.Forms.TextBox textBoxTheme_FMA;
        private System.Windows.Forms.TextBox textBoxCost_FMA;
        private System.Windows.Forms.TextBox textBoxActorName_FMA;
        private System.Windows.Forms.TextBox textBoxActorRole_FMA;

        private System.Windows.Forms.DateTimePicker dateTimePickerRecordDate_FMA;

        private System.Windows.Forms.Label labelCount_FMA;
        private System.Windows.Forms.Label labelSum_FMA;
        private System.Windows.Forms.Label labelAvg_FMA;
        private System.Windows.Forms.Label labelMin_FMA;
        private System.Windows.Forms.Label labelMax_FMA;

        private System.Windows.Forms.Panel panelChart_FMA;

        private void InitializeComponent()
        {
            this.Text = "Каталог видеоклипов";
            this.Width = 1200;
            this.Height = 700;

            dataGridViewVideoCatalog_FMA = new System.Windows.Forms.DataGridView
            {
                Dock = System.Windows.Forms.DockStyle.Top,
                Height = 250
            };

            buttonLoadCsv_FMA = new System.Windows.Forms.Button
            {
                Text = "Загрузить CSV",
                Top = 260,
                Left = 10,
                Width = 120
            };
            buttonLoadCsv_FMA.Click += buttonLoadCsv_FMA_Click;

            buttonSaveCsv_FMA = new System.Windows.Forms.Button
            {
                Text = "Сохранить CSV",
                Top = 260,
                Left = 140,
                Width = 120
            };
            buttonSaveCsv_FMA.Click += buttonSaveCsv_FMA_Click;

            buttonAddRecord_FMA = new System.Windows.Forms.Button
            {
                Text = "Добавить запись",
                Top = 260,
                Left = 270,
                Width = 140
            };
            buttonAddRecord_FMA.Click += buttonAddRecord_FMA_Click;

            panelChart_FMA = new System.Windows.Forms.Panel
            {
                Dock = System.Windows.Forms.DockStyle.Bottom,
                Height = 250,
                BackColor = System.Drawing.Color.White
            };
            panelChart_FMA.Paint += panelChart_FMA_Paint;

            Controls.Add(dataGridViewVideoCatalog_FMA);
            Controls.Add(buttonLoadCsv_FMA);
            Controls.Add(buttonSaveCsv_FMA);
            Controls.Add(buttonAddRecord_FMA);
            Controls.Add(panelChart_FMA);
        }
    }
}
