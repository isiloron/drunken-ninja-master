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

        private void IndexChange(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                lblIng.Show();
                textBoxIngr.Show();
                lblTil.Text = "Tillagning";
            }
            if (tabControl1.SelectedIndex == 1)
            {
                lblIng.Hide();
                textBoxIngr.Hide();
                lblTil.Text = "Beskrivning";
            }
        
        }


        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Recept temp = receptlista.HämtaReceptAvNamn(listBox2.SelectedItem.ToString());
            lblRubrik.Text = temp.Titel; textBoxIngr.Text = "";
            foreach (ReceptSubStruct r in temp.IngrList)
            {
                textBoxIngr.Text += r.ingrName + " ";
                textBoxIngr.Text += r.ingrNumber.ToString() + " ";
                textBoxIngr.Text += ingredienssida.ingredienslista.HämtaEnhet(r.ingrName);
                textBoxIngr.Text += Environment.NewLine;

            }
        }

        private void ButtonNyttRecept_Click(object sender, EventArgs e)
        {
            NyttReceptForm nrf = new NyttReceptForm();
            nrf.ShowDialog();
            if (nrf.Recept != null)
            {
                receptlista.NyttReceptKlass(nrf.Recept);
                listBox2.DataSource = receptlista.HämtaTitlar();
            }


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ingredient temp = ingredienssida.ingredienslista.HämtaIngrKlass(listBox1.SelectedItem.ToString());
            lblRubrik.Text = temp.Name;
            textBoxTil.Text = temp.Description;
            textBoxNär.Text = "";
            textBoxNär.Text += temp.Energy + " Energy\r\n"+ temp.Fett +"% Fett\r\n"+ temp.Kolhydrater +" Kolhydrater\r\n"+ temp.Protein + " Protein";
        }

        private void ButtonRemoveRecepie_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Är du säker på att du vill ta bort markerat recept?", "Ta bort recept", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                receptlista.TaBort(listBox2.SelectedItem.ToString());
                listBox2.DataSource = receptlista.HämtaTitlar();
            }
        }

        private void ButtonRemoveIngr_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Är du säker på att du vill ta bort markerad ingridiens?", "Ta bort ingridiens", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                ingredienssida.ingredienslista.TaBortIng(listBox1.SelectedItem.ToString());
                listBox1.DataSource = ingredienssida.ingredienslista.HämtaIngTitlar();
            }
        }

        private void ButtonNewingr_Click(object sender, EventArgs e)
        {

        }
    }
}
