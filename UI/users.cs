using Blood_Banks.BLL;
using MySql.Data.MySqlClient;

 using Blood_Banks.DAL;
//using Blood_Banks.Program;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blood_Banks.UI
{
    public partial class users : Form
    {
        public users()
        {
            InitializeComponent();
        }

         userBLL u = new userBLL();
         userDAL dal = new userDAL();
        //Program pg = new Program();
        string imageName = "no-image.png";
        private void pbusersClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {                    
            u.image_name = imageName;
            u.full_name = txtFullname.Text;
            u.email = txtmail.Text;
            u.username = txtUsername.Text;
            u.password = txtPassword.Text;
            u.contact = txtContact.Text;
            u.address = txtAddress.Text;
            u.added_date = DateTime.Now;

            // adding values from the UI to the DB
            bool Success = dal.Insert(u);

            if (Success == true)
            {
                // data or user added successfully
                MessageBox.Show("User was added successfully", "Insertion Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to add new user", "Insertion Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }
    }
}
