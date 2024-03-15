using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blood_Banks.UI
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        int move = 0;
        private void timerSplash_Tick(object sender, EventArgs e)
        {
            timerSplash.Interval = 20;
            // moves the panel by 5px to the right
            panelMovable.Width += 5;

            move += 5;

            //if loading is complete, diaply the login form

            if (move == 960)
            {

                // when loading is complete
                //stop the timer and close the form

                timerSplash.Stop();
                this.Hide();
                //this.Close();

                //display the login form
                Login login = new Login();
                login.Show();
            }
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            //load the timer
            timerSplash.Start();
        }
    }
}
