namespace InventorySystem1._0
{
    partial class frmSettings
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgtypelist = new System.Windows.Forms.DataGridView();
            this.txtunit = new System.Windows.Forms.TextBox();
            this.btnusave = new System.Windows.Forms.Button();
            this.btncdel = new System.Windows.Forms.Button();
            this.btntypeupdate = new System.Windows.Forms.Button();
            this.btntypeLoad = new System.Windows.Forms.Button();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.btnuupdate = new System.Windows.Forms.Button();
            this.btnuload = new System.Windows.Forms.Button();
            this.dtgulist = new System.Windows.Forms.DataGridView();
            this.btnTypesave = new System.Windows.Forms.Button();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.btnunit = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.deletePersonBtn = new System.Windows.Forms.Button();
            this.editPersonBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.personLastNameTxtBox = new System.Windows.Forms.TextBox();
            this.loadPersonBtn = new System.Windows.Forms.Button();
            this.personFirstNameTxtBox = new System.Windows.Forms.TextBox();
            this.personDataGridView = new System.Windows.Forms.DataGridView();
            this.personIDTxtBox = new System.Windows.Forms.TextBox();
            this.addPersonBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgtypelist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgulist)).BeginInit();
            this.GroupBox2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgtypelist
            // 
            this.dtgtypelist.AllowUserToAddRows = false;
            this.dtgtypelist.AllowUserToDeleteRows = false;
            this.dtgtypelist.AllowUserToResizeColumns = false;
            this.dtgtypelist.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgtypelist.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgtypelist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgtypelist.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgtypelist.Location = new System.Drawing.Point(6, 54);
            this.dtgtypelist.Name = "dtgtypelist";
            this.dtgtypelist.RowHeadersVisible = false;
            this.dtgtypelist.Size = new System.Drawing.Size(278, 222);
            this.dtgtypelist.TabIndex = 3;
            this.dtgtypelist.Click += new System.EventHandler(this.Dtgtypelist_Click);
            // 
            // txtunit
            // 
            this.txtunit.Location = new System.Drawing.Point(6, 31);
            this.txtunit.Name = "txtunit";
            this.txtunit.Size = new System.Drawing.Size(229, 20);
            this.txtunit.TabIndex = 2;
            // 
            // btnusave
            // 
            this.btnusave.BackColor = System.Drawing.Color.White;
            this.btnusave.ForeColor = System.Drawing.Color.Black;
            this.btnusave.Location = new System.Drawing.Point(290, 31);
            this.btnusave.Name = "btnusave";
            this.btnusave.Size = new System.Drawing.Size(75, 23);
            this.btnusave.TabIndex = 0;
            this.btnusave.Text = "إضافة";
            this.btnusave.UseVisualStyleBackColor = false;
            this.btnusave.Click += new System.EventHandler(this.Btnusave_Click);
            // 
            // btncdel
            // 
            this.btncdel.BackColor = System.Drawing.Color.White;
            this.btncdel.ForeColor = System.Drawing.Color.Black;
            this.btncdel.Location = new System.Drawing.Point(290, 89);
            this.btncdel.Name = "btncdel";
            this.btncdel.Size = new System.Drawing.Size(75, 23);
            this.btncdel.TabIndex = 6;
            this.btncdel.Text = "مسح";
            this.btncdel.UseVisualStyleBackColor = false;
            this.btncdel.Click += new System.EventHandler(this.Btncdel_Click);
            // 
            // btntypeupdate
            // 
            this.btntypeupdate.BackColor = System.Drawing.Color.White;
            this.btntypeupdate.ForeColor = System.Drawing.Color.Black;
            this.btntypeupdate.Location = new System.Drawing.Point(290, 60);
            this.btntypeupdate.Name = "btntypeupdate";
            this.btntypeupdate.Size = new System.Drawing.Size(75, 23);
            this.btntypeupdate.TabIndex = 5;
            this.btntypeupdate.Text = "تعديل";
            this.btntypeupdate.UseVisualStyleBackColor = false;
            this.btntypeupdate.Click += new System.EventHandler(this.Btntypeupdate_Click);
            // 
            // btntypeLoad
            // 
            this.btntypeLoad.BackColor = System.Drawing.Color.White;
            this.btntypeLoad.ForeColor = System.Drawing.Color.Black;
            this.btntypeLoad.Location = new System.Drawing.Point(290, 121);
            this.btntypeLoad.Name = "btntypeLoad";
            this.btntypeLoad.Size = new System.Drawing.Size(75, 23);
            this.btntypeLoad.TabIndex = 4;
            this.btntypeLoad.Text = "Load";
            this.btntypeLoad.UseVisualStyleBackColor = false;
            this.btntypeLoad.Visible = false;
            this.btntypeLoad.Click += new System.EventHandler(this.BtntypeLoad_Click);
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(6, 28);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(240, 20);
            this.txtCategory.TabIndex = 2;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.Black;
            this.Label1.Location = new System.Drawing.Point(252, 31);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(32, 13);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "الفئة";
            // 
            // btnuupdate
            // 
            this.btnuupdate.BackColor = System.Drawing.Color.White;
            this.btnuupdate.ForeColor = System.Drawing.Color.Black;
            this.btnuupdate.Location = new System.Drawing.Point(290, 60);
            this.btnuupdate.Name = "btnuupdate";
            this.btnuupdate.Size = new System.Drawing.Size(75, 23);
            this.btnuupdate.TabIndex = 5;
            this.btnuupdate.Text = "تعديل";
            this.btnuupdate.UseVisualStyleBackColor = false;
            this.btnuupdate.Click += new System.EventHandler(this.Btnuupdate_Click);
            // 
            // btnuload
            // 
            this.btnuload.BackColor = System.Drawing.Color.White;
            this.btnuload.ForeColor = System.Drawing.Color.Black;
            this.btnuload.Location = new System.Drawing.Point(290, 117);
            this.btnuload.Name = "btnuload";
            this.btnuload.Size = new System.Drawing.Size(75, 23);
            this.btnuload.TabIndex = 4;
            this.btnuload.Text = "Load";
            this.btnuload.UseVisualStyleBackColor = false;
            this.btnuload.Visible = false;
            this.btnuload.Click += new System.EventHandler(this.Btnuload_Click);
            // 
            // dtgulist
            // 
            this.dtgulist.AllowUserToAddRows = false;
            this.dtgulist.AllowUserToDeleteRows = false;
            this.dtgulist.AllowUserToResizeColumns = false;
            this.dtgulist.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgulist.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgulist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgulist.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgulist.Location = new System.Drawing.Point(6, 54);
            this.dtgulist.Name = "dtgulist";
            this.dtgulist.RowHeadersVisible = false;
            this.dtgulist.Size = new System.Drawing.Size(278, 222);
            this.dtgulist.TabIndex = 3;
            this.dtgulist.Click += new System.EventHandler(this.Dtgulist_Click);
            // 
            // btnTypesave
            // 
            this.btnTypesave.BackColor = System.Drawing.Color.White;
            this.btnTypesave.ForeColor = System.Drawing.Color.Black;
            this.btnTypesave.Location = new System.Drawing.Point(290, 31);
            this.btnTypesave.Name = "btnTypesave";
            this.btnTypesave.Size = new System.Drawing.Size(75, 23);
            this.btnTypesave.TabIndex = 0;
            this.btnTypesave.Text = "إضافة";
            this.btnTypesave.UseVisualStyleBackColor = false;
            this.btnTypesave.Click += new System.EventHandler(this.BtnTypesave_Click);
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.btnunit);
            this.GroupBox2.Controls.Add(this.btnuupdate);
            this.GroupBox2.Controls.Add(this.Label2);
            this.GroupBox2.Controls.Add(this.btnuload);
            this.GroupBox2.Controls.Add(this.dtgulist);
            this.GroupBox2.Controls.Add(this.txtunit);
            this.GroupBox2.Controls.Add(this.btnusave);
            this.GroupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox2.ForeColor = System.Drawing.Color.Black;
            this.GroupBox2.Location = new System.Drawing.Point(12, 297);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GroupBox2.Size = new System.Drawing.Size(374, 282);
            this.GroupBox2.TabIndex = 14;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "وحدات القياس";
            // 
            // btnunit
            // 
            this.btnunit.BackColor = System.Drawing.Color.White;
            this.btnunit.ForeColor = System.Drawing.Color.Black;
            this.btnunit.Location = new System.Drawing.Point(290, 88);
            this.btnunit.Name = "btnunit";
            this.btnunit.Size = new System.Drawing.Size(75, 23);
            this.btnunit.TabIndex = 7;
            this.btnunit.Text = "مسح";
            this.btnunit.UseVisualStyleBackColor = false;
            this.btnunit.Click += new System.EventHandler(this.Btnunit_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.Black;
            this.Label2.Location = new System.Drawing.Point(241, 35);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(43, 13);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "الوحدة";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.btncdel);
            this.GroupBox1.Controls.Add(this.btntypeupdate);
            this.GroupBox1.Controls.Add(this.btntypeLoad);
            this.GroupBox1.Controls.Add(this.dtgtypelist);
            this.GroupBox1.Controls.Add(this.txtCategory);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Controls.Add(this.btnTypesave);
            this.GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.GroupBox1.Location = new System.Drawing.Point(12, 9);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GroupBox1.Size = new System.Drawing.Size(374, 282);
            this.GroupBox1.TabIndex = 13;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "الفئات";
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.deletePersonBtn);
            this.GroupBox3.Controls.Add(this.editPersonBtn);
            this.GroupBox3.Controls.Add(this.label5);
            this.GroupBox3.Controls.Add(this.label4);
            this.GroupBox3.Controls.Add(this.label3);
            this.GroupBox3.Controls.Add(this.personLastNameTxtBox);
            this.GroupBox3.Controls.Add(this.loadPersonBtn);
            this.GroupBox3.Controls.Add(this.personFirstNameTxtBox);
            this.GroupBox3.Controls.Add(this.personDataGridView);
            this.GroupBox3.Controls.Add(this.personIDTxtBox);
            this.GroupBox3.Controls.Add(this.addPersonBtn);
            this.GroupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox3.ForeColor = System.Drawing.Color.Black;
            this.GroupBox3.Location = new System.Drawing.Point(392, 12);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GroupBox3.Size = new System.Drawing.Size(374, 567);
            this.GroupBox3.TabIndex = 14;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "الموظف المستلم";
            // 
            // deletePersonBtn
            // 
            this.deletePersonBtn.BackColor = System.Drawing.Color.White;
            this.deletePersonBtn.ForeColor = System.Drawing.Color.Black;
            this.deletePersonBtn.Location = new System.Drawing.Point(290, 88);
            this.deletePersonBtn.Name = "deletePersonBtn";
            this.deletePersonBtn.Size = new System.Drawing.Size(75, 23);
            this.deletePersonBtn.TabIndex = 7;
            this.deletePersonBtn.Text = "مسح";
            this.deletePersonBtn.UseVisualStyleBackColor = false;
            this.deletePersonBtn.Click += new System.EventHandler(this.DeletePersonBtn_Click);
            // 
            // editPersonBtn
            // 
            this.editPersonBtn.BackColor = System.Drawing.Color.White;
            this.editPersonBtn.ForeColor = System.Drawing.Color.Black;
            this.editPersonBtn.Location = new System.Drawing.Point(290, 60);
            this.editPersonBtn.Name = "editPersonBtn";
            this.editPersonBtn.Size = new System.Drawing.Size(75, 23);
            this.editPersonBtn.TabIndex = 5;
            this.editPersonBtn.Text = "تعديل";
            this.editPersonBtn.UseVisualStyleBackColor = false;
            this.editPersonBtn.Click += new System.EventHandler(this.EditPersonBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(242, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "العائلة";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(242, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "الإسم";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(242, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "الرقم";
            // 
            // personLastNameTxtBox
            // 
            this.personLastNameTxtBox.Location = new System.Drawing.Point(6, 93);
            this.personLastNameTxtBox.Name = "personLastNameTxtBox";
            this.personLastNameTxtBox.Size = new System.Drawing.Size(229, 20);
            this.personLastNameTxtBox.TabIndex = 2;
            this.personLastNameTxtBox.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // loadPersonBtn
            // 
            this.loadPersonBtn.BackColor = System.Drawing.Color.White;
            this.loadPersonBtn.ForeColor = System.Drawing.Color.Black;
            this.loadPersonBtn.Location = new System.Drawing.Point(290, 117);
            this.loadPersonBtn.Name = "loadPersonBtn";
            this.loadPersonBtn.Size = new System.Drawing.Size(75, 23);
            this.loadPersonBtn.TabIndex = 4;
            this.loadPersonBtn.Text = "Load";
            this.loadPersonBtn.UseVisualStyleBackColor = false;
            this.loadPersonBtn.Click += new System.EventHandler(this.LoadPersonBtn_Click);
            // 
            // personFirstNameTxtBox
            // 
            this.personFirstNameTxtBox.Location = new System.Drawing.Point(6, 63);
            this.personFirstNameTxtBox.Name = "personFirstNameTxtBox";
            this.personFirstNameTxtBox.Size = new System.Drawing.Size(229, 20);
            this.personFirstNameTxtBox.TabIndex = 2;
            this.personFirstNameTxtBox.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // personDataGridView
            // 
            this.personDataGridView.AllowUserToAddRows = false;
            this.personDataGridView.AllowUserToDeleteRows = false;
            this.personDataGridView.AllowUserToResizeColumns = false;
            this.personDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.personDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.personDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.personDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.personDataGridView.Location = new System.Drawing.Point(6, 141);
            this.personDataGridView.Name = "personDataGridView";
            this.personDataGridView.RowHeadersVisible = false;
            this.personDataGridView.Size = new System.Drawing.Size(278, 420);
            this.personDataGridView.TabIndex = 3;
            this.personDataGridView.Click += new System.EventHandler(this.PersonDTGV_Click);
            // 
            // personIDTxtBox
            // 
            this.personIDTxtBox.Location = new System.Drawing.Point(6, 34);
            this.personIDTxtBox.Name = "personIDTxtBox";
            this.personIDTxtBox.Size = new System.Drawing.Size(229, 20);
            this.personIDTxtBox.TabIndex = 2;
            this.personIDTxtBox.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // addPersonBtn
            // 
            this.addPersonBtn.BackColor = System.Drawing.Color.White;
            this.addPersonBtn.ForeColor = System.Drawing.Color.Black;
            this.addPersonBtn.Location = new System.Drawing.Point(290, 31);
            this.addPersonBtn.Name = "addPersonBtn";
            this.addPersonBtn.Size = new System.Drawing.Size(75, 23);
            this.addPersonBtn.TabIndex = 0;
            this.addPersonBtn.Text = "إضافة";
            this.addPersonBtn.UseVisualStyleBackColor = false;
            this.addPersonBtn.Click += new System.EventHandler(this.AddPersonBtn_Click);
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 729);
            this.Controls.Add(this.GroupBox3);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الضبط";
            this.Load += new System.EventHandler(this.FrmSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgtypelist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgulist)).EndInit();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.DataGridView dtgtypelist;
        internal System.Windows.Forms.TextBox txtunit;
        internal System.Windows.Forms.Button btnusave;
        internal System.Windows.Forms.Button btncdel;
        internal System.Windows.Forms.Button btntypeupdate;
        internal System.Windows.Forms.Button btntypeLoad;
        internal System.Windows.Forms.TextBox txtCategory;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button btnuupdate;
        internal System.Windows.Forms.Button btnuload;
        internal System.Windows.Forms.DataGridView dtgulist;
        internal System.Windows.Forms.Button btnTypesave;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Button btnunit;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.Button deletePersonBtn;
        internal System.Windows.Forms.Button editPersonBtn;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Button loadPersonBtn;
        internal System.Windows.Forms.DataGridView personDataGridView;
        internal System.Windows.Forms.TextBox personIDTxtBox;
        internal System.Windows.Forms.Button addPersonBtn;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.TextBox personLastNameTxtBox;
        internal System.Windows.Forms.TextBox personFirstNameTxtBox;
    }
}