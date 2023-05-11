using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplePaint
{
    internal static class Program
    {
        static public MainWindow View { get; private set; }

        static Program()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            View = new MainWindow();
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Program.ShowMainWindow();
        }

        static void ShowMainWindow() => Application.Run(View);
    }
}
