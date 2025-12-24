namespace Tyuiu.FisherMA.Sprint7.Project.V9
{
    partial class Form1
    {
        // Контейнер для компонентов формы
        private System.ComponentModel.IContainer components = null;

        // Основные панели интерфейса
        private System.Windows.Forms.Panel panelTop_FMA;    // Таблица данных
        private System.Windows.Forms.Panel panelInput_FMA;  // Ввод данных
        private System.Windows.Forms.Panel panelTools_FMA;  // Кнопки, поиск, фильтр
        private System.Windows.Forms.Panel panelStats_FMA;  // Статистика
        private System.Windows.Forms.Panel panelChart_FMA;  // График

        // Таблица отображения видеоклипов
        private System.Windows.Forms.DataGridView dataGridViewVideoCatalog_FMA;

        // Кнопки управления
        private System.Windows.Forms.Button buttonLoadCsv_FMA;     // Загрузка CSV
        private System.Windows.Forms.Button buttonSaveCsv_FMA;     // Сохранение CSV
        private System.Windows.Forms.Button buttonAddRecord_FMA;   // Добавление записи
        private System.Windows.Forms.Button buttonApplyFilter_FMA; // Поиск и фильтрация

        // Поля ввода данных видеоклипа
        private System.Windows.Forms.TextBox textBoxCode_FMA;        // Код видеоклипа
        private System.Windows.Forms.TextBox textBoxDuration_FMA;    // Длительность
        private System.Windows.Forms.TextBox textBoxTheme_FMA;       // Тема
        private System.Windows.Forms.TextBox textBoxCost_FMA;        // Стоимость
        private System.Windows.Forms.TextBox textBoxActorName_FMA;   // ФИО актёра
        private System.Windows.Forms.TextBox textBoxActorRole_FMA;   // Амплуа
        private System.Windows.Forms.TextBox textBoxSearch_FMA;      // Поле поиска

        // Элементы выбора
        private System.Windows.Forms.DateTimePicker dateTimePickerRecordDate_FMA; // Дата записи
        private System.Windows.Forms.ComboBox comboBoxFilter_FMA;                 // Фильтр по теме

        // Метки статистики
        private System.Windows.Forms.Label labelCount_FMA; // Количество записей
        private System.Windows.Forms.Label labelSum_FMA;   // Суммарная стоимость
        private System.Windows.Forms.Label labelAvg_FMA;   // Средняя стоимость
        private System.Windows.Forms.Label labelMin_FMA;   // Минимальная стоимость
        private System.Windows.Forms.Label labelMax_FMA;   // Максимальная стоимость

        // Подписи к полям ввода
        private System.Windows.Forms.Label labelCode_FMA;
        private System.Windows.Forms.Label labelDate_FMA;
        private System.Windows.Forms.Label labelDuration_FMA;
        private System.Windows.Forms.Label labelTheme_FMA;
        private System.Windows.Forms.Label labelCost_FMA;
        private System.Windows.Forms.Label labelActorName_FMA;
        private System.Windows.Forms.Label labelActorRole_FMA;

        private void InitializeComponent()
        {
            // Основные параметры формы
            this.Text = "Каталог видеоклипов";
            this.Width = 1200;
            this.Height = 750;
            this.BackColor = System.Drawing.Color.WhiteSmoke;

            // ===== ВЕРХНЯЯ ПАНЕЛЬ: ТАБЛИЦА =====
            panelTop_FMA = new System.Windows.Forms.Panel
            {
                Dock = System.Windows.Forms.DockStyle.Top,
                Height = 260
            };

            // Таблица для отображения всех видеоклипов
            dataGridViewVideoCatalog_FMA = new System.Windows.Forms.DataGridView
            {
                Dock = System.Windows.Forms.DockStyle.Fill,
                BackgroundColor = System.Drawing.Color.White,
                AllowUserToAddRows = false,
                SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            };

            panelTop_FMA.Controls.Add(dataGridViewVideoCatalog_FMA);

            // ===== ПАНЕЛЬ ВВОДА ДАННЫХ =====
            panelInput_FMA = new System.Windows.Forms.Panel
            {
                Dock = System.Windows.Forms.DockStyle.Top,
                Height = 90
            };

            // Поля и подписи для ввода информации о видеоклипе
            labelCode_FMA = new System.Windows.Forms.Label { Text = "Код", Left = 10, Top = 10 };
            textBoxCode_FMA = new System.Windows.Forms.TextBox { Left = 10, Top = 30, Width = 70 };

            labelDate_FMA = new System.Windows.Forms.Label { Text = "Дата", Left = 90, Top = 10 };
            dateTimePickerRecordDate_FMA = new System.Windows.Forms.DateTimePicker { Left = 90, Top = 30, Width = 120 };

            labelDuration_FMA = new System.Windows.Forms.Label { Text = "Длительность", Left = 220, Top = 10 };
            textBoxDuration_FMA = new System.Windows.Forms.TextBox { Left = 220, Top = 30, Width = 80 };

            labelTheme_FMA = new System.Windows.Forms.Label { Text = "Тема", Left = 310, Top = 10 };
            textBoxTheme_FMA = new System.Windows.Forms.TextBox { Left = 310, Top = 30, Width = 120 };

            labelCost_FMA = new System.Windows.Forms.Label { Text = "Стоимость", Left = 440, Top = 10 };
            textBoxCost_FMA = new System.Windows.Forms.TextBox { Left = 440, Top = 30, Width = 90 };

            labelActorName_FMA = new System.Windows.Forms.Label { Text = "Актёр", Left = 540, Top = 10 };
            textBoxActorName_FMA = new System.Windows.Forms.TextBox { Left = 540, Top = 30, Width = 140 };

            labelActorRole_FMA = new System.Windows.Forms.Label { Text = "Амплуа", Left = 690, Top = 10 };
            textBoxActorRole_FMA = new System.Windows.Forms.TextBox { Left = 690, Top = 30, Width = 120 };

            // Кнопка добавления записи в таблицу
            buttonAddRecord_FMA = new System.Windows.Forms.Button
            {
                Text = "Добавить",
                Left = 830,
                Top = 28,
                Width = 100
            };
            buttonAddRecord_FMA.Click += buttonAddRecord_FMA_Click;

            panelInput_FMA.Controls.AddRange(new System.Windows.Forms.Control[]
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

            // ===== ПАНЕЛЬ ИНСТРУМЕНТОВ =====
            panelTools_FMA = new System.Windows.Forms.Panel
            {
                Dock = System.Windows.Forms.DockStyle.Top,
                Height = 50
            };

            // Кнопки работы с CSV файлами
            buttonLoadCsv_FMA = new System.Windows.Forms.Button { Text = "Загрузить CSV", Left = 10, Width = 120 };
            buttonSaveCsv_FMA = new System.Windows.Forms.Button { Text = "Сохранить CSV", Left = 140, Width = 120 };

            buttonLoadCsv_FMA.Click += buttonLoadCsv_FMA_Click;
            buttonSaveCsv_FMA.Click += buttonSaveCsv_FMA_Click;

            // Поле поиска и фильтрации
            textBoxSearch_FMA = new System.Windows.Forms.TextBox { Left = 280, Width = 180 };
            comboBoxFilter_FMA = new System.Windows.Forms.ComboBox { Left = 470, Width = 120 };
            comboBoxFilter_FMA.Items.AddRange(new string[] { "Все", "Музыка", "Кино", "Реклама" });
            comboBoxFilter_FMA.SelectedIndex = 0;

            buttonApplyFilter_FMA = new System.Windows.Forms.Button
            {
                Text = "Поиск / Фильтр",
                Left = 600,
                Width = 120
            };
            buttonApplyFilter_FMA.Click += buttonApplyFilter_FMA_Click;

            panelTools_FMA.Controls.AddRange(new System.Windows.Forms.Control[]
            {
                buttonLoadCsv_FMA, buttonSaveCsv_FMA,
                textBoxSearch_FMA, comboBoxFilter_FMA, buttonApplyFilter_FMA
            });

            // ===== ПАНЕЛЬ СТАТИСТИКИ =====
            panelStats_FMA = new System.Windows.Forms.Panel
            {
                Dock = System.Windows.Forms.DockStyle.Top,
                Height = 30
            };

            // Вывод статистических данных
            labelCount_FMA = new System.Windows.Forms.Label { Left = 10, Width = 150 };
            labelSum_FMA = new System.Windows.Forms.Label { Left = 170, Width = 150 };
            labelAvg_FMA = new System.Windows.Forms.Label { Left = 330, Width = 150 };
            labelMin_FMA = new System.Windows.Forms.Label { Left = 490, Width = 150 };
            labelMax_FMA = new System.Windows.Forms.Label { Left = 650, Width = 150 };

            panelStats_FMA.Controls.AddRange(new System.Windows.Forms.Control[]
            {
                labelCount_FMA, labelSum_FMA, labelAvg_FMA, labelMin_FMA, labelMax_FMA
            });

            // ===== ПАНЕЛЬ ГРАФИКА =====
            panelChart_FMA = new System.Windows.Forms.Panel
            {
                Dock = System.Windows.Forms.DockStyle.Fill,
                BackColor = System.Drawing.Color.White
            };
            panelChart_FMA.Paint += panelChart_FMA_Paint;

            // Добавление всех панелей на форму
            Controls.Add(panelChart_FMA);
            Controls.Add(panelStats_FMA);
            Controls.Add(panelTools_FMA);
            Controls.Add(panelInput_FMA);
            Controls.Add(panelTop_FMA);
        }
    }
}
