namespace Grupp_7_Projekt
{
    partial class Jonas
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSetPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtConfPassword = new System.Windows.Forms.TextBox();
            this.buttonSetPass = new System.Windows.Forms.Button();
            this.panelSetPassword = new System.Windows.Forms.Panel();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.linkChangePassword = new System.Windows.Forms.LinkLabel();
            this.linkGuestLogin = new System.Windows.Forms.LinkLabel();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panelChangePassword = new System.Windows.Forms.Panel();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.txtConfNewPassword = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.txtOldPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panelSetPassword.SuspendLayout();
            this.panelLogin.SuspendLayout();
            this.panelChangePassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(381, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Välkommen!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(304, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(386, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lösenord:";
            // 
            // txtSetPassword
            // 
            this.txtSetPassword.Location = new System.Drawing.Point(484, 29);
            this.txtSetPassword.Name = "txtSetPassword";
            this.txtSetPassword.Size = new System.Drawing.Size(100, 20);
            this.txtSetPassword.TabIndex = 3;
            this.txtSetPassword.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(329, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Verifiera lösenord:";
            // 
            // txtConfPassword
            // 
            this.txtConfPassword.Location = new System.Drawing.Point(484, 72);
            this.txtConfPassword.Name = "txtConfPassword";
            this.txtConfPassword.Size = new System.Drawing.Size(100, 20);
            this.txtConfPassword.TabIndex = 5;
            this.txtConfPassword.UseSystemPasswordChar = true;
            // 
            // buttonSetPass
            // 
            this.buttonSetPass.Location = new System.Drawing.Point(390, 115);
            this.buttonSetPass.Name = "buttonSetPass";
            this.buttonSetPass.Size = new System.Drawing.Size(181, 35);
            this.buttonSetPass.TabIndex = 6;
            this.buttonSetPass.Text = "Spara lösenord och logga in";
            this.buttonSetPass.UseVisualStyleBackColor = true;
            this.buttonSetPass.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelSetPassword
            // 
            this.panelSetPassword.Controls.Add(this.panelLogin);
            this.panelSetPassword.Controls.Add(this.buttonSetPass);
            this.panelSetPassword.Controls.Add(this.label3);
            this.panelSetPassword.Controls.Add(this.txtConfPassword);
            this.panelSetPassword.Controls.Add(this.txtSetPassword);
            this.panelSetPassword.Controls.Add(this.label4);
            this.panelSetPassword.Location = new System.Drawing.Point(12, 169);
            this.panelSetPassword.Name = "panelSetPassword";
            this.panelSetPassword.Size = new System.Drawing.Size(960, 198);
            this.panelSetPassword.TabIndex = 8;
            // 
            // panelLogin
            // 
            this.panelLogin.Controls.Add(this.linkChangePassword);
            this.panelLogin.Controls.Add(this.linkGuestLogin);
            this.panelLogin.Controls.Add(this.buttonLogin);
            this.panelLogin.Controls.Add(this.txtPassword);
            this.panelLogin.Controls.Add(this.label5);
            this.panelLogin.Location = new System.Drawing.Point(0, 0);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(960, 198);
            this.panelLogin.TabIndex = 7;
            // 
            // linkChangePassword
            // 
            this.linkChangePassword.AutoSize = true;
            this.linkChangePassword.Location = new System.Drawing.Point(446, 129);
            this.linkChangePassword.Name = "linkChangePassword";
            this.linkChangePassword.Size = new System.Drawing.Size(87, 13);
            this.linkChangePassword.TabIndex = 9;
            this.linkChangePassword.TabStop = true;
            this.linkChangePassword.Text = "Ändra lösenordet";
            this.linkChangePassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkChangePassword_LinkClicked);
            // 
            // linkGuestLogin
            // 
            this.linkGuestLogin.AutoSize = true;
            this.linkGuestLogin.Location = new System.Drawing.Point(443, 112);
            this.linkGuestLogin.Name = "linkGuestLogin";
            this.linkGuestLogin.Size = new System.Drawing.Size(93, 13);
            this.linkGuestLogin.TabIndex = 8;
            this.linkGuestLogin.TabStop = true;
            this.linkGuestLogin.Text = "Logga in som gäst";
            this.linkGuestLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkGuestLogin_LinkClicked);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(432, 74);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(121, 35);
            this.buttonLogin.TabIndex = 7;
            this.buttonLogin.Text = "Logga in";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(484, 33);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(386, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Lösenord:";
            // 
            // panelChangePassword
            // 
            this.panelChangePassword.Controls.Add(this.btnChangePassword);
            this.panelChangePassword.Controls.Add(this.txtConfNewPassword);
            this.panelChangePassword.Controls.Add(this.label8);
            this.panelChangePassword.Controls.Add(this.label7);
            this.panelChangePassword.Controls.Add(this.txtNewPassword);
            this.panelChangePassword.Controls.Add(this.txtOldPassword);
            this.panelChangePassword.Controls.Add(this.label6);
            this.panelChangePassword.Location = new System.Drawing.Point(12, 169);
            this.panelChangePassword.Name = "panelChangePassword";
            this.panelChangePassword.Size = new System.Drawing.Size(960, 198);
            this.panelChangePassword.TabIndex = 9;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Location = new System.Drawing.Point(390, 145);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(194, 38);
            this.btnChangePassword.TabIndex = 10;
            this.btnChangePassword.Text = "Byt lösenord och logga in";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // txtConfNewPassword
            // 
            this.txtConfNewPassword.Location = new System.Drawing.Point(484, 105);
            this.txtConfNewPassword.Name = "txtConfNewPassword";
            this.txtConfNewPassword.Size = new System.Drawing.Size(100, 20);
            this.txtConfNewPassword.TabIndex = 9;
            this.txtConfNewPassword.UseSystemPasswordChar = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(297, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Bekräfta nytt lösenord:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(360, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Nytt lösenord:";
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(484, 70);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(100, 20);
            this.txtNewPassword.TabIndex = 6;
            this.txtNewPassword.UseSystemPasswordChar = true;
            // 
            // txtOldPassword
            // 
            this.txtOldPassword.Location = new System.Drawing.Point(484, 32);
            this.txtOldPassword.Name = "txtOldPassword";
            this.txtOldPassword.Size = new System.Drawing.Size(100, 20);
            this.txtOldPassword.TabIndex = 5;
            this.txtOldPassword.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(311, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Nuvarande lösenord:";
            // 
            // Jonas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 694);
            this.Controls.Add(this.panelChangePassword);
            this.Controls.Add(this.panelSetPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Jonas";
            this.Text = "Jonas";
            this.panelSetPassword.ResumeLayout(false);
            this.panelSetPassword.PerformLayout();
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.panelChangePassword.ResumeLayout(false);
            this.panelChangePassword.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSetPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtConfPassword;
        private System.Windows.Forms.Button buttonSetPass;
        private System.Windows.Forms.Panel panelSetPassword;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel linkChangePassword;
        private System.Windows.Forms.LinkLabel linkGuestLogin;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Panel panelChangePassword;
        private System.Windows.Forms.TextBox txtOldPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.TextBox txtConfNewPassword;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNewPassword;
    }
}