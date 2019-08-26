using Microsoft.Win32;  //
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace martindes01.Gonzales
{
    static class Program
    {

        // Fields

        private static bool startup;
        private static readonly string startupCommand = "--startup";
        private static readonly string startupRegistryKeyPath = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Run";


        // Methods

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            // Parse command line arguments
            startup = args != null && args.Contains(startupCommand);

            // Add startup registry key for current user if not launched at startup
            if (!startup)
            {
                Registry.CurrentUser.OpenSubKey(startupRegistryKeyPath, true).SetValue(
                    Application.CompanyName + " " + Application.ProductName,
                    "\"" + Application.ExecutablePath + "\" " + startupCommand
                );
            }

            // Set application properties
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Start application and ensure task icon is disposed on application exit
            // Show profile form if not launched at startup
            using (TaskIcon taskIcon = new TaskIcon(!startup))
            {
                Application.Run();
            }
        }

    }
}
