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
        private Button printButton = new Button();
        private PrintDocument printDocument1 = new PrintDocument();
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

            printButton.Click += new EventHandler(btnskrivut_Click);
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            this.Controls.Add(printButton);
        }

        private void Utskrftsform_Load(object sender, EventArgs e)
        {

        }

        private void btnskrivut_Click(object sender, EventArgs e)
        {
            CaptureScreen();
            printDocument1.Print();  
          
        }
        Bitmap memoryImage;
        private void CaptureScreen()
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
        }

        private void printDocument1_PrintPage(System.Object sender,
               System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }


        }
 
}


