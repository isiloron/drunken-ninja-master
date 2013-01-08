using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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

        private void pictureBoxut_Click(object sender, EventArgs e)
        {

        }

        private void textBoxnärut_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxutskrift_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnskrivut_Click(object sender, EventArgs e)
        {
             
        }
    }
}
