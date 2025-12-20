using System;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;

namespace Tyuiu.FisherMA.Sprint7.Project.V9.Lib
{
    public class DataService
    {
        public DataTable LoadFromCsv(string path)
        {
            DataTable table = CreateTable_FMA();
            if (!File.Exists(path)) return table;

            foreach (string line in File.ReadAllLines(path).Skip(1))
            {
                string[] values = line.Split(';');
                table.Rows.Add(
                    values[0],
                    DateTime.Parse(values[1]),
                    int.Parse(values[2]),
                    values[3],
                    double.Parse(values[4], CultureInfo.InvariantCulture),
                    values[5],
                    values[6]
                );
            }
            return table;
        }

        public void SaveToCsv(DataTable table, string path)
        {
            using StreamWriter sw = new StreamWriter(path);
            sw.WriteLine("Code;Date;Duration;Theme;Cost;Actor;Role");

            foreach (DataRow row in table.Rows)
            {
                sw.WriteLine(string.Join(";", row.ItemArray));
            }
        }

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

        public double SumCost(DataTable table) =>
            table.AsEnumerable().Sum(r => r.Field<double>("Cost"));

        public double AverageCost(DataTable table) =>
            table.AsEnumerable().Average(r => r.Field<double>("Cost"));

        public double MinCost(DataTable table) =>
            table.AsEnumerable().Min(r => r.Field<double>("Cost"));

        public double MaxCost(DataTable table) =>
            table.AsEnumerable().Max(r => r.Field<double>("Cost"));
    }
}
