/**
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
**/
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using DGVPrinterHelper;
using DriversAndCars;
using InventorySystem1._0.Includes;
using MySql.Data.MySqlClient;
using TextBox = System.Windows.Forms.TextBox;

namespace InventorySystem1._0
{
    public partial class frmRequest : Form
    {
        public frmRequest()
        {
            InitializeComponent();
        }

        public frmRequest(string cus_id)
        {
            InitializeComponent();

            txt_cusid.Text = cus_id;
        }

        readonly SQLConfig config = new SQLConfig();
        readonly usableFunction funct = new usableFunction();
        string sql;
        public static string recieverID, recieverName, recieverState;
        //ClsPrint pagePrint;

        private void Txt_cusid_TextChanged(object sender, EventArgs e)
        {

            if (isEmployeeCombo.SelectedIndex == 0)
            {
                sql = "SELECT * FROM `tblperson` WHERE `SUPLIERCUSTOMERID`='" + txt_cusid.Text + "'";
                config.SingleResult(sql);
                if (config.dt.Rows.Count > 0)
                {
                    txtCus_fname.Text = config.dt.Rows[0].Field<string>("FIRSTNAME");
                    txtCus_lname.Text = config.dt.Rows[0].Field<string>("LASTNAME");
                }
                else
                {
                    txtCus_fname.Clear();
                    txtCus_lname.Clear();
                }
            }
        }

        private void FrmStockOut_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            sql = "SELECT SUPLIERCUSTOMERID FROM tblperson WHERE TYPE = 'CUSTOMER'";
            config.Autocomplete(sql, txt_cusid);

            // sql = "SELECT `ITEMID` as 'Item ID', `NAME` as 'Name', `DESCRIPTION` as 'Description', `TYPE` as 'Type', `QTY` as 'Quantity', `UNIT` as 'Unit', `PROJECT` as 'Project', case when ISNEW =0 then 'Old' else 'New' END as 'New-Old', case when `EXPIRYDATE` IS NULL then '' ELSE `EXPIRYDATE` END as 'Expiry Date', `PROJECTEXPIRY` as 'Project Expiry', `NOTE` as 'Notes' FROM `tblitems`";

            //sql = "SELECT `ITEMID` as 'Item ID', `NAME` as 'Name', `DESCRIPTION` as 'Description', `TYPE` as 'Type', `QTY` as 'Quantity', `UNIT` as 'Unit', `PROJECT` as 'Project', case when ISNEW =0 then 'Old' else 'New' END as 'New-Old', CASE WHEN `EXPIRYDATE` BETWEEN '2010-01-01' AND '2100-01-31' THEN `EXPIRYDATE` ELSE 'N/A' END as 'Expiry Date', CASE WHEN `PROJECTEXPIRY` BETWEEN '2010-01-01' AND '2100-01-31' THEN `PROJECTEXPIRY` ELSE 'N/A' END as 'Project Expiry', `NOTE` as 'Notes' FROM `tblitems`";
            sql = "SELECT `id` as 'رقم الصنف'," +
                " `NAME` as 'الاسم'," +
                " `DESCRIPTION` as 'الشرح'," +
                " `TYPE` as 'النوع'," +
                " `QTY` as 'الكمية المتوفرة', " +
                 " `HOLD` as 'الكمية المحجوزة'," +
                "`UNIT` as 'الوحدة'," +
                " `PROJECT` as 'المشروع'," +
                " case when ISNEW =0 then 'مستعمل' else 'جديد' END as 'جديد-مستعمل', " +
                "CASE WHEN `EXPIRYDATE` BETWEEN '2010-01-01' AND '2100-01-31' THEN `EXPIRYDATE` ELSE 'N/A' END as 'انتهاء الصلاحية'," +
                //" CASE WHEN `PROJECTEXPIRY` BETWEEN '2010-01-01' AND '2100-01-31' THEN `PROJECTEXPIRY` ELSE 'N/A' END as 'انتهاء المشروع'," +
                " `NOTE` as 'ملاحظات'" +
                " FROM `tblitems`";


