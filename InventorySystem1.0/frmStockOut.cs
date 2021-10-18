using System;
using System.Data;
using System.Drawing;
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

    public partial class frmStockOut : Form
    {
        
        public frmStockOut(string cus_id)
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
            
            if (isEmployeeCombo.SelectedIndex==0)
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
            load_items_btn_Click(sender, e);
            /**
            sql = "SELECT SUPLIERCUSTOMERID FROM tblperson WHERE TYPE = 'CUSTOMER'";
            config.Autocomplete(sql, txt_cusid);

           

            config.Load_DTG(sql, dtgCus_itemlist);
            funct.ResponsiveDtg(dtgCus_itemlist);
            **/
            txtsearch.Focus();
            
        }
        private void load_items_btn_Click(object sender, EventArgs e)
        {
            // sql = "SELECT `ITEMID` as 'Item ID', `NAME` as 'Name', `DESCRIPTION` as 'Description', `TYPE` as 'Type', `QTY` as 'Quantity', `UNIT` as 'Unit', `PROJECT` as 'Project', case when ISNEW =0 then 'Old' else 'New' END as 'New-Old', case when `EXPIRYDATE` IS NULL then '' ELSE `EXPIRYDATE` END as 'Expiry Date', `PROJECTEXPIRY` as 'Project Expiry', `NOTE` as 'Notes' FROM `tblitems`";
            //sql = "SELECT `ITEMID` as 'Item ID', `NAME` as 'Name', `DESCRIPTION` as 'Description', `TYPE` as 'Type', `QTY` as 'Quantity', `UNIT` as 'Unit', `PROJECT` as 'Project', case when ISNEW =0 then 'Old' else 'New' END as 'New-Old', CASE WHEN `EXPIRYDATE` BETWEEN '2010-01-01' AND '2100-01-31' THEN `EXPIRYDATE` ELSE 'N/A' END as 'Expiry Date', CASE WHEN `PROJECTEXPIRY` BETWEEN '2010-01-01' AND '2100-01-31' THEN `PROJECTEXPIRY` ELSE 'N/A' END as 'Project Expiry', `NOTE` as 'Notes' FROM `tblitems`";
            sql = "SELECT `tblrequest`.`id` as 'Request ID', "+
                  "`tblrequest`.`project` as 'Project Name', "+
                  "`tblrequest`.`picked_by` as 'Pick by',"+
                  "(SELECT concat(`tblperson`.`FIRSTNAME`, ' ', `tblperson`.`LASTNAME`) FROM `lost_new_inventory`.`tblperson` where `tblperson`.`SUPLIERCUSTOMERID`=`tblrequest`.`picked_by`)  as 'Name' "+
                  "FROM `tblrequest`,`tblperson` where `tblrequest`.`state` = 1 and `tblperson`.`SUPLIERCUSTOMERID`=`tblrequest`.`picked_by`; ";
            config.Load_DTG(sql, dtgCus_itemlist);
            funct.ResponsiveDtg(dtgCus_itemlist);
        }
        private void FillEmpNameCombo()
        {
            sql = "SELECT concat(`FIRSTNAME`,' ',`LASTNAME`) FROM `tblperson` "+
                "WHERE `TYPE`='CUSTOMER' ORDER BY `concat(``FIRSTNAME``,' ',``LASTNAME``)` ASC ";
            config.Fiil_CBO(sql, empNameComboBox);
        }
        private void Txtsearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(scannerTxtBox.Text))
                sql = "SELECT `ITEMID` as 'رقم الصنف'," +
                    " `NAME` as 'الاسم'," +
                    " `DESCRIPTION` as 'الشرح', " +
                    "`TYPE` as 'النوع'," +
                    " `QTY` as 'الكمية المتوفرة'," +
                    " `UNIT` as 'الوحدة'," +
                    " `PROJECT` as 'المشروع'," +
                    " case when ISNEW =0 then 'مستعمل' else 'جديد' END as 'جديد-مستعمل'," +
                    " CASE WHEN `EXPIRYDATE` BETWEEN '2010-01-01' AND '2100-01-31' THEN `EXPIRYDATE` ELSE 'N/A' END as 'انتهاء الصلاحية'," +
                    " CASE WHEN `PROJECTEXPIRY` BETWEEN '2010-01-01' AND '2100-01-31' THEN `PROJECTEXPIRY` ELSE 'N/A' END as 'انتهاء المشروع', " +
                    "`NOTE` as 'ملاحظات'" +
                    " FROM `tblitems` WHERE QTY>=0 AND(" +
                    " `NAME` like '%" + txtsearch.Text + "%' " +
                    "or `DESCRIPTION` like '%" + txtsearch.Text + "%' " +
                    "or `ITEMID` like '%" + txtsearch.Text + "%')" +
                    " ORDER BY `الكمية المتوفرة` DESC;";
            else
            {
                sql = "SELECT `ITEMID` as 'رقم الصنف'," +
                " `NAME` as 'الاسم'," +
                " `DESCRIPTION` as 'الشرح', " +
                "`TYPE` as 'النوع'," +
                " `QTY` as 'الكمية المتوفرة'," +
                " `UNIT` as 'الوحدة'," +
                " `PROJECT` as 'المشروع'," +
                " case when ISNEW =0 then 'مستعمل' else 'جديد' END as 'جديد-مستعمل'," +
                " CASE WHEN `EXPIRYDATE` BETWEEN '2010-01-01' AND '2100-01-31' THEN `EXPIRYDATE` ELSE 'N/A' END as 'انتهاء الصلاحية'," +
                " CASE WHEN `PROJECTEXPIRY` BETWEEN '2010-01-01' AND '2100-01-31' THEN `PROJECTEXPIRY` ELSE 'N/A' END as 'انتهاء المشروع', " +
                "`NOTE` as 'ملاحظات'" +
                " FROM `tblitems` WHERE QTY>=0 AND" +
                " `ITEMID` = '" + txtsearch.Text + "'" +
                " ORDER BY `الكمية المتوفرة` DESC;";
            }
            //sql = "SELECT `ITEMID` as 'رقم الصنف', `NAME` as 'الاسم', `DESCRIPTION` as 'الشرح', `TYPE` as 'النوع', `QTY` as 'الكمية المتوفرة', `UNIT` as 'الوحدة', `PROJECT` as 'المشروع', case when ISNEW =0 then 'مستعمل' else 'جديد' END as 'جديد-مستعمل', CASE WHEN `EXPIRYDATE` BETWEEN '2010-01-01' AND '2100-01-31' THEN `EXPIRYDATE` ELSE 'N/A' END as 'انتهاء الصلاحية', CASE WHEN `PROJECTEXPIRY` BETWEEN '2010-01-01' AND '2100-01-31' THEN `PROJECTEXPIRY` ELSE 'N/A' END as 'انتهاء المشروع', `NOTE` as 'ملاحظات' FROM `tblitems`";

            //sql = "SELECT `ITEMID` as 'رقم الصنف', `NAME` as 'الاسم', `DESCRIPTION` as 'الشرح', `PRICE` as 'السعر', `QTY` as 'الكمية المتوفرة' FROM `tblitems` WHERE  `NAME` like '%" + txtsearch.Text + "%' or `DESCRIPTION` like '%" + txtsearch.Text + "%' or `ITEMID` like '%" + txtsearch.Text + "%'";
            config.Load_DTG(sql, dtgCus_itemlist);
            funct.ResponsiveDtg(dtgCus_itemlist);
        }
        int req_id = 0;
        private void DtgCus_itemlist_DoubleClick(object sender, EventArgs e)
        {
            req_id = Convert.ToInt32(dtgCus_itemlist.CurrentRow.Cells[0].Value);
                //config.dt.Rows[0].Field<int>("id");
            this.Enabled = false;
            // sql = "SELECT `ITEMID` as 'Item ID', `NAME` as 'Name', `DESCRIPTION` as 'Description', `TYPE` as 'Type', `QTY` as 'Quantity', `UNIT` as 'Unit', `PROJECT` as 'Project', case when ISNEW =0 then 'Old' else 'New' END as 'New-Old', case when `EXPIRYDATE` IS NULL then '' ELSE `EXPIRYDATE` END as 'Expiry Date', `PROJECTEXPIRY` as 'Project Expiry', `NOTE` as 'Notes' FROM `tblitems`";
            //sql = "SELECT `ITEMID` as 'Item ID', `NAME` as 'Name', `DESCRIPTION` as 'Description', `TYPE` as 'Type', `QTY` as 'Quantity', `UNIT` as 'Unit', `PROJECT` as 'Project', case when ISNEW =0 then 'Old' else 'New' END as 'New-Old', CASE WHEN `EXPIRYDATE` BETWEEN '2010-01-01' AND '2100-01-31' THEN `EXPIRYDATE` ELSE 'N/A' END as 'Expiry Date', CASE WHEN `PROJECTEXPIRY` BETWEEN '2010-01-01' AND '2100-01-31' THEN `PROJECTEXPIRY` ELSE 'N/A' END as 'Project Expiry', `NOTE` as 'Notes' FROM `tblitems`";
            sql = "SELECT  `tblitems`.`id`,`tblitems`.`GLINE`,`tblitems`.`SLINE`,`tblitems`.`NAME`,`tblitems`.`DESCRIPTION`," +
                "`tblitems`.`BRAND`,`tblstockout`.`qty`," +
                //"`tblitems`.`HOLD`," +
                "`tblitems`.`UNIT`,`tblitems`.`PROJECT`,`tblitems`.`ISNEW`,`tblitems`.`EXPIRYDATE`" +
                  "FROM `lost_new_inventory`.`tblstockout` ,`lost_new_inventory`.`tblitems`" +
                  "where  `tblstockout`.`item_id`=`tblitems`.`id` AND `tblstockout`.`req_id`= "+req_id+";";
            config.Load_DTG(sql, dtCus_addedlist);
            funct.ResponsiveDtg(dtgCus_itemlist);
            this.Enabled = true;
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
        private void BtnCus_save_emp(object sender, EventArgs e)
        {
            
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
            //if (string.IsNullOrWhiteSpace(projecttxtbox.Text))
            //{
            //    DialogResult dialogResult = MessageBox.Show("Are you sure you want to proceed without a project name?!", "لم تختر إسم المشروع", MessageBoxButtons.YesNo);

            //    if (dialogResult == DialogResult.Yes)
            //    {

            //    }
            //    else if (dialogResult == DialogResult.No)
            //    {
            //        return;
            //    }
            //}
            //////////////////////////////////////

            //////////////////////////////////////////////
            ///

            if (req_id == 0)
            {
                MessageBox.Show("Request ID is not recognized\nSomething went wrong!");
                return;
            }
            foreach (DataGridViewRow r in dtCus_addedlist.Rows)
            {
                //sql = "UPDATE `tblitems`  SET `HOLD`= `HOLD` - '" + r.Cells[4].Value + "' WHERE id='" + r.Cells[0].Value + "'";
                sql = "UPDATE `tblitems`  SET `qty` = `qty`- "+ r.Cells[6].Value + " , `HOLD`= `HOLD` - "+ r.Cells[6].Value + " where id ="+ r.Cells[0].Value + ";";
                Execute_Query(sql);
                //sql = ""
            }

            sql = "UPDATE tblrequest SET state = 2,picked_by_real = "+ txt_cusid.Text+ ",delivered_stamp= current_timestamp()  where id = " + req_id + ";";
            Execute_Query(sql);
            PrintLastBtn(sender, e);

            //dtCus_addedlist.Rows.Clear();
            dtCus_addedlist.DataSource = null;

            funct.clearTxt(Panel1);
            FrmStockOut_Load(sender, e);

            MessageBox.Show("تم");
        }


        private void BtnCus_save_Click(object sender, EventArgs e)
        {
            
            foreach (Control c in Panel1.Controls)
                if (c is TextBox)
                    if (string.IsNullOrEmpty(c.Text))
                    {
                        MessageBox.Show("إملأ معلومات المستلم");
                        return;
                    }
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
                //BtnCus_save_not_emp(sender, e);
            }
        }


        private void Execute_Query(string sql)
        {
            MySqlConnection con = new MySqlConnection(MyCon.GetConString());
           
            MySqlCommand cmd = new MySqlCommand();
            
            try
            {
                int result;
                cmd.Connection = con;
                cmd.CommandText = sql;
                con.Open();
                cmd = new MySqlCommand
                {
                    Connection = con,
                    CommandText = sql
                };
                result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    bool b;
                    //MessageBox.Show("Done!");
                    //b = MyCon.ReportIt(tsansType + isEmployeeCombo.SelectedItem, "ALL", stockoutID, itemName, description, 
                    //type,
                    //  qty, unit, project, Convert.ToInt32(isNew), ExpiryDate);//, projectExpiry);

                }
                else MessageBox.Show("Something Went Wrong!\nERROR_CODE 4864");
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
            dtCus_addedlist.DataSource = null;

            //dtCus_addedlist.Rows.Clear();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnviewStockout_Click(object sender, EventArgs e)
        {
            frmListStockout frm=new frmListStockout();
            frm.Show(); 
        }

       

        private void ReturnBtn_Click(object sender, EventArgs e)
        {
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
            }
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
                sql = "UPDATE `tblitems`  SET `QTY`= QTY + '" + r.Cells[4].Value + "' WHERE ITEMID='" + r.Cells[0].Value + "'";
                Execute_Query(sql);
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
                    
                    sql = "UPDATE `tblitems`  SET `QTY`= QTY + '" + r.Cells[4].Value + "' WHERE ITEMID='" + r.Cells[0].Value + "'";
                    Execute_Query(sql);
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
        }

        private void txtsearch_KeyDown(object sender, KeyEventArgs e)
        {
            scannerTxtBox.Clear();
        }

       

        private void ScannerTxtBox_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode != Keys.Return)
                //.ToString().ToLower() != "return")
                return;
            if (string.IsNullOrWhiteSpace(scannerTxtBox.Text) || string.IsNullOrEmpty(scannerTxtBox.Text))
                return;

            txtsearch.Text = scannerTxtBox.Text;
            if (dtgCus_itemlist.Rows.Count==0)
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
                    if(String.Equals(dtgCus_itemlist.CurrentRow.Cells[0].Value, r.Cells[0].Value))
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
            if (isEmployeeCombo.SelectedIndex==0)
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
