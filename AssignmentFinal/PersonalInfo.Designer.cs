
namespace AssignmentFinal
{
    partial class PersonalInfo
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
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.UpdateProfileButton = new System.Windows.Forms.Button();
            this.ChangePasswordButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.BackColor = System.Drawing.Color.Transparent;
            this.WelcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLabel.ForeColor = System.Drawing.Color.White;
            this.WelcomeLabel.Location = new System.Drawing.Point(12, 39);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(206, 37);
            this.WelcomeLabel.TabIndex = 0;
            this.WelcomeLabel.Text = "Welcome to ";
            // 
            // LogOutButton
            // 
            this.LogOutButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.LogOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LogOutButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.LogOutButton.Location = new System.Drawing.Point(652, 386);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(117, 52);
            this.LogOutButton.TabIndex = 1;
            this.LogOutButton.Text = "Log Out";
            this.LogOutButton.UseVisualStyleBackColor = false;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // UpdateProfileButton
            // 
            this.UpdateProfileButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.UpdateProfileButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UpdateProfileButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.UpdateProfileButton.Location = new System.Drawing.Point(568, 36);
            this.UpdateProfileButton.Name = "UpdateProfileButton";
            this.UpdateProfileButton.Size = new System.Drawing.Size(220, 40);
            this.UpdateProfileButton.TabIndex = 2;
            this.UpdateProfileButton.Text = "Update Profile";
            this.UpdateProfileButton.UseVisualStyleBackColor = false;
            this.UpdateProfileButton.Click += new System.EventHandler(this.UpdateProfileButton_Click);
            // 
            // ChangePasswordButton
            // 
            this.ChangePasswordButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ChangePasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ChangePasswordButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ChangePasswordButton.Location = new System.Drawing.Point(568, 110);
            this.ChangePasswordButton.Name = "ChangePasswordButton";
            this.ChangePasswordButton.Size = new System.Drawing.Size(220, 40);
            this.ChangePasswordButton.TabIndex = 3;
            this.ChangePasswordButton.Text = "Change Password";
            this.ChangePasswordButton.UseVisualStyleBackColor = false;
            // 
            // PersonalInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AssignmentFinal.Properties.Resources._83f937b69f30bb886ab8a03390da6771;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ChangePasswordButton);
            this.Controls.Add(this.UpdateProfileButton);
            this.Controls.Add(this.LogOutButton);
            this.Controls.Add(this.WelcomeLabel);
            this.ForeColor = System.Drawing.Color.Gold;
            this.Name = "PersonalInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personal Information";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PersonalInfo_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Button LogOutButton;
        private System.Windows.Forms.Button UpdateProfileButton;
        private System.Windows.Forms.Button ChangePasswordButton;
    }
}