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
            this.brandTxtBox = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.unitCombo = new System.Windows.Forms.ComboBox();
            this.dtglist = new System.Windows.Forms.DataGridView();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.btnReload = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.pnl_stockmaster = new System.Windows.Forms.Panel();
            this.sLineCombo = new System.Windows.Forms.ComboBox();
            this.gLineCombo = new System.Windows.Forms.ComboBox();
            this.expiryDateCheckBx = new System.Windows.Forms.CheckBox();
            this.isNewRadio = new System.Windows.Forms.RadioButton();
            this.isNotNewRadio = new System.Windows.Forms.RadioButton();
            this.qtyUpDown = new System.Windows.Forms.NumericUpDown();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.expiryDatePicker = new System.Windows.Forms.DateTimePicker();
            this.sLineTxtBox = new System.Windows.Forms.TextBox();
            this.gLineTxtBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.suppliertxtbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.invoiveNoTxtBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.invoiceDateTime = new System.Windows.Forms.DateTimePicker();
            this.loadLines = new System.Windows.Forms.Button();
            this.gLineCombo2 = new System.Windows.Forms.ComboBox();
            this.sLineCombo2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtglist)).BeginInit();
            this.Panel2.SuspendLayout();
            this.pnl_stockmaster.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qtyUpDown)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(1513, 304);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(141, 37);
            this.btnClose.TabIndex = 44;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(27, 315);
            this.Label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label6.Name = "Label6";
            this.Label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label6.Size = new System.Drawing.Size(53, 17);
            this.Label6.TabIndex = 31;
            this.Label6.Text = "Search";
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(88, 312);
            this.txtsearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(272, 22);
            this.txtsearch.TabIndex = 29;
            this.txtsearch.TextChanged += new System.EventHandler(this.Txtsearch_TextChanged);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.Transparent;
            this.btndelete.ForeColor = System.Drawing.Color.Black;
            this.btndelete.Location = new System.Drawing.Point(1364, 304);
            this.btndelete.Margin = new System.Windows.Forms.Padding(4);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(141, 37);
            this.btndelete.TabIndex = 34;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.Btndelete_Click);
            // 
            // itemNameTextBox
            // 
            this.itemNameTextBox.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemNameTextBox.Location = new System.Drawing.Point(655, 59);
            this.itemNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.itemNameTextBox.Name = "itemNameTextBox";
            this.itemNameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.itemNameTextBox.Size = new System.Drawing.Size(453, 26);
            this.itemNameTextBox.TabIndex = 2;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(65, 110);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(59, 22);
            this.Label4.TabIndex = 1;
            this.Label4.Text = "Project";
            // 
            // projectTextBox
            // 
            this.projectTextBox.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectTextBox.Location = new System.Drawing.Point(133, 107);
            this.projectTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.projectTextBox.Name = "projectTextBox";
            this.projectTextBox.Size = new System.Drawing.Size(401, 26);
            this.projectTextBox.TabIndex = 7;
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.Transparent;
            this.btnupdate.ForeColor = System.Drawing.Color.Black;
            this.btnupdate.Location = new System.Drawing.Point(904, 305);
            this.btnupdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(137, 37);
            this.btnupdate.TabIndex = 35;
            this.btnupdate.Text = "Edit";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Visible = false;
            this.btnupdate.Click += new System.EventHandler(this.Btnupdate_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.Transparent;
            this.btnsave.ForeColor = System.Drawing.Color.Black;
            this.btnsave.Location = new System.Drawing.Point(1214, 305);
            this.btnsave.Margin = new System.Windows.Forms.Padding(4);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(141, 37);
            this.btnsave.TabIndex = 36;
            this.btnsave.Text = "Add";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.Btnsave_Click);
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionTextBox.Location = new System.Drawing.Point(655, 100);
            this.descriptionTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.descriptionTextBox.Size = new System.Drawing.Size(453, 81);
            this.descriptionTextBox.TabIndex = 3;
            this.descriptionTextBox.Text = "";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(601, 103);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(44, 22);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "Desc";
            // 
            // brandTxtBox
            // 
            this.brandTxtBox.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brandTxtBox.Location = new System.Drawing.Point(655, 22);
            this.brandTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.brandTxtBox.Name = "brandTxtBox";
            this.brandTxtBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.brandTxtBox.Size = new System.Drawing.Size(452, 26);
            this.brandTxtBox.TabIndex = 1;
            this.brandTxtBox.TextChanged += new System.EventHandler(this.Txtitemid_TextChanged);
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(593, 25);
            this.Label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(52, 22);
            this.Label8.TabIndex = 8;
            this.Label8.Text = "Brand";
            // 
            // unitCombo
            // 
            this.unitCombo.FormattingEnabled = true;
            this.unitCombo.Location = new System.Drawing.Point(1458, 25);
            this.unitCombo.Margin = new System.Windows.Forms.Padding(4);
            this.unitCombo.Name = "unitCombo";
            this.unitCombo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.unitCombo.Size = new System.Drawing.Size(84, 25);
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
            this.dtglist.Margin = new System.Windows.Forms.Padding(4);
            this.dtglist.Name = "dtglist";
            this.dtglist.RowHeadersWidth = 51;
            this.dtglist.Size = new System.Drawing.Size(1665, 376);
            this.dtglist.TabIndex = 0;
            this.dtglist.Click += new System.EventHandler(this.Dtglist_Click);
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel2.Controls.Add(this.dtglist);
            this.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel2.Location = new System.Drawing.Point(0, 349);
            this.Panel2.Margin = new System.Windows.Forms.Padding(4);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(1667, 377);
            this.Panel2.TabIndex = 32;
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(1049, 305);
            this.btnReload.Margin = new System.Windows.Forms.Padding(4);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(157, 37);
            this.btnReload.TabIndex = 2;
            this.btnReload.Text = "Load";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(597, 63);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(48, 22);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "Name";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(1266, 29);
            this.Label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label7.Name = "Label7";
            this.Label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label7.Size = new System.Drawing.Size(69, 22);
            this.Label7.TabIndex = 5;
            this.Label7.Text = "Quantity";
            // 
            // pnl_stockmaster
            // 
            this.pnl_stockmaster.BackColor = System.Drawing.Color.White;
            this.pnl_stockmaster.Controls.Add(this.sLineCombo);
            this.pnl_stockmaster.Controls.Add(this.gLineCombo);
            this.pnl_stockmaster.Controls.Add(this.expiryDateCheckBx);
            this.pnl_stockmaster.Controls.Add(this.isNewRadio);
            this.pnl_stockmaster.Controls.Add(this.isNotNewRadio);
            this.pnl_stockmaster.Controls.Add(this.qtyUpDown);
            this.pnl_stockmaster.Controls.Add(this.dateTimePicker3);
            this.pnl_stockmaster.Controls.Add(this.expiryDatePicker);
            this.pnl_stockmaster.Controls.Add(this.sLineTxtBox);
            this.pnl_stockmaster.Controls.Add(this.gLineTxtBox);
            this.pnl_stockmaster.Controls.Add(this.label11);
            this.pnl_stockmaster.Controls.Add(this.label9);
            this.pnl_stockmaster.Controls.Add(this.brandTxtBox);
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
            this.pnl_stockmaster.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_stockmaster.Location = new System.Drawing.Point(0, 80);
            this.pnl_stockmaster.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_stockmaster.Name = "pnl_stockmaster";
            this.pnl_stockmaster.Size = new System.Drawing.Size(1667, 216);
            this.pnl_stockmaster.TabIndex = 30;
            // 
            // sLineCombo
            // 
            this.sLineCombo.FormattingEnabled = true;
            this.sLineCombo.Location = new System.Drawing.Point(134, 63);
            this.sLineCombo.Name = "sLineCombo";
            this.sLineCombo.Size = new System.Drawing.Size(226, 25);
            this.sLineCombo.TabIndex = 11;
            // 
            // gLineCombo
            // 
            this.gLineCombo.FormattingEnabled = true;
            this.gLineCombo.Location = new System.Drawing.Point(133, 25);
            this.gLineCombo.Name = "gLineCombo";
            this.gLineCombo.Size = new System.Drawing.Size(226, 25);
            this.gLineCombo.TabIndex = 11;
            // 
            // expiryDateCheckBx
            // 
            this.expiryDateCheckBx.AutoSize = true;
            this.expiryDateCheckBx.Checked = true;
            this.expiryDateCheckBx.CheckState = System.Windows.Forms.CheckState.Checked;
            this.expiryDateCheckBx.Location = new System.Drawing.Point(1322, 108);
            this.expiryDateCheckBx.Margin = new System.Windows.Forms.Padding(4);
            this.expiryDateCheckBx.Name = "expiryDateCheckBx";
            this.expiryDateCheckBx.Size = new System.Drawing.Size(50, 21);
            this.expiryDateCheckBx.TabIndex = 9;
            this.expiryDateCheckBx.Text = "N/A";
            this.expiryDateCheckBx.UseVisualStyleBackColor = true;
            this.expiryDateCheckBx.CheckedChanged += new System.EventHandler(this.ExpiryDateCheckBx_CheckedChanged);
            // 
            // isNewRadio
            // 
            this.isNewRadio.AutoSize = true;
            this.isNewRadio.Checked = true;
            this.isNewRadio.Location = new System.Drawing.Point(1360, 68);
            this.isNewRadio.Margin = new System.Windows.Forms.Padding(4);
            this.isNewRadio.Name = "isNewRadio";
            this.isNewRadio.Size = new System.Drawing.Size(52, 21);
            this.isNewRadio.TabIndex = 8;
            this.isNewRadio.TabStop = true;
            this.isNewRadio.Text = "New";
            this.isNewRadio.UseVisualStyleBackColor = true;
            this.isNewRadio.CheckedChanged += new System.EventHandler(this.IsNewRadio_CheckedChanged);
            // 
            // isNotNewRadio
            // 
            this.isNotNewRadio.AutoSize = true;
            this.isNotNewRadio.Location = new System.Drawing.Point(1436, 68);
            this.isNotNewRadio.Margin = new System.Windows.Forms.Padding(4);
            this.isNotNewRadio.Name = "isNotNewRadio";
            this.isNotNewRadio.Size = new System.Drawing.Size(101, 21);
            this.isNotNewRadio.TabIndex = 8;
            this.isNotNewRadio.TabStop = true;
            this.isNotNewRadio.Text = "Second Hand";
            this.isNotNewRadio.UseVisualStyleBackColor = true;
            this.isNotNewRadio.CheckedChanged += new System.EventHandler(this.IsNotNewRadio_CheckedChanged);
            // 
            // qtyUpDown
            // 
            this.qtyUpDown.Location = new System.Drawing.Point(1362, 26);
            this.qtyUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.qtyUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.qtyUpDown.Name = "qtyUpDown";
            this.qtyUpDown.Size = new System.Drawing.Size(88, 23);
            this.qtyUpDown.TabIndex = 5;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(-493, 59);
            this.dateTimePicker3.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(447, 23);
            this.dateTimePicker3.TabIndex = 9;
            // 
            // expiryDatePicker
            // 
            this.expiryDatePicker.Enabled = false;
            this.expiryDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.expiryDatePicker.Location = new System.Drawing.Point(1387, 107);
            this.expiryDatePicker.Margin = new System.Windows.Forms.Padding(4);
            this.expiryDatePicker.Name = "expiryDatePicker";
            this.expiryDatePicker.Size = new System.Drawing.Size(155, 23);
            this.expiryDatePicker.TabIndex = 10;
            // 
            // sLineTxtBox
            // 
            this.sLineTxtBox.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sLineTxtBox.Location = new System.Drawing.Point(454, 62);
            this.sLineTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.sLineTxtBox.Name = "sLineTxtBox";
            this.sLineTxtBox.Size = new System.Drawing.Size(79, 26);
            this.sLineTxtBox.TabIndex = 1;
            this.sLineTxtBox.TextChanged += new System.EventHandler(this.Txtitemid_TextChanged);
            // 
            // gLineTxtBox
            // 
            this.gLineTxtBox.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gLineTxtBox.Location = new System.Drawing.Point(454, 22);
            this.gLineTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.gLineTxtBox.Name = "gLineTxtBox";
            this.gLineTxtBox.Size = new System.Drawing.Size(79, 26);
            this.gLineTxtBox.TabIndex = 1;
            this.gLineTxtBox.TextChanged += new System.EventHandler(this.Txtitemid_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(51, 66);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 22);
            this.label11.TabIndex = 8;
            this.label11.Text = "Sub Line";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(27, 25);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 22);
            this.label9.TabIndex = 8;
            this.label9.Text = "General Line";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1223, 109);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 22);
            this.label10.TabIndex = 1;
            this.label10.Text = "Expiry Date";
            // 
            // suppliertxtbox
            // 
            this.suppliertxtbox.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suppliertxtbox.Location = new System.Drawing.Point(133, 29);
            this.suppliertxtbox.Margin = new System.Windows.Forms.Padding(4);
            this.suppliertxtbox.Name = "suppliertxtbox";
            this.suppliertxtbox.Size = new System.Drawing.Size(400, 26);
            this.suppliertxtbox.TabIndex = 1;
            this.suppliertxtbox.TextChanged += new System.EventHandler(this.Txtitemid_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(57, 31);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "Supplier";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(622, 315);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 31;
            this.label3.Text = "S Line";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(371, 315);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label12.Size = new System.Drawing.Size(50, 17);
            this.label12.TabIndex = 31;
            this.label12.Text = "G Line";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(900, 239);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(157, 31);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Olive;
            this.panel1.Controls.Add(this.invoiveNoTxtBox);
            this.panel1.Controls.Add(this.suppliertxtbox);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.invoiceDateTime);
            this.panel1.Location = new System.Drawing.Point(1, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1665, 78);
            this.panel1.TabIndex = 45;
            // 
            // invoiveNoTxtBox
            // 
            this.invoiveNoTxtBox.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoiveNoTxtBox.Location = new System.Drawing.Point(713, 29);
            this.invoiveNoTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.invoiveNoTxtBox.Name = "invoiveNoTxtBox";
            this.invoiveNoTxtBox.Size = new System.Drawing.Size(400, 26);
            this.invoiveNoTxtBox.TabIndex = 1;
            this.invoiveNoTxtBox.TextChanged += new System.EventHandler(this.Txtitemid_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.Window;
            this.label14.Location = new System.Drawing.Point(1157, 31);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(95, 22);
            this.label14.TabIndex = 8;
            this.label14.Text = "Invoice Date";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.Window;
            this.label13.Location = new System.Drawing.Point(587, 31);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(118, 22);
            this.label13.TabIndex = 8;
            this.label13.Text = "Invoice Number";
            // 
            // invoiceDateTime
            // 
            this.invoiceDateTime.CalendarTitleBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.invoiceDateTime.CalendarTrailingForeColor = System.Drawing.SystemColors.Desktop;
            this.invoiceDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.invoiceDateTime.Location = new System.Drawing.Point(1260, 31);
            this.invoiceDateTime.Margin = new System.Windows.Forms.Padding(4);
            this.invoiceDateTime.Name = "invoiceDateTime";
            this.invoiceDateTime.Size = new System.Drawing.Size(155, 22);
            this.invoiceDateTime.TabIndex = 10;
            this.invoiceDateTime.ValueChanged += new System.EventHandler(this.invoiceDateTime_ValueChanged);
            // 
            // loadLines
            // 
            this.loadLines.Location = new System.Drawing.Point(904, 305);
            this.loadLines.Name = "loadLines";
            this.loadLines.Size = new System.Drawing.Size(137, 37);
            this.loadLines.TabIndex = 12;
            this.loadLines.Text = "Reload Lines";
            this.loadLines.UseVisualStyleBackColor = true;
            this.loadLines.Click += new System.EventHandler(this.loadLines_Click);
            // 
            // gLineCombo2
            // 
            this.gLineCombo2.FormattingEnabled = true;
            this.gLineCombo2.Location = new System.Drawing.Point(428, 312);
            this.gLineCombo2.Name = "gLineCombo2";
            this.gLineCombo2.Size = new System.Drawing.Size(187, 24);
            this.gLineCombo2.TabIndex = 11;
            this.gLineCombo2.SelectedIndexChanged += new System.EventHandler(this.gLineCombo2_SelectedIndexChanged);
            // 
            // sLineCombo2
            // 
            this.sLineCombo2.FormattingEnabled = true;
            this.sLineCombo2.Location = new System.Drawing.Point(674, 312);
            this.sLineCombo2.Name = "sLineCombo2";
            this.sLineCombo2.Size = new System.Drawing.Size(199, 24);
            this.sLineCombo2.TabIndex = 11;
            this.sLineCombo2.SelectedIndexChanged += new System.EventHandler(this.sLineCombo2_SelectedIndexChanged);
            // 
            // frmItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1667, 726);
            this.Controls.Add(this.sLineCombo2);
            this.Controls.Add(this.gLineCombo2);
            this.Controls.Add(this.loadLines);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.pnl_stockmaster);
            this.Controls.Add(this.btnupdate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmItems";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock Master";
            this.Load += new System.EventHandler(this.FrmItems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtglist)).EndInit();
            this.Panel2.ResumeLayout(false);
            this.pnl_stockmaster.ResumeLayout(false);
            this.pnl_stockmaster.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qtyUpDown)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        internal System.Windows.Forms.TextBox brandTxtBox;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.ComboBox unitCombo;
        internal System.Windows.Forms.DataGridView dtglist;
        internal System.Windows.Forms.Panel Panel2;
        internal System.Windows.Forms.Button btnReload;
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
        internal System.Windows.Forms.TextBox sLineTxtBox;
        internal System.Windows.Forms.TextBox gLineTxtBox;
        internal System.Windows.Forms.Label label11;
        internal System.Windows.Forms.Label label9;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label label12;
        internal System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.TextBox invoiveNoTxtBox;
        internal System.Windows.Forms.Label label14;
        internal System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker invoiceDateTime;
        private System.Windows.Forms.ComboBox sLineCombo;
        public System.Windows.Forms.ComboBox gLineCombo;
        private System.Windows.Forms.Button loadLines;
        private System.Windows.Forms.ComboBox gLineCombo2;
        private System.Windows.Forms.ComboBox sLineCombo2;
    }
}