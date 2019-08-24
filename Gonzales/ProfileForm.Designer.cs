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
            this.groupBoxProfiles = new System.Windows.Forms.GroupBox();
            this.groupBoxEdit = new System.Windows.Forms.GroupBox();
            this.labelAcceleration = new System.Windows.Forms.Label();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.comboBoxAcceleration = new System.Windows.Forms.ComboBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.numericUpDownSpeed = new System.Windows.Forms.NumericUpDown();
            this.buttonApply = new System.Windows.Forms.Button();
            this.buttonMoveUp = new System.Windows.Forms.Button();
            this.buttonMoveDown = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.dataGridViewProfiles = new System.Windows.Forms.DataGridView();
            this.groupBoxProfiles.SuspendLayout();
            this.groupBoxEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProfiles)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxProfiles
            // 
            this.groupBoxProfiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxProfiles.Controls.Add(this.dataGridViewProfiles);
            this.groupBoxProfiles.Controls.Add(this.buttonEdit);
            this.groupBoxProfiles.Controls.Add(this.buttonMoveDown);
            this.groupBoxProfiles.Controls.Add(this.buttonMoveUp);
            this.groupBoxProfiles.Location = new System.Drawing.Point(8, 8);
            this.groupBoxProfiles.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxProfiles.Name = "groupBoxProfiles";
            this.groupBoxProfiles.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxProfiles.Size = new System.Drawing.Size(524, 298);
            this.groupBoxProfiles.TabIndex = 0;
            this.groupBoxProfiles.TabStop = false;
            this.groupBoxProfiles.Text = "Profiles";
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
            // numericUpDownSpeed
            // 
            this.numericUpDownSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownSpeed.Location = new System.Drawing.Point(184, 39);
            this.numericUpDownSpeed.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownSpeed.Name = "numericUpDownSpeed";
            this.numericUpDownSpeed.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownSpeed.TabIndex = 7;
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
            // buttonMoveUp
            // 
            this.buttonMoveUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMoveUp.Location = new System.Drawing.Point(441, 21);
            this.buttonMoveUp.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMoveUp.Name = "buttonMoveUp";
            this.buttonMoveUp.Size = new System.Drawing.Size(75, 23);
            this.buttonMoveUp.TabIndex = 1;
            this.buttonMoveUp.Text = "Move up";
            this.buttonMoveUp.UseVisualStyleBackColor = true;
            // 
            // buttonMoveDown
            // 
            this.buttonMoveDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMoveDown.Location = new System.Drawing.Point(441, 52);
            this.buttonMoveDown.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMoveDown.Name = "buttonMoveDown";
            this.buttonMoveDown.Size = new System.Drawing.Size(75, 23);
            this.buttonMoveDown.TabIndex = 2;
            this.buttonMoveDown.Text = "Move down";
            this.buttonMoveDown.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEdit.Location = new System.Drawing.Point(441, 267);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 3;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            // 
            // dataGridViewProfiles
            // 
            this.dataGridViewProfiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewProfiles.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewProfiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProfiles.Location = new System.Drawing.Point(8, 21);
            this.dataGridViewProfiles.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewProfiles.Name = "dataGridViewProfiles";
            this.dataGridViewProfiles.Size = new System.Drawing.Size(425, 269);
            this.dataGridViewProfiles.TabIndex = 4;
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ProfileForm";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.Text = "Gonzales";
            this.groupBoxProfiles.ResumeLayout(false);
            this.groupBoxEdit.ResumeLayout(false);
            this.groupBoxEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProfiles)).EndInit();
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
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonMoveDown;
        private System.Windows.Forms.Button buttonMoveUp;
        private System.Windows.Forms.DataGridView dataGridViewProfiles;
    }
}
