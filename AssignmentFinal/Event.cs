using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssignmentFinal
{
    public partial class Event : Form
    {
        string imageLocation;
        Event eventU;
        User user;
        Form back;
        public Event(User user, Form back)
        {
            InitializeComponent();
            eventU = null;
            this.user = user;
            this.back = back;
        }



        public Event(Event eventU, User user, Form back)
        {
            InitializeComponent();
            this.eventU = eventU;
            this.user = user;
            this.back = back;
        }



        private void imageToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }



        private void Editor_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {



        }



        private void pictureBox_Click(object sender, EventArgs e)
        {



        }



        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (eventTitleTextBox.Text != string.Empty && priorityComboBox.Text != string.Empty)
            {
                if (eventU == null)
                {
                    try
                    {
                        string sql = "INSERT INTO Events(EventName,EventDescription,Image,Priority,ModificationDate,userID) VALUES('" + eventTitleTextBox.Text + "','" + descriptionRichTextBox.Text + "',@image,'" + priorityComboBox.Text + "','" + DateTime.Today.ToString() + "'," + user.ID + ")";
                        FileStream fileStream = new FileStream(imageLocation, FileMode.Open, FileAccess.Read);
                        BinaryReader binaryReader = new BinaryReader(fileStream);
                        byte[] img = binaryReader.ReadBytes((int)fileStream.Length);
                        DataConnection dataconnection = new DataConnection();
                        SqlCommand sqlCommand = new SqlCommand(sql, dataconnection.Connection);
                        sqlCommand.Parameters.Add(new SqlParameter("@image", img));
                        int r = dataconnection.ExecuteQuery(sqlCommand);
                        if (r > 0)
                        {
                            MessageBox.Show("Event Created Succesfully!");
                            this.Hide();
                            back.Show();
                        }
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show(exc.ToString());
                    }
                }
                else
                {



                }
            }
            else
            {
                MessageBox.Show("Title & Priority Fields Cannot be Empty!");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "jpeg|*.jpg|bmp|*.bmp|all files|*.*";
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                imageLocation = openFileDialog1.FileName.ToString();
            }
        }
    }
}