            config.Load_DTG(sql, dtgCus_itemlist);
            funct.ResponsiveDtg(dtgCus_itemlist);
            scannerTxtBox.Focus();




        }
        private void FillEmpNameCombo()
        {
            sql = "SELECT concat(`FIRSTNAME`,' ',`LASTNAME`) FROM `tblperson` " +
                "WHERE `TYPE`='CUSTOMER' ORDER BY `concat(``FIRSTNAME``,' ',``LASTNAME``)` ASC ";
            config.Fiil_CBO(sql, empNameComboBox);
        }
        private void Txtsearch_TextChanged(object sender, KeyEventArgs e)
        {


            if (e.KeyCode != Keys.Return)
                //.ToString().ToLower() != "return")
                return;
            if (string.IsNullOrWhiteSpace(txtsearch.Text) || string.IsNullOrEmpty(txtsearch.Text))
                return;

            if (string.IsNullOrWhiteSpace(scannerTxtBox.Text))
                sql = "SELECT `id` as 'رقم الصنف'," +
                    " `NAME` as 'الاسم'," +
                    " `DESCRIPTION` as 'الشرح', " +
                    "`TYPE` as 'النوع'," +
                    " `QTY` as 'الكمية المتوفرة'," +
                    " `HOLD` as 'الكمية المحجوزة'," +
                    " `UNIT` as 'الوحدة'," +
                    " `PROJECT` as 'المشروع'," +
                    " case when ISNEW =0 then 'مستعمل' else 'جديد' END as 'جديد-مستعمل'," +
                    " CASE WHEN `EXPIRYDATE` BETWEEN '2010-01-01' AND '2100-01-31' THEN `EXPIRYDATE` ELSE 'N/A' END as 'انتهاء الصلاحية'," +
                    //" CASE WHEN `PROJECTEXPIRY` BETWEEN '2010-01-01' AND '2100-01-31' THEN `PROJECTEXPIRY` ELSE 'N/A' END as 'انتهاء المشروع', " +
                    "`NOTE` as 'ملاحظات'" +
                    " FROM `tblitems` WHERE QTY>=0 AND(" +
                    " `NAME` like '%" + txtsearch.Text + "%' " +
                    "or `DESCRIPTION` like '%" + txtsearch.Text + "%' " +
                    "or `id` like '%" + txtsearch.Text + "%')" +
                    " ORDER BY `الكمية المتوفرة` DESC;";
            else
            {
                sql = "SELECT `id` as 'رقم الصنف'," +
                " `NAME` as 'الاسم'," +
                " `DESCRIPTION` as 'الشرح', " +
                "`TYPE` as 'النوع'," +
                " `QTY` as 'الكمية المتوفرة'," +
                " `HOLD` as 'الكمية المحجوزة'," +
                " `UNIT` as 'الوحدة'," +
                " `PROJECT` as 'المشروع'," +
                " case when ISNEW =0 then 'مستعمل' else 'جديد' END as 'جديد-مستعمل'," +
                " CASE WHEN `EXPIRYDATE` BETWEEN '2010-01-01' AND '2100-01-31' THEN `EXPIRYDATE` ELSE 'N/A' END as 'انتهاء الصلاحية'," +
                //" CASE WHEN `PROJECTEXPIRY` BETWEEN '2010-01-01' AND '2100-01-31' THEN `PROJECTEXPIRY` ELSE 'N/A' END as 'انتهاء المشروع', " +
                "`NOTE` as 'ملاحظات'" +
                " FROM `tblitems` WHERE QTY>=0 AND" +
                " `id` = '" + txtsearch.Text + "'" +
                " ORDER BY `الكمية المتوفرة` DESC;";
            }
            //sql = "SELECT `ITEMID` as 'رقم الصنف', `NAME` as 'الاسم', `DESCRIPTION` as 'الشرح', `TYPE` as 'النوع', `QTY` as 'الكمية المتوفرة', `UNIT` as 'الوحدة', `PROJECT` as 'المشروع', case when ISNEW =0 then 'مستعمل' else 'جديد' END as 'جديد-مستعمل', CASE WHEN `EXPIRYDATE` BETWEEN '2010-01-01' AND '2100-01-31' THEN `EXPIRYDATE` ELSE 'N/A' END as 'انتهاء الصلاحية', CASE WHEN `PROJECTEXPIRY` BETWEEN '2010-01-01' AND '2100-01-31' THEN `PROJECTEXPIRY` ELSE 'N/A' END as 'انتهاء المشروع', `NOTE` as 'ملاحظات' FROM `tblitems`";

            //sql = "SELECT `ITEMID` as 'رقم الصنف', `NAME` as 'الاسم', `DESCRIPTION` as 'الشرح', `PRICE` as 'السعر', `QTY` as 'الكمية المتوفرة' FROM `tblitems` WHERE  `NAME` like '%" + txtsearch.Text + "%' or `DESCRIPTION` like '%" + txtsearch.Text + "%' or `ITEMID` like '%" + txtsearch.Text + "%'";
            config.Load_DTG(sql, dtgCus_itemlist);
            funct.ResponsiveDtg(dtgCus_itemlist);
        }

