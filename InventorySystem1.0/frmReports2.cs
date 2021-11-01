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
    public partial class frmReports2 : Form
    {
        readonly string conString = MyCon.GetConString();
           // "server=localhost;user id=root;password='';persistsecurityinfo=True;database=db_inventory;";
        string fromExpiryDate = null, toExpiryDate = null, fromProjectExpiry = null, toProjectExpiry = null, fromTransDate = null, toTransDate = null;
        public frmReports2()
        {
            InitializeComponent();
        }

        

        private void frmRepository_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            refreshAll();
            expiryFromDate.Value = DateTime.Now;
            expiryToDate.Value = DateTime.Now;
        }

        private void refreshAll()
        {
            userNameComboAutoComplete();
            functionComboAutoComplete();
            itemIDComboAutoComplete();
            projectComboAutoComplete();
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
            AutoCompleteStringCollection combData = new AutoCompleteStringCollection();
            getDataForuserNameCombo(combData);
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
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! " + ex);
            }
        }
        private void functionComboAutoComplete()
        {
            AutoCompleteStringCollection combData = new AutoCompleteStringCollection();
            getDataForFunctionCombo(combData);
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
            string sql = "SELECT DISTINCT `ITEMID` FROM `tblitems` ORDER BY `tblitems`.`ITEMID` ASC";
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
            string sql = "SELECT DISTINCT `PROJECT` FROM `tblitems` ORDER BY `tblitems`.`PROJECT` ASC";
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
            fromExpiryDate = expiryFromDate.Value.Date.ToString("yyyy-MM-dd ");
        }

        private void expiryToDate_ValueChanged(object sender, EventArgs e)
        {
            toExpiryDate = expiryToDate.Value.Date.ToString("yyyy-MM-dd ");

        }

        private void checkinCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkoutCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void printBtn_Click_1(object sender, EventArgs e)
        {

        }

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
                " `tblitems`.`ITEMID` AS 'Item ID', " +
                " `tblitems`.`NAME` AS 'Item Name', " +
                " `tblitems`.`DESCRIPTION`AS 'Description', " +
                " `tblitems`.`TYPE` AS 'Type', " +
                " `tblitems`.`QTY` AS 'QTY', " +
                " `tblitems`.`UNIT` AS 'Unit', " +
                " `tblitems`.`PROJECT` 'Project', " +
                " if (`tblitems`.`ISNEW`= 0,'False', 'True') AS 'Is New', " +
                " `tblitems`.`EXPIRYDATE` AS 'Expiry Date', " +
                " `PROJECTEXPIRY` AS 'Project Expiry' " +
                " FROM `tblitems` WHERE 1 ";

            string s2 = sqlItemID() + sqlProject() + getExpiryDateString() ;
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

        private void checkinFromTime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void checkinToTime_ValueChanged(object sender, EventArgs e)
        {

        }

        private string sqlItemID()
        {
            if (itemIDCombo.SelectedIndex <= 0)
                return null;
            else
                return " AND ITEMID='"+itemIDCombo.Text+"'";
        }
        private string sqlProject()
        {
            if (projectCombo.SelectedIndex <= 0)
                return null;
            else
                return " AND PROJECT='"+projectCombo.Text+"'";
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
 



    }
}
