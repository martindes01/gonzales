﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// TODO Doc comments

namespace martindes01.Gonzales
{
    public partial class ProfileForm : Form
    {

        // Fields

        private readonly AboutBox aboutBox = new AboutBox();
        private readonly OptionsForm optionsForm = new OptionsForm();

        private Profile fallbackProfile;


        // Constructors

        public ProfileForm()
        {
            // Store current profile
            fallbackProfile = new Profile("", MouseParams.GetSpeed(), MouseParams.GetAcceleration());

            // Initialise form (designer code)
            InitializeComponent();
            Text = Application.ProductName;

            // Initialise data grid
            DataGridViewProfiles();

            // Initialise menu strip
            toolStripMenuItemAbout.Text = "&About " + Application.ProductName;

            // Display current mouse settings
            RefreshCurrentSettings();

            // Assign event handlers
            FormClosing += ProfileForm_FormClosing;
            buttonApply.Click += ButtonApply_Click;
            buttonCancel.Click += ButtonCancel_Click;
            buttonDonate.Click += ButtonDonate_Click; ;
            buttonOK.Click += ButtonOK_Click;
            buttonRefresh.Click += ButtonRefresh_Click;
            dataGridViewProfiles.CellClick += DataGridViewProfiles_CellClick;
            dataGridViewProfiles.CellPainting += DataGridViewProfiles_CellPainting;
            dataGridViewProfiles.CellValueChanged += DataGridViewProfiles_CellValueChanged;
            dataGridViewProfiles.CurrentCellDirtyStateChanged += DataGridViewProfiles_CurrentCellDirtyStateChanged;
            dataGridViewProfiles.DataError += DataGridViewProfiles_DataError;
            dataGridViewProfiles.EditingControlShowing += DataGridViewProfiles_EditingControlShowing;
            dataGridViewProfiles.RowPostPaint += DataGridViewProfiles_RowPostPaint;
            dataGridViewProfiles.RowsAdded += DataGridViewProfiles_RowsAdded;
            dataGridViewProfiles.RowsRemoved += DataGridViewProfiles_RowsRemoved;
            toolStripMenuItemAbout.Click += ToolStripMenuItemAbout_Click;
            toolStripMenuItemDonate.Click += ToolStripMenuItemDonate_Click;
            toolStripMenuItemOptions.Click += ToolStripMenuItemOptions_Click;

            // Load saved profiles and reset bindings for data grid
            ProfileManager.LoadProfiles();
            bindingSourceProfiles.ResetBindings(false);
        }


        // Helper functions

        public void DataGridViewProfiles()
        {
            // Custom columns already exist
            dataGridViewProfiles.AutoGenerateColumns = false;

            // Set data source for data grid
            bindingSourceProfiles.DataSource = ProfileManager.Profiles;

            // Set properties for binding
            columnName.DataPropertyName = "Name";
            columnSpeed.DataPropertyName = "Speed";
            columnAcceleration.DataPropertyName = "Acceleration";

            // Set tooltips
            columnActive.ToolTipText = "Indicates whether a profile is active. Click a cell to activate the corresponding profile.";
            columnName.ToolTipText = "Choose a memorable name for this profile.";
            columnSpeed.ToolTipText = "An integer from 1 to 20, inclusive, that indicates the speed of the mouse pointer.";
            columnAcceleration.ToolTipText = "If enabled, faster mouse movements will cause the mouse pointer to move further.";

            // Hide row header content
            dataGridViewProfiles.RowHeadersDefaultCellStyle.Padding = new Padding(dataGridViewProfiles.RowHeadersWidth / 2);
        }

        public bool IsCellChecked(int rowIndex, int columnIndex)
        {
            // Return true if value not null and is true
            object value = dataGridViewProfiles.Rows[rowIndex].Cells[columnIndex].Value;
            return value != null && (bool)value;
        }

