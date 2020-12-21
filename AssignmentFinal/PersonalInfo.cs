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
        public PersonalInfo(User user)
        {
            
            InitializeComponent();
            WelcomeLabel.Text+=" "+user.Name+"'s Diary";
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
    }
}
