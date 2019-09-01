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
        private readonly OptionsForm optionsForm = new OptionsForm();
        private readonly ProfileForm profileForm = new ProfileForm();
        private readonly ToolStripItem[] toolStripMenuItemsBottom;
        private readonly ToolStripItem[] toolStripMenuItemsTop;


        // Constructors

        public TaskIcon(bool showProfileForm) {
            // Initialise context menu
            contextMenuStrip.RenderMode = ToolStripRenderMode.System;

            // Initialise toolstrip items to display at top of context menu
            toolStripMenuItemsTop = new ToolStripItem[]
            {
                new ToolStripMenuItem("Con&figure profiles...", null, ToolStripMenuItemProfiles_Click),
                new ToolStripSeparator(),
            };

            // Initialise toolstrip items to display at bottom of context menu
            toolStripMenuItemsBottom = new ToolStripItem[]
            {
                new ToolStripSeparator(),
                new ToolStripMenuItem("&Options...", null, ToolStripMenuItemOptions_Click),
                new ToolStripMenuItem("&About " + Application.ProductName + "...", null, ToolStripMenuItemAbout_Click),
                new ToolStripMenuItem("&Donate!", null, ToolStripMenuItemDonate_Click),
                new ToolStripSeparator(),
                new ToolStripMenuItem("E&xit", null, ToolStripMenuItemExit_Click),
            };

            // Initialise and show task icon
            notifyIcon.ContextMenuStrip = contextMenuStrip;
            notifyIcon.Icon = profileForm.Icon;
            notifyIcon.Text = Application.ProductName;
            notifyIcon.Visible = true;

            // Assign event handlers
            contextMenuStrip.ItemClicked += ContextMenuStrip_ItemClicked;
            contextMenuStrip.Opening += ContextMenuStrip_Opening;
            notifyIcon.MouseClick += NotifyIcon_MouseClick;

            // Show profile form if requested
            if (showProfileForm)
            {
                Program.ShowFormAsDialog(profileForm);
            }
        }


        // Helper functions

        private void Exit()
        {
            // Remove icon and exit
            notifyIcon.Visible = false;
            Application.Exit();
        }


        // Event handlers

        private void ContextMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            // Check item is a profile item with name property defined
            if (e.ClickedItem.Name != "")
            {
                // Check index within range
                int index = int.Parse(e.ClickedItem.Name);
                if (index < ProfileManager.Profiles.Count)
                {
                    // Apply profile specified by index stored in name property
                    ProfileManager.Profiles[int.Parse(e.ClickedItem.Name)].Apply();

                    // Reflect active profile change on profileform
                    profileForm.RefreshCurrentSettings();
                    profileForm.ShowActiveProfiles();
                }
                else
                {
                    // Display error message
                    string message = "Some profiles may have deleted since the menu was last opened.";
                    message += " Don't worry, just open the menu to refresh it and try again.";
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

            // Add top items
            contextMenuStrip.Items.AddRange(toolStripMenuItemsTop);

            // Check whether mouse profiles exist
            ProfileManager.LoadProfiles();
            if (ProfileManager.Profiles.Count > 0)
            {
                // Store number of items at top of menu for use as index shift correction
                int shift = toolStripMenuItemsTop.Count();

                // Add an item for each mouse profile
                for (int i = 0; i < ProfileManager.Profiles.Count; i++)
                {
                    Profile profile = ProfileManager.Profiles[i];

                    // Include the index as the name property of the item for identification
                    string text = (profile.Name == null || profile.Name.Trim() == "") ? "Untitled profile" : profile.Name.Trim();
                    contextMenuStrip.Items.Add(new ToolStripMenuItem(text, null, null, i.ToString()));

                    // Check item if associated profile is active
                    if (contextMenuStrip.Items[shift + i] is ToolStripMenuItem item)
                    {
                        item.Checked = profile.Speed == speed && profile.Acceleration == acceleration;
                    }
                }
            }
            else
            {
                // Add item with useful message
                contextMenuStrip.Items.Add(new ToolStripMenuItem("No saved profiles", null));
            }

            // Add bottom items
            contextMenuStrip.Items.AddRange(toolStripMenuItemsBottom);

            // Set cancel to false
            // By default this is set to true for optimisation if unspecified
            e.Cancel = false;
        }

        private void NotifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            // Show profile form on notify icon left click
            if (e.Button == MouseButtons.Left)
            {
                Program.ShowFormAsDialog(profileForm);
            }
        }

        private void ToolStripMenuItemAbout_Click(object sender, EventArgs e)
        {
            // TODO
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

        private void ToolStripMenuItemOptions_Click(object sender, EventArgs e)
        {
            // Show options form
            optionsForm.RefreshStartupChecked();
            Program.ShowFormAsDialog(optionsForm);
        }

        private void ToolStripMenuItemProfiles_Click(object sender, EventArgs e)
        {
            // Show profile form
            Program.ShowFormAsDialog(profileForm);
        }

    }
}
