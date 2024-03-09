using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blood_Banks.DAL
{
    internal class donorDAL
    {
        public DataTable Select()
        {
            DataTable dt = new DataTable();

            using (MySqlConnection conn = new MySqlConnection(Program.GetConnectionString()))
            {
                try
                {


                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }

            return dt;
        }
    }
}
