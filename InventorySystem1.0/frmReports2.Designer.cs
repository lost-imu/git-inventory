namespace InventorySystem1._0
{
    partial class frmReports2
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
            this.label1 = new System.Windows.Forms.Label();
            this.itemIDCombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.projectCombo = new System.Windows.Forms.ComboBox();
            this.expiryToDate = new System.Windows.Forms.DateTimePicker();
            this.expiryToTime = new System.Windows.Forms.DateTimePicker();
            this.toLabelDate = new System.Windows.Forms.Label();
            this.fromLabelDate = new System.Windows.Forms.Label();
            this.expiryFromTime = new System.Windows.Forms.DateTimePicker();
            this.expiryFromDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.reportDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // printBtn
            // 
            this.printBtn.Location = new System.Drawing.Point(65, 94);
            this.printBtn.Margin = new System.Windows.Forms.Padding(4);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(229, 63);
            this.printBtn.TabIndex = 50;
            this.printBtn.Text = "Print";
            this.printBtn.UseVisualStyleBackColor = true;
            this.printBtn.Click += new System.EventHandler(this.printBtn_Click_1);
            // 
            // reportDataGridView
            // 
            this.reportDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reportDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.reportDataGridView.Location = new System.Drawing.Point(0, 165);
            this.reportDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.reportDataGridView.Name = "reportDataGridView";
            this.reportDataGridView.RowHeadersWidth = 51;
            this.reportDataGridView.Size = new System.Drawing.Size(1253, 521);
            this.reportDataGridView.TabIndex = 49;
            // 
            // reportSubmitBtn
            // 
            this.reportSubmitBtn.Location = new System.Drawing.Point(65, 10);
            this.reportSubmitBtn.Margin = new System.Windows.Forms.Padding(4);
            this.reportSubmitBtn.Name = "reportSubmitBtn";
            this.reportSubmitBtn.Size = new System.Drawing.Size(231, 65);
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
            this.expiryDateCheckBox.Location = new System.Drawing.Point(961, 94);
            this.expiryDateCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.expiryDateCheckBox.Name = "expiryDateCheckBox";
            this.expiryDateCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.expiryDateCheckBox.Size = new System.Drawing.Size(49, 21);
            this.expiryDateCheckBox.TabIndex = 26;
            this.expiryDateCheckBox.Text = "الكل";
            this.expiryDateCheckBox.UseVisualStyleBackColor = true;
            this.expiryDateCheckBox.CheckedChanged += new System.EventHandler(this.expiryDateCheckBox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1029, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
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
            this.itemIDCombo.Location = new System.Drawing.Point(792, 31);
            this.itemIDCombo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.itemIDCombo.Name = "itemIDCombo";
            this.itemIDCombo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.itemIDCombo.Size = new System.Drawing.Size(229, 24);
            this.itemIDCombo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1029, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
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
            this.projectCombo.Location = new System.Drawing.Point(792, 62);
            this.projectCombo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.projectCombo.Name = "projectCombo";
            this.projectCombo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.projectCombo.Size = new System.Drawing.Size(229, 24);
            this.projectCombo.TabIndex = 4;
            // 
            // expiryToDate
            // 
            this.expiryToDate.CustomFormat = "dd/MM/yyyy";
            this.expiryToDate.Enabled = false;
            this.expiryToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.expiryToDate.Location = new System.Drawing.Point(420, 58);
            this.expiryToDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.expiryToDate.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.expiryToDate.Name = "expiryToDate";
            this.expiryToDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.expiryToDate.Size = new System.Drawing.Size(132, 22);
            this.expiryToDate.TabIndex = 29;
            this.expiryToDate.Value = new System.DateTime(2020, 2, 21, 0, 0, 0, 0);
            this.expiryToDate.ValueChanged += new System.EventHandler(this.expiryToDate_ValueChanged);
            // 
            // expiryToTime
            // 
            this.expiryToTime.Enabled = false;
            this.expiryToTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.expiryToTime.Location = new System.Drawing.Point(559, 58);
            this.expiryToTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.expiryToTime.Name = "expiryToTime";
            this.expiryToTime.ShowUpDown = true;
            this.expiryToTime.Size = new System.Drawing.Size(91, 22);
            this.expiryToTime.TabIndex = 52;
            this.expiryToTime.Value = new System.DateTime(2020, 2, 17, 23, 59, 0, 0);
            this.expiryToTime.ValueChanged += new System.EventHandler(this.checkinToTime_ValueChanged);
            // 
            // toLabelDate
            // 
            this.toLabelDate.AutoSize = true;
            this.toLabelDate.Location = new System.Drawing.Point(657, 63);
            this.toLabelDate.Name = "toLabelDate";
            this.toLabelDate.Size = new System.Drawing.Size(14, 17);
            this.toLabelDate.TabIndex = 36;
            this.toLabelDate.Text = "و";
            // 
            // fromLabelDate
            // 
            this.fromLabelDate.AutoSize = true;
            this.fromLabelDate.Location = new System.Drawing.Point(657, 34);
            this.fromLabelDate.Name = "fromLabelDate";
            this.fromLabelDate.Size = new System.Drawing.Size(95, 17);
            this.fromLabelDate.TabIndex = 33;
            this.fromLabelDate.Text = "تاريخ الصلاحية بين";
            // 
            // expiryFromTime
            // 
            this.expiryFromTime.Enabled = false;
            this.expiryFromTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.expiryFromTime.Location = new System.Drawing.Point(559, 29);
            this.expiryFromTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.expiryFromTime.Name = "expiryFromTime";
            this.expiryFromTime.ShowUpDown = true;
            this.expiryFromTime.Size = new System.Drawing.Size(91, 22);
            this.expiryFromTime.TabIndex = 51;
            this.expiryFromTime.Value = new System.DateTime(2020, 2, 17, 0, 0, 0, 0);
            this.expiryFromTime.ValueChanged += new System.EventHandler(this.checkinFromTime_ValueChanged);
            // 
            // expiryFromDate
            // 
            this.expiryFromDate.CustomFormat = "dd/MM/yyyy";
            this.expiryFromDate.Enabled = false;
            this.expiryFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.expiryFromDate.Location = new System.Drawing.Point(420, 29);
            this.expiryFromDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.expiryFromDate.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.expiryFromDate.Name = "expiryFromDate";
            this.expiryFromDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.expiryFromDate.Size = new System.Drawing.Size(132, 22);
            this.expiryFromDate.TabIndex = 27;
            this.expiryFromDate.Value = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.expiryFromDate.ValueChanged += new System.EventHandler(this.expiryFromDate_ValueChanged);
            // 
            // frmReports2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 686);
            this.Controls.Add(this.expiryToTime);
            this.Controls.Add(this.expiryFromTime);
            this.Controls.Add(this.printBtn);
            this.Controls.Add(this.reportDataGridView);
            this.Controls.Add(this.reportSubmitBtn);
            this.Controls.Add(this.expiryDateCheckBox);
            this.Controls.Add(this.projectCombo);
            this.Controls.Add(this.itemIDCombo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toLabelDate);
            this.Controls.Add(this.fromLabelDate);
            this.Controls.Add(this.expiryToDate);
            this.Controls.Add(this.expiryFromDate);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmReports2";
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox itemIDCombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox projectCombo;
        private System.Windows.Forms.DateTimePicker expiryToDate;
        private System.Windows.Forms.DateTimePicker expiryToTime;
        private System.Windows.Forms.Label toLabelDate;
        private System.Windows.Forms.Label fromLabelDate;
        private System.Windows.Forms.DateTimePicker expiryFromTime;
        private System.Windows.Forms.DateTimePicker expiryFromDate;
    }
}