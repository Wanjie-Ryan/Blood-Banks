using Blood_Banks.BLL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Eventing.Reader;
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

                    string sql = "SELECT * FROM donors";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    conn.Open();
                    adapter.Fill(dt);
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

        public Boolean Insert(donorsBLL b)
        {
            bool isSuccess = false;

            using (MySqlConnection conn = new MySqlConnection(Program.GetConnectionString()))
            {
                try
                {
                    string sql = "INSERT INTO donors (first_name, last_name, email, contact, gender, address, blood_group, added_date, image_name, added_by) VALUES (@first_name, @last_name, @email, @contact, @gender, @address, @blood_group, @added_date, @image_name, @added_by)";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                  
                    cmd.Parameters.AddWithValue("@first_name", b.first_name);
                    cmd.Parameters.AddWithValue("@last_name", b.last_name);
                    cmd.Parameters.AddWithValue("@email", b.email);
                    cmd.Parameters.AddWithValue("@contact", b.contact);
                    cmd.Parameters.AddWithValue("@gender", b.gender);
                    cmd.Parameters.AddWithValue("@address", b.address);
                    cmd.Parameters.AddWithValue("@blood_group", b.blood_group);
                    cmd.Parameters.AddWithValue("@added_date", b.added_date);
                    cmd.Parameters.AddWithValue("@image_name", b.image_name);
                    cmd.Parameters.AddWithValue("@added_by", b.added_by);

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
            }

                return isSuccess;
        }

        public bool Update(donorsBLL b)
        {
            bool isSuccess = false;

            using (MySqlConnection conn = new MySqlConnection(Program.GetConnectionString()))
            {
                try
                {
                    string sql = "UPDATE donors SET first_name =@first_name, last_name =@last_name, email=@email,contact=@contact, gender=@gender, address=@address, blood_group= @blood_group, image_name=@image_name, added_by=@added_by WHERE donor_id=@donor_id";

                    MySqlCommand cmd = new MySqlCommand(sql,conn);

                    cmd.Parameters.AddWithValue("@donor_id", b.donor_id);
                    cmd.Parameters.AddWithValue("@first_name", b.first_name);
                    cmd.Parameters.AddWithValue("@last_name", b.last_name);
                    cmd.Parameters.AddWithValue("@email", b.email);
                    cmd.Parameters.AddWithValue("@contact", b.contact);
                    cmd.Parameters.AddWithValue("@gender", b.gender);
                    cmd.Parameters.AddWithValue("@address", b.address);
                    cmd.Parameters.AddWithValue("@blood_group", b.blood_group);
                    cmd.Parameters.AddWithValue("@image_name", b.image_name);
                    cmd.Parameters.AddWithValue("@added_by", b.added_by);

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
            }

            return isSuccess;
        }

        public bool Delete(donorsBLL b)
        {
            bool isSuccess = false;

            using (MySqlConnection conn = new MySqlConnection(Program.GetConnectionString()))
            {
                try
                {
                    string sql = "DELETE FROM donors WHERE donor_id = @donor_id";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@donor_id", b.donor_id);

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
            }

                return isSuccess;
        }

        public DataTable Search(string keyword)
        {
            DataTable dt = new DataTable();

            using (MySqlConnection conn = new MySqlConnection(Program.GetConnectionString()))
            {
                try
                {
                    string sql = "SELECT * FROM donors WHERE first_name LIKE '%" +keyword+ "%' OR last_name LIKE '%" +keyword+ "%' OR email LIKE '%" +keyword+ "%' OR gender LIKE '%" +keyword+"%' OR blood_group LIKE '%" +keyword+ "%'  ";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    conn.Open();

                    adapter.Fill(dt);
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

        public string countDonors(string blood_group)
        {

            // using is used to ensure that the connection is properly disposed of after its use
            using(MySqlConnection conn = new MySqlConnection(Program.GetConnectionString()))
            {
                // create a string variable for donor count and set its default value to 0

                string donors = "0";

                try
                {

                    string sql = "SELECT * FROM donors WHERE blood_group = '"+blood_group+"' ";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    conn.Open();

                    DataTable dt = new DataTable();

                    adapter.Fill(dt);

                    // get the total number of donors based on the blood group

                    donors = dt.Rows.Count.ToString();
                    //counts the number of rows in the dataTable
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }

                return donors;
            }
        }
    }
}
