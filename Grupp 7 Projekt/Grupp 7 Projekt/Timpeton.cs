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
    public partial class Timpeton : Form
    {
        public Timpeton()
        {
            InitializeComponent();
        }

        private void Timpeton_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkPotatis_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

           
                    
            label4.Text = "Potatis";
            label7.Text = "Näringsvärden";
            label5.Text = "Information";
            textBox3.Text = "Potatisens näringsvärden ska stå här";
            textBox1.Text = "Här ska det stå information om potatis";
            label6.Hide();
            textBox2.Hide();
            pictureBox1.ImageLocation = "http://blogg.olandsbladet.se/vagentillvarvet/wp-content/uploads/2011/02/potatis.jpg";

        }

        private void linkBroccoli_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StreamReader broc = new StreamReader("broccoli.txt");

            label4.Text = broc.ReadLine();
            label7.Text = broc.ReadLine();
            label5.Text = "Information";
            textBox3.Text = "Broccolis näringsvärden ska stå här";
            textBox1.Text = "Här ska det stå information om broccoli";
            label6.Hide();
            textBox2.Hide();
            pictureBox1.ImageLocation = "http://www.worldcommunitycookbook.org/season/guide/photos/broccoli.jpg";

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
