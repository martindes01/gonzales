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
        private static readonly string startupRegistryKeyPath = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run";
        private static readonly string startupRegistryKeySubkeyName = Application.CompanyName + Application.ProductName;
        private static readonly string startupRegistryKeySubkeyValue = "\"" + Application.ExecutablePath + "\" " + startupCommand;

        private static Mutex mutex;


        // Methods

        public static void Donate()
        {
            // Launch URL in system default browser
            Process.Start(donationURL);
        }

        public static bool IsStartupEnabled()
        {
            // Return whether startup registry key exists
            using (RegistryKey registryKeyStartup = Registry.CurrentUser.CreateSubKey(startupRegistryKeyPath))
            {
                return registryKeyStartup.GetValue(startupRegistryKeySubkeyName) != null;
            }
        }

        public static void SetStartup(bool startup)
        {
            // Open startup registry key for writing
            // Key is created if does not exist
            using (RegistryKey registryKeyStartup = Registry.CurrentUser.CreateSubKey(startupRegistryKeyPath))
            {
                // Set or delete key as requested
                if (startup)
                {
                    registryKeyStartup.SetValue(startupRegistryKeySubkeyName, startupRegistryKeySubkeyValue);
                }
                else
                {
                    registryKeyStartup.DeleteValue(startupRegistryKeySubkeyName, false);
                }
            }
        }

        public static void ShowFormAsDialog(Form form)
        {
            // Show form as dialog or activate and give focus if already visible
            if (form.Visible)
            {
                // Set window state to normal if minimised
                if (form.WindowState == FormWindowState.Minimized)
                {
                    form.WindowState = FormWindowState.Normal;
                }

                // Activate form and give focus
                form.Activate();
            }
            else
            {
                // Show form as dialog
                form.ShowDialog();
            }
        }


        // Main

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
