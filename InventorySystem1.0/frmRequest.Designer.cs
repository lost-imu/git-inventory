
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
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hold = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.project = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isNew = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.expiryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.dtCus_addedlist.AllowUserToOrderColumns = true;
            this.dtCus_addedlist.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtCus_addedlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtCus_addedlist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.gline,
            this.sline,
            this.name,
            this.qty,
            this.hold,
            this.unit,
            this.description,
            this.brand,
            this.project,
            this.isNew,
            this.expiryDate});
            this.dtCus_addedlist.Location = new System.Drawing.Point(0, 39);
            this.dtCus_addedlist.Margin = new System.Windows.Forms.Padding(4);
            this.dtCus_addedlist.Name = "dtCus_addedlist";
            this.dtCus_addedlist.RowHeadersVisible = false;
            this.dtCus_addedlist.RowHeadersWidth = 51;
            this.dtCus_addedlist.Size = new System.Drawing.Size(1714, 313);
            this.dtCus_addedlist.TabIndex = 30;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(964, 7);
            this.Label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(154, 29);
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
            this.Panel2.Location = new System.Drawing.Point(16, 130);
            this.Panel2.Margin = new System.Windows.Forms.Padding(4);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(1716, 230);
            this.Panel2.TabIndex = 31;
            // 
            // load_items_numericUpDown
            // 
            this.load_items_numericUpDown.Location = new System.Drawing.Point(1461, 5);
            this.load_items_numericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.load_items_numericUpDown.Name = "load_items_numericUpDown";
            this.load_items_numericUpDown.Size = new System.Drawing.Size(99, 23);
            this.load_items_numericUpDown.TabIndex = 14;
            this.load_items_numericUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // load_items_btn
            // 
            this.load_items_btn.Location = new System.Drawing.Point(1392, 4);
            this.load_items_btn.Margin = new System.Windows.Forms.Padding(4);
            this.load_items_btn.Name = "load_items_btn";
            this.load_items_btn.Size = new System.Drawing.Size(61, 28);
            this.load_items_btn.TabIndex = 13;
            this.load_items_btn.Text = "Load";
            this.load_items_btn.UseVisualStyleBackColor = true;
            this.load_items_btn.Click += new System.EventHandler(this.load_items_btn_Click);
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(919, 2);
            this.Label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(208, 29);
            this.Label7.TabIndex = 3;
            this.Label7.Text = ":لائحة بالأصناف المتوفرة";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(843, 11);
            this.Label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(33, 17);
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
            this.dtgCus_itemlist.Location = new System.Drawing.Point(0, 36);
            this.dtgCus_itemlist.Margin = new System.Windows.Forms.Padding(4);
            this.dtgCus_itemlist.Name = "dtgCus_itemlist";
            this.dtgCus_itemlist.RowHeadersVisible = false;
            this.dtgCus_itemlist.RowHeadersWidth = 51;
            this.dtgCus_itemlist.Size = new System.Drawing.Size(1714, 192);
            this.dtgCus_itemlist.TabIndex = 0;
            this.dtgCus_itemlist.DoubleClick += new System.EventHandler(this.DtgCus_itemlist_DoubleClick);
            // 
            // txtsearch
            // 
            this.txtsearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtsearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtsearch.Location = new System.Drawing.Point(541, 7);
            this.txtsearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(292, 23);
            this.txtsearch.TabIndex = 4;
            this.txtsearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txtsearch_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(843, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "الماسح الضوئي";
            this.label3.Visible = false;
            // 
            // returnBtn
            // 
            this.returnBtn.BackColor = System.Drawing.Color.Transparent;
            this.returnBtn.ForeColor = System.Drawing.Color.Black;
            this.returnBtn.Location = new System.Drawing.Point(645, 730);
            this.returnBtn.Margin = new System.Windows.Forms.Padding(4);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(117, 44);
            this.returnBtn.TabIndex = 35;
            this.returnBtn.Text = "test pf";
            this.returnBtn.UseVisualStyleBackColor = false;
            this.returnBtn.Click += new System.EventHandler(this.ReturnBtn_Click);
            // 
            // scannerTxtBox
            // 
            this.scannerTxtBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.scannerTxtBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.scannerTxtBox.Location = new System.Drawing.Point(541, 7);
            this.scannerTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.scannerTxtBox.Name = "scannerTxtBox";
            this.scannerTxtBox.Size = new System.Drawing.Size(292, 22);
            this.scannerTxtBox.TabIndex = 1;
            this.scannerTxtBox.Visible = false;
            this.scannerTxtBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ScannerTxtBox_KeyDown);
            // 
            // Button2
            // 
            this.Button2.BackColor = System.Drawing.Color.Transparent;
            this.Button2.ForeColor = System.Drawing.Color.Black;
            this.Button2.Location = new System.Drawing.Point(1036, 730);
            this.Button2.Margin = new System.Windows.Forms.Padding(4);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(117, 44);
            this.Button2.TabIndex = 40;
            this.Button2.Text = "إغلاق";
            this.Button2.UseVisualStyleBackColor = false;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // btnviewStockout
            // 
            this.btnviewStockout.BackColor = System.Drawing.Color.Transparent;
            this.btnviewStockout.ForeColor = System.Drawing.Color.Black;
            this.btnviewStockout.Location = new System.Drawing.Point(400, 730);
            this.btnviewStockout.Margin = new System.Windows.Forms.Padding(4);
            this.btnviewStockout.Name = "btnviewStockout";
            this.btnviewStockout.Size = new System.Drawing.Size(117, 44);
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
            this.Panel1.Location = new System.Drawing.Point(16, 15);
            this.Panel1.Margin = new System.Windows.Forms.Padding(4);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(1629, 108);
            this.Panel1.TabIndex = 38;
            // 
            // load_names_btn
            // 
            this.load_names_btn.Location = new System.Drawing.Point(1064, 65);
            this.load_names_btn.Margin = new System.Windows.Forms.Padding(4);
            this.load_names_btn.Name = "load_names_btn";
            this.load_names_btn.Size = new System.Drawing.Size(61, 28);
            this.load_names_btn.TabIndex = 11;
            this.load_names_btn.Text = "Load";
            this.load_names_btn.UseVisualStyleBackColor = true;
            this.load_names_btn.Click += new System.EventHandler(this.load_names_btn_Click);
            // 
            // empNameComboBox
            // 
            this.empNameComboBox.FormattingEnabled = true;
            this.empNameComboBox.Location = new System.Drawing.Point(893, 65);
            this.empNameComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.empNameComboBox.Name = "empNameComboBox";
            this.empNameComboBox.Size = new System.Drawing.Size(160, 24);
            this.empNameComboBox.TabIndex = 10;
            this.empNameComboBox.SelectedIndexChanged += new System.EventHandler(this.empNameComboBox_SelectedIndexChanged);
            // 
            // isEmployeeCombo
            // 
            this.isEmployeeCombo.FormattingEnabled = true;
            this.isEmployeeCombo.Items.AddRange(new object[] {
            "موظف",
            "غير موظف"});
            this.isEmployeeCombo.Location = new System.Drawing.Point(895, 6);
            this.isEmployeeCombo.Margin = new System.Windows.Forms.Padding(4);
            this.isEmployeeCombo.Name = "isEmployeeCombo";
            this.isEmployeeCombo.Size = new System.Drawing.Size(160, 24);
            this.isEmployeeCombo.TabIndex = 9;
            this.isEmployeeCombo.Text = "موظف";
            // 
            // employeeOrPhoneNumberLabel
            // 
            this.employeeOrPhoneNumberLabel.AutoSize = true;
            this.employeeOrPhoneNumberLabel.Location = new System.Drawing.Point(753, 32);
            this.employeeOrPhoneNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.employeeOrPhoneNumberLabel.Name = "employeeOrPhoneNumberLabel";
            this.employeeOrPhoneNumberLabel.Size = new System.Drawing.Size(62, 17);
            this.employeeOrPhoneNumberLabel.TabIndex = 8;
            this.employeeOrPhoneNumberLabel.Text = ":رقم المستلم";
            // 
            // txt_cusid
            // 
            this.txt_cusid.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_cusid.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_cusid.Location = new System.Drawing.Point(452, 28);
            this.txt_cusid.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cusid.Name = "txt_cusid";
            this.txt_cusid.Size = new System.Drawing.Size(292, 22);
            this.txt_cusid.TabIndex = 1;
            this.txt_cusid.TextChanged += new System.EventHandler(this.Txt_cusid_TextChanged);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(1064, 0);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(64, 29);
            this.Label1.TabIndex = 3;
            this.Label1.Text = "المستلم";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(753, 65);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(64, 17);
            this.Label5.TabIndex = 1;
            this.Label5.Text = ":الإسم الأول";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(347, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = ":المشروع";
            // 
            // Label15
            // 
            this.Label15.AutoSize = true;
            this.Label15.Location = new System.Drawing.Point(347, 65);
            this.Label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(57, 17);
            this.Label15.TabIndex = 1;
            this.Label15.Text = ":إسم العائلة";
            // 
            // projecttxtbox
            // 
            this.projecttxtbox.Location = new System.Drawing.Point(51, 30);
            this.projecttxtbox.Margin = new System.Windows.Forms.Padding(4);
            this.projecttxtbox.Name = "projecttxtbox";
            this.projecttxtbox.Size = new System.Drawing.Size(292, 22);
            this.projecttxtbox.TabIndex = 3;
            // 
            // txtCus_lname
            // 
            this.txtCus_lname.Enabled = false;
            this.txtCus_lname.Location = new System.Drawing.Point(51, 62);
            this.txtCus_lname.Margin = new System.Windows.Forms.Padding(4);
            this.txtCus_lname.Name = "txtCus_lname";
            this.txtCus_lname.Size = new System.Drawing.Size(292, 22);
            this.txtCus_lname.TabIndex = 3;
            // 
            // txtCus_fname
            // 
            this.txtCus_fname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtCus_fname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCus_fname.Enabled = false;
            this.txtCus_fname.Location = new System.Drawing.Point(452, 62);
            this.txtCus_fname.Margin = new System.Windows.Forms.Padding(4);
            this.txtCus_fname.Name = "txtCus_fname";
            this.txtCus_fname.Size = new System.Drawing.Size(292, 22);
            this.txtCus_fname.TabIndex = 2;
            // 
            // btnCus_clear
            // 
            this.btnCus_clear.BackColor = System.Drawing.Color.Transparent;
            this.btnCus_clear.ForeColor = System.Drawing.Color.Black;
            this.btnCus_clear.Location = new System.Drawing.Point(272, 730);
            this.btnCus_clear.Margin = new System.Windows.Forms.Padding(4);
            this.btnCus_clear.Name = "btnCus_clear";
            this.btnCus_clear.Size = new System.Drawing.Size(117, 44);
            this.btnCus_clear.TabIndex = 33;
            this.btnCus_clear.Text = "مسح الأصناف المضافة";
            this.btnCus_clear.UseVisualStyleBackColor = false;
            this.btnCus_clear.Click += new System.EventHandler(this.BtnCus_clear_Click);
            // 
            // btnCus_Remove
            // 
            this.btnCus_Remove.BackColor = System.Drawing.Color.Transparent;
            this.btnCus_Remove.ForeColor = System.Drawing.Color.Black;
            this.btnCus_Remove.Location = new System.Drawing.Point(147, 730);
            this.btnCus_Remove.Margin = new System.Windows.Forms.Padding(4);
            this.btnCus_Remove.Name = "btnCus_Remove";
            this.btnCus_Remove.Size = new System.Drawing.Size(117, 44);
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
            this.printLastBtn.Location = new System.Drawing.Point(911, 730);
            this.printLastBtn.Margin = new System.Windows.Forms.Padding(4);
            this.printLastBtn.Name = "printLastBtn";
            this.printLastBtn.Size = new System.Drawing.Size(117, 44);
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
            this.btnCus_save.Location = new System.Drawing.Point(21, 730);
            this.btnCus_save.Margin = new System.Windows.Forms.Padding(4);
            this.btnCus_save.Name = "btnCus_save";
            this.btnCus_save.Size = new System.Drawing.Size(117, 44);
            this.btnCus_save.TabIndex = 37;
            this.btnCus_save.Text = "موافقة";
            this.btnCus_save.UseVisualStyleBackColor = false;
            this.btnCus_save.Click += new System.EventHandler(this.BtnCus_save_Click);
            // 
            // Panel3
            // 
            this.Panel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel3.Controls.Add(this.dtCus_addedlist);
            this.Panel3.Controls.Add(this.Label8);
            this.Panel3.Controls.Add(this.label3);
            this.Panel3.Controls.Add(this.scannerTxtBox);
            this.Panel3.Location = new System.Drawing.Point(16, 368);
            this.Panel3.Margin = new System.Windows.Forms.Padding(4);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(1716, 354);
            this.Panel3.TabIndex = 32;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Visible = false;
            this.id.Width = 25;
            // 
            // gline
            // 
            this.gline.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.gline.HeaderText = "GLINE";
            this.gline.MinimumWidth = 6;
            this.gline.Name = "gline";
            this.gline.ReadOnly = true;
            this.gline.Width = 78;
            // 
            // sline
            // 
            this.sline.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sline.HeaderText = "SLINE";
            this.sline.MinimumWidth = 6;
            this.sline.Name = "sline";
            this.sline.ReadOnly = true;
            this.sline.Width = 76;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.name.HeaderText = "Name";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 74;
            // 
            // qty
            // 
            this.qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.qty.HeaderText = "QTY";
            this.qty.MinimumWidth = 6;
            this.qty.Name = "qty";
            this.qty.Width = 66;
            // 
            // hold
            // 
            this.hold.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.hold.HeaderText = "Hold";
            this.hold.MinimumWidth = 6;
            this.hold.Name = "hold";
            this.hold.ReadOnly = true;
            this.hold.Width = 66;
            // 
            // unit
            // 
            this.unit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.unit.HeaderText = "Unit";
            this.unit.MinimumWidth = 6;
            this.unit.Name = "unit";
            this.unit.ReadOnly = true;
            this.unit.Width = 62;
            // 
            // description
            // 
            this.description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.description.HeaderText = "Description";
            this.description.MinimumWidth = 6;
            this.description.Name = "description";
            this.description.ReadOnly = true;
            this.description.Width = 108;
            // 
            // brand
            // 
            this.brand.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.brand.HeaderText = "Brand";
            this.brand.MinimumWidth = 6;
            this.brand.Name = "brand";
            this.brand.ReadOnly = true;
            this.brand.Width = 75;
            // 
            // project
            // 
            this.project.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.project.HeaderText = "Project";
            this.project.MinimumWidth = 6;
            this.project.Name = "project";
            this.project.ReadOnly = true;
            this.project.Width = 81;
            // 
            // isNew
            // 
            this.isNew.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.isNew.HeaderText = "Is New";
            this.isNew.MinimumWidth = 6;
            this.isNew.Name = "isNew";
            this.isNew.ReadOnly = true;
            this.isNew.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.isNew.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.isNew.Width = 78;
            // 
            // expiryDate
            // 
            this.expiryDate.HeaderText = "Expiry Date";
            this.expiryDate.MinimumWidth = 6;
            this.expiryDate.Name = "expiryDate";
            this.expiryDate.ReadOnly = true;
            this.expiryDate.Width = 125;
            // 
            // frmRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1745, 848);
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
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn gline;
        private System.Windows.Forms.DataGridViewTextBoxColumn sline;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn hold;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn project;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isNew;
        private System.Windows.Forms.DataGridViewTextBoxColumn expiryDate;
    }
}