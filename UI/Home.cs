using Blood_Banks.DAL;
using Blood_Banks.UI;

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
        }

        public void allDonorCount()
        {
            // get the donor count from the DB and set it to the respective label
        }
    }
}
