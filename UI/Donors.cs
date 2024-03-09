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
    public partial class Donors : Form
    {
        public Donors()
        {
            InitializeComponent();
        }

        donorsBLL d = new donorsBLL();
        donorDAL donordal = new donorDAL();
        string imageName = "no-image.png";

        private void pbdonorsClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbladdress_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            d.image_name = imageName;
            d.donor_id = int.Parse(txtUserID.Text);
            d.first_name =txtFirstname.Text;
            d.last_name = txtLastname.Text;
            d.email = txtEmail.Text;
            d.contact = txtDonorContact.Text;
            d.address = txtAddress.Text;
            d.email = txtEmail.Text;
            d.gender = cmbGender.Text;
            d.blood_group = cmbBloodGroup.Text;
            d.added_date = DateTime.Now;
            


            
        }
    }
}
