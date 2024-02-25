using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blood_Banks.DAL
{
    internal class userDAL
    {
        //create a static string to connect to DB
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connectionstring"].ConnectionString;

        // Selecting data from DB

        public DataTable Select()
        {

            //create an object to connect to DB
            SqlConnection conn = new SqlConnection();

            // create a datatable to hold data from the DB
            DataTable dt = new DataTable();

            try
            {

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // close DB connection
                conn.Close();
            }


            return dt;

        }
    }
}
