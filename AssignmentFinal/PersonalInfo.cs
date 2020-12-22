using Microsoft.VisualBasic;
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
    public partial class PersonalInfo : Form
    {
        User user;
        public PersonalInfo(User user)
        {
            
            InitializeComponent();
            WelcomeLabel.Text+=" "+user.Name+"'s Diary";
            user = user;
        }

        private void PersonalInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            LogInForm lg = new LogInForm();
            lg.Show();
            this.Hide();
        }

        private void UpdateProfileButton_Click(object sender, EventArgs e)
        {
            Profile p = new Profile(user);
            this.Hide();
            p.Show();
        }

        private void ChangePasswordButton_Click(object sender, EventArgs e)
        {

             
            string myvalue = Interaction.InputBox("Change Password", "Enter Current Password:", "Enter password");
            if (myvalue == user.Password)
            {
                string newPass = Interaction.InputBox("Change Password", "Enter New Password:", "Enter New password");
                string confPass = Interaction.InputBox("Change Password", "Confirm Password:", "Enter password");
                if (newPass == confPass)
                {
                    user.Password = newPass;
                }
                else
                {
                    MessageBox.Show("Password Confirmation Error!");
                }
            }
            else
            {
                MessageBox.Show("Incorrect Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void ChangeDatabutton_Click(object sender, EventArgs e)
        {
            Event et = new Event(user,this);
            this.Hide();
            et.Show();
        }
    }
}
