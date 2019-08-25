using System;
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

        // Field

        private readonly Profile initialProfile;


        // Constructors

        public ProfileForm()
        {
            // Store current profile
            initialProfile = new Profile("", MouseParams.GetSpeed(), MouseParams.GetAcceleration());

            // Initialise form (designer code)
            InitializeComponent();

            // Initialise data grid
            DataGridViewProfiles();

            // Assign event handlers
            buttonApply.Click += ButtonApply_Click;
            buttonCancel.Click += ButtonCancel_Click;
            buttonOK.Click += ButtonOK_Click;
            dataGridViewProfiles.CellPainting += DataGridViewProfiles_CellPainting;
            dataGridViewProfiles.CellValueChanged += DataGridViewProfiles_CellValueChanged;
            dataGridViewProfiles.CurrentCellDirtyStateChanged += DataGridViewProfiles_CurrentCellDirtyStateChanged;
            dataGridViewProfiles.EditingControlShowing += DataGridViewProfiles_EditingControlShowing;

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
        }


        // Event handlers

        private void ButtonApply_Click(object sender, EventArgs e)
        {
            // Save profiles
            ProfileManager.SaveProfiles();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            // Restore initial profile and close form
            initialProfile.Apply();
            Close();
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            // Save profiles and close form
            ProfileManager.SaveProfiles();
            Close();
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

        private void DataGridViewProfiles_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            // Check rows have been drawn and cell is in profile activation column
            if (e.RowIndex >= 0 && e.ColumnIndex == columnActive.Index)
            {
                // Print cell background without selection highlight
                e.PaintBackground(e.ClipBounds, false);

                // Print checkmark in cell if checked
                DataGridViewCheckBoxCell cell = dataGridViewProfiles.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewCheckBoxCell;
                if (cell.Value != null && (bool)cell.Value)
                {
                    Rectangle rectangle = new Rectangle(
                        e.CellBounds.X + (e.CellBounds.Width - 13) / 2,
                        e.CellBounds.Y + (e.CellBounds.Height - 17) / 2,
                        17,
                        17
                    );
                    ControlPaint.DrawMenuGlyph(e.Graphics, rectangle, MenuGlyph.Checkmark);
                }

                // Prevent event propagation
                e.Handled = true;
            }
        }

        private void DataGridViewProfiles_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Handle value changes
            if (e.ColumnIndex == columnActive.Index)
            {
                // Check cell value true
                if ((bool)dataGridViewProfiles.Rows[e.RowIndex].Cells[e.ColumnIndex].Value)
                {
                    // Apply selected profile
                    ProfileManager.Profiles[e.RowIndex].Apply();

                    // Deselect all other profiles
                    foreach (DataGridViewRow row in dataGridViewProfiles.Rows)
                    {
                        if (row.Index != e.RowIndex)
                        {
                            row.Cells[columnActive.Index].Value = false;
                        }
                    }
                }
            }
            else if (e.ColumnIndex == columnSpeed.Index)
            {
                // Validate edited profile speed
                ProfileManager.Profiles[e.RowIndex].ValidateSpeed();
            }

            // Enable apply button if changes made
            buttonApply.Enabled = true;

            // Cause paint message to be sent to control
            dataGridViewProfiles.Invalidate();
        }

        private void DataGridViewProfiles_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            // DataGridView.CellValueChanged does not occur until value committed
            // This usually occurs when focus leaves cell
            // Handle change immediately by committing change when cell clicked
            if (dataGridViewProfiles.IsCurrentCellDirty)
            {
                dataGridViewProfiles.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
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

    }
}
