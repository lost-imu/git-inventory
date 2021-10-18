using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventorySystem1._0
{
    public partial class frmReports : Form
    {
        readonly string conString = MyCon.GetConString();
           // "server=localhost;user id=root;password='';persistsecurityinfo=True;database=db_inventory;";
        string fromExpiryDate = null, toExpiryDate = null, fromProjectExpiry = null, toProjectExpiry = null, fromTransDate = null, toTransDate = null;
        public frmReports()
        {
            InitializeComponent();
        }

        

        private void frmRepository_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lost_new_inventoryDataSet.tblrequest' table. You can move, or remove it, as needed.
            //this.tblrequestTableAdapter.Fill(this.lost_new_inventoryDataSet.tblrequest);

            this.WindowState = FormWindowState.Maximized;
            refreshAll();
            invoiceFromDate.Value = DateTime.Now;
            invoiceToDate.Value = DateTime.Now;
            
        }

        private void refreshAll()
        {
            userNameComboAutoComplete();//supplierCombo
            functionComboAutoComplete();
            itemIDComboAutoComplete();
            projectComboAutoComplete();
            supplierCombo.SelectedIndex = invoiceNoCombo.SelectedIndex = projectCombo.SelectedIndex = projectCombo.SelectedIndex = 0;
          /*  getDriverList(); //available drivers
            employeeComboBoxAutoComplete();
            driverComboBoxAutoComplete();
            refreshDataGridView();
            reportEmployeeComboBoxAutoComplete();
            reportDriverComboBoxAutoComplete();
            getCarNumbers();
            fillViewDataGrid();*/

        }
        
        private void userNameComboAutoComplete() //supplierCombo
        {
            supplierCombo.Items.Clear();
            supplierCombo.Items.Add("الكل");
            supplierCombo.AutoCompleteMode = AutoCompleteMode.Suggest;
            supplierCombo.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection combData = new AutoCompleteStringCollection();
            getDataForuserNameCombo(combData);
            supplierCombo.AutoCompleteCustomSource = combData;
        }
        private void getDataForuserNameCombo(AutoCompleteStringCollection dataCollection) //supplier
        {
            MySqlConnection connection;
            MySqlCommand command;
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataSet ds = new DataSet();
            string sql = "SELECT DISTINCT `supplier` FROM `tblstockin` ORDER BY `supplier` ASC ";
            connection = new MySqlConnection(conString);
            try
            {
                
                connection.Open();
                command = new MySqlCommand(sql, connection);
                adapter.SelectCommand = command;
                adapter.Fill(ds);
                adapter.Dispose();
                command.Dispose();
                connection.Close();
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    dataCollection.Add(row[0].ToString());
                    supplierCombo.Items.Add(row[0].ToString());
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! " + ex);
            }
        }
        private void functionComboAutoComplete() //invoiceNoCombo
        {
            invoiceNoCombo.Items.Clear();
            invoiceNoCombo.Items.Add("الكل");
            invoiceNoCombo.AutoCompleteMode = AutoCompleteMode.Suggest;
            invoiceNoCombo.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection combData = new AutoCompleteStringCollection();
            getDataForFunctionCombo(combData);
            invoiceNoCombo.AutoCompleteCustomSource = combData;
        }
        private void getDataForFunctionCombo(AutoCompleteStringCollection dataCollection) //invoiceNoCombo
        {
            MySqlConnection connection;
            MySqlCommand command;
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataSet ds = new DataSet();
            string sql = "SELECT DISTINCT `invoice_number` FROM `tblstockin` ORDER BY `tblstockin`.`invoice_number` ASC ";
            connection = new MySqlConnection(conString);
            try
            {

                connection.Open();
                command = new MySqlCommand(sql, connection);
                adapter.SelectCommand = command;
                adapter.Fill(ds);
                adapter.Dispose();
                command.Dispose();
                connection.Close();
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    dataCollection.Add(row[0].ToString());
                    invoiceNoCombo.Items.Add(row[0].ToString());

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! " + ex);
            }
        }
        private void itemIDComboAutoComplete()//projectCombo
        {
            projectCombo.Items.Clear();
            projectCombo.Items.Add("الكل");
            projectCombo.AutoCompleteMode = AutoCompleteMode.Suggest;
            projectCombo.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection combData = new AutoCompleteStringCollection();
            getDataForItemIDCombo(combData);
            projectCombo.AutoCompleteCustomSource = combData;
        }
        private void getDataForItemIDCombo(AutoCompleteStringCollection dataCollection)//projectCombo
        {
            MySqlConnection connection;
            MySqlCommand command;
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataSet ds = new DataSet();
            string sql = "SELECT DISTINCT `project` FROM `tblstockin` ORDER BY `tblstockin`.`project` ASC";
            connection = new MySqlConnection(conString);
            try
            {

                connection.Open();
                command = new MySqlCommand(sql, connection);
                adapter.SelectCommand = command;
                adapter.Fill(ds);
                adapter.Dispose();
                command.Dispose();
                connection.Close();
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    dataCollection.Add(row[0].ToString());
                    projectCombo.Items.Add(row[0].ToString());

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! " + ex);
            }
        }
        private void projectComboAutoComplete()
        {
            projectCombo.Items.Clear();
            projectCombo.Items.Add("الكل");
            projectCombo.AutoCompleteMode = AutoCompleteMode.Suggest;
            projectCombo.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection combData = new AutoCompleteStringCollection();
            getDataForProjectCombo(combData);
            projectCombo.AutoCompleteCustomSource = combData;
        }
        private void getDataForProjectCombo(AutoCompleteStringCollection dataCollection)
        {
            MySqlConnection connection;
            MySqlCommand command;
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataSet ds = new DataSet();
            string sql = "SELECT DISTINCT `project` FROM `tblstockin` ORDER BY `tblstockin`.`project` ASC";
            connection = new MySqlConnection(conString);
            try
            {

                connection.Open();
                command = new MySqlCommand(sql, connection);
                adapter.SelectCommand = command;
                adapter.Fill(ds);
                adapter.Dispose();
                command.Dispose();
                connection.Close();
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    dataCollection.Add(row[0].ToString());
                    projectCombo.Items.Add(row[0].ToString());

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! " + ex);
            }
        }
        private void printBtn_Click(object sender, EventArgs e)
        {

        }

        private void reportSubmitBtn_Click(object sender, EventArgs e)
        {

        }

       

        
        private void expiryFromDate_ValueChanged(object sender, EventArgs e)
        {
            fromExpiryDate = invoiceFromDate.Value.Date.ToString("yyyy-MM-dd ");
        }

        private void expiryToDate_ValueChanged(object sender, EventArgs e)
        {
            toExpiryDate = invoiceToDate.Value.Date.ToString("yyyy-MM-dd ");

        }

        private void printBtn_Click_1(object sender, EventArgs e)
        {

        }

        private void expiryDateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (expiryDateCheckBox.Checked)
            {
                invoiceFromDate.Enabled = false;
                invoiceToDate.Enabled = false;
                invoiceFromTime.Enabled = false;
                invoiceToTime.Enabled = false;
                fromExpiryDate = null;
                toExpiryDate = null;
            }
            else
            {
                invoiceFromDate.Enabled = true;
                invoiceToDate.Enabled = true;
                invoiceFromTime.Enabled = true;
                invoiceToTime.Enabled = true;
                fromExpiryDate = invoiceFromDate.Value.Date.ToString();
                toExpiryDate = invoiceToDate.Value.Date.ToString();
            }
        }

            private void reportSubmitBtn_Click_1(object sender, EventArgs e)
        {

            //string s1 = "SELECT " +
            //    " `user`.`name` AS 'User Name', "+
            //    " `tblreport`.`FUNCTION` AS 'Function', " +
            //    " `tblreport`.`CHANGED_VALUES` AS 'Values Changed', " +
            //    " `tblreport`.`ITEM_ID` AS 'Item ID', " +
            //    " `tblreport`.`ITEM_NAME` AS 'Item Name', " +
            //    " `tblreport`.`DESCRIPTION`AS 'Description', " +
            //    " `tblreport`.`TYPE` AS 'Type', " +
            //    " `tblreport`.`QTY` AS 'QTY', " +
            //    " `tblreport`.`UNIT` AS 'Unit', " +
            //    " `tblreport`.`PROJECT` 'Project', " +
            //    " if (`tblreport`.`IS_NEW`= 0,'False', 'True') AS 'Is New', " +
            //    " `tblreport`.`EXPIRY_DATE` AS 'Expiry Date', " +
            //    " `PROJECT_EXPIRY` AS 'Project Expiry', " +
            //    " `tblreport`.`DATE_STAMP` AS 'Transaction Time', " +
            //    " `tblreport`.`RECIEVER_NUMBER` AS 'Reciever Number', " +
            //    " `tblreport`.`RECIEVER_STATE` AS 'Employee State', " +
            //    " `tblreport`.`RECIEVER_NAME` AS 'Reciever Name' " +
            //    " FROM `tblreport`,`user` " +
            //    " WHERE `user`.`user_id`=`tblreport`.`USER_ID`";
            string s1 = "SELECT id ,supplier as 'Supplier',invoice_number as 'Invoice Number',invoice_date as 'Invoice Date',item_id as 'Item ID',qty as 'Quantity',project as 'Project Name' FROM `tblstockin` WHERE 1";

            string s2 = invoiceNumber() + sqlProject() + sqlsupplier() + getExpiryDateString();

            
            //string s3 = " AND driver.driverID=reservation.driverID AND employee.empID=reservation.requesterID AND car.carID=reservation.carID ";
            //textBox1.Text = s1 + s2 + s3;
            //try
            // {

            MySqlConnection con = new MySqlConnection(conString);



                string selectQ = s1 + s2 ;

                con.Open();
                MySqlCommand command = new MySqlCommand(selectQ, con);

                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(command);
                DataSet DS = new DataSet();
                mySqlDataAdapter.Fill(DS);
                reportDataGridView.DataSource = DS.Tables[0];
                //nameList2.Items.Add(reader.GetString("fullName"));
                con.Close();
           /* }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //saveFile();
            }*/
        }

        private string sqlsupplier()
        {
            if (supplierCombo.SelectedIndex == 0)
                return null;
            else
            {

                // return " AND `USER_ID` = '" + userNameCombo.SelectedItem.ToString() + "'";
                return " AND `supplier` = '" + supplierCombo.SelectedItem.ToString() + "'";

            }
        }


        private string invoiceNumber()
        {
            if (invoiceNoCombo.SelectedIndex == 0)
                return null;
            else
                return " AND `invoice_number` = '" + invoiceNoCombo.SelectedItem.ToString() + "'";
        }

        

        private void checkinFromTime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void checkinToTime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tblrequestTableAdapter.Fill(this.lost_new_inventoryDataSet.tblrequest);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        
        private string sqlProject()
        {
            if (projectCombo.SelectedIndex == 0)
                return null;
            else
                return " AND `project` = '" + projectCombo.SelectedItem.ToString() + "'";
        }
        private string getExpiryDateString()
        {
            if (expiryDateCheckBox.Checked)
                return null;

            DateTime dtFrom = invoiceFromDate.Value.Date + invoiceFromTime.Value.TimeOfDay;
            DateTime dtTo = invoiceToDate.Value.Date + invoiceToTime.Value.TimeOfDay;
            string dtF = dtFrom.ToString("yyyy-MM-dd HH:mm:ss");
            string dtT = dtTo.ToString("yyyy-MM-dd HH:mm:ss");

            //string s = " AND reservation.checkoutTime >= '" + dtFrom +
            //   "' AND reservation.checkoutTime<= '" + dtTo + "' ";

            string s = " AND `tblstockin`.`invoice_date` BETWEEN '" + dtF + "' AND '" + dtT + "' ";

            return s;

        }
       

        
       



    }
}
