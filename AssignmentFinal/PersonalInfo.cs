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
        User user1;
        public PersonalInfo(User user)
        {
            
            InitializeComponent();
            WelcomeLabel.Text+=" "+user.Name+"'s Diary";
            user1 = user;
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
            Profile p = new Profile(user1);
            this.Hide();
            p.Show();
        }
    }
}