        public bool IsRowIndexValid(int rowIndex, bool allowNewRow)
        {
            // Return true if row index within bounds and not new row
            //return rowIndex >= 0 && rowIndex < dataGridViewProfiles.Rows.Count;
            //return rowIndex >= 0 && rowIndex < dataGridViewProfiles.Rows.Count && !dataGridViewProfiles.Rows[rowIndex].IsNewRow;
            return rowIndex >= 0 && rowIndex < dataGridViewProfiles.Rows.Count && (allowNewRow || !dataGridViewProfiles.Rows[rowIndex].IsNewRow);
        }

        public void NumberRows()
        {
            // Number each row
            foreach (DataGridViewRow row in dataGridViewProfiles.Rows)
            {
                row.HeaderCell.Value = (row.Index + 1).ToString();
            }
        }

        public void RefreshCurrentSettings()
        {
            // Display the current mouse settings
            textBoxSpeed.Text = MouseParams.GetSpeed().ToString();
            textBoxAcceleration.Text = MouseParams.GetAcceleration().ToString();
        }

        public void ShowActiveProfiles()
        {
            // Get current mouse parameters
            int speed = MouseParams.GetSpeed();
            bool acceleration = MouseParams.GetAcceleration();

            // Unassign event handler to prevent StackOverFlowException on subsequent cell value changes
            dataGridViewProfiles.CellValueChanged -= DataGridViewProfiles_CellValueChanged;

            // Go through each row and show whether the corresponding profile is active
            foreach (DataGridViewRow row in dataGridViewProfiles.Rows)
            {
                if (!row.IsNewRow)
                {
                    row.Cells[columnActive.Index].Value = (int)row.Cells[columnSpeed.Index].Value == speed && (bool)row.Cells[columnAcceleration.Index].Value == acceleration;
                }
            }

            // Reassign event handler
            dataGridViewProfiles.CellValueChanged += DataGridViewProfiles_CellValueChanged;
        }


        // Event handlers

        private void ProfileForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            fallbackProfile.Apply();
        }

        private void ButtonApply_Click(object sender, EventArgs e)
        {
            // Save profiles
            ProfileManager.SaveProfiles();

            // Update fallback profile
            fallbackProfile = new Profile("", MouseParams.GetSpeed(), MouseParams.GetAcceleration());

            // Refresh displayed settings
            RefreshCurrentSettings();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            // Restore fallback profile and close form
            fallbackProfile.Apply();
            Close();
        }

        private void ButtonDonate_Click(object sender, EventArgs e)
        {
            // Follow donation link
            Program.Donate();
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            // Save profiles and close form
            ProfileManager.SaveProfiles();
            Close();
        }

        private void ButtonRefresh_Click(object sender, EventArgs e)
        {
            // Refresh displayed settings
            RefreshCurrentSettings();
        }

