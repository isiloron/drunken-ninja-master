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
    public partial class Receptsida : Form
    {
        Receptlista receptlista = new Receptlista();
        Ingredienssida ingredienssida = new Ingredienssida();

        

        public Receptsida()
        {
            receptlista.LaddaRecept();
            InitializeComponent();
            listBox2.DataSource = receptlista.HämtaTitlar();
            
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

           
                    
            lblRubrik.Text = "Potatis";
            lblIng.Text = "Näringsvärden";
            lblNär.Text = "Information";
            textBoxIngr.Text = "Potatisens näringsvärden ska stå här";
            textBoxNär.Text = "Här ska det stå information om potatis";
            lblTil.Hide();
            textBoxTil.Hide();
            pictureBox1.ImageLocation = "http://blogg.olandsbladet.se/vagentillvarvet/wp-content/uploads/2011/02/potatis.jpg";

        }

        private void linkBroccoli_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StreamReader broc = new StreamReader("broccoli.txt");

            lblRubrik.Text = broc.ReadLine();
            lblIng.Text = broc.ReadLine();
            lblNär.Text = "Information";
            textBoxIngr.Text = "Broccolis näringsvärden ska stå här";
            textBoxNär.Text = "Här ska det stå information om broccoli";
            lblTil.Hide();
            textBoxTil.Hide();
            pictureBox1.ImageLocation = "http://www.worldcommunitycookbook.org/season/guide/photos/broccoli.jpg";

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           Recept temp = receptlista.HämtaReceptAvNamn(listBox2.SelectedItem.ToString());
           lblRubrik.Text = temp.Titel; textBoxIngr.Text = "";
            foreach (ReceptSubStruct r in temp.IngrList)
            {
                textBoxIngr.Text += r.ingrName + r.ingrNumber.ToString() + ingr;
           }
        }


    }
}
