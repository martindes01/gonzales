using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace martindes01.Gonzales
{
    public partial class OptionsForm : Form
    {

        // Constructors

        public OptionsForm()
        {
            // Initialise form (designer code)
            InitializeComponent();

            // Initialise startup checkbox
            string text = "Run on system startup.";
            text += " If enabled, this application will start minimised to the system tray at the right-hand side of the taskbar when you first log in after a shutdown or restart.";
            checkBoxStartup.Text = text;
            RefreshStartupChecked();

            // Assign event handlers
            buttonCancel.Click += ButtonCancel_Click;
            buttonOK.Click += ButtonOK_Click;
        }


        // Helper functions

        public void RefreshStartupChecked()
        {
            // Set checkbox to show whether startup enabled
            checkBoxStartup.Checked = Program.IsStartupEnabled();
        }

        // Event handlers

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            // Do nothing and close form
            Close();
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            // Set or delete startup registry key according to user input
            Program.SetStartup(checkBoxStartup.Checked);

            // Close form
            Close();
        }

    }
}
