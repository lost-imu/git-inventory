using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;


namespace InventorySystem1._0.Includes
{
    class SQLConfig
    {

        private readonly MySqlConnection con = new MySqlConnection(MyCon.GetConString());
        private MySqlCommand cmd;
        private MySqlDataAdapter da;
        public DataTable dt; 
        int result;
        readonly usableFunction funct = new usableFunction();
        public void Execute_CUD(string sql, string msg_false, string msg_true)
        {
            try
            {
                con.Open();
                cmd = new MySqlCommand
                {
                    Connection = con,
                    CommandText = sql
                };
                result = cmd.ExecuteNonQuery();

                if(result > 0)
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
        public string Execute_Query_stringreturn(string sql)
        {
            try
            {
                con.Open();
                

                MySqlCommand command = new MySqlCommand(sql, con);
                con.Open();
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                    return reader.GetString("ITEMID");
                return null;
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
        }
        public void Execute_Query(string sql)
        {
            try
            {
                con.Open();
                cmd = new MySqlCommand
                {
                    Connection = con,
                    CommandText = sql
                };
                result = cmd.ExecuteNonQuery();
                
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
        public void Load_DTG(string sql,DataGridView dtg)
        {
            try
            {
                con.Open();
                cmd = new MySqlCommand();
                da = new MySqlDataAdapter();
                dt = new DataTable();


                cmd.Connection = con;
                cmd.CommandText = sql;
                da.SelectCommand = cmd;
                da.Fill(dt);
                dtg.DataSource = dt;

               
                funct.ResponsiveDtg(dtg);
                dtg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dtg.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

                
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                da.Dispose();
                con.Close();
            }

        }
        public void Fiil_CBO(string sql, ComboBox cbo)
        {
            try
            {
                con.Open();
                cmd = new MySqlCommand();
                da = new MySqlDataAdapter();
                dt = new DataTable();


                cmd.Connection = con;
                cmd.CommandText = sql;
                da.SelectCommand = cmd;
                da.Fill(dt);
                cbo.DataSource = dt;
                cbo.ValueMember = dt.Columns[0].ColumnName;
                cbo.DisplayMember = dt.Columns[0].ColumnName;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                da.Dispose();
                con.Close();
            }

        }
        public void SingleResult(string sql)

        {
            try
            {

                con.Close();
                con.Open();
                cmd = new MySqlCommand();
                da = new MySqlDataAdapter();
                dt = new DataTable();


                cmd.Connection = con;
                cmd.CommandText = sql;
                da.SelectCommand = cmd;
                da.Fill(dt);  

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                da.Dispose();
                con.Close();
            }
        }

        public void LoadReports(string sql)

        {
            try
            {
                con.Open();
                cmd = new MySqlCommand();
                da = new MySqlDataAdapter();
                dt = new DataTable();


                cmd.Connection = con;
                cmd.CommandText = sql;
                da.SelectCommand = cmd;
                da.Fill(dt);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                da.Dispose();
                con.Close();
            }
        }

        public void Autocomplete(string sql,TextBox txt)
        {
            try
            {
                con.Open();
                cmd = new MySqlCommand();
                da = new MySqlDataAdapter();
                dt = new DataTable();


                cmd.Connection = con;
                cmd.CommandText = sql;
                da.SelectCommand = cmd;
                da.Fill(dt);
                txt.AutoCompleteCustomSource.Clear();
                txt.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txt.AutoCompleteSource = AutoCompleteSource.CustomSource;
                foreach (DataRow r in dt.Rows)
                {
                    txt.AutoCompleteCustomSource.Add(r.Field<string>(0));
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                da.Dispose();
                con.Close();
            }
        }

        public void Autonumber(string sql,TextBox txt)
        {
            try
            {
                con.Open();
                cmd = new MySqlCommand();
                da = new MySqlDataAdapter();
                dt = new DataTable();


                cmd.Connection = con;
                cmd.CommandText = sql;
                da.SelectCommand = cmd;
                da.Fill(dt);

                txt.Text = dt.Rows[0].Field<string>(0);
            

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                //MessageBox.Show(ex.Message);
            }
            finally
            {
                da.Dispose();
                con.Close();
            }
        }
        public void Update_Autonumber(string id)
        { 
            Execute_Query("UPDATE `tblautonumber` SET `END`=`END`+`INCREMENT` WHERE `DESCRIPTION`='" + id + "'");
        }
       


    }
}
