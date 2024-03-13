using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Blood_Banks.BLL;


namespace Blood_Banks.DAL
{
    internal class loginDAL
    {
        public bool LoginCheck(loginBLL l)
        {
            bool isSuccess = false;

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


            return isSuccess;
        }
    }
}
