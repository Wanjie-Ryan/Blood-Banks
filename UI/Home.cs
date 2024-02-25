using Blood_Banks.UI;

namespace Blood_Banks
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

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

        private void usersNav_Click(object sender, EventArgs e)
        {

        }

        private void usersNav_Click_1(object sender, EventArgs e)
        {
            users userform = new users();
            userform.Show();
        }
    }
}
