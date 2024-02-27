﻿using Blood_Banks.BLL;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Blood_Banks.DAL
{
    internal class userDAL
    {
        // Selecting data from DB
        public DataTable Select()
        {
            DataTable dt = new DataTable();

            // Create MySqlConnection using connection string from Program class
            using (MySqlConnection conn = new MySqlConnection(Program.GetConnectionString()))
            {
                try
                {
                    string sql = "SELECT * FROM users";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    conn.Open();
                    adapter.Fill(dt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            return dt;
        }

        public bool Insert(userBLL u)
        {
            bool isSuccess = false;

            using (MySqlConnection conn = new MySqlConnection(Program.GetConnectionString()))
            {
                try
                {
                    string sql = "INSERT INTO users (user_id, username, email, password, full_name, contact, address, added_date, image_name) " +
                                 "VALUES (@user_id, @username, @email, @password, @full_name, @contact, @address, @added_date, @image_name)";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@user_id", u.user_id);
                    cmd.Parameters.AddWithValue("@username", u.username);
                    cmd.Parameters.AddWithValue("@email", u.email);
                    cmd.Parameters.AddWithValue("@password", u.password);
                    cmd.Parameters.AddWithValue("@full_name", u.full_name);
                    cmd.Parameters.AddWithValue("@contact", u.contact);
                    cmd.Parameters.AddWithValue("@address", u.address);
                    cmd.Parameters.AddWithValue("@added_date", u.added_date);
                    cmd.Parameters.AddWithValue("@image_name", u.image_name);

                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();

                    isSuccess = rows > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            return isSuccess;
        }

        // Update functionality
        public bool Update(userBLL u)
        {
            bool isSuccess = false;

            using (MySqlConnection conn = new MySqlConnection(Program.GetConnectionString()))
            {
                try
                {
                    string sql = "UPDATE users SET username = @username, email = @email, " +
                                 "password = @password, full_name = @full_name, contact = @contact, " +
                                 "address = @address, added_date = @added_date, image_name = @image_name " +
                                 "WHERE user_id = @user_id";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

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

                    isSuccess = rows > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            return isSuccess;
        }

        // Deleting data from the DB
        public bool Delete(userBLL u)
        {
            bool isSuccess = false;

            using (MySqlConnection conn = new MySqlConnection(Program.GetConnectionString()))
            {
                try
                {
                    string sql = "DELETE FROM users WHERE user_id = @user_id";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@user_id", u.user_id);

                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();

                    isSuccess = rows > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            return isSuccess;
        }
    }
}
