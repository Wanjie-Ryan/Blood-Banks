﻿using Blood_Banks.BLL;
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
                    string sql = "INSERT INTO donors (donor_id, first_name, last_name, email, contact, gender, address, blood_group, added_date, image_name, added_by) VALUES (@donor_id, @first_name, @last_name, @email, @contact, @gender, @address, @blood_group, @added_date, @image_name, @added_by)";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@donor_id", b.donor_id);
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
                    string sql = "UPDATE donors SET first_name =@first_name, last_name =@last_name, email=@email,contact=@contact, gender=@gender, address=@address, blood_group= @blood_group, added_date=@added_date, image_name=@image_name, added_by=@added_by WHERE donor_id=@donor_id";

                    MySqlCommand cmd = new MySqlCommand();

                    cmd.Parameters.AddWithValue("@donor_id", b.donor_id);
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
    }
}