using System;
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
    public partial class Inlogg : Form //Jonas Håkansson har hand om denna klass
    {
        int passwordcount = 1;  //variabel med antal inloggningsförsök
        public static bool loggedIn = false; //boolean för att kontrollera om man är inloggad eller inte

        public Inlogg()
        {
            InitializeComponent();

            FileStream lösen = new FileStream("password.dat", FileMode.OpenOrCreate); //Öppna filström till password.dat, eller skapa den om den inte redan finns
            StreamReader pass = new StreamReader(lösen);
            string password = pass.ReadLine();  //Läs password-filen
            if (password == null)        // Om lösenordsfilen är tom, visa sidan för att sätta lösenord (Visas första gången programmet körs)
            {
                panelSetPassword.Visible = true;
                panelLogin.Visible = false;
                panelChangePassword.Visible = false;  
                lösen.Close();
                pass.Close();
            }
            else                         //Om lösenordsfilen inte är tom, visa sidan för att logga in vanligt
            {
                panelLogin.Visible = true;
                panelSetPassword.Visible = true;
                panelChangePassword.Visible = false;
                lösen.Close();
                pass.Close();
            }
            
        }


        private void button1_Click(object sender, EventArgs e)      //Event när man trycker på knapp för att sätta lösenord första gången
        {
            if (txtSetPassword.Text == txtConfPassword.Text)        //Om lösenorden stämmer överens
            {
                
                StreamWriter pass = new StreamWriter("password.dat");   //Öppna filen, skriv dit det valda lösenordet, stäng filen, visa meddelande att lösenordet är sparat, sätt inloggningsboolean till true och logga sen in
                string SetPass = txtSetPassword.Text;
                pass.Write(SetPass);
                pass.Close();
                MessageBox.Show("Lösenordet sparat, välkommen!");
                loggedIn = true;
                Receptsida newform = new Receptsida(loggedIn);
                newform.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Lösenorden matchar inte,\nvänligen försök igen!");     // om lösenorden inte matchar, meddela det.
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)      // Event vid tryck på logga in-knappen
        {
            StreamReader pass = new StreamReader("password.dat");       //Öppna passwordfilen, läs in vad som står och spara det i en sträng, stäng sen filen
            string confirm = pass.ReadLine();
            pass.Close();
            

            if (txtPassword.Text == confirm)                //Om det inskrivna lösenordet stämmer överens med det som står i passwordfilen, sätt inloggningsboolean till true och logga in
            {
                loggedIn = true;
                Receptsida newform = new Receptsida(loggedIn);
                newform.Show();
                this.Hide();
            }
            else if (passwordcount < 3)
            {
                MessageBox.Show("Fel lösenord, försök igen!");      //Så länge man inte försökt 3ggr, visa meddelande om fel lösenord
                passwordcount++;
            }
            else
            {
                MessageBox.Show("Du har gjort tre misslyckade inloggningsförsök.\nDu loggas nu in som gäst och kan inte redigera recept, men fortfarande läsa och skriva ut dem.");
                loggedIn = false;                                   //Om man försökt logga in 3 gånger, meddela det och logga in som gäst, med inloggningsboolean satt till false
                Receptsida newform = new Receptsida(loggedIn);
                newform.Show();
                this.Hide();
            }

        }

        private void linkGuestLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)     //Vid tryck på Logga in som gäst, ha kvar inloggningsboolean som false och logga in som gäst
        {
            loggedIn = false;
            Receptsida newform = new Receptsida(loggedIn);
            newform.Show();
            this.Hide();
        }

        private void linkChangePassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)     //Vid tryck på Ändra lösenord, visa sidan för att ändra lösenord
        {
            panelLogin.Visible = false;
            panelSetPassword.Visible = false;
            panelChangePassword.Visible = true;
        }

        private void btnChangePassword_Click(object sender, EventArgs e)        //Vid knapptryckning att byta lösenord
        {
            StreamReader pass = new StreamReader("password.dat");   //Öppna password-filen, spara det som står till en sträng och stäng filen
            string confirm = pass.ReadLine();
            pass.Close();

            if (txtOldPassword.Text == confirm)     //Om texten i gammalt lösenords-rutan stämmer överens med strängen
            {
                if (txtNewPassword.Text == txtConfNewPassword.Text) //Om båda nya lösenordsrutor matchar
                {
                    FileStream passStream = new FileStream("password.dat", FileMode.Truncate, FileAccess.ReadWrite); //Öppna password.dat, trunkera den och sätt så man kan skriva i den
                    StreamWriter passOverwrite = new StreamWriter(passStream);
                    string SetNewPass = txtNewPassword.Text; // Spara texten från nytt lösenords-rutan till en sträng
                    passOverwrite.Write(SetNewPass);    //skriv det nya lösenordet i passwordfilen, och stäng filen
                    passOverwrite.Close();
                    MessageBox.Show("Nytt Lösenord sparat, välkommen!");    //Meddela att nytt lösenord är sparat, sätt boolean till true och logga in
                    loggedIn = true;
                    Receptsida newform = new Receptsida(loggedIn);
                    newform.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Nya Lösenord matchar inte,\nvänligen försök igen!");   //Om nya lösenorden inte matchar, meddela det
                }
            }
            else
            {
                MessageBox.Show("Det gamla lösenordet var inte korrekt! Vänligen försök igen."); //Om det gamla lösenordet inte matchar det som står i filen, meddela det
            }

            
        }
    }
}
