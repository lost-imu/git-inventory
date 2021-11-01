using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Application;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventorySystem1._0.Properties;

namespace InventorySystem1._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void CloseForm()
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }

        }
        public void Enabled_menu(int prev)
        {
            ts_Login.Text = "تسجيل خروج";
            ts_Login.Image = Resources.lock_open;

            if (prev == 0)
            {
                //enability
                ts_ManageUsers.Enabled = false;
                ts_Report.Enabled = false;
                ts_Return.Enabled = false;
                ts_StockOut.Enabled = false;
                ts_stocks.Enabled = false;
                ts_settings.Enabled = false;
                ts_repository.Enabled = false;
                toolStripButton1.Enabled = false;
                //visibility
                ts_ManageUsers.Visible = false;
                ts_Report.Visible = false;
                ts_Return.Visible = false;
                ts_StockOut.Visible = false;
                ts_stocks.Visible = false;
                ts_settings.Visible = false;
                ts_repository.Visible = false;
                toolStripButton1.Visible = false;

            }

            else if (prev == 1)
            {
                //stock in
                ts_stocks.Enabled = true;
                ts_stocks.Visible = true;
                //stockout
                ts_StockOut.Enabled = true;
                ts_StockOut.Visible = true;
                //manage users
                ts_ManageUsers.Enabled = false; 
                ts_ManageUsers.Visible = false;
                //settings
                ts_settings.Enabled = true;
                ts_settings.Visible = true;
                //reports
                ts_Report.Enabled = true;
                ts_Report.Visible = true;
                //reports2
                toolStripButton1.Enabled = true;
                toolStripButton1.Visible = true;

            }

            else if (prev == 2)
            {
                //stock in
                ts_stocks.Enabled = true;
                ts_stocks.Visible = true;
                //stockout
                ts_StockOut.Enabled = true;
                ts_StockOut.Visible = true;
                //manage users
                ts_ManageUsers.Enabled = true;
                ts_ManageUsers.Visible = true;
                //settings
                ts_settings.Enabled = true;
                ts_settings.Visible = true;
                //reports
                ts_Report.Enabled = true;
                ts_Report.Visible = true;
                //reports2
                toolStripButton1.Enabled = true;
                toolStripButton1.Visible = true;

            }
            

        }
        public void Disabled_menu()
        {
            ts_Login.Image = Resources.login;
            
            //stock in
            ts_stocks.Enabled = false;
            ts_stocks.Visible = false;
            //stockout
            ts_StockOut.Enabled = false;
            ts_StockOut.Visible = false;
            //manage users
            ts_ManageUsers.Enabled = false;
            ts_ManageUsers.Visible = false;
            //settings
            ts_settings.Enabled = false;
            ts_settings.Visible = false;
            //reports
            ts_Report.Enabled = false;
            ts_Report.Visible = false;
        }
        public void ShowFrm(Form frm)
        {
            this.IsMdiContainer = true;
            frm.MdiParent = this;
            frm.Show();
        }

        private void Ts_stocks_Click(object sender, EventArgs e)
        {
            CheckBtn(ts_stocks);
            CloseForm();
            ShowFrm(new frmItems());
        }

        private void Ts_StockOut_Click(object sender, EventArgs e)
        {
            CheckBtn(ts_StockOut);
            CloseForm();
            ShowFrm(new frmStockOut(""));
        }

        private void Ts_Return_Click(object sender, EventArgs e)
        {
            CheckBtn(ts_Return);
            CloseForm();
            ShowFrm(new frmReturn());
        }

        private void Ts_ManageUsers_Click(object sender, EventArgs e)
        {
            CheckBtn(ts_ManageUsers);
            CloseForm();
            ShowFrm(new FrmUsers());
        }

        private void Ts_Report_Click(object sender, EventArgs e)
        {
            CheckBtn(ts_Report);
            CloseForm();
            ShowFrm(new frmReports());

        }

        private void Ts_Login_Click(object sender, EventArgs e)
        {
            CheckBtn(ts_Login);
            if (ts_Login.Text == "تسجيل دخول")
            {
                
                CloseForm();
                ShowFrm(new frmLogin(this));
            }
            else
            {
                frmLogin.ResetUserName();
                CloseForm();
                Disabled_menu();
                ts_Login.Text = "تسجيل دخول";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (ApplicationDeployment.IsNetworkDeployed)
            {
                versionTSLabel.Text = string.Format("v{0}",
                    ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString(4));
            }
            else
                MessageBox.Show("not");
            //versionTSLabel.Text = Application.publi;
            //"version: " + Assembly.GetExecutingAssembly().GetName().Version.ToString();
            Disabled_menu();
            Ts_Login_Click(sender, e);

        }

        private void Ts_settings_Click(object sender, EventArgs e)
        {
            CheckBtn(ts_settings);
            CloseForm();
            ShowFrm(new frmSettings());
        }

        private void Ts_repository_Click(object sender, EventArgs e)
        {
            CheckBtn(ts_repository);
            CloseForm();
            ShowFrm(new frmReports());
        }

        private void CheckBtn(ToolStripButton t)
        {
            ts_stocks.Checked = false;
            ts_StockOut.Checked = false;
            ts_Return.Checked = false;
            ts_ManageUsers.Checked = false;
            ts_repository.Checked = false;
            ts_Report.Checked = false;
            toolStripButton1.Checked = false;
            ts_settings.Checked = false;
            ts_Login.Checked = false;
            t.Checked = true;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            CheckBtn(toolStripButton1);
            CloseForm();
            ShowFrm(new frmReports2());

        }
    }
}
