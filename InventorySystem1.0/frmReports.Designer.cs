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
            this.printBtn = new System.Windows.Forms.Button();
            this.reportDataGridView = new System.Windows.Forms.DataGridView();
            this.reportSubmitBtn = new System.Windows.Forms.Button();
            this.expiryDateCheckBox = new System.Windows.Forms.CheckBox();
            this.projectExpiryToDate = new System.Windows.Forms.DateTimePicker();
            this.projectExpiryFromDate = new System.Windows.Forms.DateTimePicker();
            this.projectExpiryCheckBox = new System.Windows.Forms.CheckBox();
            this.functionComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.toLabelDate = new System.Windows.Forms.Label();
            this.fromLabelDate = new System.Windows.Forms.Label();
            this.expiryToDate = new System.Windows.Forms.DateTimePicker();
            this.expiryFromDate = new System.Windows.Forms.DateTimePicker();
            this.userNameCombo = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.itemIDCombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.projectCombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.transFromDate = new System.Windows.Forms.DateTimePicker();
            this.transToDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tranDateCheckBox = new System.Windows.Forms.CheckBox();
            this.projectExpiryToTime = new System.Windows.Forms.DateTimePicker();
            this.projectExpiryFromTime = new System.Windows.Forms.DateTimePicker();
            this.transFromTime = new System.Windows.Forms.DateTimePicker();
            this.transToTime = new System.Windows.Forms.DateTimePicker();
            this.expiryFromTime = new System.Windows.Forms.DateTimePicker();
            this.expiryToTime = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.reportDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // printBtn
            // 
            this.printBtn.Location = new System.Drawing.Point(75, 177);
            this.printBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(258, 78);
            this.printBtn.TabIndex = 50;
            this.printBtn.Text = "Print";
            this.printBtn.UseVisualStyleBackColor = true;
            this.printBtn.Click += new System.EventHandler(this.printBtn_Click_1);
            // 
            // reportDataGridView
            // 
            this.reportDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reportDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.reportDataGridView.Location = new System.Drawing.Point(0, 300);
            this.reportDataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.reportDataGridView.Name = "reportDataGridView";
            this.reportDataGridView.RowHeadersWidth = 62;
            this.reportDataGridView.Size = new System.Drawing.Size(1410, 557);
            this.reportDataGridView.TabIndex = 49;
            // 
            // reportSubmitBtn
            // 
            this.reportSubmitBtn.Location = new System.Drawing.Point(75, 86);
            this.reportSubmitBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.reportSubmitBtn.Name = "reportSubmitBtn";
            this.reportSubmitBtn.Size = new System.Drawing.Size(260, 82);
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
            this.expiryDateCheckBox.Location = new System.Drawing.Point(1082, 191);
            this.expiryDateCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.expiryDateCheckBox.Name = "expiryDateCheckBox";
            this.expiryDateCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.expiryDateCheckBox.Size = new System.Drawing.Size(56, 24);
            this.expiryDateCheckBox.TabIndex = 26;
            this.expiryDateCheckBox.Text = "الكل";
            this.expiryDateCheckBox.UseVisualStyleBackColor = true;
            this.expiryDateCheckBox.CheckedChanged += new System.EventHandler(this.expiryDateCheckBox_CheckedChanged);
            // 
            // projectExpiryToDate
            // 
            this.projectExpiryToDate.CustomFormat = "dd/MM/yyyy";
            this.projectExpiryToDate.Enabled = false;
            this.projectExpiryToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.projectExpiryToDate.Location = new System.Drawing.Point(416, 112);
            this.projectExpiryToDate.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.projectExpiryToDate.Name = "projectExpiryToDate";
            this.projectExpiryToDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.projectExpiryToDate.Size = new System.Drawing.Size(150, 26);
            this.projectExpiryToDate.TabIndex = 32;
            this.projectExpiryToDate.Value = new System.DateTime(2020, 2, 21, 0, 0, 0, 0);
            this.projectExpiryToDate.ValueChanged += new System.EventHandler(this.projectExpiryToDate_ValueChanged);
            // 
            // projectExpiryFromDate
            // 
            this.projectExpiryFromDate.CustomFormat = "dd/MM/yyyy";
            this.projectExpiryFromDate.Enabled = false;
            this.projectExpiryFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.projectExpiryFromDate.Location = new System.Drawing.Point(416, 74);
            this.projectExpiryFromDate.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.projectExpiryFromDate.Name = "projectExpiryFromDate";
            this.projectExpiryFromDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.projectExpiryFromDate.Size = new System.Drawing.Size(150, 26);
            this.projectExpiryFromDate.TabIndex = 31;
            this.projectExpiryFromDate.Value = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.projectExpiryFromDate.ValueChanged += new System.EventHandler(this.projectExpiryFromDate_ValueChanged);
            // 
            // projectExpiryCheckBox
            // 
            this.projectExpiryCheckBox.AutoSize = true;
            this.projectExpiryCheckBox.Checked = true;
            this.projectExpiryCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.projectExpiryCheckBox.Location = new System.Drawing.Point(552, 37);
            this.projectExpiryCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.projectExpiryCheckBox.Name = "projectExpiryCheckBox";
            this.projectExpiryCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.projectExpiryCheckBox.Size = new System.Drawing.Size(97, 24);
            this.projectExpiryCheckBox.TabIndex = 30;
            this.projectExpiryCheckBox.Text = "كل المشاريع";
            this.projectExpiryCheckBox.UseVisualStyleBackColor = true;
            this.projectExpiryCheckBox.CheckedChanged += new System.EventHandler(this.checkoutCheckBox_CheckedChanged_1);
            // 
            // functionComboBox
            // 
            this.functionComboBox.FormattingEnabled = true;
            this.functionComboBox.Items.AddRange(new object[] {
            "ALL",
            "driver1",
            "driver2",
            "driver3"});
            this.functionComboBox.Location = new System.Drawing.Point(891, 74);
            this.functionComboBox.Name = "functionComboBox";
            this.functionComboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.functionComboBox.Size = new System.Drawing.Size(258, 28);
            this.functionComboBox.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1158, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 20);
            this.label8.TabIndex = 40;
            this.label8.Text = "الوظيفة";
            // 
            // toLabelDate
            // 
            this.toLabelDate.AutoSize = true;
            this.toLabelDate.Location = new System.Drawing.Point(1158, 268);
            this.toLabelDate.Name = "toLabelDate";
            this.toLabelDate.Size = new System.Drawing.Size(16, 20);
            this.toLabelDate.TabIndex = 36;
            this.toLabelDate.Text = "و";
            // 
            // fromLabelDate
            // 
            this.fromLabelDate.AutoSize = true;
            this.fromLabelDate.Location = new System.Drawing.Point(1158, 231);
            this.fromLabelDate.Name = "fromLabelDate";
            this.fromLabelDate.Size = new System.Drawing.Size(112, 20);
            this.fromLabelDate.TabIndex = 33;
            this.fromLabelDate.Text = "تاريخ الصلاحية بين";
            // 
            // expiryToDate
            // 
            this.expiryToDate.CustomFormat = "dd/MM/yyyy";
            this.expiryToDate.Enabled = false;
            this.expiryToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.expiryToDate.Location = new System.Drawing.Point(891, 262);
            this.expiryToDate.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.expiryToDate.Name = "expiryToDate";
            this.expiryToDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.expiryToDate.Size = new System.Drawing.Size(148, 26);
            this.expiryToDate.TabIndex = 29;
            this.expiryToDate.Value = new System.DateTime(2020, 2, 21, 0, 0, 0, 0);
            this.expiryToDate.ValueChanged += new System.EventHandler(this.expiryToDate_ValueChanged);
            // 
            // expiryFromDate
            // 
            this.expiryFromDate.CustomFormat = "dd/MM/yyyy";
            this.expiryFromDate.Enabled = false;
            this.expiryFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.expiryFromDate.Location = new System.Drawing.Point(891, 225);
            this.expiryFromDate.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.expiryFromDate.Name = "expiryFromDate";
            this.expiryFromDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.expiryFromDate.Size = new System.Drawing.Size(148, 26);
            this.expiryFromDate.TabIndex = 27;
            this.expiryFromDate.Value = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.expiryFromDate.ValueChanged += new System.EventHandler(this.expiryFromDate_ValueChanged);
            // 
            // userNameCombo
            // 
            this.userNameCombo.FormattingEnabled = true;
            this.userNameCombo.Items.AddRange(new object[] {
            "ALL",
            "requester1",
            "requester2",
            "requester3"});
            this.userNameCombo.Location = new System.Drawing.Point(891, 34);
            this.userNameCombo.Name = "userNameCombo";
            this.userNameCombo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.userNameCombo.Size = new System.Drawing.Size(258, 28);
            this.userNameCombo.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1158, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 20);
            this.label10.TabIndex = 28;
            this.label10.Text = "اسم المستخدم";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1158, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 40;
            this.label1.Text = "رقم الصنف";
            // 
            // itemIDCombo
            // 
            this.itemIDCombo.FormattingEnabled = true;
            this.itemIDCombo.Items.AddRange(new object[] {
            "ALL",
            "driver1",
            "driver2",
            "driver3"});
            this.itemIDCombo.Location = new System.Drawing.Point(891, 112);
            this.itemIDCombo.Name = "itemIDCombo";
            this.itemIDCombo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.itemIDCombo.Size = new System.Drawing.Size(258, 28);
            this.itemIDCombo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1158, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 40;
            this.label2.Text = "المشروع";
            // 
            // projectCombo
            // 
            this.projectCombo.FormattingEnabled = true;
            this.projectCombo.Items.AddRange(new object[] {
            "ALL",
            "driver1",
            "driver2",
            "driver3"});
            this.projectCombo.Location = new System.Drawing.Point(891, 151);
            this.projectCombo.Name = "projectCombo";
            this.projectCombo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.projectCombo.Size = new System.Drawing.Size(258, 28);
            this.projectCombo.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(681, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 20);
            this.label3.TabIndex = 33;
            this.label3.Text = "تاريخ انتهاء المشروع بين";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(681, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 20);
            this.label4.TabIndex = 36;
            this.label4.Text = "و";
            // 
            // transFromDate
            // 
            this.transFromDate.CustomFormat = "dd/MM/yyyy";
            this.transFromDate.Enabled = false;
            this.transFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.transFromDate.Location = new System.Drawing.Point(417, 188);
            this.transFromDate.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.transFromDate.Name = "transFromDate";
            this.transFromDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.transFromDate.Size = new System.Drawing.Size(148, 26);
            this.transFromDate.TabIndex = 27;
            this.transFromDate.Value = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.transFromDate.ValueChanged += new System.EventHandler(this.transFromDate_ValueChanged);
            // 
            // transToDate
            // 
            this.transToDate.CustomFormat = "dd/MM/yyyy";
            this.transToDate.Enabled = false;
            this.transToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.transToDate.Location = new System.Drawing.Point(417, 225);
            this.transToDate.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.transToDate.Name = "transToDate";
            this.transToDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.transToDate.Size = new System.Drawing.Size(148, 26);
            this.transToDate.TabIndex = 29;
            this.transToDate.Value = new System.DateTime(2020, 2, 21, 0, 0, 0, 0);
            this.transToDate.ValueChanged += new System.EventHandler(this.transToDate_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(681, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 20);
            this.label5.TabIndex = 33;
            this.label5.Text = "تاريخ العملية بين";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(681, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 20);
            this.label6.TabIndex = 36;
            this.label6.Text = "و";
            // 
            // tranDateCheckBox
            // 
            this.tranDateCheckBox.AutoSize = true;
            this.tranDateCheckBox.Checked = true;
            this.tranDateCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tranDateCheckBox.Location = new System.Drawing.Point(608, 154);
            this.tranDateCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tranDateCheckBox.Name = "tranDateCheckBox";
            this.tranDateCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tranDateCheckBox.Size = new System.Drawing.Size(56, 24);
            this.tranDateCheckBox.TabIndex = 26;
            this.tranDateCheckBox.Text = "الكل";
            this.tranDateCheckBox.UseVisualStyleBackColor = true;
            this.tranDateCheckBox.CheckedChanged += new System.EventHandler(this.tranDateCheckBox_CheckedChanged);
            // 
            // projectExpiryToTime
            // 
            this.projectExpiryToTime.Enabled = false;
            this.projectExpiryToTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.projectExpiryToTime.Location = new System.Drawing.Point(573, 112);
            this.projectExpiryToTime.Name = "projectExpiryToTime";
            this.projectExpiryToTime.ShowUpDown = true;
            this.projectExpiryToTime.Size = new System.Drawing.Size(102, 26);
            this.projectExpiryToTime.TabIndex = 52;
            this.projectExpiryToTime.Value = new System.DateTime(2020, 2, 17, 23, 59, 0, 0);
            this.projectExpiryToTime.ValueChanged += new System.EventHandler(this.checkinToTime_ValueChanged);
            // 
            // projectExpiryFromTime
            // 
            this.projectExpiryFromTime.Enabled = false;
            this.projectExpiryFromTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.projectExpiryFromTime.Location = new System.Drawing.Point(573, 75);
            this.projectExpiryFromTime.Name = "projectExpiryFromTime";
            this.projectExpiryFromTime.ShowUpDown = true;
            this.projectExpiryFromTime.Size = new System.Drawing.Size(102, 26);
            this.projectExpiryFromTime.TabIndex = 51;
            this.projectExpiryFromTime.Value = new System.DateTime(2020, 2, 17, 0, 0, 0, 0);
            this.projectExpiryFromTime.ValueChanged += new System.EventHandler(this.checkinFromTime_ValueChanged);
            // 
            // transFromTime
            // 
            this.transFromTime.Enabled = false;
            this.transFromTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.transFromTime.Location = new System.Drawing.Point(572, 188);
            this.transFromTime.Name = "transFromTime";
            this.transFromTime.ShowUpDown = true;
            this.transFromTime.Size = new System.Drawing.Size(102, 26);
            this.transFromTime.TabIndex = 51;
            this.transFromTime.Value = new System.DateTime(2020, 2, 17, 0, 0, 0, 0);
            // 
            // transToTime
            // 
            this.transToTime.Enabled = false;
            this.transToTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.transToTime.Location = new System.Drawing.Point(572, 225);
            this.transToTime.Name = "transToTime";
            this.transToTime.ShowUpDown = true;
            this.transToTime.Size = new System.Drawing.Size(102, 26);
            this.transToTime.TabIndex = 52;
            this.transToTime.Value = new System.DateTime(2020, 2, 17, 23, 59, 0, 0);
            // 
            // expiryFromTime
            // 
            this.expiryFromTime.Enabled = false;
            this.expiryFromTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.expiryFromTime.Location = new System.Drawing.Point(1047, 225);
            this.expiryFromTime.Name = "expiryFromTime";
            this.expiryFromTime.ShowUpDown = true;
            this.expiryFromTime.Size = new System.Drawing.Size(102, 26);
            this.expiryFromTime.TabIndex = 51;
            this.expiryFromTime.Value = new System.DateTime(2020, 2, 17, 0, 0, 0, 0);
            this.expiryFromTime.ValueChanged += new System.EventHandler(this.checkinFromTime_ValueChanged);
            // 
            // expiryToTime
            // 
            this.expiryToTime.Enabled = false;
            this.expiryToTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.expiryToTime.Location = new System.Drawing.Point(1047, 262);
            this.expiryToTime.Name = "expiryToTime";
            this.expiryToTime.ShowUpDown = true;
            this.expiryToTime.Size = new System.Drawing.Size(102, 26);
            this.expiryToTime.TabIndex = 52;
            this.expiryToTime.Value = new System.DateTime(2020, 2, 17, 23, 59, 0, 0);
            this.expiryToTime.ValueChanged += new System.EventHandler(this.checkinToTime_ValueChanged);
            // 
            // frmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1410, 857);
            this.Controls.Add(this.transToTime);
            this.Controls.Add(this.transFromTime);
            this.Controls.Add(this.expiryToTime);
            this.Controls.Add(this.projectExpiryToTime);
            this.Controls.Add(this.expiryFromTime);
            this.Controls.Add(this.projectExpiryFromTime);
            this.Controls.Add(this.printBtn);
            this.Controls.Add(this.reportDataGridView);
            this.Controls.Add(this.reportSubmitBtn);
            this.Controls.Add(this.tranDateCheckBox);
            this.Controls.Add(this.expiryDateCheckBox);
            this.Controls.Add(this.projectExpiryToDate);
            this.Controls.Add(this.projectExpiryFromDate);
            this.Controls.Add(this.projectExpiryCheckBox);
            this.Controls.Add(this.projectCombo);
            this.Controls.Add(this.itemIDCombo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.functionComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.toLabelDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.transToDate);
            this.Controls.Add(this.fromLabelDate);
            this.Controls.Add(this.transFromDate);
            this.Controls.Add(this.expiryToDate);
            this.Controls.Add(this.expiryFromDate);
            this.Controls.Add(this.userNameCombo);
            this.Controls.Add(this.label10);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmReports";
            this.Text = "frmRepository";
            this.Load += new System.EventHandler(this.frmRepository_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reportDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button printBtn;
        private System.Windows.Forms.DataGridView reportDataGridView;
        private System.Windows.Forms.Button reportSubmitBtn;
        private System.Windows.Forms.CheckBox expiryDateCheckBox;
        private System.Windows.Forms.DateTimePicker projectExpiryToDate;
        private System.Windows.Forms.DateTimePicker projectExpiryFromDate;
        private System.Windows.Forms.CheckBox projectExpiryCheckBox;
        private System.Windows.Forms.ComboBox functionComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label toLabelDate;
        private System.Windows.Forms.Label fromLabelDate;
        private System.Windows.Forms.DateTimePicker expiryToDate;
        private System.Windows.Forms.DateTimePicker expiryFromDate;
        private System.Windows.Forms.ComboBox userNameCombo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox itemIDCombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox projectCombo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker transFromDate;
        private System.Windows.Forms.DateTimePicker transToDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox tranDateCheckBox;
        private System.Windows.Forms.DateTimePicker projectExpiryToTime;
        private System.Windows.Forms.DateTimePicker projectExpiryFromTime;
        private System.Windows.Forms.DateTimePicker transFromTime;
        private System.Windows.Forms.DateTimePicker transToTime;
        private System.Windows.Forms.DateTimePicker expiryFromTime;
        private System.Windows.Forms.DateTimePicker expiryToTime;
    }
}