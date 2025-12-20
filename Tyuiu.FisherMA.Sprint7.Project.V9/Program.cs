using System;
using System.Windows.Forms;

namespace Tyuiu.FisherMA.Sprint7.Project.V9
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
