using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Onana_Hospital_Management_System
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Show the splash screen
            SplashScreenManager.ShowForm(typeof(SplashScreen1));

            // Simulate loading process (replace with actual initialization)
            System.Threading.Thread.Sleep(5000);

            // Close the splash screen
            SplashScreenManager.CloseForm();

            Application.Run(new frmLogin());
        }
    }
}
