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
using System.Security.Cryptography.X509Certificates;
using static System.Net.Mime.MediaTypeNames;

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

                // display the data in the datagridview
                DataTable dt = dal.Select();
                dgvUsers.DataSource = dt;

                //clear the textboxes
                Clear();
            }
            else
            {
                MessageBox.Show("Failed to add new user", "Insertion Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Clear()
        {
            txtUserID.Text = "";
            txtFullname.Text = "";
            txtmail.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtContact.Text = "";
            txtAddress.Text = "";

        }

        private void dgvUsers_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // find the row index of the row clicked 

            int rowIndex = e.RowIndex;
            txtUserID.Text = dgvUsers.Rows[rowIndex].Cells[0].Value.ToString();
            txtUsername.Text = dgvUsers.Rows[rowIndex].Cells[1].Value.ToString();
            txtmail.Text = dgvUsers.Rows[rowIndex].Cells[2].Value.ToString();
            txtPassword.Text = dgvUsers.Rows[rowIndex].Cells[3].Value.ToString();
            txtFullname.Text = dgvUsers.Rows[rowIndex].Cells[4].Value.ToString();
            txtContact.Text = dgvUsers.Rows[rowIndex].Cells[5].Value.ToString();
            txtAddress.Text = dgvUsers.Rows[rowIndex].Cells[6].Value.ToString();
            imageName = dgvUsers.Rows[rowIndex].Cells[7].Value.ToString();


        }

        private void users_Load(object sender, EventArgs e)
        {
            //load the data when the app is launched

            DataTable dt = dal.Select();
            dgvUsers.DataSource = dt;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            u.user_id = int.Parse(txtUserID.Text);
            u.username = txtUsername.Text;
            u.email = txtmail.Text;
            u.password = txtPassword.Text;
            u.full_name = txtFullname.Text;
            u.contact = txtContact.Text;
            u.address = txtAddress.Text;
            u.added_date = DateTime.Now;
            u.image_name = imageName;

            bool isSuccess = false;

            isSuccess = dal.Update(u);

            if (isSuccess == true)
            {
                MessageBox.Show("User has been updated successfully", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // load the data on the datagridview
                DataTable dt = dal.Select();
                dgvUsers.DataSource = dt;

                Clear();
            }
            else
            {
                MessageBox.Show("Failed to update user", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            u.user_id = int.Parse(txtUserID.Text);

            bool isSuccess = dal.Delete(u);

            if(isSuccess == true)
            {
                MessageBox.Show("User has been deleted successfully", "Delete Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DataTable dt = dal.Select();
                dgvUsers.DataSource = dt;

                Clear();
            }
            else 
            {
                MessageBox.Show("Failed to delete user", "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
