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

            listBox1.DataSource = (ingredienssida.ingredienslista.HämtaIngTitlar());
            

            
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
                textBoxIngr.Text += r.ingrName + " ";
                    textBoxIngr.Text += r.ingrNumber.ToString() +" ";
                    textBoxIngr.Text += ingredienssida.ingredienslista.HämtaEnhet(r.ingrName);
                    textBoxIngr.Text += Environment.NewLine;

           }
        }


    }
}
