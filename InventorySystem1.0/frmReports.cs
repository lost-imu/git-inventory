using DGVPrinterHelper;
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
            this.WindowState = FormWindowState.Maximized;
            refreshAll();
            expiryFromDate.Value = DateTime.Now;
            expiryToDate.Value = DateTime.Now;
            projectExpiryFromDate.Value = DateTime.Now;
            projectExpiryToDate.Value = DateTime.Now;
            transFromDate.Value = DateTime.Now;
            transToDate.Value = DateTime.Now;
        }

        private void refreshAll()
        {
            userNameComboAutoComplete();
            functionComboAutoComplete();
            itemIDComboAutoComplete();
            projectComboAutoComplete();
            branchAutoComplete();

            userNameCombo.SelectedIndex = functionComboBox.SelectedIndex = itemIDCombo.SelectedIndex = projectCombo.SelectedIndex = branchCombo.SelectedIndex = 0;
          /*  getDriverList(); //available drivers
            employeeComboBoxAutoComplete();
            driverComboBoxAutoComplete();
            refreshDataGridView();
            reportEmployeeComboBoxAutoComplete();
            reportDriverComboBoxAutoComplete();
            getCarNumbers();
            fillViewDataGrid();*/

        }
        
        private void userNameComboAutoComplete()
        {
            userNameCombo.Items.Clear();
            userNameCombo.Items.Add("الكل");
            userNameCombo.AutoCompleteMode = AutoCompleteMode.Suggest;
            userNameCombo.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection combData = new AutoCompleteStringCollection();
            getDataForuserNameCombo(combData);
            userNameCombo.AutoCompleteCustomSource = combData;
        }
        private void getDataForuserNameCombo(AutoCompleteStringCollection dataCollection)
        {
            MySqlConnection connection;
            MySqlCommand command;
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataSet ds = new DataSet();
            string sql = "SELECT DISTINCT `name` FROM `user` WHERE `deleted`=0 ORDER BY `user`.`name` ASC ";
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
                    userNameCombo.Items.Add(row[0].ToString());
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! " + ex);
            }
        }
        private void functionComboAutoComplete()
        {
            functionComboBox.Items.Clear();
            functionComboBox.Items.Add("الكل");
            functionComboBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            functionComboBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection combData = new AutoCompleteStringCollection();
            getDataForFunctionCombo(combData);
            functionComboBox.AutoCompleteCustomSource = combData;
        }
        private void getDataForFunctionCombo(AutoCompleteStringCollection dataCollection)
        {
            MySqlConnection connection;
            MySqlCommand command;
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataSet ds = new DataSet();
            string sql = "SELECT DISTINCT `FUNCTION` FROM `tblreport` ORDER BY `tblreport`.`FUNCTION` ASC ";
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
                    functionComboBox.Items.Add(row[0].ToString());

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! " + ex);
            }
        }
        private void itemIDComboAutoComplete()
        {
            itemIDCombo.Items.Clear();
            itemIDCombo.Items.Add("الكل");
            itemIDCombo.AutoCompleteMode = AutoCompleteMode.Suggest;
            itemIDCombo.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection combData = new AutoCompleteStringCollection();
            getDataForItemIDCombo(combData);
            itemIDCombo.AutoCompleteCustomSource = combData;
        }
        private void getDataForItemIDCombo(AutoCompleteStringCollection dataCollection)
        {
            MySqlConnection connection;
            MySqlCommand command;
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataSet ds = new DataSet();
            string sql = "SELECT DISTINCT `ITEM_ID` FROM `tblreport` ORDER BY `tblreport`.`ITEM_ID` ASC";
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
                    itemIDCombo.Items.Add(row[0].ToString());

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
            string sql = "SELECT DISTINCT `PROJECT` FROM `tblreport` ORDER BY `tblreport`.`PROJECT` ASC";
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
        private void branchAutoComplete()
        {
            branchCombo.Items.Clear();
            branchCombo.Items.Add("الكل");
            branchCombo.AutoCompleteMode = AutoCompleteMode.Suggest;
            branchCombo.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection combData = new AutoCompleteStringCollection();
            getDataForbranchCombo(combData);
            branchCombo.AutoCompleteCustomSource = combData;
        }
        private void getDataForbranchCombo(AutoCompleteStringCollection dataCollection)
        {
            MySqlConnection connection;
            MySqlCommand command;
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataSet ds = new DataSet();
            string sql = "SELECT DISTINCT `BRANCH` FROM `tblreport` ORDER BY `tblreport`.`BRANCH` ASC";
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
                    branchCombo.Items.Add(row[0].ToString());

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

        private void checkoutCheckBox_CheckedChanged_1(object sender, EventArgs e)
        {
            if (projectExpiryCheckBox.Checked)
            {
                projectExpiryFromDate.Enabled = false;
                projectExpiryToDate.Enabled = false;
                projectExpiryFromTime.Enabled = false;
                projectExpiryToTime.Enabled = false;
                fromProjectExpiry = null;
                toProjectExpiry = null;
            }
            else
            {
                projectExpiryFromDate.Enabled = true;
                projectExpiryToDate.Enabled = true;
                projectExpiryFromTime.Enabled = true;
                projectExpiryToTime.Enabled = true;
                fromProjectExpiry = projectExpiryFromDate.Value.Date.ToString();
                toProjectExpiry = projectExpiryToDate.Value.Date.ToString();
            }
        }

        private void tranDateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (tranDateCheckBox.Checked)
            {
                transFromDate.Enabled = false;
                transToDate.Enabled = false;
                transFromTime.Enabled = false;
                transToTime.Enabled = false;
                fromTransDate = null;
                toTransDate = null;
            }
            else
            {
                transFromDate.Enabled = true;
                transToDate.Enabled = true;
                transFromTime.Enabled = true;
                transToTime.Enabled = true;
                fromTransDate = transFromDate.Value.Date.ToString();
                toTransDate = transToDate.Value.Date.ToString();
            }
        }

        private void expiryFromDate_ValueChanged(object sender, EventArgs e)
        {
            fromExpiryDate = expiryFromDate.Value.Date.ToString("yyyy-MM-dd ");
        }

        private void expiryToDate_ValueChanged(object sender, EventArgs e)
        {
            toExpiryDate = expiryToDate.Value.Date.ToString("yyyy-MM-dd ");

        }

        private void projectExpiryFromDate_ValueChanged(object sender, EventArgs e)
        {
            fromProjectExpiry = projectExpiryFromDate.Value.Date.ToString("yyyy-MM-dd ");

        }

        private void projectExpiryToDate_ValueChanged(object sender, EventArgs e)
        {
            toProjectExpiry = projectExpiryToDate.Value.Date.ToString("yyyy-MM-dd ");
        }

        private void transFromDate_ValueChanged(object sender, EventArgs e)
        {
            fromTransDate = transFromDate.Value.Date.ToString("yyyy-MM-dd ");

        }

        private void transToDate_ValueChanged(object sender, EventArgs e)
        {
            toTransDate = transToDate.Value.Date.ToString("yyyy-MM-dd ");
        }

        private void checkinCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkoutCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void printBtn_Click_1(object sender, EventArgs e)
        {
            if (reportDataGridView.Rows.Count < 1)
                MessageBox.Show("Nothing to PRINT!");
            else
            PrintLastBtn(sender, e);



        }
        DGVPrinter printer = new DGVPrinter();
        private void PrintLastBtn(object sender, EventArgs e)
        {

            printerEmpty();
        

            printer.PrintDataGridView(reportDataGridView);
            //dtCus_addedlist =  dtCus_addedlist.Rows.Add({ "a","b"};


        }
        /// ////////////////////////////////////////////////
        /// 
        private void printerEmpty()
        {
            printer = new DGVPrinter
            {
                Title = "Report",

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







            // ///////////////////////////////////////////////

            private void expiryDateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (expiryDateCheckBox.Checked)
            {
                expiryFromDate.Enabled = false;
                expiryToDate.Enabled = false;
                expiryFromTime.Enabled = false;
                expiryToTime.Enabled = false;
                fromExpiryDate = null;
                toExpiryDate = null;
            }
            else
            {
                expiryFromDate.Enabled = true;
                expiryToDate.Enabled = true;
                expiryFromTime.Enabled = true;
                expiryToTime.Enabled = true;
                fromExpiryDate = expiryFromDate.Value.Date.ToString();
                toExpiryDate = expiryToDate.Value.Date.ToString();
            }
        }

            private void reportSubmitBtn_Click_1(object sender, EventArgs e)
        {

            string s1 = "SELECT " +
                // " `user`.`name` AS 'User Name', "+
                " `tblreport`.`FUNCTION` AS 'Function', " +
                // " `tblreport`.`CHANGED_VALUES` AS 'Values Changed', " +
                " `tblreport`.`ITEM_ID` AS 'Item ID', " +
                " `tblreport`.`ITEM_NAME` AS 'Item Name', " +
                " `tblreport`.`DESCRIPTION`AS 'Description', " +
                " `tblreport`.`BRANCH` AS 'Branch', " +
                // " `tblreport`.`TYPE` AS 'Type', " +
                " `tblreport`.`QTY` AS 'QTY', " +
                
                //" `tblreport`.`UNIT` AS 'Unit', " +
                //" `tblreport`.`PROJECT` 'Project', " +
                // " if (`tblreport`.`IS_NEW`= 0,'False', 'True') AS 'Is New', " +
                // " `tblreport`.`EXPIRY_DATE` AS 'Expiry Date', " +
                // " `PROJECT_EXPIRY` AS 'Project Expiry', " +
                " `tblreport`.`DATE_STAMP` AS 'Transaction Time' " +
                // " `tblreport`.`RECIEVER_NUMBER` AS 'Reciever Number', " +
                //" `tblreport`.`RECIEVER_STATE` AS 'Employee State', " +
                //" `tblreport`.`RECIEVER_NAME` AS 'Reciever Name' " +
                " FROM `tblreport`,`user` " +
                " WHERE `user`.`user_id`=`tblreport`.`USER_ID`";

            string s2 = sqlFunction() + sqlItemID() + sqlProject() + sqlUserName() + getExpiryDateString() + getProjectExpiryString()+ getTransDateString() + GetBranch();

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

        private string sqlUserName()
        {
            if (userNameCombo.SelectedIndex == 0)
                return null;
            else
            {

               // return " AND `USER_ID` = '" + userNameCombo.SelectedItem.ToString() + "'";
                return " AND `tblreport`.`USER_ID` = (SELECT `user_id` FROM `user` WHERE `name` = '" + userNameCombo.SelectedItem.ToString() + "')";
            }
        }


        private string sqlFunction()
        {
            if (functionComboBox.SelectedIndex == 0)
                return null;
            else
                return " AND `FUNCTION` = '" + functionComboBox.SelectedItem.ToString() + "'";
        }

        private void checkinFromTime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void checkinToTime_ValueChanged(object sender, EventArgs e)
        {

        }

        private string sqlItemID()
        {
            if (itemIDCombo.SelectedIndex == 0)
                return null;
            else
                return " AND `ITEM_ID` = '" + itemIDCombo.SelectedItem.ToString() + "'";
        }
        private string sqlProject()
        {
            if (projectCombo.SelectedIndex == 0)
                return null;
            else
                return " AND `PROJECT` = '" + projectCombo.SelectedItem.ToString() + "'";
        }
        private string getExpiryDateString()
        {
            if (expiryDateCheckBox.Checked)
                return null;

            DateTime dtFrom = expiryFromDate.Value.Date + expiryFromTime.Value.TimeOfDay;
            DateTime dtTo = expiryToDate.Value.Date + expiryToTime.Value.TimeOfDay;
            string dtF = dtFrom.ToString("yyyy-MM-dd HH:mm:ss");
            string dtT = dtTo.ToString("yyyy-MM-dd HH:mm:ss");

            //string s = " AND reservation.checkoutTime >= '" + dtFrom +
            //   "' AND reservation.checkoutTime<= '" + dtTo + "' ";

            string s = " AND `tblreport`.`EXPIRY_DATE` BETWEEN '" + dtF + "' AND '" + dtT + "' ";

            return s;

        }
        private string getProjectExpiryString()
        {
            if (projectExpiryCheckBox.Checked)
                return null;

            DateTime dtFrom = projectExpiryFromDate.Value.Date + projectExpiryFromTime.Value.TimeOfDay;
            DateTime dtTo = projectExpiryToDate.Value.Date + projectExpiryToTime.Value.TimeOfDay;
            string dtF = dtFrom.ToString("yyyy-MM-dd HH:mm:ss");
            string dtT = dtTo.ToString("yyyy-MM-dd HH:mm:ss");

            //string s = " AND reservation.checkoutTime >= '" + dtFrom +
            //   "' AND reservation.checkoutTime<= '" + dtTo + "' ";

            string s = " AND `tblreport`.`PROJECT_EXPIRY` BETWEEN '" + dtF + "' AND '" + dtT + "' ";

            return s;

        }
        private string getTransDateString()
        {
            if (tranDateCheckBox.Checked)
                return null;
            
            DateTime dtFrom = transFromDate.Value.Date + transFromTime.Value.TimeOfDay;
            DateTime dtTo = transToDate.Value.Date + transToTime.Value.TimeOfDay;
            string dtF = dtFrom.ToString("yyyy-MM-dd HH:mm:ss");
            string dtT = dtTo.ToString("yyyy-MM-dd HH:mm:ss");

            //string s = " AND reservation.checkoutTime >= '" + dtFrom +
            //   "' AND reservation.checkoutTime<= '" + dtTo + "' ";

            string s = " AND `tblreport`.`DATE_STAMP` BETWEEN '" + dtF + "' AND '" + dtT + "' ";

            return s;

        }
        private string GetBranch()
        {
            if (branchCombo.SelectedIndex == 0)
                return null;
            else
                return " AND `BRANCH` = '" + branchCombo.SelectedItem.ToString() + "'";
        }



    }
}
