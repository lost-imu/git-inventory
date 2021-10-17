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
        string sql;
        int itemID;
        int maxcolumn;
        //int inc = 0;
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

            //inc = 0;
          
            sql = "SELECT * FROM tblitems where `DELETED`=0 limit 10";
            config.Load_DTG(sql, dtglist);  

            //maxcolumn = dtglist.Columns.Count - 1;

            //dtglist.Columns[maxcolumn].Visible = false;

             
            //Select_navigation("SELECT id FROM tblitems where `DELETED`=0");
            //lblmax.Text = maxrow.ToString();
            //lblinc.Text = inc.ToString();

            

            //sql = "SELECT DESCRIPTION FROM `tblsettings` WHERE `PARA`='Unit' AND DELETED=0";
            //config.Fiil_CBO(sql, unitCombo);


            funct.clearTxt(pnl_stockmaster);

        }

        private void FrmItems_Load(object sender, EventArgs e)
        {
            
            this.WindowState = FormWindowState.Maximized;
            sql = "SELECT DESCRIPTION FROM `tblsettings` WHERE `PARA`='Unit' AND DELETED=0";
            config.Fiil_CBO(sql, unitCombo);
        }


        private DateTime ExpiryDate()
        {
            DateTime expiryDate = new DateTime(1000,01,01);
            



            if (!expiryDateCheckBx.Checked)
                expiryDate = expiryDatePicker.Value;
            return expiryDate;
            
        }
        private string expiryString(DateTime dt)
        {
            if (dt > DateTime.MinValue && dt < DateTime.MaxValue)
                return dt.ToString("yyyy-MM-dd");
            return null;
        }
       

        private void Btnsave_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(MyCon.GetConString());
            MySqlCommand command;
            /////////////////////////////////////////
            ///check if values are existing no blank
            foreach (Control obj in panel1.Controls)
            {
                if (obj is TextBox)
                {
                    if (string.IsNullOrWhiteSpace(obj.Text))
                    {
                        MessageBox.Show("إملأ كل الفراغات بالمعلومات المطلوبة", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }
            }
            foreach (Control obj in pnl_stockmaster.Controls)
            {
                if(obj is TextBox)
                {
                    if(string.IsNullOrWhiteSpace(obj.Text))
                    {
                        MessageBox.Show("إملأ كل الفراغات بالمعلومات المطلوبة", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }
            }
            if (qtyUpDown.Value == 0)
            {
                MessageBox.Show("Quantity is Zero!\nNothing Changed");
                return;
            }
            if (!invoice_changed)
        
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to proceed without changing the invoice date?!", "INVOICE DATE!", MessageBoxButtons.YesNo);

                    if (dialogResult == DialogResult.Yes)
                    {

                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        return;
                    }
                }
                //MessageBox.Show("Please change the invoice date");
                //return;
            


            /////////////////////////////////////////////////////////////
            ///check if exist
            sql = "SELECT id FROM tblitems WHERE " +
                   " GLINE = @GLINE" +
               " AND SLINE = @SLINE" +
               " AND NAME = @NAME" +
               " AND DESCRIPTION = @DESCRIPTION" +
               " AND BRAND = @BRAND" +
               " AND UNIT = @UNIT" +
               " AND PROJECT = @PROJECT" +
               " AND ISNEW = @ISNEW" +
               " AND EXPIRYDATE = @EXPIRYDATE;";
            //sql = "SELECT * FROM tblitems WHERE  GLINE = 'زراعة' AND SLINE = 'SLINE' AND NAME = 'قاعدة حديد' AND DESCRIPTION = 'قاعدة حديد للمزرعة (ستاند)' AND BRAND = 'Brand1' AND UNIT = 'قطعة' AND PROJECT = 'Poject1' AND ISNEW = '0' AND EXPIRYDATE = '2021-01-01';";
            try
            {
                con.Close();
                con.Open();
                command = new MySqlCommand(sql, con);
                command.Parameters.Add(new MySqlParameter("@GLINE", gLineTxtBox.Text));
                command.Parameters.Add(new MySqlParameter("@SLINE", sLineTxtBox.Text));
                command.Parameters.Add(new MySqlParameter("@NAME", itemNameTextBox.Text));
                command.Parameters.Add(new MySqlParameter("@DESCRIPTION", descriptionTextBox.Text));
                command.Parameters.Add(new MySqlParameter("@BRAND", brandTxtBox.Text));
                command.Parameters.Add(new MySqlParameter("@UNIT", unitCombo.SelectedValue.ToString()));
                command.Parameters.Add(new MySqlParameter("@PROJECT", projectTextBox.Text));
                int isnew = Convert.ToInt16(isNewRadio.Checked);
                command.Parameters.Add(new MySqlParameter("@ISNEW", isnew));
                command.Parameters.Add(new MySqlParameter("@EXPIRYDATE", expiryString(ExpiryDate())));
                string st = ExpiryDate().ToString("yyyy-MM-dd");
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

                    string s = reader.GetString("id");
                    //MessageBox.Show(reader.HasRows + "\n" + s);
                    sql = "UPDATE tblitems SET QTY =QTY + '" + qtyUpDown.Value + "' WHERE id = '" + s + "'";
                    reader.Close();
                    
                    command = new MySqlCommand(sql, con);
                    if (command.ExecuteNonQuery() > 0)
                        while (!isReported)
                        {
                            isReported =MyCon.ReportAdd(suppliertxtbox.Text, invoiveNoTxtBox.Text, invoiceDateTime.Value.ToString("yyyy-MM-dd"), itemID.ToString(), qtyUpDown.Value.ToString(), projectTextBox.Text, frmLogin.username);                            
                            
                        }
                    else
                        MessageBox.Show("حصل خطأما\nerror: 3753");
                    con.Close();
                    MessageBox.Show("تمت الإضافة بنجاح");
                }
                
                else
                {
                    //string testi = "date1: '" + expiryDate() + "'\n"+
                    //    "date2: '" + projectExpiry+"'";
                    //MessageBox.Show(testi);
                    reader.Close();
                    
                    sql = "insert into tblitems  (GLINE, SLINE , NAME, DESCRIPTION, BRAND, QTY, UNIT, PROJECT, ISNEW, EXPIRYDATE)" + //, RECIEVER_NUMBER, RECIEVER_STATE, RECIEVER_NAME)" +
                                        "VALUES (@GLINE, @SLINE , @NAME, @DESCRIPTION, @BRAND, @QTY, @UNIT, @PROJECT, @ISNEW, @EXPIRYDATE)"; //, @RECIEVER_NUMBER, @RECIEVER_STATE, @RECIEVER_NAME)";

                    command = new MySqlCommand(sql, con);
                    command.Parameters.Add(new MySqlParameter("GLINE", gLineTxtBox.Text));
                    command.Parameters.Add(new MySqlParameter("SLINE", sLineTxtBox.Text));
                    command.Parameters.Add(new MySqlParameter("NAME", itemNameTextBox.Text));
                    command.Parameters.Add(new MySqlParameter("DESCRIPTION", descriptionTextBox.Text));
                    command.Parameters.Add(new MySqlParameter("BRAND", brandTxtBox.Text));
                    command.Parameters.Add(new MySqlParameter("QTY", qtyUpDown.Value.ToString()));
                    command.Parameters.Add(new MySqlParameter("UNIT", Convert.ToString(unitCombo.SelectedValue)));
                    command.Parameters.Add(new MySqlParameter("PROJECT", projectTextBox.Text));
                    command.Parameters.Add(new MySqlParameter("ISNEW",Convert.ToInt16(isNewRadio.Checked)));
                    command.Parameters.Add(new MySqlParameter("EXPIRYDATE", ExpiryDate()));

                    //command.Parameters.Add(new MySqlParameter("RECIEVER_STATE", "Employee"));
                    //command.Parameters.Add(new MySqlParameter("RECIEVER_NAME", frmLogin.fullName));

                    if (command.ExecuteNonQuery() > 0)
                    {
                        MyCon.ReportAdd(suppliertxtbox.Text, invoiveNoTxtBox.Text, invoiceDateTime.Value.ToString("yyyyMMdd"), itemID.ToString(), qtyUpDown.Value.ToString(), projectTextBox.Text, frmLogin.username);

                        //Convert.ToString(
                        //typeCombo.SelectedValue),
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
            invoice_changed = false;
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
                " ITEMID= '" + brandTxtBox.Text + "'" +
                ", NAME= '" + itemNameTextBox.Text + "'" +
                ", DESCRIPTION = '" + descriptionTextBox.Text + "'" +
                //", TYPE = '" + typeCombo.SelectedValue + "'" +
                //", QTY = '" + qtyUpDown.Value +"'"+
                ", UNIT = '" + unitCombo.SelectedValue + "'" +
                ", PROJECT = '" + projectTextBox.Text + "'" +
                ", ISNEW = '" + isNew + "'" +
                ", EXPIRYDATE = '" + ExpiryDate() + "'" +
                //", PROJECTEXPIRY = '" + ProjectExpiry() + "'" +
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
                    //MyCon.ReportIt(reportFunaction, "All", brandTxtBox.Text, itemNameTextBox.Text, descriptionTextBox.Text, 
                        //Convert.ToString(typeCombo.SelectedValue),
                        //Convert.ToInt32(qtyUpDown.Value), Convert.ToString(unitCombo.SelectedValue), projectTextBox.Text, Convert.ToInt16(isNewRadio.Checked), ExpiryDate());//, ProjectExpiry());

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
                
                sql = "SELECT * FROM tblitems WHERE id='" + dtglist.CurrentRow.Cells[0].Value.ToString() + "'";
                config.SingleResult(sql);
                if (config.dt.Rows.Count > 0)
                {
                    itemID = config.dt.Rows[0].Field<int>("id");
                    gLineTxtBox.Text = config.dt.Rows[0].Field<string>("GLINE");
                    sLineTxtBox.Text = config.dt.Rows[0].Field<string>("SLINE");
                    projectTextBox.Text = config.dt.Rows[0].Field<string>("PROJECT");
                    brandTxtBox.Text = config.dt.Rows[0].Field<string>("BRAND");
                    itemNameTextBox.Text = config.dt.Rows[0].Field<string>("NAME");
                    descriptionTextBox.Text = config.dt.Rows[0].Field<string>("DESCRIPTION");
                    
                    ////////////////////////////
                    

                    try
                    {
                        //MessageBox.Show("date1 " + config.dt.Rows[0].Field<DateTime>(8));
                        if (config.dt.Rows[0].Field<DateTime>("EXPIRYDATE") >= expiryDatePicker.MinDate && config.dt.Rows[0].Field<DateTime>("EXPIRYDATE") <= expiryDatePicker.MaxDate)
                        {
                            expiryDatePicker.Value = config.dt.Rows[0].Field<DateTime>("EXPIRYDATE");
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

                    ///////////////isNew7
                    if (config.dt.Rows[0].Field<bool>("ISNEW"))
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
        
        private void btnReload_Click(object sender, EventArgs e)
        {
            btnReload.Text = "Reload";
            Btnnew_Click(sender, e);
        }

        private void ExpiryDateCheckBx_CheckedChanged(object sender, EventArgs e)
        {
            if (expiryDateCheckBx.Checked)
                expiryDatePicker.Enabled = false;
            else
                expiryDatePicker.Enabled = true;
        }
        bool invoice_changed = false;
        private void invoiceDateTime_ValueChanged(object sender, EventArgs e)
        {
            invoice_changed = true;
        }
    }
}
