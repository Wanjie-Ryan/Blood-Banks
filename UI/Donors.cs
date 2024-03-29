﻿using Blood_Banks.BLL;
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
        userDAL user = new userDAL();
        string imageName = "no-image.png";
        int added_by = 1;

        private void pbdonorsClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbladdress_Click(object sender, EventArgs e)
        {

        }

        public void Clear()
        {
            txtUserID.Text = "";
            txtFirstname.Text = "";
            txtLastname.Text = "";
            txtEmail.Text = "";
            cmbGender.Text = "";
            cmbBloodGroup.Text = "";
            txtDonorContact.Text = "";
            txtAddress.Text = "";

            //clear the picturebox

            string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 26));
            string imagepath = path + "\\images\\no-image.png";
            pbSelectImage.Image = new Bitmap(imagepath);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            // do not need to pass the id od the donor cause it is auto generated by the db

            d.image_name = imageName;
            d.first_name = txtFirstname.Text;
            d.last_name = txtLastname.Text;
            d.email = txtEmail.Text;
            d.contact = txtDonorContact.Text;
            d.address = txtAddress.Text;
            d.email = txtEmail.Text;
            d.gender = cmbGender.Text;
            d.blood_group = cmbBloodGroup.Text;
            d.added_date = DateTime.Now;

            // getting the ID of the logged in user

            string loggedInUser = Login.loggedInUser;
            userBLL ubll = user.GetIDFromUsername(loggedInUser);
            if (ubll != null)
            {

            d.added_by = ubll.user_id;
            }
            else
            {
                MessageBox.Show("Cannot find reference", "Ref not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            

            // adding values from the ui to the db

            bool success = donordal.Insert(d);

            if (success == true)
            {
                MessageBox.Show("Donor was added succesfully", "Insertion successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataTable dt = donordal.Select();
                dgvDonors.DataSource = dt;

                Clear();
            }
            else
            {
                MessageBox.Show("Donor failed to be add", "Insertion failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Donors_Load(object sender, EventArgs e)
        {
            // display donors in the dgv
            DataTable dt = donordal.Select();
            dgvDonors.DataSource = dt;
        }

        private void dgvDonors_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtUserID.Text = dgvDonors.Rows[rowIndex].Cells[0].Value.ToString();
            txtFirstname.Text = dgvDonors.Rows[rowIndex].Cells[1].Value.ToString();
            txtLastname.Text = dgvDonors.Rows[rowIndex].Cells[2].Value.ToString();
            txtEmail.Text = dgvDonors.Rows[rowIndex].Cells[3].Value.ToString();
            txtDonorContact.Text = dgvDonors.Rows[rowIndex].Cells[4].Value.ToString();
            cmbGender.Text = dgvDonors.Rows[rowIndex].Cells[5].Value.ToString();
            txtAddress.Text = dgvDonors.Rows[rowIndex].Cells[6].Value.ToString();
            cmbBloodGroup.Text = dgvDonors.Rows[rowIndex].Cells[7].Value.ToString();

            imageName = dgvDonors.Rows[rowIndex].Cells[9].Value.ToString();


            // display the image in the picturebox

            string paths = Application.StartupPath.Substring(0, Application.StartupPath.Length - 26);

            if (imageName != "no-image.jpg")
            {
                //path to destination folder

                string imagePath = paths + "\\images\\" + imageName;

                // display the image in the picturebox
                pbSelectImage.Image = new Bitmap(imagePath);


            }
            else
            {
                //path to destination folder

                string imagePath = paths + "\\images\\no-image.jpg";

                // display the image in the picturebox
                pbSelectImage.Image = new Bitmap(imagePath);

            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            d.donor_id = int.Parse(txtUserID.Text);
            d.first_name = txtFirstname.Text;
            d.last_name = txtLastname.Text;
            d.email = txtEmail.Text;
            d.contact = txtDonorContact.Text;
            d.gender = cmbGender.Text;
            d.address = txtAddress.Text;
            d.blood_group = cmbBloodGroup.Text;
            d.added_date = DateTime.Now;

            string loggedInUser = Login.loggedInUser;
            userBLL ubll = user.GetIDFromUsername(loggedInUser);
            if (ubll != null)
            {
            d.added_by = ubll.user_id;

            }
            else
            {
                MessageBox.Show("Cannot find reference", "Ref not found", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            d.image_name = imageName;

            bool success = false;

            success = donordal.Update(d);

            if (success == true)
            {
                MessageBox.Show("Updated Successfully", "Update Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataTable dt = donordal.Select();
                dgvDonors.DataSource = dt;
                Clear();
            }
            else
            {
                MessageBox.Show("Failed to update", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DataTable dt = donordal.Select();
                dgvDonors.DataSource = dt;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            d.donor_id = int.Parse(txtUserID.Text);

            bool success = donordal.Delete(d);

            if (success == true)
            {
                MessageBox.Show("Donor deleted successfully", "Delete Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataTable dt = donordal.Select();
                dgvDonors.DataSource = dt;
                Clear();
            }
            else
            {
                MessageBox.Show("Failed to delete", "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSI_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();

            try
            {
                if (open.ShowDialog() == DialogResult.OK)
                {
                    if (open.CheckFileExists)
                    {
                        pbSelectImage.Image = new Bitmap(open.FileName);

                        string ext = Path.GetExtension(open.FileName);

                        Random random = new Random();

                        int RandInt = random.Next(1, 1000);

                        imageName = "Donor_" + RandInt + ext;

                        string sourcepath = open.FileName;

                        string path = Application.StartupPath.Substring(0, Application.StartupPath.Length - 26);

                        string destinationpath = path + "\\images\\" + imageName;

                        File.Copy(sourcepath, destinationpath);

                        MessageBox.Show("Image uploaded successfully", "Image Uploaded", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtDonorSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtDonorSearch.Text;

            if( keyword != null)
            {
                DataTable dt = donordal.Search(keyword);
                dgvDonors.DataSource = dt;
            }
            else
            {
                DataTable dt = donordal.Select();
                dgvDonors.DataSource = dt;
            }
        }
    }
}
