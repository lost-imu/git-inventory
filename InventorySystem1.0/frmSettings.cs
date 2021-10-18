using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventorySystem1._0.Includes;
using MySql.Data.MySqlClient;

namespace InventorySystem1._0
{
    public partial class frmSettings : Form
    {

        public frmSettings()
        {
            InitializeComponent();
        }

        readonly SQLConfig config = new SQLConfig();
        readonly usableFunction funct = new usableFunction();
        string sql,unitid,personID,sLineID,gLineID;

        private void BtnTypesave_Click(object sender, EventArgs e)
        {
           
            if (string.IsNullOrWhiteSpace(gLineTxtBox.Text))
            {
                MessageBox.Show("املأ الإسم أولا");
                return;
            }
            
            string checkSql = "SELECT * FROM tblsettings WHERE DESCRIPTION ='" + gLineTxtBox.Text + "'";
            MySqlConnection con = new MySqlConnection(MyCon.GetConString());

            MySqlCommand command = new MySqlCommand(checkSql, con);
            con.Open();
            MySqlDataReader reader = command.ExecuteReader();
            reader.Read();
            

            if (reader.HasRows)
            {
                if(reader.GetInt16("DELETED")==1)
                {
                    sql = "UPDATE `tblsettings` SET DELETED=0 WHERE `ID`=" + reader.GetInt16("ID");
                    config.Execute_CUD(sql, "حصل خطأ ما", "تمت الاضافة");
                    BtntypeLoad_Click(sender, e);
                    return;
                }
                MessageBox.Show("هذا العنصر موجود في اللائحة");
            }
            else
            {
                sql = "INSERT INTO tblsettings (DESCRIPTION,PARA) VALUES ('" + gLineTxtBox.Text + "','GLINE')";
                config.Execute_CUD(sql, "error to save date", "Data has been saved in the database.");
                BtntypeLoad_Click(sender, e);
            }
        }
           
        private void BtntypeLoad_Click(object sender, EventArgs e)
        {
            sql = "SELECT ID, DESCRIPTION as 'GLINE' FROM tblsettings WHERE PARA='GLINE' AND `DELETED`=0";
            config.Load_DTG(sql, dtgGLINElist); 
            dtgGLINElist.Columns[0].Visible = false;
            gLineTxtBox.Clear();
        }

        private void Btncdel_Click(object sender, EventArgs e)
        {
            /*
            sql = "DELETE FROM `tblautonumber` WHERE `ID`='" + dtgtypelist.CurrentRow.Cells[0].Value + "'";
            config.Execute_Query(sql);*/

            sql = "UPDATE `tblsettings` SET DELETED=1 WHERE `ID`='" + dtgGLINElist.CurrentRow.Cells[0].Value + "'";
            config.Execute_CUD(sql, "حصل خطأ ما", "تم الحذف");

            BtntypeLoad_Click(sender, e);
        }

        private void Dtgtypelist_Click(object sender, EventArgs e)
        {
            gLineTxtBox.Text = dtgGLINElist.CurrentRow.Cells[1].Value.ToString();
            gLineID = dtgGLINElist.CurrentRow.Cells[0].Value.ToString();
        }

        private void Btnuload_Click(object sender, EventArgs e)
        {
            sql = "SELECT ID, DESCRIPTION as 'Unit' FROM tblsettings WHERE PARA='Unit' AND `DELETED`=0";
            config.Load_DTG(sql, dtgulist);
            dtgulist.Columns[0].Visible = false;
            gLineTxtBox.Clear();
            
        }

