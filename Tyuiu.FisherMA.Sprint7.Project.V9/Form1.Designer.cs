using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tyuiu.FisherMA.Sprint7.Project.V9
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private Panel panelTop_FMA;
        private Panel panelInput_FMA;
        private Panel panelTools_FMA;
        private Panel panelStats_FMA;
        private Panel panelChart_FMA;
        private Panel panelHelp_FMA;

        private DataGridView dataGridViewVideoCatalog_FMA;

        private Button buttonLoadCsv_FMA;
        private Button buttonSaveCsv_FMA;
        private Button buttonAddRecord_FMA;
        private Button buttonSearch_FMA;
        private Button buttonReset_FMA;

        private TextBox textBoxCode_FMA;
        private TextBox textBoxDuration_FMA;
        private TextBox textBoxTheme_FMA;
        private TextBox textBoxCost_FMA;
        private TextBox textBoxActorName_FMA;
        private TextBox textBoxActorRole_FMA;
        private TextBox textBoxSearchActor_FMA;

        private ComboBox comboBoxSort_FMA;

        private DateTimePicker dateTimePickerRecordDate_FMA;

        private Label labelCount_FMA;
        private Label labelSum_FMA;
        private Label labelAvg_FMA;
        private Label labelMin_FMA;
        private Label labelMax_FMA;

        private Label labelCode_FMA;
        private Label labelDate_FMA;
        private Label labelDuration_FMA;
        private Label labelTheme_FMA;
        private Label labelCost_FMA;
        private Label labelActorName_FMA;
        private Label labelActorRole_FMA;

        private Label labelHelpTitle_FMA;
        private Label labelHelpText_FMA;

        private void InitializeComponent()
        {
            Text = "Каталог видеоклипов";
            Width = 1200;
            Height = 760;
            BackColor = Color.WhiteSmoke;

            // ===== Таблица =====
            panelTop_FMA = new Panel { Dock = DockStyle.Top, Height = 260 };
            dataGridViewVideoCatalog_FMA = new DataGridView
            {
                Dock = DockStyle.Fill,
                AllowUserToAddRows = false,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                BackgroundColor = Color.White
            };
            dataGridViewVideoCatalog_FMA.CellClick += dataGridViewVideoCatalog_FMA_CellClick;
            panelTop_FMA.Controls.Add(dataGridViewVideoCatalog_FMA);

            // ===== Ввод данных =====
            panelInput_FMA = new Panel { Dock = DockStyle.Top, Height = 90, BackColor = Color.White };

            labelCode_FMA = new Label { Text = "Код", Left = 10, Top = 7, Width = 40 };
            textBoxCode_FMA = new TextBox { Left = 10, Top = 30, Width = 70 };

            labelDate_FMA = new Label { Text = "Дата", Left = 90, Top = 7, Width = 40 };
            dateTimePickerRecordDate_FMA = new DateTimePicker { Left = 90, Top = 30, Width = 120 };

            labelDuration_FMA = new Label { Text = "Длительность", Left = 220, Top = 7, Width = 85 };
            textBoxDuration_FMA = new TextBox { Left = 220, Top = 30, Width = 80 };

            labelTheme_FMA = new Label { Text = "Тема", Left = 310, Top = 7, Width = 40 };
            textBoxTheme_FMA = new TextBox { Left = 310, Top = 30, Width = 120 };

            labelCost_FMA = new Label { Text = "Стоимость", Left = 440, Top = 7, Width = 70 };
            textBoxCost_FMA = new TextBox { Left = 440, Top = 30, Width = 90 };

            labelActorName_FMA = new Label { Text = "Актёр (ФИО)", Left = 540, Top = 7, Width = 100 };
            textBoxActorName_FMA = new TextBox { Left = 540, Top = 30, Width = 140 };

            labelActorRole_FMA = new Label { Text = "Амплуа", Left = 690, Top = 7, Width = 70 };
            textBoxActorRole_FMA = new TextBox { Left = 690, Top = 30, Width = 120 };

            buttonAddRecord_FMA = new Button { Text = "Добавить", Left = 840, Top = 31, Width = 100 };
            buttonAddRecord_FMA.Click += buttonAddRecord_FMA_Click;

            panelInput_FMA.Controls.AddRange(new Control[]
            {
                labelCode_FMA, textBoxCode_FMA,
                labelDate_FMA, dateTimePickerRecordDate_FMA,
                labelDuration_FMA, textBoxDuration_FMA,
                labelTheme_FMA, textBoxTheme_FMA,
                labelCost_FMA, textBoxCost_FMA,
                labelActorName_FMA, textBoxActorName_FMA,
                labelActorRole_FMA, textBoxActorRole_FMA,
                buttonAddRecord_FMA
            });

            // ===== Панель инструментов =====
            panelTools_FMA = new Panel { Dock = DockStyle.Top, Height = 45 };
            buttonLoadCsv_FMA = new Button { Text = "Загрузить CSV", Left = 10, Width = 130 };
            buttonSaveCsv_FMA = new Button { Text = "Сохранить CSV", Left = 150, Width = 130 };
            textBoxSearchActor_FMA = new TextBox { Left = 310, Width = 160, PlaceholderText = "Поиск по актёру" };
            buttonSearch_FMA = new Button { Text = "Найти", Left = 480, Width = 90 };
            buttonReset_FMA = new Button { Text = "Сбросить", Left = 580, Width = 90 };
            comboBoxSort_FMA = new ComboBox { Left = 690, Width = 200, DropDownStyle = ComboBoxStyle.DropDownList };
            comboBoxSort_FMA.Items.AddRange(new object[]
            {
                "Без сортировки",
                "Стоимость ↑", "Стоимость ↓",
                "Длительность ↑", "Длительность ↓",
                "Дата ↑", "Дата ↓"
            });
            comboBoxSort_FMA.SelectedIndex = 0;

            buttonLoadCsv_FMA.Click += buttonLoadCsv_FMA_Click;
            buttonSaveCsv_FMA.Click += buttonSaveCsv_FMA_Click;
            buttonSearch_FMA.Click += buttonSearch_FMA_Click;
            buttonReset_FMA.Click += buttonReset_FMA_Click;
            comboBoxSort_FMA.SelectedIndexChanged += comboBoxSort_FMA_SelectedIndexChanged;

            panelTools_FMA.Controls.AddRange(new Control[]
            {
                buttonLoadCsv_FMA, buttonSaveCsv_FMA,
                textBoxSearchActor_FMA, buttonSearch_FMA, buttonReset_FMA,
                comboBoxSort_FMA
            });

            // ===== Статистика =====
            panelStats_FMA = new Panel { Dock = DockStyle.Top, Height = 30 };
            labelCount_FMA = new Label { Left = 10, Width = 150 };
            labelSum_FMA = new Label { Left = 170, Width = 150 };
            labelAvg_FMA = new Label { Left = 330, Width = 150 };
            labelMin_FMA = new Label { Left = 490, Width = 150 };
            labelMax_FMA = new Label { Left = 650, Width = 150 };
            panelStats_FMA.Controls.AddRange(new Control[]
            {
                labelCount_FMA, labelSum_FMA, labelAvg_FMA, labelMin_FMA, labelMax_FMA
            });

            // ===== Диаграмма =====
            panelChart_FMA = new Panel { Dock = DockStyle.Fill };
            panelChart_FMA.Paint += panelChart_FMA_Paint;

            // ===== Справка =====
            panelHelp_FMA = new Panel { Width = 320, Height = 180, BackColor = Color.LightYellow, BorderStyle = BorderStyle.FixedSingle, Anchor = AnchorStyles.Bottom | AnchorStyles.Right };
            labelHelpTitle_FMA = new Label { Text = "🛈 Справка", Font = new Font("Segoe UI", 10F, FontStyle.Bold), ForeColor = Color.DarkBlue, Left = 10, Top = 8, AutoSize = true };
            labelHelpText_FMA = new Label
            {
                Left = 10,
                Top = 35,
                Width = 300,
                Height = 130,
                Font = new Font("Segoe UI", 9F),
                ForeColor = Color.Black,
                Text = "1. Загрузите CSV файл\n2. Выберите запись\n3. Поиск по ФИО\n4. Сортировка\n5. Сохраните CSV\nДиаграмма обновляется"
            };
            panelHelp_FMA.Controls.Add(labelHelpTitle_FMA);
            panelHelp_FMA.Controls.Add(labelHelpText_FMA);
            panelChart_FMA.Controls.Add(panelHelp_FMA);
            panelChart_FMA.Resize += (s, e) =>
            {
                panelHelp_FMA.Left = panelChart_FMA.Width - panelHelp_FMA.Width - 15;
                panelHelp_FMA.Top = panelChart_FMA.Height - panelHelp_FMA.Height - 15;
            };

            // ===== Добавление на форму =====
            Controls.Add(panelChart_FMA);
            Controls.Add(panelStats_FMA);
            Controls.Add(panelTools_FMA);
            Controls.Add(panelInput_FMA);
            Controls.Add(panelTop_FMA);
        }
    }
}
