using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;
using Tyuiu.FisherMA.Sprint7.Project.V9.Lib;

namespace Tyuiu.FisherMA.Sprint7.Project.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckSumCost_FMA()
        {
            DataService ds = new DataService();
            DataTable table = new DataTable();
            table.Columns.Add("Cost", typeof(double));

            table.Rows.Add(100);
            table.Rows.Add(200);

            Assert.AreEqual(300, ds.SumCost(table));
        }

        [TestMethod]
        public void CheckAverageCost_FMA()
        {
            DataService ds = new DataService();
            DataTable table = new DataTable();
            table.Columns.Add("Cost", typeof(double));

            table.Rows.Add(100);
            table.Rows.Add(200);

            Assert.AreEqual(150, ds.AverageCost(table));
        }
    }
}
