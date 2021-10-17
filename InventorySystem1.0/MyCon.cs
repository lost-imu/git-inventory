using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace InventorySystem1._0
{
    class MyCon
    {
        //private static string con = "server='192.192.255.232'; user id='abs';password='root';database='db_inventory';sslMode=none;allowuservariables=True;Convert Zero Datetime=True;";

        //private static readonly string ConString = "server=160.153.131.197;port=20;user id=eeb;password=aPxK5cVibm~?;database=lost_inventory;sslMode=none;allowuservariables=True;Convert Zero Datetime=True;";
        
        // wissam
        //private static readonly string ConString = "server=160.153.131.197;user id=eeb;database=lost_wissam;port=3306;password=aPxK5cVibm~?;sslMode=none;allowuservariables=True;Convert Zero Datetime=True;Character Set=utf8;";

        // lost_inventory
        private static readonly string ConString = "server=160.153.131.197;user id=eeb;database=lost_new_inventory;port=3306;password=BPxK6cnVibm~?;sslMode=none;allowuservariables=True;Convert Zero Datetime=True;Character Set=utf8;";

        // localhost
        //private static readonly string ConString = "server=localhost;user id=root;database=db_inventory;sslMode=none;allowuservariables=True;Convert Zero Datetime=True;Character Set=utf8;";

        public MyCon()
        {
        }
        public static string GetConString()
        {
            return ConString;
        }

        ///////////////////////////////////////////////
        ///global report functions
        ///
        public static bool ReportAdd(string supplier, string invoice_number, string invoice_date, string item_id, string qty, string project, string user_id)
        {
            
            
            string reportSQL = "INSERT INTO `tblstockin` ( supplier, invoice_number, invoice_date, item_id, qty, project, user_id) VALUES" +
                                                      " (@supplier, @invoice_number, @invoice_date, @item_id, @qty, @project, @user_id)";

            MySqlConnection con = new MySqlConnection(MyCon.GetConString());
            MySqlCommand cmd;


            con.Open();
            cmd = new MySqlCommand
            {
                Connection = con,
                CommandText = reportSQL
            };
            
            cmd.Parameters.Add(new MySqlParameter("@supplier", supplier));
            cmd.Parameters.Add(new MySqlParameter("@invoice_number", invoice_number));
            cmd.Parameters.Add(new MySqlParameter("@invoice_date", invoice_date));
            cmd.Parameters.Add(new MySqlParameter("@item_id", item_id));
            cmd.Parameters.Add(new MySqlParameter("@qty", qty));
            cmd.Parameters.Add(new MySqlParameter("@project", project));
            cmd.Parameters.Add(new MySqlParameter("@user_id", user_id));
            //cmd.Parameters.Add(new MySqlParameter("TYPE", TYPE));
            //cmd.Parameters.Add(new MySqlParameter("RECIEVER_NUMBER", RECIEVER_NUMBER));
            //cmd.Parameters.Add(new MySqlParameter("RECIEVER_STATE", RECIEVER_STATE));
            //cmd.Parameters.Add(new MySqlParameter("RECIEVER_NAME", RECIEVER_NAME));

            

            //System.Windows.Forms.MessageBox.Show(cmd.CommandText);
            if (cmd.ExecuteNonQuery() > 0)
                return true;
            return ReportAdd(supplier, invoice_number, invoice_date, item_id, qty, project, user_id);
                
        }

        public static string ReturnSingleResult(string sql, string value)
        {
            MySqlConnection con = new MySqlConnection(GetConString());
            MySqlCommand command;
            try
            {
                con.Close();
                con.Open();
                command = new MySqlCommand(sql, con);
                MySqlDataReader reader = command.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    return reader.GetString(value);
                }

                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                con.Close();
            }
            ///////////////////////////////////////////////////////


            //Btnnew_Click(sender, e);

        }
    }


    //////////////////////////////////////////////////


}
