using Blood_Banks.BLL;
using Blood_Banks.DAL;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        loginDAL login = new loginDAL();
        loginBLL lb = new loginBLL();
        private void btnLogin_Click(object sender, EventArgs e)
        {
            lb.username = txtUsername.Text;
            lb.password = txtPassword.Text;

            bool success = login.LoginCheck(lb);

            if(success == true)
            {
                MessageBox.Show("User Login successful", "Login Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                HomeForm hf = new HomeForm();
                hf.Show();
                //this.Hide();

            }
            else
            {
                MessageBox.Show("User Login Failed", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void pbCloseLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
