namespace martindes01.Gonzales
{
    partial class ProfileForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBoxProfiles = new System.Windows.Forms.GroupBox();
            this.dataGridViewProfiles = new System.Windows.Forms.DataGridView();
            this.bindingSourceProfiles = new System.Windows.Forms.BindingSource(this.components);
            this.groupBoxEdit = new System.Windows.Forms.GroupBox();
            this.numericUpDownSpeed = new System.Windows.Forms.NumericUpDown();
            this.labelAcceleration = new System.Windows.Forms.Label();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.comboBoxAcceleration = new System.Windows.Forms.ComboBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonApply = new System.Windows.Forms.Button();
            this.columnActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.columnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnSpeed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnAcceleration = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBoxProfiles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProfiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceProfiles)).BeginInit();
            this.groupBoxEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxProfiles
            // 
            this.groupBoxProfiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxProfiles.Controls.Add(this.dataGridViewProfiles);
            this.groupBoxProfiles.Location = new System.Drawing.Point(8, 8);
            this.groupBoxProfiles.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxProfiles.Name = "groupBoxProfiles";
            this.groupBoxProfiles.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxProfiles.Size = new System.Drawing.Size(524, 298);
            this.groupBoxProfiles.TabIndex = 0;
            this.groupBoxProfiles.TabStop = false;
            this.groupBoxProfiles.Text = "Profiles";
            // 
            // dataGridViewProfiles
            // 
            this.dataGridViewProfiles.AllowUserToResizeRows = false;
            this.dataGridViewProfiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewProfiles.AutoGenerateColumns = false;
            this.dataGridViewProfiles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProfiles.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProfiles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewProfiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProfiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnActive,
            this.columnName,
            this.columnSpeed,
            this.columnAcceleration});
            this.dataGridViewProfiles.DataSource = this.bindingSourceProfiles;
            this.dataGridViewProfiles.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridViewProfiles.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridViewProfiles.Location = new System.Drawing.Point(8, 21);
            this.dataGridViewProfiles.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewProfiles.Name = "dataGridViewProfiles";
            this.dataGridViewProfiles.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewProfiles.ShowEditingIcon = false;
            this.dataGridViewProfiles.Size = new System.Drawing.Size(508, 269);
            this.dataGridViewProfiles.TabIndex = 4;
            // 
            // groupBoxEdit
            // 
            this.groupBoxEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxEdit.Controls.Add(this.numericUpDownSpeed);
            this.groupBoxEdit.Controls.Add(this.labelAcceleration);
            this.groupBoxEdit.Controls.Add(this.labelSpeed);
            this.groupBoxEdit.Controls.Add(this.labelName);
            this.groupBoxEdit.Controls.Add(this.textBoxName);
            this.groupBoxEdit.Controls.Add(this.comboBoxAcceleration);
            this.groupBoxEdit.Controls.Add(this.buttonSave);
            this.groupBoxEdit.Location = new System.Drawing.Point(8, 314);
            this.groupBoxEdit.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxEdit.Name = "groupBoxEdit";
            this.groupBoxEdit.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxEdit.Size = new System.Drawing.Size(524, 67);
            this.groupBoxEdit.TabIndex = 1;
            this.groupBoxEdit.TabStop = false;
            this.groupBoxEdit.Text = "Add profile";
            // 
            // numericUpDownSpeed
            // 
            this.numericUpDownSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownSpeed.Location = new System.Drawing.Point(184, 39);
            this.numericUpDownSpeed.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownSpeed.Name = "numericUpDownSpeed";
            this.numericUpDownSpeed.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownSpeed.TabIndex = 7;
            // 
            // labelAcceleration
            // 
            this.labelAcceleration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAcceleration.AutoSize = true;
            this.labelAcceleration.Location = new System.Drawing.Point(309, 21);
            this.labelAcceleration.Margin = new System.Windows.Forms.Padding(4, 4, 4, 0);
            this.labelAcceleration.Name = "labelAcceleration";
            this.labelAcceleration.Size = new System.Drawing.Size(103, 13);
            this.labelAcceleration.TabIndex = 6;
            this.labelAcceleration.Text = "Mouse acceleration:";
            // 
            // labelSpeed
            // 
            this.labelSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Location = new System.Drawing.Point(181, 21);
            this.labelSpeed.Margin = new System.Windows.Forms.Padding(4, 4, 4, 0);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(74, 13);
            this.labelSpeed.TabIndex = 5;
            this.labelSpeed.Text = "Mouse speed:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(5, 21);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(68, 13);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "Profile name:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(8, 38);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(168, 20);
            this.textBoxName.TabIndex = 2;
            // 
            // comboBoxAcceleration
            // 
            this.comboBoxAcceleration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxAcceleration.FormattingEnabled = true;
            this.comboBoxAcceleration.Location = new System.Drawing.Point(312, 38);
            this.comboBoxAcceleration.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxAcceleration.Name = "comboBoxAcceleration";
            this.comboBoxAcceleration.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAcceleration.TabIndex = 1;
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Location = new System.Drawing.Point(441, 36);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.Text = "Add";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.Location = new System.Drawing.Point(291, 389);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 2;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(374, 389);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonApply
            // 
            this.buttonApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonApply.Enabled = false;
            this.buttonApply.Location = new System.Drawing.Point(457, 389);
            this.buttonApply.Margin = new System.Windows.Forms.Padding(4);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(75, 23);
            this.buttonApply.TabIndex = 4;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            // 
            // columnActive
            // 
            this.columnActive.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.columnActive.Frozen = true;
            this.columnActive.HeaderText = "Active";
            this.columnActive.Name = "columnActive";
            this.columnActive.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.columnActive.Width = 43;
            // 
            // columnName
            // 
            this.columnName.HeaderText = "Profile name";
            this.columnName.Name = "columnName";
            // 
            // columnSpeed
            // 
            this.columnSpeed.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.columnSpeed.DefaultCellStyle = dataGridViewCellStyle2;
            this.columnSpeed.HeaderText = "Speed";
            this.columnSpeed.Name = "columnSpeed";
            this.columnSpeed.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.columnSpeed.Width = 63;
            // 
            // columnAcceleration
            // 
            this.columnAcceleration.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.columnAcceleration.HeaderText = "Acceleration";
            this.columnAcceleration.Name = "columnAcceleration";
            this.columnAcceleration.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.columnAcceleration.Width = 72;
            // 
            // ProfileForm
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(540, 420);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.groupBoxProfiles);
            this.Controls.Add(this.groupBoxEdit);
            this.Name = "ProfileForm";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.Text = "Gonzales";
            this.groupBoxProfiles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProfiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceProfiles)).EndInit();
            this.groupBoxEdit.ResumeLayout(false);
            this.groupBoxEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxProfiles;
        private System.Windows.Forms.GroupBox groupBoxEdit;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.ComboBox comboBoxAcceleration;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelAcceleration;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.NumericUpDown numericUpDownSpeed;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.DataGridView dataGridViewProfiles;
        private System.Windows.Forms.BindingSource bindingSourceProfiles;
        private System.Windows.Forms.DataGridViewCheckBoxColumn columnActive;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnSpeed;
        private System.Windows.Forms.DataGridViewCheckBoxColumn columnAcceleration;
    }
}
