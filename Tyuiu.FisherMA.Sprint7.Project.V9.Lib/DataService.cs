using System;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;

namespace Tyuiu.FisherMA.Sprint7.Project.V9.Lib
{
    public class DataService
    {
        // ===== Загрузка CSV =====
        public DataTable LoadFromCsv(string path)
        {
            DataTable table = CreateTable_FMA();
            if (!File.Exists(path)) return table;

            foreach (string line in File.ReadAllLines(path).Skip(1)) // Пропуск заголовка
            {
                string[] values = line.Split(';');
                table.Rows.Add(
                    values[0],                                // Code
                    DateTime.Parse(values[1]),               // Date
                    int.Parse(values[2]),                     // Duration
                    values[3],                                // Theme
                    double.Parse(values[4], CultureInfo.InvariantCulture), // Cost
                    values[5],                                // Actor
                    values[6]                                 // Role
                );
            }
            return table;
        }

        // ===== Сохранение CSV =====
        public void SaveToCsv(DataTable table, string path)
        {
            using StreamWriter sw = new StreamWriter(path);
            sw.WriteLine("Code;Date;Duration;Theme;Cost;Actor;Role"); // Заголовок CSV

            foreach (DataRow row in table.Rows)
            {
                sw.WriteLine(string.Join(";", row.ItemArray));
            }
        }

        // ===== Создание структуры таблицы =====
        private DataTable CreateTable_FMA()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Code");
            dt.Columns.Add("Date", typeof(DateTime));
            dt.Columns.Add("Duration", typeof(int));
            dt.Columns.Add("Theme");
            dt.Columns.Add("Cost", typeof(double));
            dt.Columns.Add("Actor");
            dt.Columns.Add("Role");
            return dt;
        }

        // ===== Методы статистики =====
        public double SumCost(DataTable table) => table.AsEnumerable().Sum(r => r.Field<double>("Cost"));
        public double AverageCost(DataTable table) => table.AsEnumerable().Average(r => r.Field<double>("Cost"));
        public double MinCost(DataTable table) => table.AsEnumerable().Min(r => r.Field<double>("Cost"));
        public double MaxCost(DataTable table) => table.AsEnumerable().Max(r => r.Field<double>("Cost"));
    }
}
