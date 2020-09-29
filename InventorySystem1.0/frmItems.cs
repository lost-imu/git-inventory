using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared.Json;
using CrystalDecisions.Windows.Forms;
using InventorySystem1._0.Includes;
using MySql.Data.MySqlClient;

namespace InventorySystem1._0
{
    public partial class frmItems : Form
    {
        public frmItems()
        {
            InitializeComponent();
        }

        readonly SQLConfig config = new SQLConfig();
        readonly usableFunction funct = new  usableFunction();
        string sql, itemID;
        int maxcolumn;
        int inc = 0;
        int maxrow;
        int isNew = 1;

        private void Select_navigation(string sql)
        {
            config.SingleResult(sql);
            maxrow = config.dt.Rows.Count;
        }
        public void Navigate_records(int inc)
        {/*
            config.singleResult("SELECT * FROM `tblitems`");
            itemIDTxtBox.Text =config.dt.Rows[inc].Field<string>("ITEMID");
            itemNameTextBox.Text = config.dt.Rows[inc].Field<string>("NAME");
            descriptionTextBox.Text = config.dt.Rows[inc].Field<string>("DESCRIPTION");
            typeCombo.Text = config.dt.Rows[inc].Field<string>("TYPE");
            projectTextBox.Text = config.dt.Rows[inc].Field<double>("QTY").ToString();
            typeCombo.Text = config.dt.Rows[inc].Field<string>("TYPE");
            typeCombo.Text = config.dt.Rows[inc].Field<string>("TYPE");
            typeCombo.Text = config.dt.Rows[inc].Field<string>("TYPE");
            typeCombo.Text = config.dt.Rows[inc].Field<string>("TYPE");
            typeCombo.Text = config.dt.Rows[inc].Field<string>("TYPE");
            typeCombo.Text = config.dt.Rows[inc].Field<string>("TYPE");

            //txtqty.Text = config.dt.Rows[inc].Field<int>("Quantity").ToString();
            //cbounit.Text = config.dt.Rows[inc].Field<string>("Units");

            */
        }
        private void Btnnew_Click(object sender, EventArgs e)
        {

            inc = 0;
          
            sql = "SELECT * FROM tblitems where `DELETED`=0";
            config.Load_DTG(sql, dtglist);  

            maxcolumn = dtglist.Columns.Count - 1;

            dtglist.Columns[maxcolumn].Visible = false;

            btnadd.Visible = false;
             
            Select_navigation("SELECT ITEMID FROM tblitems where `DELETED`=0");
            //lblmax.Text = maxrow.ToString();
            //lblinc.Text = inc.ToString();

            sql = "SELECT DESCRIPTION FROM `tblsettings` WHERE `PARA`='CATEGORY' AND DELETED=0";
            config.Fiil_CBO(sql, typeCombo);

            sql = "SELECT DESCRIPTION FROM `tblsettings` WHERE `PARA`='Unit' AND DELETED=0";
            config.Fiil_CBO(sql, unitCombo);


            funct.clearTxt(pnl_stockmaster);

        }

        private void FrmItems_Load(object sender, EventArgs e)
        {
            Btnnew_Click(sender, e);
            this.WindowState = FormWindowState.Maximized;
        }


        private void Cbotype_SelectedIndexChanged(object sender, EventArgs e)
        { 
                sql = "SELECT concat(`STRT`, `END`) FROM `tblautonumber` WHERE `DESCRIPTION`= '" + typeCombo.Text + "'";
                //config.autonumber(sql, itemIDTxtBox);
 
        }
        private string ExpiryDate()
        {
            string expiryDate = null;
            

            if (!expiryDateCheckBx.Checked)
                expiryDate = expiryDatePicker.Value.Date.ToString("yyyyMMdd");
            return expiryDate;
        }
        private string ProjectExpiry()
        {
            string projectExpiry = null;
            if (!projectExpiryCheckBx.Checked)
                projectExpiry = projectExpiryPicker.Value.Date.ToString("yyyyMMdd");
            return projectExpiry;
        }

