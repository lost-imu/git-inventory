﻿
namespace InventorySystem1._0
{
    partial class frmRequest
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
            this.dtCus_addedlist = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UNIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EXPIRYDATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOTES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Label8 = new System.Windows.Forms.Label();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.load_items_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.load_items_btn = new System.Windows.Forms.Button();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.dtgCus_itemlist = new System.Windows.Forms.DataGridView();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.returnBtn = new System.Windows.Forms.Button();
            this.scannerTxtBox = new System.Windows.Forms.TextBox();
            this.Button2 = new System.Windows.Forms.Button();
            this.btnviewStockout = new System.Windows.Forms.Button();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.load_names_btn = new System.Windows.Forms.Button();
            this.empNameComboBox = new System.Windows.Forms.ComboBox();
            this.isEmployeeCombo = new System.Windows.Forms.ComboBox();
            this.employeeOrPhoneNumberLabel = new System.Windows.Forms.Label();
            this.txt_cusid = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Label15 = new System.Windows.Forms.Label();
            this.projecttxtbox = new System.Windows.Forms.TextBox();
            this.txtCus_lname = new System.Windows.Forms.TextBox();
            this.txtCus_fname = new System.Windows.Forms.TextBox();
            this.btnCus_clear = new System.Windows.Forms.Button();
            this.btnCus_Remove = new System.Windows.Forms.Button();
            this.printLastBtn = new System.Windows.Forms.Button();
            this.btnCus_save = new System.Windows.Forms.Button();
            this.Panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dtCus_addedlist)).BeginInit();
            this.Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.load_items_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCus_itemlist)).BeginInit();
            this.Panel1.SuspendLayout();
            this.Panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtCus_addedlist
            // 
            this.dtCus_addedlist.AllowUserToAddRows = false;
            this.dtCus_addedlist.AllowUserToDeleteRows = false;
            this.dtCus_addedlist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtCus_addedlist.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtCus_addedlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtCus_addedlist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.TYPE,
            this.Column5,
            this.Column8,
            this.UNIT,
            this.Column4,
            this.Column6,
            this.EXPIRYDATE,
            this.NOTES});
            this.dtCus_addedlist.Location = new System.Drawing.Point(16, 333);
            this.dtCus_addedlist.Name = "dtCus_addedlist";
            this.dtCus_addedlist.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtCus_addedlist.RowHeadersVisible = false;
            this.dtCus_addedlist.Size = new System.Drawing.Size(1217, 254);
            this.dtCus_addedlist.TabIndex = 30;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "رقم الصنف";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 75;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.HeaderText = "اسم الصنف";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 79;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column3.HeaderText = "الشرح";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 62;
            // 
            // TYPE
            // 
            this.TYPE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TYPE.HeaderText = "النوع";
            this.TYPE.Name = "TYPE";
            this.TYPE.ReadOnly = true;
            this.TYPE.Width = 54;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column5.HeaderText = "الكمية";
            this.Column5.Name = "Column5";
            this.Column5.Width = 61;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "الحجز";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 382;
            // 
            // UNIT
            // 
            this.UNIT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.UNIT.HeaderText = "الوحدة";
            this.UNIT.Name = "UNIT";
            this.UNIT.ReadOnly = true;
            this.UNIT.Width = 61;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.HeaderText = "مشروع";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 67;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column6.HeaderText = "جديد\\ مستعمل";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 96;
            // 
            // EXPIRYDATE
            // 
            this.EXPIRYDATE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.EXPIRYDATE.HeaderText = "إنتهاء الصلاحية";
            this.EXPIRYDATE.Name = "EXPIRYDATE";
            this.EXPIRYDATE.ReadOnly = true;
            this.EXPIRYDATE.Width = 90;
            // 
            // NOTES
            // 
            this.NOTES.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NOTES.HeaderText = "ملاحظات";
            this.NOTES.Name = "NOTES";
            this.NOTES.Width = 73;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(723, 6);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(121, 24);
            this.Label8.TabIndex = 26;
            this.Label8.Text = ":الأصناف المضافة";
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel2.Controls.Add(this.load_items_numericUpDown);
            this.Panel2.Controls.Add(this.load_items_btn);
            this.Panel2.Controls.Add(this.Label7);
            this.Panel2.Controls.Add(this.Label6);
            this.Panel2.Controls.Add(this.dtgCus_itemlist);
            this.Panel2.Controls.Add(this.txtsearch);
            this.Panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Panel2.Location = new System.Drawing.Point(12, 106);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(1222, 187);
            this.Panel2.TabIndex = 31;
            // 
            // load_items_numericUpDown
            // 
            this.load_items_numericUpDown.Location = new System.Drawing.Point(1096, 4);
            this.load_items_numericUpDown.Name = "load_items_numericUpDown";
            this.load_items_numericUpDown.Size = new System.Drawing.Size(74, 20);
            this.load_items_numericUpDown.TabIndex = 14;
            this.load_items_numericUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // load_items_btn
            // 
            this.load_items_btn.Location = new System.Drawing.Point(1044, 3);
            this.load_items_btn.Name = "load_items_btn";
            this.load_items_btn.Size = new System.Drawing.Size(46, 23);
            this.load_items_btn.TabIndex = 13;
            this.load_items_btn.Text = "Load";
            this.load_items_btn.UseVisualStyleBackColor = true;
            this.load_items_btn.Click += new System.EventHandler(this.load_items_btn_Click);
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(689, 2);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(163, 24);
            this.Label7.TabIndex = 3;
            this.Label7.Text = ":لائحة بالأصناف المتوفرة";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(632, 9);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(29, 13);
            this.Label6.TabIndex = 4;
            this.Label6.Text = ":بحث";
            // 
            // dtgCus_itemlist
            // 
            this.dtgCus_itemlist.AllowUserToAddRows = false;
            this.dtgCus_itemlist.AllowUserToDeleteRows = false;
            this.dtgCus_itemlist.AllowUserToResizeColumns = false;
            this.dtgCus_itemlist.AllowUserToResizeRows = false;
            this.dtgCus_itemlist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgCus_itemlist.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgCus_itemlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCus_itemlist.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgCus_itemlist.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgCus_itemlist.Location = new System.Drawing.Point(0, 29);
            this.dtgCus_itemlist.Name = "dtgCus_itemlist";
            this.dtgCus_itemlist.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtgCus_itemlist.RowHeadersVisible = false;
            this.dtgCus_itemlist.Size = new System.Drawing.Size(1220, 156);
            this.dtgCus_itemlist.TabIndex = 0;
            this.dtgCus_itemlist.DoubleClick += new System.EventHandler(this.DtgCus_itemlist_DoubleClick);
            // 
            // txtsearch
            // 
            this.txtsearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtsearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtsearch.Location = new System.Drawing.Point(406, 6);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(220, 20);
            this.txtsearch.TabIndex = 4;
            this.txtsearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txtsearch_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(632, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "الماسح الضوئي";
            this.label3.Visible = false;
            // 
            // returnBtn
            // 
            this.returnBtn.BackColor = System.Drawing.Color.Transparent;
            this.returnBtn.Enabled = false;
            this.returnBtn.ForeColor = System.Drawing.Color.Black;
            this.returnBtn.Location = new System.Drawing.Point(484, 593);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(88, 36);
            this.returnBtn.TabIndex = 35;
            this.returnBtn.Text = "إرجاع الصنف";
            this.returnBtn.UseVisualStyleBackColor = false;
            this.returnBtn.Visible = false;
            this.returnBtn.Click += new System.EventHandler(this.ReturnBtn_Click);
            // 
            // scannerTxtBox
            // 
            this.scannerTxtBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.scannerTxtBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.scannerTxtBox.Location = new System.Drawing.Point(406, 6);
            this.scannerTxtBox.Name = "scannerTxtBox";
            this.scannerTxtBox.Size = new System.Drawing.Size(220, 20);
            this.scannerTxtBox.TabIndex = 1;
            this.scannerTxtBox.Visible = false;
            this.scannerTxtBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ScannerTxtBox_KeyDown);
            // 
            // Button2
            // 
            this.Button2.BackColor = System.Drawing.Color.Transparent;
            this.Button2.ForeColor = System.Drawing.Color.Black;
            this.Button2.Location = new System.Drawing.Point(777, 593);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(88, 36);
            this.Button2.TabIndex = 40;
            this.Button2.Text = "إغلاق";
            this.Button2.UseVisualStyleBackColor = false;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // btnviewStockout
            // 
            this.btnviewStockout.BackColor = System.Drawing.Color.Transparent;
            this.btnviewStockout.ForeColor = System.Drawing.Color.Black;
            this.btnviewStockout.Location = new System.Drawing.Point(300, 593);
            this.btnviewStockout.Name = "btnviewStockout";
            this.btnviewStockout.Size = new System.Drawing.Size(88, 36);
            this.btnviewStockout.TabIndex = 39;
            this.btnviewStockout.Text = "لائحة الأصناف المتوفرة";
            this.btnviewStockout.UseVisualStyleBackColor = false;
            this.btnviewStockout.Click += new System.EventHandler(this.BtnviewStockout_Click);
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.load_names_btn);
            this.Panel1.Controls.Add(this.empNameComboBox);
            this.Panel1.Controls.Add(this.isEmployeeCombo);
            this.Panel1.Controls.Add(this.employeeOrPhoneNumberLabel);
            this.Panel1.Controls.Add(this.txt_cusid);
            this.Panel1.Controls.Add(this.Label1);
            this.Panel1.Controls.Add(this.Label5);
            this.Panel1.Controls.Add(this.label2);
            this.Panel1.Controls.Add(this.Label15);
            this.Panel1.Controls.Add(this.projecttxtbox);
            this.Panel1.Controls.Add(this.txtCus_lname);
            this.Panel1.Controls.Add(this.txtCus_fname);
            this.Panel1.Location = new System.Drawing.Point(12, 12);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(1222, 88);
            this.Panel1.TabIndex = 38;
            // 
            // load_names_btn
            // 
            this.load_names_btn.Location = new System.Drawing.Point(798, 53);
            this.load_names_btn.Name = "load_names_btn";
            this.load_names_btn.Size = new System.Drawing.Size(46, 23);
            this.load_names_btn.TabIndex = 11;
            this.load_names_btn.Text = "Load";
            this.load_names_btn.UseVisualStyleBackColor = true;
            this.load_names_btn.Click += new System.EventHandler(this.load_names_btn_Click);
            // 
            // empNameComboBox
            // 
            this.empNameComboBox.FormattingEnabled = true;
            this.empNameComboBox.Location = new System.Drawing.Point(670, 53);
            this.empNameComboBox.Name = "empNameComboBox";
            this.empNameComboBox.Size = new System.Drawing.Size(121, 21);
            this.empNameComboBox.TabIndex = 10;
            this.empNameComboBox.SelectedIndexChanged += new System.EventHandler(this.empNameComboBox_SelectedIndexChanged);
            // 
            // isEmployeeCombo
            // 
            this.isEmployeeCombo.FormattingEnabled = true;
            this.isEmployeeCombo.Items.AddRange(new object[] {
            "موظف",
            "غير موظف"});
            this.isEmployeeCombo.Location = new System.Drawing.Point(671, 5);
            this.isEmployeeCombo.Name = "isEmployeeCombo";
            this.isEmployeeCombo.Size = new System.Drawing.Size(121, 21);
            this.isEmployeeCombo.TabIndex = 9;
            this.isEmployeeCombo.Text = "موظف";
            // 
            // employeeOrPhoneNumberLabel
            // 
            this.employeeOrPhoneNumberLabel.AutoSize = true;
            this.employeeOrPhoneNumberLabel.Location = new System.Drawing.Point(565, 26);
            this.employeeOrPhoneNumberLabel.Name = "employeeOrPhoneNumberLabel";
            this.employeeOrPhoneNumberLabel.Size = new System.Drawing.Size(72, 13);
            this.employeeOrPhoneNumberLabel.TabIndex = 8;
            this.employeeOrPhoneNumberLabel.Text = ":رقم المستلم";
            // 
            // txt_cusid
            // 
            this.txt_cusid.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_cusid.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_cusid.Location = new System.Drawing.Point(339, 23);
            this.txt_cusid.Name = "txt_cusid";
            this.txt_cusid.Size = new System.Drawing.Size(220, 20);
            this.txt_cusid.TabIndex = 1;
            this.txt_cusid.TextChanged += new System.EventHandler(this.Txt_cusid_TextChanged);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(798, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(50, 24);
            this.Label1.TabIndex = 3;
            this.Label1.Text = "المستلم";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(565, 53);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(65, 13);
            this.Label5.TabIndex = 1;
            this.Label5.Text = ":الإسم الأول";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = ":المشروع";
            // 
            // Label15
            // 
            this.Label15.AutoSize = true;
            this.Label15.Location = new System.Drawing.Point(260, 53);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(64, 13);
            this.Label15.TabIndex = 1;
            this.Label15.Text = ":إسم العائلة";
            // 
            // projecttxtbox
            // 
            this.projecttxtbox.Location = new System.Drawing.Point(38, 24);
            this.projecttxtbox.Name = "projecttxtbox";
            this.projecttxtbox.Size = new System.Drawing.Size(220, 20);
            this.projecttxtbox.TabIndex = 3;
            // 
            // txtCus_lname
            // 
            this.txtCus_lname.Enabled = false;
            this.txtCus_lname.Location = new System.Drawing.Point(38, 50);
            this.txtCus_lname.Name = "txtCus_lname";
            this.txtCus_lname.Size = new System.Drawing.Size(220, 20);
            this.txtCus_lname.TabIndex = 3;
            // 
            // txtCus_fname
            // 
            this.txtCus_fname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtCus_fname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCus_fname.Enabled = false;
            this.txtCus_fname.Location = new System.Drawing.Point(339, 50);
            this.txtCus_fname.Name = "txtCus_fname";
            this.txtCus_fname.Size = new System.Drawing.Size(220, 20);
            this.txtCus_fname.TabIndex = 2;
            // 
            // btnCus_clear
            // 
            this.btnCus_clear.BackColor = System.Drawing.Color.Transparent;
            this.btnCus_clear.ForeColor = System.Drawing.Color.Black;
            this.btnCus_clear.Location = new System.Drawing.Point(204, 593);
            this.btnCus_clear.Name = "btnCus_clear";
            this.btnCus_clear.Size = new System.Drawing.Size(88, 36);
            this.btnCus_clear.TabIndex = 33;
            this.btnCus_clear.Text = "مسح الأصناف المضافة";
            this.btnCus_clear.UseVisualStyleBackColor = false;
            this.btnCus_clear.Click += new System.EventHandler(this.BtnCus_clear_Click);
            // 
            // btnCus_Remove
            // 
            this.btnCus_Remove.BackColor = System.Drawing.Color.Transparent;
            this.btnCus_Remove.ForeColor = System.Drawing.Color.Black;
            this.btnCus_Remove.Location = new System.Drawing.Point(110, 593);
            this.btnCus_Remove.Name = "btnCus_Remove";
            this.btnCus_Remove.Size = new System.Drawing.Size(88, 36);
            this.btnCus_Remove.TabIndex = 34;
            this.btnCus_Remove.Text = "مسح الصنف";
            this.btnCus_Remove.UseVisualStyleBackColor = false;
            this.btnCus_Remove.Click += new System.EventHandler(this.BtnCus_Remove_Click);
            // 
            // printLastBtn
            // 
            this.printLastBtn.BackColor = System.Drawing.Color.Transparent;
            this.printLastBtn.Enabled = false;
            this.printLastBtn.ForeColor = System.Drawing.Color.Black;
            this.printLastBtn.Location = new System.Drawing.Point(683, 593);
            this.printLastBtn.Name = "printLastBtn";
            this.printLastBtn.Size = new System.Drawing.Size(88, 36);
            this.printLastBtn.TabIndex = 36;
            this.printLastBtn.Text = "طباعة الوصل الأخير";
            this.printLastBtn.UseVisualStyleBackColor = false;
            this.printLastBtn.Visible = false;
            this.printLastBtn.Click += new System.EventHandler(this.printLastBtn_Click);
            // 
            // btnCus_save
            // 
            this.btnCus_save.BackColor = System.Drawing.Color.Transparent;
            this.btnCus_save.ForeColor = System.Drawing.Color.Black;
            this.btnCus_save.Location = new System.Drawing.Point(16, 593);
            this.btnCus_save.Name = "btnCus_save";
            this.btnCus_save.Size = new System.Drawing.Size(88, 36);
            this.btnCus_save.TabIndex = 37;
            this.btnCus_save.Text = "موافقة";
            this.btnCus_save.UseVisualStyleBackColor = false;
            this.btnCus_save.Click += new System.EventHandler(this.BtnCus_save_Click);
            // 
            // Panel3
            // 
            this.Panel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel3.Controls.Add(this.Label8);
            this.Panel3.Controls.Add(this.label3);
            this.Panel3.Controls.Add(this.scannerTxtBox);
            this.Panel3.Location = new System.Drawing.Point(12, 299);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(1222, 288);
            this.Panel3.TabIndex = 32;
            // 
            // frmRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 689);
            this.Controls.Add(this.dtCus_addedlist);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.returnBtn);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.btnviewStockout);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.btnCus_clear);
            this.Controls.Add(this.btnCus_Remove);
            this.Controls.Add(this.printLastBtn);
            this.Controls.Add(this.btnCus_save);
            this.Controls.Add(this.Panel3);
            this.Name = "frmRequest";
            this.RightToLeftLayout = true;
            this.Text = "Request";
            this.Load += new System.EventHandler(this.frmRequest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtCus_addedlist)).EndInit();
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.load_items_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCus_itemlist)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.Panel3.ResumeLayout(false);
            this.Panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.DataGridView dtCus_addedlist;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Panel Panel2;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.DataGridView dtgCus_itemlist;
        internal System.Windows.Forms.TextBox txtsearch;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Button returnBtn;
        internal System.Windows.Forms.TextBox scannerTxtBox;
        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.Button btnviewStockout;
        internal System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.Button load_names_btn;
        private System.Windows.Forms.ComboBox empNameComboBox;
        private System.Windows.Forms.ComboBox isEmployeeCombo;
        internal System.Windows.Forms.Label employeeOrPhoneNumberLabel;
        internal System.Windows.Forms.TextBox txt_cusid;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label15;
        internal System.Windows.Forms.TextBox txtCus_lname;
        internal System.Windows.Forms.TextBox txtCus_fname;
        internal System.Windows.Forms.Button btnCus_clear;
        internal System.Windows.Forms.Button btnCus_Remove;
        internal System.Windows.Forms.Button printLastBtn;
        internal System.Windows.Forms.Button btnCus_save;
        internal System.Windows.Forms.Panel Panel3;
        private System.Windows.Forms.NumericUpDown load_items_numericUpDown;
        private System.Windows.Forms.Button load_items_btn;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TextBox projecttxtbox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn TYPE;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn UNIT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn EXPIRYDATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOTES;
    }
}