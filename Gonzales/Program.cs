using Microsoft.Win32;  //
using System;
using System.Collections.Generic;
using System.Diagnostics;  //
using System.Linq;
using System.Threading;  //
using System.Threading.Tasks;
using System.Windows.Forms;

namespace martindes01.Gonzales
{
    static class Program
    {

        // Fields

        private static bool startup;
        private static readonly string donationURL = "https://www.paypal.me/martindes01";
        private static readonly string startupCommand = "--startup";
        private static readonly string startupRegistryKeyPath = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Run";

        private static Mutex mutex;


        // Methods

        public static void Donate()
        {
            Process.Start(donationURL);
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            // Only allow one instance of this application
            mutex = new Mutex(true, Application.CompanyName + Application.ProductName, out bool initialOwner);
            if (!initialOwner)
            {
                // Exit this instance if application already running
                return;
            }

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
