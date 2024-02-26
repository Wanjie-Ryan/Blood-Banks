using Blood_Banks.BLL;
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
                string sql = "SELECT * FROM users";

                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                //Transfer data from SqlData Adapter to datatable
                adapter.Fill(dt);
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

        public bool Insert(userBLL u)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection();

            try
            {
                string sql = "INSERT INTO users (user_id, username, email, password, full_name, contact, address, added_date, image_name) VALUES (@user_id, @username, @email, @password, @full_name, @contact, @address, @added_date, @image_name)";

                // create am sql command to pass the value in the query
                SqlCommand cmd = new SqlCommand(sql, conn);

                conn.Open();

                // create the parameters to get value from the UI and pass it 
                cmd.Parameters.AddWithValue("@user_id", u.user_id);
                cmd.Parameters.AddWithValue("@username", u.username);
                cmd.Parameters.AddWithValue("@email", u.email);
                cmd.Parameters.AddWithValue("@password", u.password);
                cmd.Parameters.AddWithValue("@full_name", u.full_name);
                cmd.Parameters.AddWithValue("@contact", u.contact);
                cmd.Parameters.AddWithValue("@address", u.address);
                cmd.Parameters.AddWithValue("@added_date", u.added_date);
                cmd.Parameters.AddWithValue("@image_name", u.image_name);

                //open db connection
                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }

        //update functionality

        public bool Update(userBLL u)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection();

            try
            {
                string sql = "UPDATE users SET username = @username, email = @email, password = @password, full_name = @full_name, contact = @contact, address = @address, added_date = @added_date, image_name = @image_name WHERE user_id = @user_id";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@username", u.username);
                cmd.Parameters.AddWithValue("@email", u.email);
                cmd.Parameters.AddWithValue("@password", u.password);
                cmd.Parameters.AddWithValue("@full_name", u.full_name);
                cmd.Parameters.AddWithValue("@contact", u.contact);
                cmd.Parameters.AddWithValue("@address", u.address);
                cmd.Parameters.AddWithValue("@added_date", u.added_date);
                cmd.Parameters.AddWithValue("@image_name", u.image_name);
                cmd.Parameters.AddWithValue("@user_id", u.user_id);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }

        // deleting data from the DB

        public bool Delete (userBLL u)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection();

            try
            {
                string sql = "DELETE FROM users WHERE user_id = @user_id";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@user_id", u.user_id);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }
    }
}