        private void ColumnSpeed_KeyPress(object sender, KeyPressEventArgs e)
        {
            // See https://docs.microsoft.com/en-us/dotnet/api/system.char.iscontrol?view=netframework-4.8

            // Do nothing if key not control character or digit (prevent event propagation)
            if (!(char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void DataGridViewProfiles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check row index valid
            if (IsRowIndexValid(e.RowIndex, false))
            {
                // Set cell true if profile activation column clicked
                if (e.ColumnIndex == columnActive.Index)
                {
                    dataGridViewProfiles.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = true;

                    // Cause paint message to be sent to control
                    dataGridViewProfiles.Invalidate();
                }
            }
        }

        private void DataGridViewProfiles_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            // Check rows have been drawn and cell is in profile activation column
            if (IsRowIndexValid(e.RowIndex, true) && e.ColumnIndex == columnActive.Index)
            {
                // Print cell background without selection highlight
                e.PaintBackground(e.ClipBounds, false);

                // Print checkmark in cell if checked
                if (IsCellChecked(e.RowIndex, e.ColumnIndex))
                {
                    Rectangle rectangle = new Rectangle(
                        e.CellBounds.X + (e.CellBounds.Width - 13) / 2,
                        e.CellBounds.Y + (e.CellBounds.Height - 17) / 2,
                        17,
                        17
                    );
                    ControlPaint.DrawMenuGlyph(e.Graphics, rectangle, MenuGlyph.Checkmark);
                }

                // Paint focus rectangle around cell
                e.Paint(e.ClipBounds, DataGridViewPaintParts.Focus);

                // Prevent event propagation
                e.Handled = true;
            }
        }

        private void DataGridViewProfiles_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Check row index valid
            if (IsRowIndexValid(e.RowIndex, false))
            {
                // Handle value changes
                if (e.ColumnIndex == columnActive.Index)
                {
                    // Check cell value is true
                    if (IsCellChecked(e.RowIndex, e.ColumnIndex))
                    {
                        // Apply selected profile
                        ProfileManager.Profiles[e.RowIndex].Apply();

                        // Refresh displayed settings
                        RefreshCurrentSettings();
                    }

                    // Show active profiles
                    ShowActiveProfiles();
                }
                else if (e.ColumnIndex == columnName.Index)
                {
                    // Trim whitespace from profile name
                    DataGridViewCell cell = dataGridViewProfiles.Rows[e.RowIndex].Cells[columnName.Index];
                    cell.Value = cell.Value != null ? cell.Value.ToString().Trim() : "";
                }
                else if (e.ColumnIndex == columnSpeed.Index)
                {
                    // Validate edited profile speed
                    ProfileManager.Profiles[e.RowIndex].ValidateSpeed();

                    // Show active profiles
                    ShowActiveProfiles();
                }
                else if (e.ColumnIndex == columnAcceleration.Index)
                {
                    // Show active profiles
                    ShowActiveProfiles();
                }

                // Enable apply button if changes made
                buttonApply.Enabled = true;

                // Cause paint message to be sent to control
                dataGridViewProfiles.Invalidate();
            }

        }

        private void DataGridViewProfiles_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            // DataGridView.CellValueChanged does not occur until value committed
            // This usually occurs when focus leaves cell
            // Handle change immediately for checkbox cells by committing change when cell clicked
            if (dataGridViewProfiles.IsCurrentCellDirty && dataGridViewProfiles.CurrentCell.GetType() == typeof(DataGridViewCheckBoxCell))
            {
                dataGridViewProfiles.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void DataGridViewProfiles_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Empty data error handler
            // Invalid cell value changes not committed
            // Error dialog suppressed
        }

        private void DataGridViewProfiles_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            //  Unassign previously added input handler
            e.Control.KeyPress -= ColumnSpeed_KeyPress;

            // Check whether speed column is being edited
            if (dataGridViewProfiles.CurrentCell.ColumnIndex == columnSpeed.Index)
            {
                // Handle speed column input
                if (e.Control is TextBox textBox)
                {
                    textBox.KeyPress += ColumnSpeed_KeyPress;
                }
            }
        }

        private void DataGridViewProfiles_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            // Get row header text
            object value = dataGridViewProfiles.Rows[e.RowIndex].HeaderCell.Value;
            string text = value != null ? value.ToString() : "";

            // Measure row header text
            Size size = TextRenderer.MeasureText(text, dataGridViewProfiles.Font);

            // Paint row header text (cannot print since row header content hidden by padding)
            e.Graphics.DrawString(
                text,
                dataGridViewProfiles.Font,
                new SolidBrush(dataGridViewProfiles.RowHeadersDefaultCellStyle.ForeColor),
                e.RowBounds.Left + (dataGridViewProfiles.RowHeadersWidth - size.Width) / 2,
                e.RowBounds.Top + (e.RowBounds.Height - size.Height) / 2
            );
        }

        private void DataGridViewProfiles_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            // Number each row
            NumberRows();

            // Show active profiles
            ShowActiveProfiles();
        }

        private void DataGridViewProfiles_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            // Number each row
            NumberRows();
        }

        private void ToolStripMenuItemAbout_Click(object sender, EventArgs e)
        {
            // Show about box
            Program.ShowFormAsDialog(aboutBox, true);
        }

        private void ToolStripMenuItemDonate_Click(object sender, EventArgs e)
        {
            // Follow donation link
            Program.Donate();
        }

        private void ToolStripMenuItemOptions_Click(object sender, EventArgs e)
        {
            // Show options form
            Program.ShowFormAsDialog(optionsForm, true);
        }

    }
}
