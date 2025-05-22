using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;


namespace BonsandBlooms
{
    class DatabaseConnect
    {

        private OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" 
                                     + Application.StartupPath + "\\BonsandBloomsDatabase.accdb; JET OLEDB:Database Password = admin1234");
        private OleDbCommand cmd;
        private OleDbDataAdapter da;
        public DataTable dt; 
        int result;
        usableFunction funct = new usableFunction();
        public void Execute_CUD(string sql, string msg_false, string msg_true)
        {
            try
            {
                con.Open();
                cmd = new OleDbCommand();
                cmd.Connection = con;
                cmd.CommandText = sql;
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
        public void Execute_Query(string sql)
        {
            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                } 
                //con.Open();
                cmd = new OleDbCommand();
                cmd.Connection = con;
                cmd.CommandText = sql;
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

        public DataTable Execute_Query(string sql, params OleDbParameter[] parameters)
        {
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                using (OleDbCommand cmd = new OleDbCommand(sql, con))
                {
                    if (parameters != null && parameters.Length > 0)
                        cmd.Parameters.AddRange(parameters);

                    OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                    da.Fill(dt);
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
            return dt;
        }

        public void Load_DTG(string sql, DataGridView dtg, params OleDbParameter[] parameters)
        {
            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                using (OleDbCommand cmd = new OleDbCommand(sql, con))
                {
                    // Add parameters if any
                    if (parameters != null && parameters.Length > 0)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }

                    using (OleDbDataAdapter da = new OleDbDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dtg.DataSource = dt;

                        funct.ResponsiveDtg(dtg);
                        dtg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dtg.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        public void fiil_CBO(string sql, ComboBox cbo)
        {
            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open(); 
                } 

                cmd = new OleDbCommand();
                da = new OleDbDataAdapter();
                dt = new DataTable();


                cmd.Connection = con;
                cmd.CommandText = sql;
                da.SelectCommand = cmd;
                da.Fill(dt);

                cbo.DataSource = dt;
                cbo.ValueMember = dt.Columns[0].ColumnName;
                cbo.DisplayMember = dt.Columns[1].ColumnName;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
                da.Dispose();
            }

        }
        public void combo(string sql, ComboBox cbo)
        {
            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                cmd = new OleDbCommand();
                da = new OleDbDataAdapter();
                dt = new DataTable();


                cmd.Connection = con;
                cmd.CommandText = sql;
                da.SelectCommand = cmd;
                da.Fill(dt);

                cbo.Items.Clear();
                cbo.Text = "Select";
                foreach(DataRow r in dt.Rows)
                {
                    cbo.Items.Add(r.Field<string>(0));
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
                da.Dispose();
            }

        }
        public void singleResult(string sql)

        {
            try
            {
                con.Open();
                cmd = new OleDbCommand();
                da = new OleDbDataAdapter();
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

        public int maxrow(string sql)

        {
            int maxrow = 0;
             
            try
            {
                con.Open();
                cmd = new OleDbCommand();
                da = new OleDbDataAdapter();
                dt = new DataTable();


                cmd.Connection = con;
                cmd.CommandText = sql;
                da.SelectCommand = cmd;
                da.Fill(dt);

                maxrow = dt.Rows.Count;

               

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
             
            return maxrow;

        }

        public void loadReports(string sql)

        {
            try
            {
                con.Open();
                cmd = new OleDbCommand();
                da = new OleDbDataAdapter();
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
                con.Close();
                da.Dispose();
            }
        }

        public void autocomplete(string sql,TextBox txt)
        {
            try
            {
                con.Open();
                cmd = new OleDbCommand();
                da = new OleDbDataAdapter();
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
                con.Close();
                da.Dispose();
            }
        }

        public void autonumber(int ID, TextBox txt)
        {
            try
            {

                if (con.State != ConnectionState.Open)
                {
                    con.Open(); 
                }
                cmd = new OleDbCommand();
                da = new OleDbDataAdapter();
                dt = new DataTable();


                cmd.Connection = con;
                cmd.CommandText = "SELECT (STARTNUM + INCNUM) FROM tblAutoNumber WHERE ID=" + ID;
                da.SelectCommand = cmd;
                da.Fill(dt);

                txt.Text = DateTime.Now.ToString("yyyy") + dt.Rows[0].Field<string>(0);
            

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
                da.Dispose();
            }
        }

        public void autonumber_transaction(int ID, Label txt)
        {
            try
            {

                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                cmd = new OleDbCommand();
                da = new OleDbDataAdapter();
                dt = new DataTable();


                cmd.Connection = con;
                cmd.CommandText = "SELECT (STARTNUM + INCNUM) FROM tblAutoNumber WHERE ID=" + ID;
                da.SelectCommand = cmd;
                da.Fill(dt);

                txt.Text = dt.Rows[0].Field<string>(0);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
                da.Dispose();
            }
        }
        public void update_Autonumber(int id)
        { 
            Execute_Query("UPDATE tblAutoNumber SET  INCNUM=INCNUM + 1 WHERE ID=" + id);
        }
       


    }
}
