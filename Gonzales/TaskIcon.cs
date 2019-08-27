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

        public TaskIcon(bool showProfileForm) {
            // Initialise toolstrip items to display at bottom of context menu
            toolStripMenuItems = new ToolStripItem[]
            {
                new ToolStripSeparator(),
                new ToolStripMenuItem("Con&figure profiles", null, ToolStripMenuItemProfiles_Click),
                new ToolStripMenuItem("&Donate", null, ToolStripMenuItemDonate_Click),
                new ToolStripSeparator(),
                new ToolStripMenuItem("E&xit", null, ToolStripMenuItemExit_Click),
            };

            // Assign event handlers
            contextMenuStrip.ItemClicked += ContextMenuStrip_ItemClicked;
            contextMenuStrip.Opening += ContextMenuStrip_Opening;
            notifyIcon.MouseClick += NotifyIcon_MouseClick;

            // Initialise and show task icon
            notifyIcon.ContextMenuStrip = contextMenuStrip;
            notifyIcon.Icon = profileForm.Icon;
            notifyIcon.Text = Application.ProductName;
            notifyIcon.Visible = true;

            // Show profile form if requested
            if (showProfileForm)
            {
                ShowProfileForm();
            }
        }


        // Helper functions

        private void Exit()
        {
            // Remove icon and exit
            notifyIcon.Visible = false;
            Application.Exit();
        }

        private void ShowProfileForm()
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
            // Get current mouse parameters
            int speed = MouseParams.GetSpeed();
            bool acceleration = MouseParams.GetAcceleration();

            // Remove old items
            contextMenuStrip.Items.Clear();

            // Add an item for each mouse profile
            ProfileManager.LoadProfiles();
            for (int i = 0; i < ProfileManager.Profiles.Count; i++)
            {
                Profile profile = ProfileManager.Profiles[i];

                // Include the index as the name property of the item for identification
                string text = profile.Name.Trim() == "" ? "Untitled profile" : profile.Name.Trim();
                contextMenuStrip.Items.Add(new ToolStripMenuItem(text, null, null, i.ToString()));

                // Check item if assoicated profile is active
                if (contextMenuStrip.Items[i] is ToolStripMenuItem item)
                {
                    item.Checked = profile.Speed == speed && profile.Acceleration == acceleration;
                }
            }

            // Add final items
            contextMenuStrip.Items.AddRange(toolStripMenuItems);
        }

        private void NotifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            // Show profile form on notify icon left click
            if (e.Button == MouseButtons.Left)
            {
                ShowProfileForm();
            }
        }

        private void ToolStripMenuItemDonate_Click(object sender, EventArgs e)
        {
            // Follow donation link
            Program.Donate();
        }

        private void ToolStripMenuItemExit_Click(object sender, EventArgs e)
        {
            // Exit application
            Exit();
        }

        private void ToolStripMenuItemProfiles_Click(object sender, EventArgs e)
        {
            // Show profile form
            ShowProfileForm();
        }

    }
}
