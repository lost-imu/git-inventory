namespace InventorySystem1._0
{
    partial class frmReports
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
            this.printBtn = new System.Windows.Forms.Button();
            this.reportDataGridView = new System.Windows.Forms.DataGridView();
            this.reportSubmitBtn = new System.Windows.Forms.Button();
            this.expiryDateCheckBox = new System.Windows.Forms.CheckBox();
            this.invoiceNoCombo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.toLabelDate = new System.Windows.Forms.Label();
            this.fromLabelDate = new System.Windows.Forms.Label();
            this.invoiceToDate = new System.Windows.Forms.DateTimePicker();
            this.invoiceFromDate = new System.Windows.Forms.DateTimePicker();
            this.supplierCombo = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.projectCombo = new System.Windows.Forms.ComboBox();
            this.invoiceFromTime = new System.Windows.Forms.DateTimePicker();
            this.invoiceToTime = new System.Windows.Forms.DateTimePicker();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lost_new_inventoryDataSet = new InventorySystem1._0.lost_new_inventoryDataSet();
            this.tblrequestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblrequestTableAdapter = new InventorySystem1._0.lost_new_inventoryDataSetTableAdapters.tblrequestTableAdapter();
            this.tblrequestBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.reportDataGridView)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lost_new_inventoryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblrequestBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblrequestBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // printBtn
            // 
            this.printBtn.Location = new System.Drawing.Point(895, 82);
            this.printBtn.Margin = new System.Windows.Forms.Padding(4);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(229, 37);
            this.printBtn.TabIndex = 50;
            this.printBtn.Text = "Print";
            this.printBtn.UseVisualStyleBackColor = true;
            this.printBtn.Visible = false;
            this.printBtn.Click += new System.EventHandler(this.printBtn_Click_1);
            // 
            // reportDataGridView
            // 
            this.reportDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reportDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.reportDataGridView.Location = new System.Drawing.Point(0, 179);
            this.reportDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.reportDataGridView.Name = "reportDataGridView";
            this.reportDataGridView.RowHeadersWidth = 51;
            this.reportDataGridView.Size = new System.Drawing.Size(1253, 507);
            this.reportDataGridView.TabIndex = 49;
            // 
            // reportSubmitBtn
            // 
            this.reportSubmitBtn.Location = new System.Drawing.Point(895, 35);
            this.reportSubmitBtn.Margin = new System.Windows.Forms.Padding(4);
            this.reportSubmitBtn.Name = "reportSubmitBtn";
            this.reportSubmitBtn.Size = new System.Drawing.Size(231, 39);
            this.reportSubmitBtn.TabIndex = 35;
            this.reportSubmitBtn.Text = "Submit";
            this.reportSubmitBtn.UseVisualStyleBackColor = true;
            this.reportSubmitBtn.Click += new System.EventHandler(this.reportSubmitBtn_Click_1);
            // 
            // expiryDateCheckBox
            // 
            this.expiryDateCheckBox.AutoSize = true;
            this.expiryDateCheckBox.Checked = true;
            this.expiryDateCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.expiryDateCheckBox.Location = new System.Drawing.Point(712, 27);
            this.expiryDateCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.expiryDateCheckBox.Name = "expiryDateCheckBox";
            this.expiryDateCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.expiryDateCheckBox.Size = new System.Drawing.Size(45, 21);
            this.expiryDateCheckBox.TabIndex = 26;
            this.expiryDateCheckBox.Text = "All";
            this.expiryDateCheckBox.UseVisualStyleBackColor = true;
            this.expiryDateCheckBox.CheckedChanged += new System.EventHandler(this.expiryDateCheckBox_CheckedChanged);
            // 
            // invoiceNoCombo
            // 
            this.invoiceNoCombo.FormattingEnabled = true;
            this.invoiceNoCombo.Items.AddRange(new object[] {
            "ALL",
            "driver1",
            "driver2",
            "driver3"});
            this.invoiceNoCombo.Location = new System.Drawing.Point(130, 50);
            this.invoiceNoCombo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.invoiceNoCombo.Name = "invoiceNoCombo";
            this.invoiceNoCombo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.invoiceNoCombo.Size = new System.Drawing.Size(229, 24);
            this.invoiceNoCombo.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 53);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(106, 17);
            this.label8.TabIndex = 40;
            this.label8.Text = "Invoice Number";
            // 
            // toLabelDate
            // 
            this.toLabelDate.AutoSize = true;
            this.toLabelDate.Location = new System.Drawing.Point(504, 85);
            this.toLabelDate.Name = "toLabelDate";
            this.toLabelDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toLabelDate.Size = new System.Drawing.Size(33, 17);
            this.toLabelDate.TabIndex = 36;
            this.toLabelDate.Text = "And";
            // 
            // fromLabelDate
            // 
            this.fromLabelDate.AutoSize = true;
            this.fromLabelDate.Location = new System.Drawing.Point(393, 57);
            this.fromLabelDate.Name = "fromLabelDate";
            this.fromLabelDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fromLabelDate.Size = new System.Drawing.Size(144, 17);
            this.fromLabelDate.TabIndex = 33;
            this.fromLabelDate.Text = "Invoice Date Between";
            // 
            // invoiceToDate
            // 
            this.invoiceToDate.CustomFormat = "dd/MM/yyyy";
            this.invoiceToDate.Enabled = false;
            this.invoiceToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.invoiceToDate.Location = new System.Drawing.Point(543, 83);
            this.invoiceToDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.invoiceToDate.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.invoiceToDate.Name = "invoiceToDate";
            this.invoiceToDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.invoiceToDate.Size = new System.Drawing.Size(132, 22);
            this.invoiceToDate.TabIndex = 29;
            this.invoiceToDate.Value = new System.DateTime(2020, 2, 21, 0, 0, 0, 0);
            this.invoiceToDate.ValueChanged += new System.EventHandler(this.expiryToDate_ValueChanged);
            // 
            // invoiceFromDate
            // 
            this.invoiceFromDate.CustomFormat = "dd/MM/yyyy";
            this.invoiceFromDate.Enabled = false;
            this.invoiceFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.invoiceFromDate.Location = new System.Drawing.Point(543, 54);
            this.invoiceFromDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.invoiceFromDate.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.invoiceFromDate.Name = "invoiceFromDate";
            this.invoiceFromDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.invoiceFromDate.Size = new System.Drawing.Size(132, 22);
            this.invoiceFromDate.TabIndex = 27;
            this.invoiceFromDate.Value = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.invoiceFromDate.ValueChanged += new System.EventHandler(this.expiryFromDate_ValueChanged);
            // 
            // supplierCombo
            // 
            this.supplierCombo.FormattingEnabled = true;
            this.supplierCombo.Items.AddRange(new object[] {
            "ALL",
            "requester1",
            "requester2",
            "requester3"});
            this.supplierCombo.Location = new System.Drawing.Point(130, 18);
            this.supplierCombo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.supplierCombo.Name = "supplierCombo";
            this.supplierCombo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.supplierCombo.Size = new System.Drawing.Size(229, 24);
            this.supplierCombo.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(64, 21);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label10.Size = new System.Drawing.Size(60, 17);
            this.label10.TabIndex = 28;
            this.label10.Text = "Supplier";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 86);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 40;
            this.label1.Text = "Project";
            // 
            // projectCombo
            // 
            this.projectCombo.FormattingEnabled = true;
            this.projectCombo.Items.AddRange(new object[] {
            "ALL",
            "driver1",
            "driver2",
            "driver3"});
            this.projectCombo.Location = new System.Drawing.Point(130, 82);
            this.projectCombo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.projectCombo.Name = "projectCombo";
            this.projectCombo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.projectCombo.Size = new System.Drawing.Size(229, 24);
            this.projectCombo.TabIndex = 3;
            // 
            // invoiceFromTime
            // 
            this.invoiceFromTime.Enabled = false;
            this.invoiceFromTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.invoiceFromTime.Location = new System.Drawing.Point(682, 54);
            this.invoiceFromTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.invoiceFromTime.Name = "invoiceFromTime";
            this.invoiceFromTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.invoiceFromTime.ShowUpDown = true;
            this.invoiceFromTime.Size = new System.Drawing.Size(91, 22);
            this.invoiceFromTime.TabIndex = 51;
            this.invoiceFromTime.Value = new System.DateTime(2020, 2, 17, 0, 0, 0, 0);
            this.invoiceFromTime.ValueChanged += new System.EventHandler(this.checkinFromTime_ValueChanged);
            // 
            // invoiceToTime
            // 
            this.invoiceToTime.Enabled = false;
            this.invoiceToTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.invoiceToTime.Location = new System.Drawing.Point(682, 83);
            this.invoiceToTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.invoiceToTime.Name = "invoiceToTime";
            this.invoiceToTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.invoiceToTime.ShowUpDown = true;
            this.invoiceToTime.Size = new System.Drawing.Size(91, 22);
            this.invoiceToTime.TabIndex = 52;
            this.invoiceToTime.Value = new System.DateTime(2020, 2, 17, 23, 59, 0, 0);
            this.invoiceToTime.ValueChanged += new System.EventHandler(this.checkinToTime_ValueChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1253, 172);
            this.tabControl1.TabIndex = 53;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.supplierCombo);
            this.tabPage1.Controls.Add(this.invoiceToTime);
            this.tabPage1.Controls.Add(this.invoiceFromDate);
            this.tabPage1.Controls.Add(this.invoiceToDate);
            this.tabPage1.Controls.Add(this.invoiceFromTime);
            this.tabPage1.Controls.Add(this.fromLabelDate);
            this.tabPage1.Controls.Add(this.printBtn);
            this.tabPage1.Controls.Add(this.reportSubmitBtn);
            this.tabPage1.Controls.Add(this.toLabelDate);
            this.tabPage1.Controls.Add(this.expiryDateCheckBox);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.invoiceNoCombo);
            this.tabPage1.Controls.Add(this.projectCombo);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1245, 143);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Stock In";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lost_new_inventoryDataSet
            // 
            this.lost_new_inventoryDataSet.DataSetName = "lost_new_inventoryDataSet";
            this.lost_new_inventoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblrequestBindingSource
            // 
            this.tblrequestBindingSource.DataMember = "tblrequest";
            this.tblrequestBindingSource.DataSource = this.lost_new_inventoryDataSet;
            // 
            // tblrequestTableAdapter
            // 
            this.tblrequestTableAdapter.ClearBeforeFill = true;
            // 
            // tblrequestBindingSource1
            // 
            this.tblrequestBindingSource1.DataMember = "tblrequest";
            this.tblrequestBindingSource1.DataSource = this.lost_new_inventoryDataSet;
            // 
            // frmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 686);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.reportDataGridView);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmReports";
            this.Text = "frmRepository";
            this.Load += new System.EventHandler(this.frmRepository_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reportDataGridView)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lost_new_inventoryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblrequestBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblrequestBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button printBtn;
        private System.Windows.Forms.DataGridView reportDataGridView;
        private System.Windows.Forms.Button reportSubmitBtn;
        private System.Windows.Forms.CheckBox expiryDateCheckBox;
        private System.Windows.Forms.ComboBox invoiceNoCombo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label toLabelDate;
        private System.Windows.Forms.Label fromLabelDate;
        private System.Windows.Forms.DateTimePicker invoiceToDate;
        private System.Windows.Forms.DateTimePicker invoiceFromDate;
        private System.Windows.Forms.ComboBox supplierCombo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox projectCombo;
        private System.Windows.Forms.DateTimePicker invoiceFromTime;
        private System.Windows.Forms.DateTimePicker invoiceToTime;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private lost_new_inventoryDataSet lost_new_inventoryDataSet;
        private System.Windows.Forms.BindingSource tblrequestBindingSource;
        private lost_new_inventoryDataSetTableAdapters.tblrequestTableAdapter tblrequestTableAdapter;
        private System.Windows.Forms.BindingSource tblrequestBindingSource1;
    }
}