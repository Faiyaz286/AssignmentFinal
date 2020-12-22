using Microsoft.VisualBasic;
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
    public partial class PersonalInfo : Form
    {
        User user;
        string ev;
        public PersonalInfo(User user)
        {
            
            InitializeComponent();
            WelcomeLabel.Text+=" "+user.Name+"'s Diary";
            this.user = user;
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
            try
            {
                string sql1 = "SELECT * FROM Events WHERE EventName='" + updateTextBox.Text + "'";
                DataConnection dataAccess1 = new DataConnection();
                SqlDataReader sqlDataReader1 = dataAccess1.GetData(sql1);
                sqlDataReader1.Read();
                Class1 @event = new Class1((int)sqlDataReader1["ID"], sqlDataReader1["EventName"].ToString(), sqlDataReader1["EventDescription"].ToString(), (byte[])sqlDataReader1["Image"], sqlDataReader1["Priority"].ToString(), sqlDataReader1["ModificationDate"].ToString(), user);
                Event editor = new Event(@event, user, this, updateTextBox.Text);
                dataAccess1.CloseConnection();
                editor.Show();
                this.Hide();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
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

        private void deleteButton_Click(object sender, EventArgs e)
        {
            string sqlD = "DELETE FROM Events WHERE EventName='" + updateTextBox.Text + "'";
            try
            {
                DataConnection dataAccess = new DataConnection();
                int resD = dataAccess.ExecuteQuery(sqlD);
                if (resD > 0)
                {
                    MessageBox.Show("Successfuly Deleted!");
                }
                else
                {
                    MessageBox.Show("Unsuccess! Please try again...");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string eventName = (string)dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                updateTextBox.Text = eventName;
                ev = eventName;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string eventName = (string)dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                updateTextBox.Text = eventName;
                ev = eventName;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string eventName = (string)dataGridView3.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                updateTextBox.Text = eventName;
                ev = eventName;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void PersonalInfo_Load(object sender, EventArgs e)
        {
            string sqlH = "SELECT EventName FROM Events WHERE UserID=" + user.ID + " AND Priority='High'";
            string sqlM = "SELECT EventName FROM Events WHERE UserID=" + user.ID + " AND Priority='Moderate'";
            string sqlL = "SELECT EventName FROM Events WHERE UserID=" + user.ID + " AND Priority='Less Important'";
            DataConnection dataAccessH = new DataConnection();
            DataConnection dataAccessM = new DataConnection();
            DataConnection dataAccessL = new DataConnection();
            SqlDataReader sqlDataReaderH = dataAccessH.GetData(sqlH);
            SqlDataReader sqlDataReaderM = dataAccessM.GetData(sqlM);
            SqlDataReader sqlDataReaderL = dataAccessL.GetData(sqlL);
            List<string> eventsH = new List<string>();
            List<string> eventsM = new List<string>();
            List<string> eventsL = new List<string>();

            while (sqlDataReaderH.Read())
            {
                eventsH.Add(sqlDataReaderH["EventName"].ToString());
            }
            while (sqlDataReaderM.Read())
            {
                eventsM.Add(sqlDataReaderM["EventName"].ToString());
            }
            while (sqlDataReaderL.Read())
            {
                eventsL.Add(sqlDataReaderL["EventName"].ToString());
            }
            DataTable dataTableH = new DataTable();
            dataTableH.Columns.Add("EventName High Priority", typeof(string));
            foreach (string str in eventsH)
            {
                DataRow rowH = dataTableH.NewRow();
                rowH["EventName High Priority"] = str;
                dataTableH.Rows.Add(rowH);
            }
            DataTable dataTableM = new DataTable();
            dataTableM.Columns.Add("EventName Moderate Priority", typeof(string));
            foreach (string str in eventsM)
            {
                DataRow rowM = dataTableM.NewRow();
                rowM["EventName Moderate Priority"] = str;
                dataTableM.Rows.Add(rowM);
            }
            DataTable dataTableL = new DataTable();
            dataTableL.Columns.Add("EventName Less Priority", typeof(string));
            foreach (string str in eventsL)
            {
                DataRow rowL = dataTableL.NewRow();
                rowL["EventName Less Priority"] = str;
                dataTableL.Rows.Add(rowL);
            }
            dataGridView1.DataSource = dataTableH;
            dataGridView2.DataSource = dataTableM;
            dataGridView3.DataSource = dataTableL;
            dataAccessH.CloseConnection();
            dataAccessM.CloseConnection();
            dataAccessL.CloseConnection();
        }
    }
}
