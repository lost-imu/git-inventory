namespace InventorySystem1._0
{
    partial class frmItems
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
            this.btnClose = new System.Windows.Forms.Button();
            this.Label6 = new System.Windows.Forms.Label();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.btndelete = new System.Windows.Forms.Button();
            this.itemNameTextBox = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.projectTextBox = new System.Windows.Forms.TextBox();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.descriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.itemIDTxtBox = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.unitCombo = new System.Windows.Forms.ComboBox();
            this.dtglist = new System.Windows.Forms.DataGridView();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.btnadd = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.pnl_stockmaster = new System.Windows.Forms.Panel();
            this.expiryDateCheckBx = new System.Windows.Forms.CheckBox();
            this.isNewRadio = new System.Windows.Forms.RadioButton();
            this.isNotNewRadio = new System.Windows.Forms.RadioButton();
            this.qtyUpDown = new System.Windows.Forms.NumericUpDown();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.expiryDatePicker = new System.Windows.Forms.DateTimePicker();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.suppliertxtbox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtglist)).BeginInit();
            this.Panel2.SuspendLayout();
            this.pnl_stockmaster.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qtyUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(1132, 191);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(106, 30);
            this.btnClose.TabIndex = 44;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(63, 200);
            this.Label6.Name = "Label6";
            this.Label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label6.Size = new System.Drawing.Size(40, 13);
            this.Label6.TabIndex = 31;
            this.Label6.Text = "Search";
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(109, 196);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(205, 20);
            this.txtsearch.TabIndex = 29;
            this.txtsearch.TextChanged += new System.EventHandler(this.Txtsearch_TextChanged);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.Transparent;
            this.btndelete.ForeColor = System.Drawing.Color.Black;
            this.btndelete.Location = new System.Drawing.Point(1020, 191);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(106, 30);
            this.btndelete.TabIndex = 34;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.Btndelete_Click);
            // 
            // itemNameTextBox
            // 
            this.itemNameTextBox.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemNameTextBox.Location = new System.Drawing.Point(491, 48);
            this.itemNameTextBox.Name = "itemNameTextBox";
            this.itemNameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.itemNameTextBox.Size = new System.Drawing.Size(341, 22);
            this.itemNameTextBox.TabIndex = 2;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(43, 123);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(45, 16);
            this.Label4.TabIndex = 1;
            this.Label4.Text = "Project";
            // 
            // projectTextBox
            // 
            this.projectTextBox.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectTextBox.Location = new System.Drawing.Point(94, 120);
            this.projectTextBox.Name = "projectTextBox";
            this.projectTextBox.Size = new System.Drawing.Size(302, 22);
            this.projectTextBox.TabIndex = 7;
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.Transparent;
            this.btnupdate.ForeColor = System.Drawing.Color.Black;
            this.btnupdate.Location = new System.Drawing.Point(911, 191);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(103, 30);
            this.btnupdate.TabIndex = 35;
            this.btnupdate.Text = "Edit";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.Btnupdate_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.Transparent;
            this.btnsave.ForeColor = System.Drawing.Color.Black;
            this.btnsave.Location = new System.Drawing.Point(799, 191);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(106, 30);
            this.btnsave.TabIndex = 36;
            this.btnsave.Text = "Add";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.Btnsave_Click);
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionTextBox.Location = new System.Drawing.Point(491, 81);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.descriptionTextBox.Size = new System.Drawing.Size(341, 81);
            this.descriptionTextBox.TabIndex = 3;
            this.descriptionTextBox.Text = "";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(451, 84);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(34, 16);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "Desc";
            // 
            // itemIDTxtBox
            // 
            this.itemIDTxtBox.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemIDTxtBox.Location = new System.Drawing.Point(491, 18);
            this.itemIDTxtBox.Name = "itemIDTxtBox";
            this.itemIDTxtBox.Size = new System.Drawing.Size(340, 22);
            this.itemIDTxtBox.TabIndex = 1;
            this.itemIDTxtBox.TextChanged += new System.EventHandler(this.Txtitemid_TextChanged);
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(445, 20);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(40, 16);
            this.Label8.TabIndex = 8;
            this.Label8.Text = "Brand";
            // 
            // unitCombo
            // 
            this.unitCombo.FormattingEnabled = true;
            this.unitCombo.Location = new System.Drawing.Point(1004, 18);
            this.unitCombo.Name = "unitCombo";
            this.unitCombo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.unitCombo.Size = new System.Drawing.Size(64, 23);
            this.unitCombo.TabIndex = 6;
            this.unitCombo.Text = "Metre";
            // 
            // dtglist
            // 
            this.dtglist.AllowUserToAddRows = false;
            this.dtglist.AllowUserToDeleteRows = false;
            this.dtglist.AllowUserToResizeColumns = false;
            this.dtglist.AllowUserToResizeRows = false;
            this.dtglist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtglist.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtglist.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtglist.Location = new System.Drawing.Point(0, -1);
            this.dtglist.Name = "dtglist";
            this.dtglist.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtglist.Size = new System.Drawing.Size(1248, 360);
            this.dtglist.TabIndex = 0;
            this.dtglist.Click += new System.EventHandler(this.Dtglist_Click);
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel2.Controls.Add(this.btnadd);
            this.Panel2.Controls.Add(this.dtglist);
            this.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel2.Location = new System.Drawing.Point(0, 229);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(1250, 361);
            this.Panel2.TabIndex = 32;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(227, 55);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(142, 25);
            this.btnadd.TabIndex = 2;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(448, 51);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(37, 16);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "Name";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(860, 21);
            this.Label7.Name = "Label7";
            this.Label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label7.Size = new System.Drawing.Size(53, 16);
            this.Label7.TabIndex = 5;
            this.Label7.Text = "Quantity";
            // 
            // pnl_stockmaster
            // 
            this.pnl_stockmaster.BackColor = System.Drawing.Color.White;
            this.pnl_stockmaster.Controls.Add(this.expiryDateCheckBx);
            this.pnl_stockmaster.Controls.Add(this.isNewRadio);
            this.pnl_stockmaster.Controls.Add(this.isNotNewRadio);
            this.pnl_stockmaster.Controls.Add(this.qtyUpDown);
            this.pnl_stockmaster.Controls.Add(this.dateTimePicker3);
            this.pnl_stockmaster.Controls.Add(this.expiryDatePicker);
            this.pnl_stockmaster.Controls.Add(this.textBox2);
            this.pnl_stockmaster.Controls.Add(this.textBox1);
            this.pnl_stockmaster.Controls.Add(this.suppliertxtbox);
            this.pnl_stockmaster.Controls.Add(this.label11);
            this.pnl_stockmaster.Controls.Add(this.label9);
            this.pnl_stockmaster.Controls.Add(this.label5);
            this.pnl_stockmaster.Controls.Add(this.itemIDTxtBox);
            this.pnl_stockmaster.Controls.Add(this.Label8);
            this.pnl_stockmaster.Controls.Add(this.unitCombo);
            this.pnl_stockmaster.Controls.Add(this.Label7);
            this.pnl_stockmaster.Controls.Add(this.descriptionTextBox);
            this.pnl_stockmaster.Controls.Add(this.itemNameTextBox);
            this.pnl_stockmaster.Controls.Add(this.label10);
            this.pnl_stockmaster.Controls.Add(this.Label4);
            this.pnl_stockmaster.Controls.Add(this.projectTextBox);
            this.pnl_stockmaster.Controls.Add(this.Label2);
            this.pnl_stockmaster.Controls.Add(this.Label1);
            this.pnl_stockmaster.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_stockmaster.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_stockmaster.Location = new System.Drawing.Point(0, 0);
            this.pnl_stockmaster.Name = "pnl_stockmaster";
            this.pnl_stockmaster.Size = new System.Drawing.Size(1250, 184);
            this.pnl_stockmaster.TabIndex = 30;
            // 
            // expiryDateCheckBx
            // 
            this.expiryDateCheckBx.AutoSize = true;
            this.expiryDateCheckBx.Checked = true;
            this.expiryDateCheckBx.CheckState = System.Windows.Forms.CheckState.Checked;
            this.expiryDateCheckBx.Location = new System.Drawing.Point(1022, 121);
            this.expiryDateCheckBx.Name = "expiryDateCheckBx";
            this.expiryDateCheckBx.Size = new System.Drawing.Size(43, 19);
            this.expiryDateCheckBx.TabIndex = 9;
            this.expiryDateCheckBx.Text = "N/A";
            this.expiryDateCheckBx.UseVisualStyleBackColor = true;
            this.expiryDateCheckBx.CheckedChanged += new System.EventHandler(this.ExpiryDateCheckBx_CheckedChanged);
            // 
            // isNewRadio
            // 
            this.isNewRadio.AutoSize = true;
            this.isNewRadio.Checked = true;
            this.isNewRadio.Location = new System.Drawing.Point(1014, 78);
            this.isNewRadio.Name = "isNewRadio";
            this.isNewRadio.Size = new System.Drawing.Size(44, 19);
            this.isNewRadio.TabIndex = 8;
            this.isNewRadio.TabStop = true;
            this.isNewRadio.Text = "New";
            this.isNewRadio.UseVisualStyleBackColor = true;
            this.isNewRadio.CheckedChanged += new System.EventHandler(this.IsNewRadio_CheckedChanged);
            // 
            // isNotNewRadio
            // 
            this.isNotNewRadio.AutoSize = true;
            this.isNotNewRadio.Location = new System.Drawing.Point(1086, 78);
            this.isNotNewRadio.Name = "isNotNewRadio";
            this.isNotNewRadio.Size = new System.Drawing.Size(86, 19);
            this.isNotNewRadio.TabIndex = 8;
            this.isNotNewRadio.TabStop = true;
            this.isNotNewRadio.Text = "Second Hand";
            this.isNotNewRadio.UseVisualStyleBackColor = true;
            this.isNotNewRadio.CheckedChanged += new System.EventHandler(this.IsNotNewRadio_CheckedChanged);
            // 
            // qtyUpDown
            // 
            this.qtyUpDown.Location = new System.Drawing.Point(932, 19);
            this.qtyUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.qtyUpDown.Name = "qtyUpDown";
            this.qtyUpDown.Size = new System.Drawing.Size(66, 20);
            this.qtyUpDown.TabIndex = 5;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(-370, 48);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(336, 20);
            this.dateTimePicker3.TabIndex = 9;
            // 
            // expiryDatePicker
            // 
            this.expiryDatePicker.Enabled = false;
            this.expiryDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.expiryDatePicker.Location = new System.Drawing.Point(1071, 120);
            this.expiryDatePicker.Name = "expiryDatePicker";
            this.expiryDatePicker.Size = new System.Drawing.Size(117, 20);
            this.expiryDatePicker.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(94, 84);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(301, 22);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.Txtitemid_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(94, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(301, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.Txtitemid_TextChanged);
            // 
            // suppliertxtbox
            // 
            this.suppliertxtbox.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suppliertxtbox.Location = new System.Drawing.Point(94, 20);
            this.suppliertxtbox.Name = "suppliertxtbox";
            this.suppliertxtbox.Size = new System.Drawing.Size(301, 22);
            this.suppliertxtbox.TabIndex = 1;
            this.suppliertxtbox.TextChanged += new System.EventHandler(this.Txtitemid_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(32, 87);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 16);
            this.label11.TabIndex = 8;
            this.label11.Text = "Sub Line";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(14, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "General Line";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Supplier";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(948, 122);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 16);
            this.label10.TabIndex = 1;
            this.label10.Text = "Expiry Date";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(615, 196);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(160, 20);
            this.textBox3.TabIndex = 29;
            this.textBox3.TextChanged += new System.EventHandler(this.Txtsearch_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(569, 199);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Search";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(403, 197);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(160, 20);
            this.textBox4.TabIndex = 29;
            this.textBox4.TextChanged += new System.EventHandler(this.Txtsearch_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(358, 200);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "Search";
            // 
            // frmItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 590);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.pnl_stockmaster);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmItems";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock Master";
            this.Load += new System.EventHandler(this.FrmItems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtglist)).EndInit();
            this.Panel2.ResumeLayout(false);
            this.pnl_stockmaster.ResumeLayout(false);
            this.pnl_stockmaster.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qtyUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Button btnClose;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.TextBox txtsearch;
        internal System.Windows.Forms.Button btndelete;
        internal System.Windows.Forms.TextBox itemNameTextBox;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox projectTextBox;
        internal System.Windows.Forms.Button btnupdate;
        internal System.Windows.Forms.Button btnsave;
        internal System.Windows.Forms.RichTextBox descriptionTextBox;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox itemIDTxtBox;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.ComboBox unitCombo;
        internal System.Windows.Forms.DataGridView dtglist;
        internal System.Windows.Forms.Panel Panel2;
        internal System.Windows.Forms.Button btnadd;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Panel pnl_stockmaster;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.DateTimePicker expiryDatePicker;
        internal System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown qtyUpDown;
        private System.Windows.Forms.RadioButton isNewRadio;
        private System.Windows.Forms.RadioButton isNotNewRadio;
        private System.Windows.Forms.CheckBox expiryDateCheckBx;
        internal System.Windows.Forms.TextBox suppliertxtbox;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.TextBox textBox2;
        internal System.Windows.Forms.TextBox textBox1;
        internal System.Windows.Forms.Label label11;
        internal System.Windows.Forms.Label label9;
        internal System.Windows.Forms.TextBox textBox3;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.TextBox textBox4;
        internal System.Windows.Forms.Label label12;
    }
}