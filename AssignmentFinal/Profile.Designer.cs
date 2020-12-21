
using System;

namespace AssignmentFinal
{
    partial class Profile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.BackRegisterButton = new System.Windows.Forms.Button();
            this.SaveChangesButton = new System.Windows.Forms.Button();
            this.BloodGroupComboBox = new System.Windows.Forms.ComboBox();
            this.BloodGroupLabel = new System.Windows.Forms.Label();
            this.FemaleRadioButton = new System.Windows.Forms.RadioButton();
            this.MaleRadioButton = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.GenderLabel = new System.Windows.Forms.Label();
            this.DateofBirthLabel = new System.Windows.Forms.Label();
            this.UserBox = new System.Windows.Forms.TextBox();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.NametextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.ProfileLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.EmailBox);
            this.panel1.Controls.Add(this.EmailLabel);
            this.panel1.Controls.Add(this.BackRegisterButton);
            this.panel1.Controls.Add(this.SaveChangesButton);
            this.panel1.Controls.Add(this.BloodGroupComboBox);
            this.panel1.Controls.Add(this.BloodGroupLabel);
            this.panel1.Controls.Add(this.FemaleRadioButton);
            this.panel1.Controls.Add(this.MaleRadioButton);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.GenderLabel);
            this.panel1.Controls.Add(this.DateofBirthLabel);
            this.panel1.Controls.Add(this.UserBox);
            this.panel1.Controls.Add(this.UserNameLabel);
            this.panel1.Controls.Add(this.NametextBox);
            this.panel1.Controls.Add(this.NameLabel);
            this.panel1.Location = new System.Drawing.Point(195, 125);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(512, 569);
            this.panel1.TabIndex = 1;
            // 
            // EmailBox
            // 
            this.EmailBox.Location = new System.Drawing.Point(168, 130);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(326, 26);
            this.EmailBox.TabIndex = 19;
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabel.Location = new System.Drawing.Point(45, 131);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(65, 25);
            this.EmailLabel.TabIndex = 18;
            this.EmailLabel.Text = "Email";
            // 
            // BackRegisterButton
            // 
            this.BackRegisterButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BackRegisterButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BackRegisterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackRegisterButton.Location = new System.Drawing.Point(199, 472);
            this.BackRegisterButton.Name = "BackRegisterButton";
            this.BackRegisterButton.Size = new System.Drawing.Size(118, 42);
            this.BackRegisterButton.TabIndex = 17;
            this.BackRegisterButton.Text = "Back";
            this.BackRegisterButton.UseVisualStyleBackColor = false;
            this.BackRegisterButton.Click += new System.EventHandler(this.BackRegisterButton_Click);
            // 
            // SaveChangesButton
            // 
            this.SaveChangesButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.SaveChangesButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SaveChangesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveChangesButton.Location = new System.Drawing.Point(147, 404);
            this.SaveChangesButton.Name = "SaveChangesButton";
            this.SaveChangesButton.Size = new System.Drawing.Size(213, 42);
            this.SaveChangesButton.TabIndex = 1;
            this.SaveChangesButton.Text = "Save Changes";
            this.SaveChangesButton.UseVisualStyleBackColor = false;
            this.SaveChangesButton.Click += new System.EventHandler(this.SaveChangesButton_Click);
            // 
            // BloodGroupComboBox
            // 
            this.BloodGroupComboBox.FormattingEnabled = true;
            this.BloodGroupComboBox.Items.AddRange(new object[] {
            "A+",
            "A-",
            "O+",
            "O-",
            "B+",
            "B-",
            "AB+",
            "AB-"});
            this.BloodGroupComboBox.Location = new System.Drawing.Point(168, 327);
            this.BloodGroupComboBox.Name = "BloodGroupComboBox";
            this.BloodGroupComboBox.Size = new System.Drawing.Size(121, 28);
            this.BloodGroupComboBox.TabIndex = 16;
            // 
            // BloodGroupLabel
            // 
            this.BloodGroupLabel.AutoSize = true;
            this.BloodGroupLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BloodGroupLabel.Location = new System.Drawing.Point(5, 326);
            this.BloodGroupLabel.Name = "BloodGroupLabel";
            this.BloodGroupLabel.Size = new System.Drawing.Size(139, 25);
            this.BloodGroupLabel.TabIndex = 15;
            this.BloodGroupLabel.Text = "Blood Group:";
            // 
            // FemaleRadioButton
            // 
            this.FemaleRadioButton.AutoSize = true;
            this.FemaleRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FemaleRadioButton.Location = new System.Drawing.Point(313, 259);
            this.FemaleRadioButton.Name = "FemaleRadioButton";
            this.FemaleRadioButton.Size = new System.Drawing.Size(108, 29);
            this.FemaleRadioButton.TabIndex = 14;
            this.FemaleRadioButton.TabStop = true;
            this.FemaleRadioButton.Text = "Female";
            this.FemaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // MaleRadioButton
            // 
            this.MaleRadioButton.AutoSize = true;
            this.MaleRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaleRadioButton.Location = new System.Drawing.Point(168, 259);
            this.MaleRadioButton.Name = "MaleRadioButton";
            this.MaleRadioButton.Size = new System.Drawing.Size(84, 29);
            this.MaleRadioButton.TabIndex = 13;
            this.MaleRadioButton.TabStop = true;
            this.MaleRadioButton.Text = "Male";
            this.MaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(168, 200);
            this.dateTimePicker1.MaxDate = new System.DateTime(2020, 12, 20, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(326, 26);
            this.dateTimePicker1.TabIndex = 12;
            this.dateTimePicker1.Value = new System.DateTime(2020, 12, 20, 0, 0, 0, 0);
            // 
            // GenderLabel
            // 
            this.GenderLabel.AutoSize = true;
            this.GenderLabel.BackColor = System.Drawing.Color.Transparent;
            this.GenderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenderLabel.Location = new System.Drawing.Point(45, 259);
            this.GenderLabel.Name = "GenderLabel";
            this.GenderLabel.Size = new System.Drawing.Size(90, 25);
            this.GenderLabel.TabIndex = 10;
            this.GenderLabel.Text = "Gender:";
            // 
            // DateofBirthLabel
            // 
            this.DateofBirthLabel.AutoSize = true;
            this.DateofBirthLabel.BackColor = System.Drawing.Color.Transparent;
            this.DateofBirthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateofBirthLabel.Location = new System.Drawing.Point(12, 200);
            this.DateofBirthLabel.Name = "DateofBirthLabel";
            this.DateofBirthLabel.Size = new System.Drawing.Size(138, 25);
            this.DateofBirthLabel.TabIndex = 8;
            this.DateofBirthLabel.Text = "Date of Birth:";
            // 
            // UserBox
            // 
            this.UserBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserBox.Location = new System.Drawing.Point(168, 86);
            this.UserBox.Name = "UserBox";
            this.UserBox.Size = new System.Drawing.Size(326, 26);
            this.UserBox.TabIndex = 3;
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.UserNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameLabel.Location = new System.Drawing.Point(3, 87);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(132, 25);
            this.UserNameLabel.TabIndex = 2;
            this.UserNameLabel.Text = "User Name :";
            // 
            // NametextBox
            // 
            this.NametextBox.Location = new System.Drawing.Point(168, 37);
            this.NametextBox.Name = "NametextBox";
            this.NametextBox.Size = new System.Drawing.Size(326, 26);
            this.NametextBox.TabIndex = 1;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.BackColor = System.Drawing.Color.Transparent;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(30, 38);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(75, 25);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Name:";
            // 
            // ProfileLabel
            // 
            this.ProfileLabel.AutoSize = true;
            this.ProfileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfileLabel.Location = new System.Drawing.Point(13, 39);
            this.ProfileLabel.Name = "ProfileLabel";
            this.ProfileLabel.Size = new System.Drawing.Size(306, 37);
            this.ProfileLabel.TabIndex = 2;
            this.ProfileLabel.Text = "Profile Information:";
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AssignmentFinal.Properties.Resources.fantasy_3645269_960_720;
            this.ClientSize = new System.Drawing.Size(897, 706);
            this.Controls.Add(this.ProfileLabel);
            this.Controls.Add(this.panel1);
            this.Name = "Profile";
            this.Text = "Profile";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Profile_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Button BackRegisterButton;
        private System.Windows.Forms.Button SaveChangesButton;
        private System.Windows.Forms.ComboBox BloodGroupComboBox;
        private System.Windows.Forms.Label BloodGroupLabel;
        private System.Windows.Forms.RadioButton FemaleRadioButton;
        private System.Windows.Forms.RadioButton MaleRadioButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label GenderLabel;
        private System.Windows.Forms.Label DateofBirthLabel;
        private System.Windows.Forms.TextBox UserBox;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.TextBox NametextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label ProfileLabel;
    }
}