        private void DtgCus_itemlist_DoubleClick(object sender, EventArgs e)
        {
            double tot;
            int qty;
            //MessageBox.Show("test");
            if (dtCus_addedlist.RowCount == 0)
            {
                string expiryDate;
                /**
                string isNew = "جديد";
                if (dtgCus_itemlist.CurrentRow.Cells["ISNEW"].Value.ToString().ToLower() is "false" ||
                    dtgCus_itemlist.CurrentRow.Cells["ISNEW"].Value.ToString() is "0" ||
                    dtgCus_itemlist.CurrentRow.Cells["ISNEW"].Value.ToString() is "مستعمل" ||
                    dtgCus_itemlist.CurrentRow.Cells["ISNEW"].Value.ToString().ToLower() is "old")
                    isNew = "مستعمل";
                **/
                if (dtgCus_itemlist.CurrentRow.Cells["EXPIRYDATE"].Value.ToString() == "1000-01-01")
                    expiryDate = "N/A";
                //expiryDate = null;
                else
                    expiryDate = dtgCus_itemlist.CurrentRow.Cells["EXPIRYDATE"].Value.ToString();
                
                qty = 1;
                _ = double.Parse(dtgCus_itemlist.CurrentRow.Cells[4].Value.ToString()) * 1;
                string[] row = new string[] { 
                    dtgCus_itemlist.CurrentRow.Cells["id"].Value.ToString(),
                    dtgCus_itemlist.CurrentRow.Cells["GLINE"].Value.ToString(),
                    dtgCus_itemlist.CurrentRow.Cells["SLINE"].Value.ToString(),
                    dtgCus_itemlist.CurrentRow.Cells["NAME"].Value.ToString(),
                    qty.ToString(),
                    dtgCus_itemlist.CurrentRow.Cells["HOLD"].Value.ToString(),
                    dtgCus_itemlist.CurrentRow.Cells["UNIT"].Value.ToString(),
                    dtgCus_itemlist.CurrentRow.Cells["DESCRIPTION"].Value.ToString(),
                    dtgCus_itemlist.CurrentRow.Cells["BRAND"].Value.ToString(),
                    dtgCus_itemlist.CurrentRow.Cells["PROJECT"].Value.ToString(),
                    dtgCus_itemlist.CurrentRow.Cells["ISNEW"].Value.ToString(),
                    //dtgCus_itemlist.CurrentRow.Cells[7].Value.ToString(),
                    //dtgCus_itemlist.CurrentRow.Cells[8].Value.ToString(),
                    //Convert.ToDateTime(dtgCus_itemlist.CurrentRow.Cells[9].Value).Date.ToString("yyyy-MM-dd"),
                    expiryDate,
                    //projectExpiry,
                    //dtgCus_itemlist.CurrentRow.Cells[10].Value.ToString(),
                    // qty.ToString()
                    // tot.ToString()
                };

                dtCus_addedlist.Rows.Add(row);


            }
            else
            {
                foreach (DataGridViewRow r in dtCus_addedlist.Rows)
                {

                    if (dtgCus_itemlist.CurrentRow.Cells[0].Value == r.Cells[0].Value)
                    {
                        //r.Cells[4].Value = Convert.ToString(Convert.ToInt32(r.Cells[4].Value) +1);
                        //MessageBox.Show(dtgCus_itemlist.CurrentRow.Cells[4].Value.ToString());

                        //int i = Convert.ToInt32(dtgCus_itemlist.CurrentRow.Cells[0].Value);

                        //dtCus_addedlist.CurrentRow.Cells[4].Value = ((Convert.ToInt32(dtCus_addedlist.CurrentRow.Cells[4].Value)+1).ToString());
                        MessageBox.Show("الصنف موجود في القائمة\nيمكنك تعديل الكمية المطلوبة في قائمة الاصناف المطلوبة أدناه", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }

                if (dtCus_addedlist.CurrentRow.Cells[0].Value != dtgCus_itemlist.CurrentRow.Cells[0].Value)
                {
                    ////////////////////////
                    string expiryDate;
                    /**
                    string isNew = "جديد";
                    if (dtgCus_itemlist.CurrentRow.Cells["ISNEW"].Value.ToString().ToLower() is "false" ||
                        dtgCus_itemlist.CurrentRow.Cells["ISNEW"].Value.ToString() is "0" ||
                        dtgCus_itemlist.CurrentRow.Cells["ISNEW"].Value.ToString() is "مستعمل" ||
                        dtgCus_itemlist.CurrentRow.Cells["ISNEW"].Value.ToString().ToLower() is "old")
                        isNew = "مستعمل";
                    **/
                    if (dtgCus_itemlist.CurrentRow.Cells["EXPIRYDATE"].Value.ToString() == "1000-01-01")
                        expiryDate = "N/A";
                    //expiryDate = null;
                    else
                        expiryDate = dtgCus_itemlist.CurrentRow.Cells["EXPIRYDATE"].Value.ToString();

                    qty = 1;
                    _ = double.Parse(dtgCus_itemlist.CurrentRow.Cells[4].Value.ToString()) * 1;
                    string[] row = new string[] {
                    dtgCus_itemlist.CurrentRow.Cells["id"].Value.ToString(),
                    dtgCus_itemlist.CurrentRow.Cells["GLINE"].Value.ToString(),
                    dtgCus_itemlist.CurrentRow.Cells["SLINE"].Value.ToString(),
                    dtgCus_itemlist.CurrentRow.Cells["NAME"].Value.ToString(),
                    qty.ToString(),
                    dtgCus_itemlist.CurrentRow.Cells["HOLD"].Value.ToString(),
                    dtgCus_itemlist.CurrentRow.Cells["UNIT"].Value.ToString(),
                    dtgCus_itemlist.CurrentRow.Cells["DESCRIPTION"].Value.ToString(),
                    dtgCus_itemlist.CurrentRow.Cells["BRAND"].Value.ToString(),
                    dtgCus_itemlist.CurrentRow.Cells["PROJECT"].Value.ToString(),
                    dtgCus_itemlist.CurrentRow.Cells["ISNEW"].Value.ToString(),
                    //dtgCus_itemlist.CurrentRow.Cells[7].Value.ToString(),
                    //dtgCus_itemlist.CurrentRow.Cells[8].Value.ToString(),
                    //Convert.ToDateTime(dtgCus_itemlist.CurrentRow.Cells[9].Value).Date.ToString("yyyy-MM-dd"),
                    expiryDate,
                    //projectExpiry,
                    //dtgCus_itemlist.CurrentRow.Cells[10].Value.ToString(),
                    // qty.ToString()
                    // tot.ToString()
                };

                    dtCus_addedlist.Rows.Add(row);
                    ////////////////////
                }
                else
                {
                    MessageBox.Show("الصنف موجود في القائمة\nيمكنك تعديل الكمية المطلوبة في قائمة الاصناف المطلوبة أدناه", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    //MessageBox.Show("Item is already in the cart", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }



            }


        }




        private void DtCus_addedlist_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {//1234
            double total;
            if (dtCus_addedlist.CurrentCell.ColumnIndex == 4)
            {
                foreach (DataGridViewRow row in dtCus_addedlist.Rows)
                {
                    total = double.Parse(row.Cells[4].Value.ToString()) * double.Parse(row.Cells[4].Value.ToString());
                    //row.Cells[5].Value = total;
                }
            }
        }
        private void BtnCus_save_not_emp(object sender, EventArgs e)
        {
            {
                //MessageBox.Show("index: " + isEmployeeCombo.SelectedIndex + "\nitem: " + isEmployeeCombo.SelectedItem + "\nvalue: " + isEmployeeCombo.SelectedValue);

                _ = config.dt.Rows[0].Field<string>(0);

                foreach (Control t in Panel1.Controls)
                    if (t is System.Windows.Forms.TextBox)
                    {

                        if (string.IsNullOrEmpty(t.Text) || string.IsNullOrWhiteSpace(t.Text))
                        {
                            MessageBox.Show("تأكد أنك أدخلت كل المعلومات المطلوبة", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            //MessageBox.Show("There are empty fields left that must be fill up!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                    }
                if (dtCus_addedlist.RowCount == 0)
                {
                    MessageBox.Show("لم تضف أي صنف", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //MessageBox.Show("Cart is empty!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                sql = "SELECT id,`QTY` FROM `tblitems`";
                config.SingleResult(sql);

                foreach (DataRow row in config.dt.Rows)
                {
                    for (int i = 0; i < dtCus_addedlist.Rows.Count; i++)
                    {
                        if (dtCus_addedlist.Rows[i].Cells[0].Value.ToString() == row.Field<string>(0))
                        {
                            if (double.Parse(dtCus_addedlist.Rows[i].Cells[4].Value.ToString()) > row.Field<double>(1))
                            {
                                MessageBox.Show("غير متوفرة  ( " + dtCus_addedlist.Rows[i].Cells[1].Value.ToString() + " ) الكمية المطلوبة من  ", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                return;
                            }
                        }
                        if (dtCus_addedlist.Rows[i].Cells[4].Value.ToString() == "")
                        {
                            MessageBox.Show("Set your purpose.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                    }
                }

                foreach (DataGridViewRow r in dtCus_addedlist.Rows)
                {
                    /*
                    sql = "INSERT INTO `tblstock_in_out` ( `TRANSACTIONNUMBER`, `ITEMID`, `TRANSACTIONDATE`, `QTY`, `TOTALPRICE`, `SUPLIERCUSTOMERID`,REMARKS)" +
                    " VALUES ('" + stockoutID + "','" + r.Cells[0].Value + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "','" + r.Cells[4].Value +
                    "','" + r.Cells[5].Value + "','" + txt_cusid.Text + "','StockOut')";
                    Execute_Query(sql,r);
                    */
                    sql = "UPDATE `tblitems`  SET `QTY`= QTY - '" + r.Cells[4].Value + "' WHERE id='" + r.Cells[0].Value + "'";
                    Execute_Query(sql, r, "Stock Out");
                }




                // sql = "INSERT INTO  `tbltransaction` (`TRANSACTIONNUMBER`,  `TRANSACTIONDATE`,  `TYPE`, `SUPLIERCUSTOMERID`)" +
                //        " VALUES ('" + stockoutID + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "','StockOut','" + txt_cusid.Text + "')";
                // config.Execute_Query(sql);

                // '-----------------------------------------------update autonumber
                config.Execute_Query("UPDATE tblautonumber SET END= END + INCREMENT WHERE ID = 5");

                // '------------------------------------------------------------
                PrintLastBtn(sender, e);
                MessageBox.Show("تم");
                //MessageBox.Show("Item(s) has been saved in the database.");
                // '------------------------------------------------------------clearing
                funct.clearTxt(Panel1);
                dtCus_addedlist.Rows.Clear();

                FrmStockOut_Load(sender, e);
            }
        }
        private void BtnCus_save_emp(object sender, EventArgs e)
        {//////////////////////////////
            int count = 1;
            string[,] items = new string[100, 2];

            if (string.IsNullOrEmpty(frmLogin.username))
            {
                MessageBox.Show("You Are Not LoggedIn", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //MessageBox.Show("There are empty fields left that must be fill up!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txt_cusid.Text == "")
            {
                MessageBox.Show("تأكد أنك أدخلت كل المعلومات المطلوبة", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //MessageBox.Show("There are empty fields left that must be fill up!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (dtCus_addedlist.RowCount == 0)
            {
                MessageBox.Show("لم تضف أي صنف", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //MessageBox.Show("Cart is empty!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            //////////////////////////////////////////
            if (string.IsNullOrWhiteSpace(projecttxtbox.Text))
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to proceed without a project name?!", "لم تختر إسم المشروع", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {

                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }
            }
            //////////////////////////////////////

            sql = "SELECT `id`,`QTY`,`HOLD` FROM `tblitems`";
            config.SingleResult(sql);
            MySqlConnection conn = new MySqlConnection(MyCon.GetConString());
            conn.Open();

            foreach (DataRow row in config.dt.Rows)
            {
                for (int i = 0; i < dtCus_addedlist.Rows.Count; i++)
                {
                    if (Convert.ToInt32(dtCus_addedlist.Rows[i].Cells[0].Value) == row.Field<Int32>(0))
                    {
                        double a = double.Parse(dtCus_addedlist.Rows[i].Cells[4].Value.ToString());
                        double b = double.Parse(dtCus_addedlist.Rows[i].Cells[5].Value.ToString());
                        double c = row.Field<double>(1);
                        if (!(a + b <= c))
                        {
                            MessageBox.Show("غير متوفرة  ( " + dtCus_addedlist.Rows[i].Cells[1].Value.ToString() + " ) الكمية المطلوبة من  ", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                    }
                    if (dtCus_addedlist.Rows[i].Cells[4].Value.ToString() == "")
                    {
                        MessageBox.Show("Set your purpose.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }
            }
            //////////////////////////////////////////////
            ///
            int newmax = 0;
            string sql2 = "SELECT MAX(id) as max FROM `lost_new_inventory`.`tblrequest`;";
            MySqlCommand cmd = new MySqlCommand(sql2, conn);
            //cmd.Parameters.Add("@Name", SqlDbType.VarChar);
            //cmd.Parameters["@name"].Value = newName;
            try
            {
                newmax = 1 + (int)(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            if (newmax == 0)
            {
                MessageBox.Show("Somthing went wrong\nERROR_CODE 8594");
                return;
            }
            //////////////////////////////////////////////////
            ///
            openRequest(newmax);
            foreach (DataGridViewRow r in dtCus_addedlist.Rows)
            {
                sql = "UPDATE `tblitems`  SET `HOLD`= `HOLD` + '" + r.Cells[4].Value + "' WHERE id='" + r.Cells[0].Value + "'";

                items[count, 0] = r.Cells[0].Value.ToString();
                items[count, 1] = r.Cells[4].Value.ToString();
                count++;
                Execute_Query(sql, r, newmax.ToString());
                //sql = ""
            }

            //PrintLastBtn(sender, e);

            dtCus_addedlist.Rows.Clear();
            items[0, 0] = count.ToString();

            funct.clearTxt(Panel1);
            FrmStockOut_Load(sender, e);

            MessageBox.Show("تم");
        }

        private void openRequest(int id)
        {
            //////////////
            //for (int i = 1; i <= Convert.ToInt32(items[0, 0]); i++) {
            sql = "INSERT INTO `tblrequest` (`id`,`project`,`req_by`, `picked_by`, `state`) VALUES (@id,@project,@req_by, @picked_by,'1');";
            MySqlConnection conn = new MySqlConnection(MyCon.GetConString());
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.Add(new MySqlParameter("@id", id));
            cmd.Parameters.Add(new MySqlParameter("@project", projecttxtbox.Text));
            cmd.Parameters.Add(new MySqlParameter("@req_by", frmLogin.username));
            cmd.Parameters.Add(new MySqlParameter("@picked_by", txt_cusid.Text));
            conn.Open();
            if (!(cmd.ExecuteNonQuery() > 0))
            {
                MessageBox.Show("request not sent\nEROOR_CODE 7429");
            }
            conn.Close();

        }
        private void BtnCus_save_Click(object sender, EventArgs e)
        {

            foreach (Control c in Panel1.Controls)

                recieverID = txt_cusid.Text;
            recieverName = txtCus_fname.Text + " " + txtCus_lname.Text;
            
            if (isEmployeeCombo.SelectedIndex == 0)
            {
                recieverState = "Employee";
                BtnCus_save_emp(sender, e);

            }
            else
            {
                recieverState = "Not Employee";
                BtnCus_save_not_emp(sender, e);
            }
        }


        private void Execute_Query(string sql, DataGridViewRow r, string reqid)
        {
            MySqlConnection con = new MySqlConnection(MyCon.GetConString());
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            string item_id = r.Cells[0].Value.ToString(),
                req_id = reqid,
                qty = r.Cells[4].Value.ToString();

            try
            {
                int result;
                cmd.Connection = con;
                cmd.CommandText = sql;
                cmd = new MySqlCommand
                {
                    Connection = con,
                    CommandText = sql
                };
                result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    string reportSQL = "INSERT INTO `tblstockout` (`req_id`, `item_id`, `qty`) VALUES (@req_id , @item_id, @qty);";
                    
                    cmd = new MySqlCommand
                    {
                        Connection = con,
                        CommandText = reportSQL
                    };

                    cmd.Parameters.Add(new MySqlParameter("@req_id", req_id));
                    cmd.Parameters.Add(new MySqlParameter("@item_id", item_id));
                    cmd.Parameters.Add(new MySqlParameter("@qty", qty));
                    if (cmd.ExecuteNonQuery() > 0)
                    return;

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
        private void BtnCus_Remove_Click(object sender, EventArgs e)
        {
            dtCus_addedlist.Rows.Remove(dtCus_addedlist.CurrentRow);
        }

        private void BtnCus_clear_Click(object sender, EventArgs e)
        {
            dtCus_addedlist.Rows.Clear();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnviewStockout_Click(object sender, EventArgs e)
        {
            frmListStockout frm = new frmListStockout();
            frm.Show();
        }



        private void ReturnBtn_Click(object sender, EventArgs e)
        {/**
            string file = "test.properties";
            IDictionary<string, string> properties;

            var data = new Dictionary<string, string>();
            foreach (var row in File.ReadAllLines("PATH_TO_FILE"))
                data.Add(row.Split('=')[0], string.Join("=", row.Split('=').Skip(1).ToArray()));

            Console.WriteLine(data["ServerName"]);
            **/
            /**
            recieverID = txt_cusid.Text;
            recieverName = txtCus_fname.Text + " " + txtCus_lname.Text;

            if (isEmployeeCombo.SelectedIndex == 0)
            {
                recieverState = "Employee";
                ReturnBtn_Click_emp(sender, e);
            }
            else
            {
                recieverState = "Not Employee";
                ReturnBtn_not_emp(sender, e);
            }**/
        }
        private void ReturnBtn_Click_emp(object sender, EventArgs e)
        {
            config.SingleResult("SELECT concat(STRT,END) FROM tblautonumber WHERE ID = 5");
            _ = config.dt.Rows[0].Field<string>(0);

            if (txt_cusid.Text == "")
            {
                MessageBox.Show("تأكد أنك أدخلت كل المعلومات المطلوبة", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //MessageBox.Show("There are empty fields left that must be fill up!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (dtCus_addedlist.RowCount == 0)
            {
                MessageBox.Show("لم تضف أي صنف", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //MessageBox.Show("Cart is empty!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            /*
            sql = "SELECT ITEMID,`QTY` FROM `tblitems`";
            config.singleResult(sql);

            foreach (DataRow row in config.dt.Rows)
            {
                for (int i = 0; i < dtCus_addedlist.Rows.Count; i++)
                {
                    if (dtCus_addedlist.Rows[i].Cells[0].Value.ToString() == row.Field<string>(0))
                    {
                        if (int.Parse(dtCus_addedlist.Rows[i].Cells[4].Value.ToString()) > row.Field<int>(1))
                        {
                            MessageBox.Show("غير متوفرة  ( " + dtCus_addedlist.Rows[i].Cells[1].Value.ToString() + " ) الكمية المطلوبة من  ", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                    }
                    if (dtCus_addedlist.Rows[i].Cells[4].Value.ToString() == "")
                    {
                        MessageBox.Show("Set your purpose.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }
            }*/

            foreach (DataGridViewRow r in dtCus_addedlist.Rows)
            {
                /*
                sql = "INSERT INTO `tblstock_in_out` ( `TRANSACTIONNUMBER`, `ITEMID`, `TRANSACTIONDATE`, `QTY`, `TOTALPRICE`, `SUPLIERCUSTOMERID`,REMARKS)" +
                " VALUES ('" + stockoutID + "','" + r.Cells[0].Value + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "','" + r.Cells[4].Value +
                "','" + r.Cells[5].Value + "','" + txt_cusid.Text + "','StockOut')";
                Execute_Query(sql,r);
                */
                sql = "UPDATE `tblitems`  SET `QTY`= QTY + '" + r.Cells[4].Value + "' WHERE id='" + r.Cells[0].Value + "'";
                Execute_Query(sql, r, "Return");
            }




            // sql = "INSERT INTO  `tbltransaction` (`TRANSACTIONNUMBER`,  `TRANSACTIONDATE`,  `TYPE`, `SUPLIERCUSTOMERID`)" +
            //        " VALUES ('" + stockoutID + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "','StockOut','" + txt_cusid.Text + "')";
            // config.Execute_Query(sql);

            // '-----------------------------------------------update autonumber
            config.Execute_Query("UPDATE tblautonumber SET END= END + INCREMENT WHERE ID = 5");

            // '------------------------------------------------------------
            MessageBox.Show("تم");
            //MessageBox.Show("Item(s) has been saved in the database.");
            // '------------------------------------------------------------clearing
            funct.clearTxt(Panel1);
            dtCus_addedlist.Rows.Clear();

            FrmStockOut_Load(sender, e);
        }

        private void ReturnBtn_not_emp(object sender, EventArgs e)
        {
            {
                //MessageBox.Show("index: " + isEmployeeCombo.SelectedIndex + "\nitem: " + isEmployeeCombo.SelectedItem + "\nvalue: " + isEmployeeCombo.SelectedValue);

                config.SingleResult("SELECT concat(STRT,END) FROM tblautonumber WHERE ID = 5");
                _ = config.dt.Rows[0].Field<string>(0);

                foreach (Control t in Panel1.Controls)
                    if (t is TextBox)
                    {

                        if (string.IsNullOrEmpty(t.Text) || string.IsNullOrWhiteSpace(t.Text))
                        {
                            MessageBox.Show("تأكد أنك أدخلت كل المعلومات المطلوبة", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            //MessageBox.Show("There are empty fields left that must be fill up!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                    }
                if (dtCus_addedlist.RowCount == 0)
                {
                    MessageBox.Show("لم تضف أي صنف", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //MessageBox.Show("Cart is empty!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                foreach (DataGridViewRow r in dtCus_addedlist.Rows)
                {

                    sql = "UPDATE `tblitems`  SET `QTY`= QTY + '" + r.Cells[4].Value + "' WHERE id='" + r.Cells[0].Value + "'";
                    Execute_Query(sql, r, "Return");
                }
                config.Execute_Query("UPDATE tblautonumber SET END= END + INCREMENT WHERE ID = 5");

                // '------------------------------------------------------------
                MessageBox.Show("تم");
                //MessageBox.Show("Item(s) has been saved in the database.");
                // '------------------------------------------------------------clearing
                funct.clearTxt(Panel1);
                dtCus_addedlist.Rows.Clear();

                FrmStockOut_Load(sender, e);
            }
        }

        private void Txt_cusid_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void TxtCus_fname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
        public DataGridView CloneDataGrid(DataGridView mainDataGridView)
        {
            DataGridView cloneDataGridView = new DataGridView();

            if (cloneDataGridView.Columns.Count == 0)
            {
                foreach (DataGridViewColumn datagrid in mainDataGridView.Columns)
                {
                    cloneDataGridView.Columns.Add(datagrid.Clone() as DataGridViewColumn);
                }
            }

            _ = new DataGridViewRow();

            for (int i = 0; i < mainDataGridView.Rows.Count; i++)
            {
                DataGridViewRow dataRow = (DataGridViewRow)mainDataGridView.Rows[i].Clone();
                int Index = 0;
                foreach (DataGridViewCell cell in mainDataGridView.Rows[i].Cells)
                {
                    dataRow.Cells[Index].Value = cell.Value;
                    Index++;
                }
                cloneDataGridView.Rows.Add(dataRow);
            }
            cloneDataGridView.AllowUserToAddRows = false;
            cloneDataGridView.Refresh();


            return cloneDataGridView;
        }
        private void printerEmpty()
        {
            printer = new DGVPrinter
            {
                Title = "فاتورة إستلام من المستودع",

                SubTitle = "التاريخ: " + DateTime.Now.ToString("dd-MM-yyyy HH:mm"),

                SubTitleFormatFlags = StringFormatFlags.LineLimit |

                                          StringFormatFlags.NoClip,


                PageNumbers = true,

                ShowTotalPageNumber = true,

                PageNumberInHeader = false,

                PorportionalColumns = false,

                HeaderCellAlignment = StringAlignment.Near,

                Footer = "الجمعية اللبنانية للدراسات والتدريب",

                FooterSpacing = 15,

                PrinterName = default
            };
        }
        private void PrintLastBtn_Click(object sender, EventArgs e)
        {
            printerEmpty();
            printer.PrintDataGridView(newDGRV);
        }
        private void fillNewDGRV()
        {
            newDGRV = CloneDataGrid(dtCus_addedlist);
            newDGRV.RightToLeft = RightToLeft.Yes;
            string[] row = new string[] { "__________", "__________", "________", "__________", "________", "________", "__________", "__________", "__________", "__________" };
            newDGRV.Rows.Add(row);
            //newDGRV.Columns[0].Width *= 2; 
            row = new string[] {
                     "اسم المستلم" //0
                    ,"رقم المستلم"   //1
                    ,"الإمضاء"   //2
                    ,null   //3
                    ,null   //4
                    ,"أمين المستودع"   //5
                    ,null   //6
                    ,"رقم أمين المستودع"   //7
                    ,null   //8
                    ,null   //9
                    ,"الإمضاء"   //10
                   
                };



            newDGRV.Rows.Add(row);
            string recieverNumber, recieverName, empNumber, empName;
            recieverName = txtCus_fname.Text + " " + txtCus_lname.Text;
            recieverNumber = txt_cusid.Text;
            empNumber = frmLogin.username.ToString();
            empName = frmLogin.fullName;

            row = new string[] {
                     recieverName //0
                    ,recieverNumber   //1
                    ,null   //2
                    ,null   //3
                    ,null   //4
                    ,empName   //5
                    ,null   //6
                    ,empNumber   //7
                    ,null   //8
                    ,null   //9
                    ,null   //10
                   
                };

            newDGRV.Rows.Add(row);
            int last = newDGRV.Rows.Count - 1;

            newDGRV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            newDGRV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            newDGRV.Rows[last].Height = 30;
            newDGRV.Columns[9].Visible = false;
            newDGRV.Columns[8].Visible = false;
            newDGRV.Columns[6].Visible = false;
            newDGRV.Columns[3].Visible = false;

        }
        DGVPrinter printer;
        DataGridView newDGRV;//= DataGridView();
        private void PrintLastBtn(object sender, EventArgs e)
        {
            fillNewDGRV();

            printerEmpty();
            /*
            printer = new DGVPrinter
            {
                Title = "فاتورة إستلام من المستودع",

                SubTitle = "التاريخ: " + DateTime.Now.ToString("dd-MM-yyyy HH:mm") ,

                SubTitleFormatFlags = StringFormatFlags.LineLimit |

                                          StringFormatFlags.NoClip,


                PageNumbers = true,

                ShowTotalPageNumber = true,

                PageNumberInHeader = false,

                PorportionalColumns = false,

                HeaderCellAlignment = StringAlignment.Near,

                Footer = "الجمعية اللبنانية للدراسات والتدريب",

                FooterSpacing = 15,

                PrinterName = default
            };
            */

            // PrintOptions.FitToPage = true;

            printer.PrintDataGridView(newDGRV);
            //dtCus_addedlist =  dtCus_addedlist.Rows.Add({ "a","b"};


        }

        private void empNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "SELECT `SUPLIERCUSTOMERID` FROM `tblperson` WHERE concat(`FIRSTNAME`, ' ', `LASTNAME`) ='" + empNameComboBox.SelectedValue.ToString() + "'";
            txt_cusid.Text = MyCon.ReturnSingleResult(sql, "SUPLIERCUSTOMERID");

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void load_names_btn_Click(object sender, EventArgs e)
        {
            FillEmpNameCombo();
            config.Autocomplete(sql, txt_cusid);
        }
    
            private void txtsearch_KeyDown(object sender, KeyEventArgs e)
            {
                scannerTxtBox.Clear();
            }

       
            private void printLastBtn_Click(object sender, EventArgs e)
            {
                printerEmpty();
                printer.PrintDataGridView(newDGRV);
            }

        private void frmRequest_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            
            scannerTxtBox.Focus();
        }

        
        private void load_items_btn_Click(object sender, EventArgs e)
        {
            int limit = (int)load_items_numericUpDown.Value;
            

            // sql = "SELECT `ITEMID` as 'Item ID', `NAME` as 'Name', `DESCRIPTION` as 'Description', `TYPE` as 'Type', `QTY` as 'Quantity', `UNIT` as 'Unit', `PROJECT` as 'Project', case when ISNEW =0 then 'Old' else 'New' END as 'New-Old', case when `EXPIRYDATE` IS NULL then '' ELSE `EXPIRYDATE` END as 'Expiry Date', `PROJECTEXPIRY` as 'Project Expiry', `NOTE` as 'Notes' FROM `tblitems`";

            //sql = "SELECT `ITEMID` as 'Item ID', `NAME` as 'Name', `DESCRIPTION` as 'Description', `TYPE` as 'Type', `QTY` as 'Quantity', `UNIT` as 'Unit', `PROJECT` as 'Project', case when ISNEW =0 then 'Old' else 'New' END as 'New-Old', CASE WHEN `EXPIRYDATE` BETWEEN '2010-01-01' AND '2100-01-31' THEN `EXPIRYDATE` ELSE 'N/A' END as 'Expiry Date', CASE WHEN `PROJECTEXPIRY` BETWEEN '2010-01-01' AND '2100-01-31' THEN `PROJECTEXPIRY` ELSE 'N/A' END as 'Project Expiry', `NOTE` as 'Notes' FROM `tblitems`";
            
           
            sql = "SELECT id,"+ 
                " GLINE," +
               " SLINE," +
               " NAME," +
               " QTY," +
               " HOLD," +
               " UNIT," +
               " BRAND," +
               " DESCRIPTION," +
               " PROJECT," +
               " ISNEW," +
               " EXPIRYDATE"+
               " FROM lost_new_inventory.tblitems" +
               " WHERE QTY > 0" +
               " limit " + limit + ";";

            config.Load_DTG(sql, dtgCus_itemlist);
            funct.ResponsiveDtg(dtgCus_itemlist);
        }


        private void ScannerTxtBox_KeyDown(object sender, KeyEventArgs e)
            {
            if (e.KeyCode != Keys.Return)
                    //.ToString().ToLower() != "return")
                    return;
                if (string.IsNullOrWhiteSpace(scannerTxtBox.Text) || string.IsNullOrEmpty(scannerTxtBox.Text))
                    return;

                txtsearch.Text = scannerTxtBox.Text;
                if (dtgCus_itemlist.Rows.Count == 0)
                {
                    MessageBox.Show("هذا الصنف غير موجود");
                    return;
                }
                try
                {


                    string s = scannerTxtBox.Text;
                    // if (dtCus_addedlist.Rows.Count!=0)
                    //    dtCus_addedlist.FirstDisplayedScrollingRowIndex = 0;

                    foreach (DataGridViewRow r in dtCus_addedlist.Rows)
                    {
                        if (String.Equals(dtgCus_itemlist.CurrentRow.Cells[0].Value, r.Cells[0].Value))
                        //if (Convert.ToInt32(dtgCus_itemlist.CurrentRow.Cells[0].Value) == Convert.ToInt32(r.Cells[0].Value))
                        {
                            r.Cells[4].Value = Convert.ToString(Convert.ToInt32(r.Cells[4].Value) + 1);
                            return;
                        }
                    }
                    DtgCus_itemlist_DoubleClick(sender, e);
                    //MessageBox.Show("هذا العنصر غير موجود في القائمة");

                }
                catch (Exception) { }
                // finally { txtsearch.Text = scannerTxtBox.Text = null; }


            }

            private void IsEmployeeCombo_SelectedIndexChanged(object sender, EventArgs e)
            {
                if (isEmployeeCombo.SelectedIndex == 0)
                {
                    employeeOrPhoneNumberLabel.Text = ":رقم المستلم";
                    txtCus_lname.Enabled = false;
                    txtCus_fname.Enabled = false;
                }
                else
                {
                    employeeOrPhoneNumberLabel.Text = ":رقم الهاتف" +
                        "";
                    txtCus_lname.Enabled = true;
                    txtCus_fname.Enabled = true;
                }
            }
        }
    }

