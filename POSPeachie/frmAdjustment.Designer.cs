﻿namespace POSPeachie
{
    partial class frmAdjustment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdjustment));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRef = new System.Windows.Forms.TextBox();
            this.txtPcode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboCommand = new System.Windows.Forms.ComboBox();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Select = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtSearch = new MetroFramework.Controls.MetroTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1062, 30);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1013, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "STOCK ADJUSTMENT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 427);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "REFERENCE NO";
            // 
            // txtRef
            // 
            this.txtRef.Enabled = false;
            this.txtRef.Location = new System.Drawing.Point(136, 424);
            this.txtRef.Name = "txtRef";
            this.txtRef.Size = new System.Drawing.Size(387, 23);
            this.txtRef.TabIndex = 5;
            this.txtRef.TextChanged += new System.EventHandler(this.txtRef_TextChanged);
            // 
            // txtPcode
            // 
            this.txtPcode.Enabled = false;
            this.txtPcode.Location = new System.Drawing.Point(136, 453);
            this.txtPcode.Name = "txtPcode";
            this.txtPcode.Size = new System.Drawing.Size(387, 23);
            this.txtPcode.TabIndex = 7;
            this.txtPcode.TextChanged += new System.EventHandler(this.txtPcode_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 456);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "PCODE";
            // 
            // txtDesc
            // 
            this.txtDesc.Enabled = false;
            this.txtDesc.Location = new System.Drawing.Point(136, 482);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(387, 23);
            this.txtDesc.TabIndex = 9;
            this.txtDesc.TextChanged += new System.EventHandler(this.txtDesc_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 485);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "DESCRIPTION";
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(136, 511);
            this.txtQty.MaxLength = 4;
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(387, 23);
            this.txtQty.TabIndex = 11;
            this.txtQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQty_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 514);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "QTY";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(531, 429);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "COMMAND";
            // 
            // cboCommand
            // 
            this.cboCommand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCommand.FormattingEnabled = true;
            this.cboCommand.Items.AddRange(new object[] {
            "REMOVE FROM INVENTORY",
            "ADD TO INVENTORY"});
            this.cboCommand.Location = new System.Drawing.Point(615, 427);
            this.cboCommand.Name = "cboCommand";
            this.cboCommand.Size = new System.Drawing.Size(428, 23);
            this.cboCommand.TabIndex = 13;
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(615, 456);
            this.txtRemarks.MaxLength = 30;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(428, 23);
            this.txtRemarks.TabIndex = 15;
            this.txtRemarks.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRemarks_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(531, 459);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "REMARKS";
            // 
            // txtUser
            // 
            this.txtUser.Enabled = false;
            this.txtUser.Location = new System.Drawing.Point(615, 485);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(428, 23);
            this.txtUser.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(531, 490);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "USER";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.MintCream;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column8,
            this.Column4,
            this.Column3,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Select});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.MintCream;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.PowderBlue;
            this.dataGridView1.Location = new System.Drawing.Point(7, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1043, 351);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "#";
            this.Column1.Name = "Column1";
            this.Column1.Width = 36;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.HeaderText = "PCODE";
            this.Column2.Name = "Column2";
            this.Column2.Width = 67;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column8.HeaderText = "BARCODE";
            this.Column8.Name = "Column8";
            this.Column8.Width = 81;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "DESCRIPTION";
            this.Column4.Name = "Column4";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column3.HeaderText = "BRAND";
            this.Column3.Name = "Column3";
            this.Column3.Width = 67;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column5.HeaderText = "CATEGORY";
            this.Column5.Name = "Column5";
            this.Column5.Width = 85;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column6.DefaultCellStyle = dataGridViewCellStyle8;
            this.Column6.HeaderText = "PRICE";
            this.Column6.Name = "Column6";
            this.Column6.Width = 61;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column7.DefaultCellStyle = dataGridViewCellStyle9;
            this.Column7.HeaderText = "STOCK ON HAND";
            this.Column7.Name = "Column7";
            this.Column7.Width = 119;
            // 
            // Select
            // 
            this.Select.HeaderText = "";
            this.Select.Image = ((System.Drawing.Image)(resources.GetObject("Select.Image")));
            this.Select.Name = "Select";
            this.Select.Width = 30;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(966, 514);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(77, 28);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtSearch
            // 
            // 
            // 
            // 
            this.txtSearch.CustomButton.Image = null;
            this.txtSearch.CustomButton.Location = new System.Drawing.Point(344, 1);
            this.txtSearch.CustomButton.Name = "";
            this.txtSearch.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearch.CustomButton.TabIndex = 1;
            this.txtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearch.CustomButton.UseSelectable = true;
            this.txtSearch.CustomButton.Visible = false;
            this.txtSearch.DisplayIcon = true;
            this.txtSearch.Icon = ((System.Drawing.Image)(resources.GetObject("txtSearch.Icon")));
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(7, 36);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PromptText = "Search here";
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(368, 25);
            this.txtSearch.TabIndex = 20;
            this.txtSearch.UseSelectable = true;
            this.txtSearch.WaterMark = "Search here";
            this.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // frmAdjustment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 550);
            this.ControlBox = false;
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cboCommand);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPcode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRef);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmAdjustment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtRef;
        public System.Windows.Forms.TextBox txtPcode;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.ComboBox cboCommand;
        public System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Button btnSave;
        private MetroFramework.Controls.MetroTextBox txtSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewImageColumn Select;
    }
}