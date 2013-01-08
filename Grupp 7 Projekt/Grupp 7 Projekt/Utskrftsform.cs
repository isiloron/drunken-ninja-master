using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace Grupp_7_Projekt
{
    public partial class Utskrftsform : Form
    {
        private PrintDocument SkrivutDok = new PrintDocument();
        public Utskrftsform(TextBox textBoxIngr, ComboBox comboBoxPort, Label lblTitel, TextBox textBoxnär, TextBox textBoxTil, PictureBox pictureBox1)
        {

            InitializeComponent();
            textBoxutskrift.Text = textBoxIngr.Text;
            lbltitelut.Text = lblTitel.Text;
            textBoxPortUt.Text = comboBoxPort.Text;
            textBoxnärut.Text = textBoxnär.Text;
            textBoxtilut.Text = textBoxTil.Text;
            pictureBoxut.Image = pictureBox1.Image;
            pictureBoxbakgrund.SendToBack();

           
            SkrivutDok.PrintPage += new PrintPageEventHandler(SkrivutDok_PrintSida);
            
        }

        private void Utskrftsform_Load(object sender, EventArgs e)
        {

        }

        private void btnskrivut_Click(object sender, EventArgs e) //När man trycker på Skriv ut knappen anopas metoderna
        {
            SparaBild();
            SkrivutDok.Print();  
          
        }
        Bitmap memoryBild;
        private void SparaBild() //tar printscreen på fönstret och sparar bilden på minnet
        {
            Graphics Bild = this.CreateGraphics();
            Size s = this.Size;
            memoryBild = new Bitmap(s.Width, s.Height, Bild);
            Graphics memoryGrafik= Graphics.FromImage(memoryBild);
            memoryGrafik.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
        }

        private void SkrivutDok_PrintSida(System.Object sender, System.Drawing.Printing.PrintPageEventArgs e)//skriver ut
        {
            e.Graphics.DrawImage(memoryBild, 0, 0);
        }


        }
 
}


