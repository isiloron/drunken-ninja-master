﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Grupp_7_Projekt
{
    public partial class Inlogg : Form
    {
        int passwordcount = 1;
        public static bool loggedIn = false;

        public Inlogg()
        {
            InitializeComponent();

            FileStream lösen = new FileStream("password.dat", FileMode.OpenOrCreate);
            StreamReader pass = new StreamReader(lösen);
            string password = pass.ReadLine();
            if (password == null)
            {
                panelSetPassword.Visible = true;
                panelLogin.Visible = false;
                panelChangePassword.Visible = false;
                lösen.Close();
                pass.Close();
            }
            else
            {
                panelLogin.Visible = true;
                panelSetPassword.Visible = true;
                panelChangePassword.Visible = false;
                lösen.Close();
                pass.Close();
            }
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (txtSetPassword.Text == txtConfPassword.Text)
            {
                
                StreamWriter pass = new StreamWriter("password.dat");
                string SetPass = txtSetPassword.Text;
                pass.Write(SetPass);
                pass.Close();
                MessageBox.Show("Lösenordet sparat, välkommen!");
                loggedIn = true;
                //Logga in
                Receptsida newform = new Receptsida(loggedIn);
                newform.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Lösenorden matchar inte,\nvänligen försök igen!");
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            StreamReader pass = new StreamReader("password.dat");
            string confirm = pass.ReadLine();
            pass.Close();
            

            if (txtPassword.Text == confirm)            
            {
                loggedIn = true;
                //Logga in
                Receptsida newform = new Receptsida(loggedIn);
                newform.Show();
                this.Hide();
            }
            else if (passwordcount < 3)
            {
                MessageBox.Show("Fel lösenord, försök igen!");
                passwordcount++;
            }
            else
            {
                MessageBox.Show("Du har gjort tre misslyckade inloggningsförsök.\nDu loggas nu in som gäst och kan inte redigera recept, men fortfarande läsa och skriva ut dem.");
                loggedIn = false;
                //Logga in som gäst
                Receptsida newform = new Receptsida(loggedIn);
                newform.Show();
                this.Hide();
            }

        }

        private void linkGuestLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            loggedIn = false;
            //Logga in som gäst
            Receptsida newform = new Receptsida(loggedIn);
            newform.Show();
            this.Hide();
        }

        private void linkChangePassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelLogin.Visible = false;
            panelSetPassword.Visible = false;
            panelChangePassword.Visible = true;
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            StreamReader pass = new StreamReader("password.dat");
            string confirm = pass.ReadLine();
            pass.Close();

            if (txtOldPassword.Text == confirm)
            {
                if (txtNewPassword.Text == txtConfNewPassword.Text)
                {
                    FileStream passStream = new FileStream("password.dat", FileMode.Truncate, FileAccess.ReadWrite);
                    StreamWriter passOverwrite = new StreamWriter(passStream);
                    string SetNewPass = txtNewPassword.Text;
                    passOverwrite.Write(SetNewPass);
                    passOverwrite.Close();
                    MessageBox.Show("Nytt Lösenord sparat, välkommen!");
                    loggedIn = true;
                    //Logga in
                    Receptsida newform = new Receptsida(loggedIn);
                    newform.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Nya Lösenord matchar inte,\nvänligen försök igen!");
                }
            }
            else
            {
                MessageBox.Show("Det gamla lösenordet var inte korrekt! Vänligen försök igen.");
            }

            
        }
    }
}
