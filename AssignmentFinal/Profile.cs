using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssignmentFinal
{
    public partial class Profile : Form
    {
        User user;
        public Profile(User user)
        {
            InitializeComponent();
            this.user = user;
            this.NametextBox.Text = user.Name;
            this.UserBox.Text = user.UserName;
            this.EmailBox.Text = user.Email;
            this.dateTimePicker1.Text = user.Dob;
            this.BloodGroupComboBox.Text = user.BloodGroup;
            if (user.Gender == "Male")
            {
                this.MaleRadioButton.Checked = true;
            }
            else if (user.Gender == "Female")
            {
                this.FemaleRadioButton.Checked = true;
            }
           
        }

        private void Profile_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BackRegisterButton_Click(object sender, EventArgs e)
        {
            PersonalInfo pi = new PersonalInfo(user);
            this.Hide();
            pi.Show();
        }

        private void SaveChangesButton_Click(object sender, EventArgs e)
        {
            if (NametextBox.Text != string.Empty && UserBox.Text != string.Empty && EmailBox.Text != string.Empty && BloodGroupComboBox.Text != string.Empty)
            {
                this.user.Name = NametextBox.Text;
                this.user.UserName = UserBox.Text;
                this.user.Email = EmailBox.Text;
                this.user.Dob = dateTimePicker1.Text;
                this.user.BloodGroup = BloodGroupComboBox.Text;
                if (MaleRadioButton.Checked)
                {
                    this.user.Gender = MaleRadioButton.Text;
                }
                else if (FemaleRadioButton.Checked)
                {
                    this.user.Gender = FemaleRadioButton.Text;
                }
                
                string sql = "UPDATE Users SET Name='" + this.user.Name + "',UserName='" + this.user.UserName + "',Email='" + this.user.Email + "',DOB='" + this.user.Dob + "',Password='" + this.user.Password + "',Gender='" + this.user.Gender + "',BloodGroup='" + this.user.BloodGroup + "' WHERE id=" + this.user.ID;
                try
                {
                    DataConnection dataConnection = new DataConnection();
                    int result = dataConnection.ExecuteQuery(sql);
                    if (result > 0)
                    {
                        MessageBox.Show("Profile Updated Successfully...!");
                    }
                    else
                    {
                        MessageBox.Show("Unsuccessful operation...");
                    }
                    dataConnection.CloseConnection();
                }
                catch (Exception ex)
                {
                    string msg = ex.Message;
                    MessageBox.Show("Invalid Update Request!");
                }
            }
            else
            {
                MessageBox.Show("Fields cannot be Empty!");
            }
        }
    }
}
