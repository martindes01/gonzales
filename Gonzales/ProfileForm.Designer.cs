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
            this.bindingSourceProfiles = new System.Windows.Forms.BindingSource(this.components);
            this.buttonApply = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonDonate = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.columnAcceleration = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.columnActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.columnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnSpeed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewProfiles = new System.Windows.Forms.DataGridView();
            this.groupBoxCurrent = new System.Windows.Forms.GroupBox();
            this.groupBoxProfiles = new System.Windows.Forms.GroupBox();
            this.labelAcceleration = new System.Windows.Forms.Label();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.textBoxAcceleration = new System.Windows.Forms.TextBox();
            this.textBoxSpeed = new System.Windows.Forms.TextBox();
            this.toolStripMenuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDonate = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemOptions = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceProfiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProfiles)).BeginInit();
            this.groupBoxCurrent.SuspendLayout();
            this.groupBoxProfiles.SuspendLayout();
            this.menuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonApply
            // 
            this.buttonApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonApply.Enabled = false;
            this.buttonApply.Location = new System.Drawing.Point(397, 329);
            this.buttonApply.Margin = new System.Windows.Forms.Padding(4);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(75, 23);
            this.buttonApply.TabIndex = 4;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(314, 329);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonDonate
            // 
            this.buttonDonate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDonate.Location = new System.Drawing.Point(8, 329);
            this.buttonDonate.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDonate.Name = "buttonDonate";
            this.buttonDonate.Size = new System.Drawing.Size(75, 23);
            this.buttonDonate.TabIndex = 5;
            this.buttonDonate.Text = "Donate!";
            this.buttonDonate.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.Location = new System.Drawing.Point(231, 329);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 2;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRefresh.Location = new System.Drawing.Point(381, 42);
            this.buttonRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(75, 23);
            this.buttonRefresh.TabIndex = 2;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            // 
            // columnAcceleration
            // 
            this.columnAcceleration.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.columnAcceleration.HeaderText = "Acceleration";
            this.columnAcceleration.Name = "columnAcceleration";
            this.columnAcceleration.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.columnAcceleration.Width = 79;
            // 
            // columnActive
            // 
            this.columnActive.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.columnActive.Frozen = true;
            this.columnActive.HeaderText = "Active";
            this.columnActive.Name = "columnActive";
            this.columnActive.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.columnActive.Width = 46;
            // 
            // columnName
            // 
            this.columnName.HeaderText = "Profile name";
            this.columnName.Name = "columnName";
            this.columnName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // columnSpeed
            // 
            this.columnSpeed.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.columnSpeed.DefaultCellStyle = dataGridViewCellStyle2;
            this.columnSpeed.HeaderText = "Speed";
            this.columnSpeed.Name = "columnSpeed";
            this.columnSpeed.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.columnSpeed.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.columnSpeed.Width = 45;
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.dataGridViewProfiles.Location = new System.Drawing.Point(8, 24);
            this.dataGridViewProfiles.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewProfiles.Name = "dataGridViewProfiles";
            this.dataGridViewProfiles.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewProfiles.ShowEditingIcon = false;
            this.dataGridViewProfiles.Size = new System.Drawing.Size(448, 171);
            this.dataGridViewProfiles.TabIndex = 1;
            // 
            // groupBoxCurrent
            // 
            this.groupBoxCurrent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxCurrent.Controls.Add(this.buttonRefresh);
            this.groupBoxCurrent.Controls.Add(this.labelAcceleration);
            this.groupBoxCurrent.Controls.Add(this.labelSpeed);
            this.groupBoxCurrent.Controls.Add(this.textBoxAcceleration);
            this.groupBoxCurrent.Controls.Add(this.textBoxSpeed);
            this.groupBoxCurrent.Location = new System.Drawing.Point(8, 247);
            this.groupBoxCurrent.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxCurrent.Name = "groupBoxCurrent";
            this.groupBoxCurrent.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxCurrent.Size = new System.Drawing.Size(464, 74);
            this.groupBoxCurrent.TabIndex = 1;
            this.groupBoxCurrent.TabStop = false;
            this.groupBoxCurrent.Text = "Current settings";
            // 
            // groupBoxProfiles
            // 
            this.groupBoxProfiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxProfiles.Controls.Add(this.dataGridViewProfiles);
            this.groupBoxProfiles.Location = new System.Drawing.Point(8, 36);
            this.groupBoxProfiles.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxProfiles.Name = "groupBoxProfiles";
            this.groupBoxProfiles.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxProfiles.Size = new System.Drawing.Size(464, 203);
            this.groupBoxProfiles.TabIndex = 0;
            this.groupBoxProfiles.TabStop = false;
            this.groupBoxProfiles.Text = "Profiles";
            // 
            // labelAcceleration
            // 
            this.labelAcceleration.AutoSize = true;
            this.labelAcceleration.Location = new System.Drawing.Point(113, 24);
            this.labelAcceleration.Margin = new System.Windows.Forms.Padding(4, 4, 4, 0);
            this.labelAcceleration.Name = "labelAcceleration";
            this.labelAcceleration.Size = new System.Drawing.Size(76, 15);
            this.labelAcceleration.TabIndex = 1;
            this.labelAcceleration.Text = "Acceleration:";
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Location = new System.Drawing.Point(5, 24);
            this.labelSpeed.Margin = new System.Windows.Forms.Padding(4, 4, 4, 0);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(42, 15);
            this.labelSpeed.TabIndex = 0;
            this.labelSpeed.Text = "Speed:";
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemOptions,
            this.toolStripMenuItemAbout,
            this.toolStripMenuItemDonate});
            this.menuStripMain.Location = new System.Drawing.Point(4, 4);
            this.menuStripMain.Margin = new System.Windows.Forms.Padding(4);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.menuStripMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStripMain.Size = new System.Drawing.Size(472, 24);
            this.menuStripMain.TabIndex = 6;
            this.menuStripMain.Text = "menuStripMain";
            // 
            // textBoxAcceleration
            // 
            this.textBoxAcceleration.Enabled = false;
            this.textBoxAcceleration.Location = new System.Drawing.Point(116, 43);
            this.textBoxAcceleration.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAcceleration.Name = "textBoxAcceleration";
            this.textBoxAcceleration.Size = new System.Drawing.Size(100, 23);
            this.textBoxAcceleration.TabIndex = 1;
            this.textBoxAcceleration.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxSpeed
            // 
            this.textBoxSpeed.Enabled = false;
            this.textBoxSpeed.Location = new System.Drawing.Point(8, 43);
            this.textBoxSpeed.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSpeed.Name = "textBoxSpeed";
            this.textBoxSpeed.Size = new System.Drawing.Size(100, 23);
            this.textBoxSpeed.TabIndex = 0;
            this.textBoxSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // toolStripMenuItemAbout
            // 
            this.toolStripMenuItemAbout.Name = "toolStripMenuItemAbout";
            this.toolStripMenuItemAbout.Size = new System.Drawing.Size(52, 20);
            this.toolStripMenuItemAbout.Text = "&About";
            // 
            // toolStripMenuItemDonate
            // 
            this.toolStripMenuItemDonate.Name = "toolStripMenuItemDonate";
            this.toolStripMenuItemDonate.Size = new System.Drawing.Size(60, 20);
            this.toolStripMenuItemDonate.Text = "&Donate!";
            // 
            // toolStripMenuItemOptions
            // 
            this.toolStripMenuItemOptions.Name = "toolStripMenuItemOptions";
            this.toolStripMenuItemOptions.Size = new System.Drawing.Size(61, 20);
            this.toolStripMenuItemOptions.Text = "&Options";
            // 
            // ProfileForm
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(480, 360);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonDonate);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.groupBoxCurrent);
            this.Controls.Add(this.groupBoxProfiles);
            this.Controls.Add(this.menuStripMain);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "ProfileForm";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Gonzales";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceProfiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProfiles)).EndInit();
            this.groupBoxCurrent.ResumeLayout(false);
            this.groupBoxCurrent.PerformLayout();
            this.groupBoxProfiles.ResumeLayout(false);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSourceProfiles;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonDonate;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.DataGridViewCheckBoxColumn columnAcceleration;
        private System.Windows.Forms.DataGridViewCheckBoxColumn columnActive;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnSpeed;
        private System.Windows.Forms.DataGridView dataGridViewProfiles;
        private System.Windows.Forms.GroupBox groupBoxCurrent;
        private System.Windows.Forms.GroupBox groupBoxProfiles;
        private System.Windows.Forms.Label labelAcceleration;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.TextBox textBoxAcceleration;
        private System.Windows.Forms.TextBox textBoxSpeed;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAbout;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDonate;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemOptions;
    }
}