        private void Btnsave_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(MyCon.GetConString());
            MySqlCommand command;
            /////////////////////////////////////////
            ///check if values are existing no blank

            foreach (Control obj in pnl_stockmaster.Controls)
            {
                if(obj is TextBox)
                {
                    if(obj.Text == "")
                    {
                        MessageBox.Show("إملأ كل الفراغات بالمعلومات المطلوبة", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }
            }

            
            /////////////////////////////////////////////////////////////
            ///check if exist
            sql = "SELECT ITEMID FROM tblitems WHERE NAME = @NAME" +
               " AND DESCRIPTION = @DESCRIPTION" +
               " AND TYPE = @TYPE" +
               " AND UNIT = @UNIT " +
               " AND UPPER(PROJECT) =  UPPER(@PROJECT)" +
               " AND ISNEW = @ISNEW"; // + 
               //" AND EXPIRYDATE = @EXPIRYDATE" +
               //" AND PROJECTEXPIRY = @PROJECTEXPIRY;";

            //sql = "select * from tblitems where ITEMID= '"+ itemIDTxtBox.Text+"'";



            try
            {
                con.Close();
                con.Open();
                command = new MySqlCommand(sql, con);
                command.Parameters.Add(new MySqlParameter("NAME", itemNameTextBox.Text));
                command.Parameters.Add(new MySqlParameter("DESCRIPTION", descriptionTextBox.Text));
                command.Parameters.Add(new MySqlParameter("TYPE", Convert.ToString(typeCombo.SelectedValue)));
                command.Parameters.Add(new MySqlParameter("UNIT", Convert.ToString(unitCombo.SelectedValue)));
                command.Parameters.Add(new MySqlParameter("PROJECT", projectTextBox.Text));
                command.Parameters.Add(new MySqlParameter("ISNEW", isNewRadio.Checked));
                //command.Parameters.Add(new MySqlParameter("EXPIRYDATE", expiryDate));
                //command.Parameters.Add(new MySqlParameter("PROJECTEXPIRY", projectExpiry));
                MySqlDataReader reader = command.ExecuteReader();
                //string testCom = command.CommandText;
                //MessageBox.Show(testCom);
                reader.Read();
                if (reader.HasRows)
                ////////////////////////////////////////////////////////////////////
                /// if exists, update quantity
                /// 

                {
                    bool isReported = false;
                    //MessageBox.Show("date1='" + Convert.ToString(reader.GetOrdinal("EXPIRYDATE")+"'"));
                    //MessageBox.Show("date2='" + Convert.ToString(reader.GetOrdinal("PROJECTEXPIRY")+"'"));

                    string s = reader.GetString("ITEMID");
                    //MessageBox.Show(reader.HasRows + "\n" + s);
                    sql = "UPDATE tblitems SET qty =qty + '" + qtyUpDown.Value + "' WHERE ITEMID = '" + s + "'";
                    reader.Close();
                    
                    command = new MySqlCommand(sql, con);
                    if (command.ExecuteNonQuery() > 0)
                        while (!isReported)
                        {
                            isReported = MyCon.ReportIt("Add Quantity To Existing Item", "QTY", s, itemNameTextBox.Text, descriptionTextBox.Text, Convert.ToString(typeCombo.SelectedValue), Convert.ToInt32(qtyUpDown.Value), Convert.ToString(unitCombo.SelectedValue), projectTextBox.Text, -1, ExpiryDate(), ProjectExpiry());
//                          MyCon.ReportIt("Add New Item Btn", "All", itemIDTxtBox.Text, itemNameTextBox.Text, descriptionTextBox.Text, Convert.ToString(typeCombo.SelectedValue), Convert.ToInt32(qtyUpDown.Value), Convert.ToString(unitCombo.SelectedValue), projectTextBox.Text, Convert.ToInt16(isNewRadio.Checked), ExpiryDate(), ProjectExpiry());

                            MessageBox.Show(" تم تعديل الكمية الى " + "\n" + s);
                        }
                    else
                        MessageBox.Show("حصل خطأما\nerror: 3753");
                    con.Close();
                }
                
                else
                {
                    //string testi = "date1: '" + expiryDate() + "'\n"+
                    //    "date2: '" + projectExpiry+"'";
                    //MessageBox.Show(testi);
                    reader.Close();
                    sql = "insert into tblitems  (ITEMID,NAME, DESCRIPTION, TYPE, QTY, UNIT,PROJECT, ISNEW, EXPIRYDATE, PROJECTEXPIRY)" + //, RECIEVER_NUMBER, RECIEVER_STATE, RECIEVER_NAME)" +
                     "VALUES (@ITEMID, @NAME, @DESCRIPTION, @TYPE, @QTY, @UNIT, @PROJECT, @ISNEW, @EXPIRYDATE, @PROJECTEXPIRY)"; //, @RECIEVER_NUMBER, @RECIEVER_STATE, @RECIEVER_NAME)";

                    command = new MySqlCommand(sql, con);
                    command.Parameters.Add(new MySqlParameter("ITEMID", itemIDTxtBox.Text));
                    command.Parameters.Add(new MySqlParameter("NAME", itemNameTextBox.Text));
                    command.Parameters.Add(new MySqlParameter("DESCRIPTION", descriptionTextBox.Text));
                    command.Parameters.Add(new MySqlParameter("TYPE", Convert.ToString(typeCombo.SelectedValue)));
                    command.Parameters.Add(new MySqlParameter("QTY", qtyUpDown.Value));
                    command.Parameters.Add(new MySqlParameter("UNIT", Convert.ToString(unitCombo.SelectedValue)));
                    command.Parameters.Add(new MySqlParameter("PROJECT", projectTextBox.Text));
                    command.Parameters.Add(new MySqlParameter("ISNEW", isNewRadio.Checked));
                    command.Parameters.Add(new MySqlParameter("EXPIRYDATE", ExpiryDate()));
                    command.Parameters.Add(new MySqlParameter("PROJECTEXPIRY", ProjectExpiry()));

                    //command.Parameters.Add(new MySqlParameter("RECIEVER_NUMBER", frmLogin.user_id));
                    //command.Parameters.Add(new MySqlParameter("RECIEVER_STATE", "Employee"));
                    //command.Parameters.Add(new MySqlParameter("RECIEVER_NAME", frmLogin.fullName));

                    if (command.ExecuteNonQuery() > 0)
                    {
                        MyCon.ReportIt("Add New Item Btn", "All", itemIDTxtBox.Text, itemNameTextBox.Text, descriptionTextBox.Text, Convert.ToString(typeCombo.SelectedValue), Convert.ToInt32(qtyUpDown.Value), Convert.ToString(unitCombo.SelectedValue), projectTextBox.Text, Convert.ToInt16(isNewRadio.Checked), ExpiryDate(), ProjectExpiry());
                        MessageBox.Show("تمت الاضافة بنجاح");
                    }
                    else
                        MessageBox.Show("حصل خطأما\nerror: 3553");

                    con.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
                    ///////////////////////////////////////////////////////


            //Btnnew_Click(sender, e);
            
        }
        public static T ConvertFromDBVal<T>(object obj)
        {
            if (obj == null || obj == DBNull.Value)
            {

                return default(T); // returns the default value for the type
            }
            else
            {
                return (T)obj;
            }
        }
        private void Btnupdate_Click(object sender, EventArgs e)
        {
            if (frmLogin.userType != "Administrator")
            {
                MessageBox.Show("صلاحيات التعديل غير متوفرة");
                return;
            }

            sql = "UPDATE tblitems SET" +
                " ITEMID= '" + itemIDTxtBox.Text + "'" +
                ", NAME= '" + itemNameTextBox.Text + "'" +
                ", DESCRIPTION = '" + descriptionTextBox.Text + "'" +
                ", TYPE = '" + typeCombo.SelectedValue + "'" +
                //", QTY = '" + qtyUpDown.Value +"'"+
                ", UNIT = '" + unitCombo.SelectedValue + "'" +
                ", PROJECT = '" + projectTextBox.Text + "'" +
                ", ISNEW = '" + isNew + "'" +
                ", EXPIRYDATE = '" + ExpiryDate() + "'" +
                ", PROJECTEXPIRY = '" + ProjectExpiry() + "'" +
                "WHERE ITEMID= '" + itemID + "'";
            //sql = "UPDATE tblitems SET `NAME`='" + itemNameTextBox.Text + "', `DESCRIPTION`='" + descriptionTextBox.Text + "', `TYPE`='" + typeCombo.Text + "', `PRICE`='" + projectTextBox.Text + "'" +
            //",`UNIT`='" + unitComo.Text + "' WHERE ITEMID='" + itemIDTxtBox.Text + "'";
            string reportFunction = "Update Item Btn";
            Execute_CUD(sql, "Error to update", "Data has been updated in the database", reportFunction);
            
            Btnnew_Click(sender, e);
        }
        public void Execute_CUD(string sql, string msg_false, string msg_true, string reportFunaction)
        {
             MySqlConnection con = new MySqlConnection(MyCon.GetConString());
         MySqlCommand cmd;
         
        int result;
        
            try
            {
                con.Open();
                cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = sql;
                result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    MyCon.ReportIt(reportFunaction, "All", itemIDTxtBox.Text, itemNameTextBox.Text, descriptionTextBox.Text, Convert.ToString(typeCombo.SelectedValue), Convert.ToInt32(qtyUpDown.Value), Convert.ToString(unitCombo.SelectedValue), projectTextBox.Text, Convert.ToInt16(isNewRadio.Checked), ExpiryDate(), ProjectExpiry());

                    MessageBox.Show(msg_true);

                }
                else
                {
                    MessageBox.Show(msg_false);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        private void Btndelete_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("لا يمكن استعادة هذا الصنف\nهل انت متأكد؟?!", "مسح الصنف؟", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                sql = "UPDATE `tblitems` SET `DELETED`=1 WHERE ITEMID='" + dtglist.CurrentRow.Cells[0].Value + "'";
                string reportFunction = "DELETE";
                Execute_CUD(sql, "error to delete", "Data has been deleted.", reportFunction);
                Btnnew_Click(sender, e);
            }
            else if (dialogResult == DialogResult.No)
            {
                
            }
            
        }
        /*
        private void Execute_CUD(string sql, string msg_false, string msg_true)
        {

            try
            {
                con.Open();
                cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = sql;
                result = cmd.ExecuteNonQuery();

                if (result > 0)
                {

                    MessageBox.Show(msg_true);

                }
                else
                {
                    MessageBox.Show(msg_false);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        */
        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Txtitemid_TextChanged(object sender, EventArgs e)
        {
            
             
        }

        private void Dtglist_Click(object sender, EventArgs e)
        {
            try
            {
                
                sql = "SELECT * FROM tblitems WHERE ITEMID='" + dtglist.CurrentRow.Cells[0].Value.ToString() + "'";
                config.SingleResult(sql);
                if (config.dt.Rows.Count > 0)
                {
                    itemID = config.dt.Rows[0].Field<string>(0);
                    itemIDTxtBox.Text = config.dt.Rows[0].Field<string>(0);
                    itemNameTextBox.Text = config.dt.Rows[0].Field<string>(1);
                    descriptionTextBox.Text = config.dt.Rows[0].Field<string>(2);
                    typeCombo.SelectedIndex = typeCombo.FindString(config.dt.Rows[0].Field<string>(3));
                    unitCombo.SelectedIndex = unitCombo.FindString(config.dt.Rows[0].Field<string>(5));
                    projectTextBox.Text = config.dt.Rows[0].Field<string>(6).ToString();

                    try
                    {
                        //MessageBox.Show("date1 " + config.dt.Rows[0].Field<DateTime>(8));
                        if (config.dt.Rows[0].Field<DateTime>(8) >= expiryDatePicker.MinDate && config.dt.Rows[0].Field<DateTime>(8) <= expiryDatePicker.MaxDate)
                        {
                            expiryDatePicker.Value = config.dt.Rows[0].Field<DateTime>(8);
                            expiryDateCheckBx.Checked = false;
                            expiryDatePicker.Enabled = true;
                        }
                        else
                        {
                            //dtglist.CurrentRow.Cells[8].Value = null;
                            expiryDateCheckBx.Checked = true;
                            expiryDatePicker.Enabled = false;
                        }
                    }
                    catch
                    {
                        // MessageBox.Show("string1 " + config.dt.Rows[0].Field<string>(8));

                        expiryDateCheckBx.Checked = true;
                        expiryDatePicker.Enabled = false;
                    }

                    try
                    {
                        //MessageBox.Show("date2 " + config.dt.Rows[0].Field<DateTime>(9));
                        if (config.dt.Rows[0].Field<DateTime>(9) >= projectExpiryPicker.MinDate && config.dt.Rows[0].Field<DateTime>(9) <= projectExpiryPicker.MaxDate)
                        {


                            projectExpiryPicker.Value = config.dt.Rows[0].Field<DateTime>(9);
                            projectExpiryCheckBx.Checked = false;
                            projectExpiryPicker.Enabled = true;
                        }
                        else
                        {
                            //dtglist.CurrentRow.Cells[9].Value = null;
                            projectExpiryCheckBx.Checked = true;
                            projectExpiryPicker.Enabled = false;
                        }
                    }
                    catch
                    {
                        // MessageBox.Show("string2 " + config.dt.Rows[0].Field<string>(9));

                        projectExpiryCheckBx.Checked = true;
                        projectExpiryPicker.Enabled = false;
                    }


                    ///////////////isNew7
                    if (config.dt.Rows[0].Field<bool>(7))
                    {
                        isNewRadio.Checked = true;
                        isNotNewRadio.Checked = false;
                    }
                    else
                    {
                        isNewRadio.Checked = false;
                        isNotNewRadio.Checked = true;
                    }


                }
            }
            catch (Exception) { }
        }
        

        

       

       

        private void Txtsearch_TextChanged(object sender, EventArgs e)
        {
            sql = "SELECT * FROM tblitems WHERE"+
                " DELETED = 0 AND ("+ 
                " ITEMID LIKE '%" + txtsearch.Text +
                "%' OR NAME LIKE '%" + txtsearch.Text +
                "%' OR DESCRIPTION LIKE '%" + txtsearch.Text +
                "%' OR PROJECT LIKE '%" + txtsearch.Text +
                "%')";
            config.Load_DTG(sql, dtglist);


            maxcolumn = dtglist.Columns.Count - 1;

            dtglist.Columns[maxcolumn].Visible = false;

        }

        

        private void IsNewRadio_CheckedChanged(object sender, EventArgs e)
        {
            //isNotNewRadio.Checked = false;
            //isNewRadio.Checked = true;
            if (isNewRadio.Checked)
                isNew = 1;
        }

        private void IsNotNewRadio_CheckedChanged(object sender, EventArgs e)
        {
            //isNewRadio.Checked = false;
            //isNotNewRadio.Checked = true;
            if (isNotNewRadio.Checked)
                isNew = 0;
        }

        private void ExpiryDateCheckBx_CheckedChanged(object sender, EventArgs e)
        {
            if (expiryDateCheckBx.Checked)
                expiryDatePicker.Enabled = false;
            else
                expiryDatePicker.Enabled = true;
        }

        private void ProjectExpiryCheckBx_CheckedChanged(object sender, EventArgs e)
        {
            if (projectExpiryCheckBx.Checked)
                projectExpiryPicker.Enabled = false;
            else
                projectExpiryPicker.Enabled = true;
        }
        
    }
}
