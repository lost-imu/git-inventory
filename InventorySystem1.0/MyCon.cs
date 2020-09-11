﻿using MySql.Data.MySqlClient;


namespace InventorySystem1._0
{
    class MyCon
    {
        //private static string con = "server='192.192.255.232'; user id='abs';password='root';database='db_inventory';sslMode=none;allowuservariables=True;Convert Zero Datetime=True;";

        private static readonly string con = "server=localhost;user id=root;database=db_inventory;sslMode=none;allowuservariables=True;Convert Zero Datetime=True;";
        public MyCon()
        {
        }
        public static string GetConString()
        {
            return con;
        }
        
        ///////////////////////////////////////////////
        ///global report functions
        ///
        public static bool ReportIt(string FUNCTION, string CHANGED_VALUES, string ITEM_ID, string ITEM_NAME, string DESCRIPTION, string TYPE, double QTY, string UNIT, string PROJECT, int IS_NEW, string EXPIRY_DATE, string PROJECT_EXPIRY)
           {
            string RECIEVER_NUMBER, RECIEVER_STATE, RECIEVER_NAME;


            if (string.IsNullOrEmpty(frmStockOut.recieverID) || string.IsNullOrWhiteSpace(frmStockOut.recieverID))
            {
                RECIEVER_NUMBER = frmLogin.user_id.ToString();
                RECIEVER_STATE = "Employee";
                RECIEVER_NAME = frmLogin.fullName;
            }
            else
            {
                RECIEVER_NUMBER = frmStockOut.recieverID.ToString();
                RECIEVER_STATE = frmStockOut.recieverState;
                RECIEVER_NAME = frmStockOut.recieverName;

            }


            string reportSQL = "INSERT INTO `tblreport` (`USER_ID`, `FUNCTION`, `CHANGED_VALUES`, `ITEM_ID`, `ITEM_NAME`, `DESCRIPTION`, `TYPE`, `QTY`, `UNIT`, `PROJECT`, `IS_NEW`, `EXPIRY_DATE`, `PROJECT_EXPIRY`, RECIEVER_NUMBER , RECIEVER_STATE, RECIEVER_NAME) VALUES (@USER_ID, @FUNCTION, @CHANGED_VALUES, @ITEM_ID, @ITEM_NAME, @DESCRIPTION, @TYPE, @QTY, @UNIT, @PROJECT, @IS_NEW, @EXPIRY_DATE, @PROJECT_EXPIRY, @RECIEVER_NUMBER , @RECIEVER_STATE, @RECIEVER_NAME);";
 
            MySqlConnection con = new MySqlConnection(MyCon.GetConString());
            MySqlCommand cmd;


            con.Open();
            cmd = new MySqlCommand
            {
                Connection = con,
                CommandText = reportSQL
            };

            cmd.Parameters.Add(new MySqlParameter("USER_ID", frmLogin.user_id));
            cmd.Parameters.Add(new MySqlParameter("FUNCTION", FUNCTION));
            cmd.Parameters.Add(new MySqlParameter("CHANGED_VALUES", CHANGED_VALUES));
            cmd.Parameters.Add(new MySqlParameter("ITEM_ID", ITEM_ID));
            cmd.Parameters.Add(new MySqlParameter("ITEM_NAME", ITEM_NAME));
            cmd.Parameters.Add(new MySqlParameter("DESCRIPTION", DESCRIPTION));
            cmd.Parameters.Add(new MySqlParameter("TYPE", TYPE));
            cmd.Parameters.Add(new MySqlParameter("RECIEVER_NUMBER", RECIEVER_NUMBER));
            cmd.Parameters.Add(new MySqlParameter("RECIEVER_STATE", RECIEVER_STATE));
            cmd.Parameters.Add(new MySqlParameter("RECIEVER_NAME", RECIEVER_NAME));
             
            if (QTY==-1)
            cmd.Parameters.Add(new MySqlParameter("null", QTY));
            else
                cmd.Parameters.Add(new MySqlParameter("QTY", QTY));

            cmd.Parameters.Add(new MySqlParameter("UNIT", UNIT));
            cmd.Parameters.Add(new MySqlParameter("PROJECT", PROJECT));

            if (IS_NEW == -1)
                cmd.Parameters.Add(new MySqlParameter("null", IS_NEW));
            else
                cmd.Parameters.Add(new MySqlParameter("IS_NEW", IS_NEW));

            cmd.Parameters.Add(new MySqlParameter("EXPIRY_DATE", EXPIRY_DATE));
            cmd.Parameters.Add(new MySqlParameter("PROJECT_EXPIRY", PROJECT_EXPIRY));

            //System.Windows.Forms.MessageBox.Show(cmd.CommandText);
            if (cmd.ExecuteNonQuery() > 0)
                return true;
            return ReportIt(FUNCTION, CHANGED_VALUES, ITEM_ID, ITEM_NAME, DESCRIPTION, TYPE, QTY, UNIT, PROJECT, IS_NEW, EXPIRY_DATE, PROJECT_EXPIRY);
        }




        //////////////////////////////////////////////////


    }
}