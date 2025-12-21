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

        private System.Windows.Forms.TextBox textBoxSearch_FMA;
        private System.Windows.Forms.ComboBox comboBoxFilter_FMA;
        private System.Windows.Forms.Button buttonApplyFilter_FMA;

        // Метки для полей на русском
        private System.Windows.Forms.Label labelCode_FMA;
        private System.Windows.Forms.Label labelDate_FMA;
        private System.Windows.Forms.Label labelDuration_FMA;
        private System.Windows.Forms.Label labelTheme_FMA;
        private System.Windows.Forms.Label labelCost_FMA;
        private System.Windows.Forms.Label labelActorName_FMA;
        private System.Windows.Forms.Label labelActorRole_FMA;

        private void InitializeComponent()
        {
            this.Text = "Каталог видеоклипов";
            this.Width = 1200;
            this.Height = 700;

            // DataGridView
            dataGridViewVideoCatalog_FMA = new System.Windows.Forms.DataGridView
            {
                Dock = System.Windows.Forms.DockStyle.Top,
                Height = 250,
                AllowUserToAddRows = false,
                ReadOnly = false,
                SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            };

            // Кнопки
            buttonLoadCsv_FMA = new System.Windows.Forms.Button { Text = "Загрузить CSV", Top = 260, Left = 10, Width = 120 };
            buttonLoadCsv_FMA.Click += buttonLoadCsv_FMA_Click;

            buttonSaveCsv_FMA = new System.Windows.Forms.Button { Text = "Сохранить CSV", Top = 260, Left = 140, Width = 120 };
            buttonSaveCsv_FMA.Click += buttonSaveCsv_FMA_Click;

            buttonAddRecord_FMA = new System.Windows.Forms.Button { Text = "Добавить запись", Top = 260, Left = 270, Width = 140 };
            buttonAddRecord_FMA.Click += buttonAddRecord_FMA_Click;

            // Панель графика
            panelChart_FMA = new System.Windows.Forms.Panel
            {
                Dock = System.Windows.Forms.DockStyle.Bottom,
                Height = 250,
                BackColor = System.Drawing.Color.White
            };
            panelChart_FMA.Paint += panelChart_FMA_Paint;

            // Поля ввода
            textBoxCode_FMA = new System.Windows.Forms.TextBox { Top = 300, Left = 100, Width = 80 };
            dateTimePickerRecordDate_FMA = new System.Windows.Forms.DateTimePicker { Top = 300, Left = 220, Width = 120 };
            textBoxDuration_FMA = new System.Windows.Forms.TextBox { Top = 300, Left = 360, Width = 60 };
            textBoxTheme_FMA = new System.Windows.Forms.TextBox { Top = 300, Left = 440, Width = 120 };
            textBoxCost_FMA = new System.Windows.Forms.TextBox { Top = 300, Left = 580, Width = 80 };
            textBoxActorName_FMA = new System.Windows.Forms.TextBox { Top = 300, Left = 680, Width = 120 };
            textBoxActorRole_FMA = new System.Windows.Forms.TextBox { Top = 300, Left = 820, Width = 120 };

            // Подписи над полями на русском
            labelCode_FMA = new System.Windows.Forms.Label { Text = "Код видеоклипа", Top = 280, Left = 100, Width = 100 };
            labelDate_FMA = new System.Windows.Forms.Label { Text = "Дата записи", Top = 280, Left = 220, Width = 100 };
            labelDuration_FMA = new System.Windows.Forms.Label { Text = "Длительность (мин)", Top = 280, Left = 360, Width = 120 };
            labelTheme_FMA = new System.Windows.Forms.Label { Text = "Тема видеоклипа", Top = 280, Left = 440, Width = 120 };
            labelCost_FMA = new System.Windows.Forms.Label { Text = "Стоимость (₽)", Top = 280, Left = 580, Width = 100 };
            labelActorName_FMA = new System.Windows.Forms.Label { Text = "ФИО актёра", Top = 280, Left = 680, Width = 120 };
            labelActorRole_FMA = new System.Windows.Forms.Label { Text = "Амплуа", Top = 280, Left = 820, Width = 100 };

            // Статистика
            labelCount_FMA = new System.Windows.Forms.Label { Top = 330, Left = 10, Width = 200 };
            labelSum_FMA = new System.Windows.Forms.Label { Top = 330, Left = 220, Width = 200 };
            labelAvg_FMA = new System.Windows.Forms.Label { Top = 330, Left = 430, Width = 200 };
            labelMin_FMA = new System.Windows.Forms.Label { Top = 330, Left = 640, Width = 150 };
            labelMax_FMA = new System.Windows.Forms.Label { Top = 330, Left = 800, Width = 150 };

            // Поиск и фильтр
            textBoxSearch_FMA = new System.Windows.Forms.TextBox { Top = 360, Left = 10, Width = 200, PlaceholderText = "Поиск по теме/актеру" };
            comboBoxFilter_FMA = new System.Windows.Forms.ComboBox { Top = 360, Left = 220, Width = 150 };
            comboBoxFilter_FMA.Items.AddRange(new string[] { "Все", "Музыка", "Реклама", "Кино" });
            comboBoxFilter_FMA.SelectedIndex = 0;
            buttonApplyFilter_FMA = new System.Windows.Forms.Button { Top = 360, Left = 380, Width = 100, Text = "Применить фильтр" };
            buttonApplyFilter_FMA.Click += buttonApplyFilter_FMA_Click;

            // Добавляем все элементы на форму
            Controls.AddRange(new System.Windows.Forms.Control[]
            {
                dataGridViewVideoCatalog_FMA,
                buttonLoadCsv_FMA, buttonSaveCsv_FMA, buttonAddRecord_FMA,
                labelCode_FMA, textBoxCode_FMA,
                labelDate_FMA, dateTimePickerRecordDate_FMA,
                labelDuration_FMA, textBoxDuration_FMA,
                labelTheme_FMA, textBoxTheme_FMA,
                labelCost_FMA, textBoxCost_FMA,
                labelActorName_FMA, textBoxActorName_FMA,
                labelActorRole_FMA, textBoxActorRole_FMA,
                labelCount_FMA, labelSum_FMA, labelAvg_FMA, labelMin_FMA, labelMax_FMA,
                textBoxSearch_FMA, comboBoxFilter_FMA, buttonApplyFilter_FMA,
                panelChart_FMA
            });
        }
    }
}
