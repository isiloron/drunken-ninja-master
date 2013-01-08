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
        }

        private void Utskrftsform_Load(object sender, EventArgs e)
        {

        }

        private void btnskrivut_Click(object sender, EventArgs e)
        {
            
            System.Drawing.Printing.PrintDocument Doc = new System.Drawing.Printing.PrintDocument();
            Doc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.Doc_PrintPage123);
            Doc.DefaultPageSettings.Landscape = true;
            Doc.DefaultPageSettings.PrinterSettings.DefaultPageSettings.Landscape = true;
            Doc.DefaultPageSettings.PrinterSettings.Copies = 1;
            Doc.PrinterSettings.Copies = 1;
            Doc.Print();
        }

 private void Doc_PrintPage123(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bitmap = new Bitmap(this.Width, this.Height);
            this.DrawToBitmap(bitmap, new Rectangle(0, 0, bitmap.Width, bitmap.Height));
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        

 

            //PrintDocument pd = new PrintDocument();
            //PrintDialog wtf = new PrintDialog();
            //wtf.Document = pd;
            //PrintPreviewDialog Preview = new PrintPreviewDialog();
            //Preview.Document = pd;
            //Preview.ShowDialog();
            //if (wtf.ShowDialog() == DialogResult.OK)
            //{
            //    pd.Print();
            //}
        }
 
}


