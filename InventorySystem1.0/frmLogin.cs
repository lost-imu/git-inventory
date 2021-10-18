using InventorySystem1._0.Includes;
using MySql.Data.MySqlClient;
using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Linq;


namespace InventorySystem1._0
{
    public partial class frmLogin : Form
    {
        readonly Form1 frm;
        public static int user_id = 0;
        public static string username = null, userType = null, fullName;


        public static void ResetUserName()
        {
            username = null;
        }
        public static string GetUserName()
        {
            return username;
        }

        public frmLogin(Form1 frm)
        {
            InitializeComponent();

            this.frm = frm;
        }

        readonly SQLConfig config = new SQLConfig();

        //string sql;

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lbltime.Text = DateTime.Now.ToShortTimeString();
            lbldate.Text = DateTime.Now.ToShortDateString();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            Timer1.Start();
            
            /////\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
            ///
            /* bool ssl = true;
             int maxWaitMillisec = 20000;

             // The SSL server hostname may be an IP address, a domain name,
             // or "localhost".  You'll need to change this:
             string sslServerHost;
             sslServerHost = "localhost";
             int sslServerPort = 8123;

             // Connect to the SSL server:
             bool success = socket.Connect(sslServerHost, sslServerPort, ssl, maxWaitMillisec);
             if (success != true)
             {
                 Debug.WriteLine(socket.LastErrorText);
                 return;
             }

             // Set maximum timeouts for reading an writing (in millisec)
             socket.MaxReadIdleMs = 20000;
             socket.MaxSendIdleMs = 20000;

             // Send a "Hello Server! -EOM-" message:
             success = socket.SendString("Hello Server! -EOM-");
             if (success != true)
             {
                 Debug.WriteLine(socket.LastErrorText);
                 return;
             }

             // The server (in this example) is going to send a "Hello Client! -EOM-" 
             // message.  Read it:
             string receivedMsg = socket.ReceiveUntilMatch("-EOM-");
             if (socket.LastMethodSuccess != true)
             {
                 Debug.WriteLine(socket.LastErrorText);
                 return;
             }

             // Close the connection with the server
             // Wait a max of 20 seconds (20000 millsec)
             success = socket.Close(20000);

             Debug.WriteLine(receivedMsg);*/
            ///////////////////////////////////////////////////////////////////////////////////
        }
        static string Hash(string input)
        {
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(input));
                var sb = new StringBuilder(hash.Length * 2);

                foreach (byte b in hash)
                {
                    // can be "x2" if you want lowercase
                    sb.Append(b.ToString("X2"));
                }

                return sb.ToString();
            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            /*
            try
            {
                MySqlConnection con = new MySqlConnection(MyCon.GetConString());
                con.Open();
                MessageBox.Show("sucseed");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return;*/
            try
            {
                MySqlConnection con = new MySqlConnection(MyCon.GetConString());
                string cmd = "SELECT * FROM user WHERE deleted=0 and user_name=@user_name and pass=@password";
                MySqlCommand command = new MySqlCommand(cmd, con);
                string pass = Hash(txtpass.Text);
                command.Parameters.Add(new MySqlParameter("user_name", txtusername.Text));
                command.Parameters.Add(new MySqlParameter("password", pass));
                //MySqlCommand command = new MySqlCommand(cmd, con);
                con.Open();
                /////////////////////////

                MySqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    if (reader.HasRows)
                    {
                        user_id = reader.GetInt16("user_id");
                        fullName = reader.GetString("name");
                        username = txtusername.Text;
                        userType = reader.GetString("type");
                        if (userType == "WH Manager")
                        {
                            frm.Enabled_menu(2);
                            this.Close();
                        }
                        else if (userType == "WH Keeper")
                        {
                            frm.Enabled_menu(1);
                            this.Close();
                        }
                        else if (userType == "Procurement")
                        {
                            frm.Enabled_menu(0);
                            this.Close();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("تأكد من الاسم وكلمة المرور", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void Button2_Click(object sender, EventArgs e)
        {
            txtpass.Clear();
            txtusername.Clear();
            txtusername.Focus();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
