using System;
using System.Windows.Forms;

namespace Linuxide
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static int Updater() //not completed, and i don't think it will ever be
        {
            //Application.Run(new Updater());
            return 0;
        }
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
        }
    }
}
