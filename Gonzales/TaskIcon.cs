using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;  //

namespace martindes01.Gonzales
{
    class TaskIcon : ApplicationContext
    {

        // Fields

        private readonly ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
        private readonly NotifyIcon notifyIcon = new NotifyIcon();
        private readonly ProfileForm profileForm = new ProfileForm();
        private readonly ToolStripItem[] toolStripMenuItems;


        // Constructors

        public TaskIcon() {
            // Initialise toolstrip items to display at bottom of context menu
            toolStripMenuItems = new ToolStripItem[]
            {
                new ToolStripSeparator(),
                new ToolStripMenuItem("Configure profiles", null, new EventHandler(ShowProfileForm)),
                new ToolStripMenuItem("Exit " + Application.ProductName, null, new EventHandler(Exit)),
            };

            // Assign event handlers
            contextMenuStrip.ItemClicked += ContextMenuStrip_ItemClicked;
            contextMenuStrip.Opening += ContextMenuStrip_Opening;

            // Initialise and show task icon
            notifyIcon.ContextMenuStrip = contextMenuStrip;
            notifyIcon.Icon = profileForm.Icon;
            notifyIcon.Text = Application.ProductName;
            notifyIcon.Visible = true;
        }


        // Helper functions

        private void Exit(object sender, EventArgs e)
        {
            // Remove icon and exit
            notifyIcon.Visible = false;
            Application.Exit();
        }

        private void ShowProfileForm(object sender, EventArgs e)
        {
            // Show form as dialog or activate and give focus if already visible
            if (profileForm.Visible)
            {
                profileForm.Activate();
            }
            else
            {
                profileForm.ShowDialog();
            }
        }


        // Event handlers

        private void ContextMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            // Check item name property defined
            if (e.ClickedItem.Name != "")
            {
                try
                {
                    // Apply profile specified by index stored in name property
                    ProfileManager.Profiles[int.Parse(e.ClickedItem.Name)].Apply();
                }
                catch (Exception)
                {
                    // Display error message
                    string message = "This profile has been renamed or deleted since opening the menu.";
                    message += " Don't worry, just reopen the menu and try again.";
                    MessageBox.Show(message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void ContextMenuStrip_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // Remove old items
            contextMenuStrip.Items.Clear();

            // Add an item for each mouse profile
            // Include the index as the name property of the item for identification
            ProfileManager.LoadProfiles();
            for (int i = 0; i < ProfileManager.Profiles.Count; i++)
            {
                contextMenuStrip.Items.Add(new ToolStripMenuItem(ProfileManager.Profiles[i].Name, null, null, i.ToString()));
            }

            // Add final items
            contextMenuStrip.Items.AddRange(toolStripMenuItems);
        }

    }
}