        private void Btnusave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtunit.Text))
            {
                MessageBox.Show("املأ الإسم أولا");
                return;
            }

            string checkSql = "SELECT * FROM tblsettings WHERE DESCRIPTION ='" + txtunit.Text + "'";
            MySqlConnection con = new MySqlConnection(MyCon.GetConString());

            MySqlCommand command = new MySqlCommand(checkSql, con);
            con.Open();
            MySqlDataReader reader = command.ExecuteReader();
            reader.Read();


            if (reader.HasRows)
            {
                if (reader.GetInt16("DELETED") == 1)
                {
                    sql = "UPDATE `tblsettings` SET DELETED=0 WHERE `ID`=" + reader.GetInt16("ID");
                    config.Execute_CUD(sql, "حصل خطأ ما", "تمت الاضافة");
                    BtntypeLoad_Click(sender, e);
                    return;
                }
                MessageBox.Show("هذا العنصر موجود في اللائحة");
            }
            else
            {
                sql = "INSERT INTO tblsettings (DESCRIPTION,PARA) VALUES ('" + txtunit.Text + "','Unit')";
                config.Execute_CUD(sql, "error to save date", "Data has been saved in the database.");
                Btnuload_Click(sender, e);
            }
        }

        private void Btnunit_Click(object sender, EventArgs e)
        {
            sql = "UPDATE `tblsettings` SET DELETED=1 WHERE `ID`='" + dtgulist.CurrentRow.Cells[0].Value + "'";
            config.Execute_CUD(sql, "حصل خطأ ما", "تم الحذف");
            Btnuload_Click(sender, e);
        }

        private void Dtgulist_Click(object sender, EventArgs e)
        {
            
            try
            {
                txtunit.Text = dtgulist.CurrentRow.Cells[1].Value.ToString();
                unitid = dtgulist.CurrentRow.Cells[0].Value.ToString();
            }
            catch {
                MessageBox.Show("catched");
            }
        }
        private void DtgSLINElist_Click(object sender, EventArgs e)
        {

            try
            {
                sLineTxtBox.Text = dtgSLINElist.CurrentRow.Cells[1].Value.ToString();
                sLineID = dtgSLINElist.CurrentRow.Cells[0].Value.ToString();
            }
            catch
            {
                MessageBox.Show("catched");
            }
        }
        private void PersonDTGV_Click(object sender, EventArgs e)
        {

            try
            {
                personID = personDataGridView.CurrentRow.Cells[1].Value.ToString();
                personIDTxtBox.Text = personDataGridView.CurrentRow.Cells[1].Value.ToString();
                personFirstNameTxtBox.Text = personDataGridView.CurrentRow.Cells[2].Value.ToString();
                personLastNameTxtBox.Text = personDataGridView.CurrentRow.Cells[3].Value.ToString();
                //unitid = dtgulist.CurrentRow.Cells[0].Value.ToString();
            }
            catch
            {
                MessageBox.Show("catched");
            }
        }

        private void FrmSettings_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            BtntypeLoad_Click(sender, e);
            Btnuload_Click(sender, e);
            LoadPersonBtn_Click(sender, e);
            btntSLineLoad_Click(sender, e);
            

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoadPersonBtn_Click(object sender, EventArgs e)
        {
            sql = "SELECT `ID`, `SUPLIERCUSTOMERID` AS 'Number', `FIRSTNAME` AS 'First Name', `LASTNAME` AS 'Last Name' FROM `tblperson` WHERE `TYPE`='CUSTOMER' AND DELETED=0";
            config.Load_DTG(sql, personDataGridView);
            personDataGridView.Columns[0].Visible = false;
            personIDTxtBox.Clear();
            personFirstNameTxtBox.Clear();
            personLastNameTxtBox.Clear();
        }

        private void AddPersonBtn_Click(object sender, EventArgs e)
        {
            foreach (Control T in GroupBox3.Controls)
            {
                if(T is TextBox)
                if (string.IsNullOrEmpty(T.Text))
                {
                    MessageBox.Show("أدخل المعلومات المطلوبة");
                    return;
                }
            }
            string checkSql = "SELECT * FROM tblperson WHERE SUPLIERCUSTOMERID  ='" + personIDTxtBox.Text + "'";
            MySqlConnection con = new MySqlConnection(MyCon.GetConString());

            MySqlCommand command = new MySqlCommand(checkSql, con);
            con.Open();
            MySqlDataReader reader = command.ExecuteReader();
            reader.Read();


            if (reader.HasRows)
            {
                if (reader.GetInt16("DELETED") == 1)
                {
                    sql = "UPDATE `tblperson` SET DELETED=0 WHERE `ID`=" + reader.GetInt16("ID");
                    config.Execute_CUD(sql, "حصل خطأ ما", "تمت الاضافة");
                    LoadPersonBtn_Click(sender, e);
                    return;
                }
                MessageBox.Show("هذا الاسم موجود في اللائحة");
            }
            else
            {
                sql = "INSERT INTO tblperson (SUPLIERCUSTOMERID,FIRSTNAME, LASTNAME, TYPE) VALUES ('" + personIDTxtBox.Text + "','" + personFirstNameTxtBox.Text + "','" + personLastNameTxtBox.Text + "', 'CUSTOMER')";
                config.Execute_CUD(sql, "error saving data", "Data has been saved in the database.");
                LoadPersonBtn_Click(sender, e);
            }
        }

        private void EditPersonBtn_Click(object sender, EventArgs e)
        {
            foreach (Control T in GroupBox3.Controls)
            {
                if (T is TextBox)
                    if (string.IsNullOrEmpty(T.Text))
                    {
                        MessageBox.Show("أدخل المعلومات المطلوبة");
                        return;
                    }
            }
            sql = "UPDATE tblperson  SET"+
                " SUPLIERCUSTOMERID = '" + personIDTxtBox.Text + "'," +
                " FIRSTNAME= '" + personFirstNameTxtBox.Text + "'," +
                " LASTNAME= '" + personLastNameTxtBox.Text + "'" +
                 " WHERE ID ='" + personID+ "'";
            config.Execute_CUD(sql, "حصل خطأ ما", "تم تعديل المعلومات");
            LoadPersonBtn_Click(sender, e);
        }

        private void btntSLineLoad_Click(object sender, EventArgs e)
        {
            sql = "SELECT ID, DESCRIPTION as 'SLINE' FROM tblsettings WHERE PARA='SLINE' AND `DELETED`=0";
            config.Load_DTG(sql, dtgSLINElist);
            dtgSLINElist.Columns[0].Visible = false;
            sLineTxtBox.Clear();
        }

        private void btnSLinesave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(sLineTxtBox.Text))
            {
                MessageBox.Show("املأ الإسم أولا");
                return;
            }

            string checkSql = "SELECT * FROM tblsettings WHERE DESCRIPTION ='" + sLineTxtBox.Text + "'";
            MySqlConnection con = new MySqlConnection(MyCon.GetConString());

            MySqlCommand command = new MySqlCommand(checkSql, con);
            con.Open();
            MySqlDataReader reader = command.ExecuteReader();
            reader.Read();


            if (reader.HasRows)
            {
                if (reader.GetInt16("DELETED") == 1)
                {
                    sql = "UPDATE `tblsettings` SET DELETED=0 WHERE `ID`=" + reader.GetInt16("ID");
                    config.Execute_CUD(sql, "حصل خطأ ما", "تمت الاضافة");
                    BtntypeLoad_Click(sender, e);
                    return;
                }
                MessageBox.Show("هذا العنصر موجود في اللائحة");
            }
            else
            {
                sql = "INSERT INTO tblsettings (DESCRIPTION,PARA) VALUES ('" + sLineTxtBox.Text + "','SLINE')";
                config.Execute_CUD(sql, "error to saving data", "Data has been saved in the database.");
                btntSLineLoad_Click(sender, e);
            }
        }

        private void sLineUpdateBtn_Click(object sender, EventArgs e)
        {
            sql = "UPDATE tblsettings  SET DESCRIPTION= '" + sLineTxtBox.Text + "' WHERE ID ='" + sLineID + "'";
            config.Execute_CUD(sql, "حصل خطأ ما", "تم تعديل المعلومات");
            btntSLineLoad_Click(sender, e);
        }

        private void DeletePersonBtn_Click(object sender, EventArgs e)
        {
            sql = "UPDATE `tblperson` SET DELETED=1 WHERE `SUPLIERCUSTOMERID`='" + personID + "'";
            config.Execute_CUD(sql, "حصل خطأ ما", "تم الحذف");
            LoadPersonBtn_Click(sender, e);
        }

        private void Btnuupdate_Click(object sender, EventArgs e)
        {
            sql = "UPDATE tblsettings  SET DESCRIPTION= '" + txtunit.Text + "' WHERE ID ='" + unitid + "'";
            config.Execute_CUD(sql, "حصل خطأ ما", "تم تعديل المعلومات");
            Btnuload_Click(sender, e);
        }

        private void Btntypeupdate_Click(object sender, EventArgs e)
        {
            sql = "UPDATE tblsettings  SET DESCRIPTION= '" + gLineTxtBox.Text + "' WHERE ID ='" + gLineID + "'";
            config.Execute_CUD(sql, "حصل خطأ ما", "تم تعديل المعلومات");
            BtntypeLoad_Click(sender, e);
        }
    }
}
