using System;
using System.Windows.Forms;
using Tutorial_Winforms_MVP_Pattern.Forms;

namespace Tutorial_Winforms_MVP_Pattern
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormLogin());
        }
    }
}
