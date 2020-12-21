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
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void SignUpForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            string message = "Are you Want to Exit?";
            string title = "Closing Window?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if(result ==DialogResult.Yes)
            {
                Application.Exit(); 
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void BackRegisterButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            string sql = "";
            if (NametextBox.Text != "" && UserBox.Text != "" && PasswordBox.Text != "" && ConfirmPassBox.Text != "" &&
               EmailBox.Text != "" && (MaleRadioButton.Checked || FemaleRadioButton.Checked) && BloodGroupComboBox.Text != "" && checkBox1.Checked)
            {
                if (PasswordBox.Text == ConfirmPassBox.Text)
                {
                    string email = EmailBox.Text;
                    string word = ".com";
                    if (email.Contains(word))
                    {
                        if (MaleRadioButton.Checked)
                        {
                            sql = "INSERT INTO Users(Name,UserName,Email,DOB,Password,Gender,BloodGroup) VALUES('" + NametextBox.Text + "','" + UserBox.Text + "','" + EmailBox.Text + "','" + dateTimePicker1.Text + "','" + PasswordBox.Text + "','" + MaleRadioButton.Text + "','"  + BloodGroupComboBox.Text + "')";

                        }
                        else if (FemaleRadioButton.Checked)
                        {
                            sql = "INSERT INTO Users(Name,UserName,Email,DOB,Password,Gender,BloodGroup) VALUES('" + NametextBox.Text + "','" + UserBox.Text + "','" + EmailBox.Text + "','" + dateTimePicker1.Text + "','" + PasswordBox.Text + "','"  + FemaleRadioButton.Text + "','"  + BloodGroupComboBox.Text + "')";



                        }
                        DataConnection dataConnection = new DataConnection();
                        int result = dataConnection.ExecuteQuery(sql);
                        if (result > 0)
                        {
                            MessageBox.Show("User Added Successfully");
                            NametextBox.Text = UserBox.Text = EmailBox.Text = PasswordBox.Text = ConfirmPassBox.Text = BloodGroupComboBox.Text = string.Empty;
                            MaleRadioButton.Checked = false;
                            FemaleRadioButton.Checked = false;
                            checkBox1.Checked = false;

                        }
                        else
                        {
                            MessageBox.Show("Invalid");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Invalid Email!");
                    }
                }
                else
                {
                    MessageBox.Show("Enter Password Again!");
                }
            }
            else
            {
                MessageBox.Show("Please fill up the form and check the agreement!");
            }
            

        }

        
    }
}
