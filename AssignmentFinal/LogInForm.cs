using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssignmentFinal
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }

        private void LogInForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            {
                string message = "Are you Want to Exit?";
                string title = "Closing Window?";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (UserNameTextbox.Text != string.Empty && PasswordTextBox.Text != string.Empty)
            {
                string sql = "SELECT * FROM Users WHERE UserName='" + UserNameTextbox.Text + "'AND Password='" + PasswordTextBox.Text + "'";
                SqlDataReader sqlDataReader;
                try
                {
                    DataConnection dataConnection = new DataConnection();
                    sqlDataReader = dataConnection.GetData(sql);
                    sqlDataReader.Read();
                    User user = new User(sqlDataReader["Name"].ToString(), sqlDataReader["UserName"].ToString(), sqlDataReader["Email"].ToString(), sqlDataReader["Password"].ToString(), sqlDataReader["DOB"].ToString(), sqlDataReader["Gender"].ToString(), sqlDataReader["BloodGroup"].ToString());
                    PersonalInfo pi = new PersonalInfo(user);
                    pi.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    string msg = ex.Message;
                    MessageBox.Show("User Name or Password incorrect");
                }
            }
            else
            {
                MessageBox.Show("Fields Cannot be Empty!");
            }
        }
    }
}
