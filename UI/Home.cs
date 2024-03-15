using Blood_Banks.DAL;
using Blood_Banks.UI;
using System.Data;

namespace Blood_Banks
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        donorDAL donor = new donorDAL();
        private void menuStripTop_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //Users user = new Users();
            //user.Show();
        }

        private void usersNav_Click_1(object sender, EventArgs e)
        {
            users userform = new users();
            userform.Show();
        }

        private void donorsNav_Click(object sender, EventArgs e)
        {
            Donors donorsForm = new Donors();
            donorsForm.Show();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            //load all the blood donors count when form is loaded
            //call the alldonorcount method
            allDonorCount();

            DataTable dt = donor.Select();
            dgvDonors.DataSource = dt;

            DateTime now = DateTime.Now;
            string greeting;

            if(now.Hour>=0 && now.Hour < 12)
            {
                greeting = "Good Morning";
            }
            else if(now.Hour>=12 && now.Hour < 16)
            {
                greeting = "Good Afternoon";
            }
            else
            {
                greeting = "Good Evening";
            }

            //lblmessage.Text = greeting + Login.loggedInUser;
            lblmessage.Text = $"{greeting}, {Login.loggedInUser}";
        }

        public void allDonorCount()
        {
            // get the donor count from the DB and set it to the respective label
            lblOPosCount.Text = donor.countDonors("O+");
            lblOnegCount.Text = donor.countDonors("O-");
            lblAposCount.Text = donor.countDonors("A+");
            lblAnegCount.Text = donor.countDonors("A-");
            lblBPosCount.Text = donor.countDonors("B+");
            lblBNegCount.Text = donor.countDonors("B-");
            lblABposCount.Text = donor.countDonors("AB+");
            lblABNegCount.Text = donor.countDonors("AB-");

        }

        private void HomeForm_Activated(object sender, EventArgs e)
        {
            allDonorCount();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text;

            if(keyword != null)
            {
                DataTable dt = donor.Search(keyword);
                dgvDonors.DataSource = dt;
            }
            else
            {
                DataTable dt = donor.Select();
                dgvDonors.DataSource = dt;
            }
        }
    }
}
