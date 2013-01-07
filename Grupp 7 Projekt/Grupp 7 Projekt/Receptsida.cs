using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Printing;

namespace Grupp_7_Projekt
{
    public partial class Receptsida : Form
    {
        static Receptlista receptlista = new Receptlista();
        static Ingredienssida ingredienssida = new Ingredienssida();


        public Receptsida()
        {
            receptlista.LaddaRecept();
            InitializeComponent();
            ListBoxRecept.DataSource = receptlista.HämtaTitlar();

            listBoxIngr.DataSource = (ingredienssida.ingredienslista.HämtaIngTitlar());
        }

        private void IndexChange(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                lblIng.Show();
                textBoxIngr.Show();
                lblTil.Text = "Tillagning";
                listBoxRecept_SelectedIndexChanged(null, null);
            }
            if (tabControl1.SelectedIndex == 1)
            {
                lblIng.Hide();
                textBoxIngr.Hide();
                lblTil.Text = "Beskrivning";
                listBoxIngr_SelectedIndexChanged(null, null );
            }
        
        }


        private void listBoxRecept_SelectedIndexChanged(object sender, EventArgs e)
        {
            Recept temp = receptlista.HämtaReceptAvNamn(ListBoxRecept.SelectedItem.ToString());
            lblRubrik.Text = temp.Titel; textBoxIngr.Text = "";
            textBoxTil.Text = temp.Instructions;
            foreach (ReceptSubStruct r in temp.IngrList)
            {
                //This part updates the ingrident box
                textBoxIngr.Text += r.ingrName + " ";
                textBoxIngr.Text += r.ingrNumber.ToString() + " ";
                textBoxIngr.Text += ingredienssida.ingredienslista.HämtaEnhet(r.ingrName);
                textBoxIngr.Text += Environment.NewLine;

                //This part updates the energy values
                textBoxNär.Text = "";
                textBoxNär.Text +=  ingredienssida.ingredienslista.GetTotalEnergy(temp) + " Energi \r\n";
                textBoxNär.Text +=  ingredienssida.ingredienslista.GetTotalKolhyd(temp) + " Kolhydrater \r\n";
                textBoxNär.Text +=  ingredienssida.ingredienslista.GetTotalProtein(temp) +" Proteiner \r\n";
                textBoxNär.Text +=  ingredienssida.ingredienslista.GetTotalFett(temp) + "% Fett \r\n";

            }
        }

        private void ButtonNyttRecept_Click(object sender, EventArgs e)
        {
            NyttReceptForm nrf = new NyttReceptForm();
            nrf.ShowDialog();
            if (nrf.Recept != null)
            {
                receptlista.NyttReceptKlass(nrf.Recept);
                ListBoxRecept.DataSource = receptlista.HämtaTitlar();
            }


        }

        private void listBoxIngr_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ingredient temp = ingredienssida.ingredienslista.HämtaIngrKlass(listBoxIngr.SelectedItem.ToString());
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
                receptlista.TaBort(ListBoxRecept.SelectedItem.ToString());
                ListBoxRecept.DataSource = receptlista.HämtaTitlar();
            }
        }

        private void ButtonRemoveIngr_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Är du säker på att du vill ta bort markerad ingridiens?", "Ta bort ingridiens", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                ingredienssida.ingredienslista.TaBortIng(listBoxIngr.SelectedItem.ToString());
                listBoxIngr.DataSource = ingredienssida.ingredienslista.HämtaIngTitlar();
            }
        }

        private void ButtonNewingr_Click(object sender, EventArgs e)
        {
            NyIngridiensForm nig = new NyIngridiensForm();
            nig.ShowDialog();
            if (nig.newingr != null)
            {
                ingredienssida.ingredienslista.LäggTillIngrKlass(nig.newingr);
                listBoxIngr.DataSource = ingredienssida.ingredienslista.HämtaIngTitlar();
            }

        }

        private void ButtonSearchRecept_Click(object sender, EventArgs e)
        {
            listBoxSearchReceptResults.Items.Clear();
            try
            {
                List<Recept> ResultList = new List<Recept>(receptlista.Clone());
                if (TboxSearchReceptTitel.Text != "") //Om titel angets, sök titel
                {
                    ResultList = receptlista.SökReceptNamn(TboxSearchReceptTitel.Text);
                }
                if ( TboxSearchReceptMinEnergi.Text != "" && TboxSearchReceptMAXEnergi.Text != "") //Om min/max energi angets, sök
                {
                    ResultList = receptlista.SökMinMaxEnergi(Int32.Parse(TboxSearchReceptMinEnergi.Text), Int32.Parse(TboxSearchReceptMAXEnergi.Text), ResultList);

                }
                if (TboxSearchReceptMinFett.Text != "" && TboxSearchReceptMAXFett.Text != "") //Om min/max fett angets, sök
                {
                    ResultList = receptlista.SökMinMaxFett(Int32.Parse(TboxSearchReceptMinFett.Text), Int32.Parse(TboxSearchReceptMAXFett.Text), ResultList);
                }
                if (TBoxSearchReceptMinProtein.Text != "" && TBoxSearchReceptMAXProtein.Text != "") //Om min/max protein angets, sök
                {
                    ResultList = receptlista.SökMinMaxProtein(Int32.Parse(TBoxSearchReceptMinProtein.Text), Int32.Parse(TBoxSearchReceptMAXProtein.Text), ResultList);
                }
                if (TBoxSearchReceptMinKolhyd.Text != "" && TBoxSearchReceptMAXKolhyd.Text != "") //Om minmax kolhydrater angets, sök
                {
                ResultList = receptlista.SökMinMaxKolhydrater(Int32.Parse(TBoxSearchReceptMinKolhyd.Text), Int32.Parse(TBoxSearchReceptMAXKolhyd.Text), ResultList);
                }
                if (listBoxSearchTags.Items.Count != 0)
                {
                    
                    List<string> seachtags = new List<string>();
                    for (int z = 0; z < listBoxSearchTags.Items.Count; z++ )
                    {
                        listBoxSearchTags.SelectedIndex = z;
                        seachtags.Add(listBoxSearchTags.SelectedItem.ToString());
                    }
                    ResultList = receptlista.SökReceptSomHarTag(seachtags, ResultList);

                }
                foreach (Recept rep in ResultList)
                {
                    listBoxSearchReceptResults.Items.Add(rep.Titel);
                }
            }
            catch
            {
                MessageBox.Show("Search failed");
            }
        }

        private void SkrivUt_Click(object sender, EventArgs e)
        {

            ingredienssida.Skrivaren();
            
        }

        private void buttonAddSearchTag_Click(object sender, EventArgs e)
        {
            listBoxSearchTags.Items.Add(TBoxSearchReceptTags.Text);
            TBoxSearchReceptTags.Text = "";
        }

        private void buttonRemoveSearchTag_Click(object sender, EventArgs e)
        {
            listBoxSearchTags.Items.Remove(listBoxSearchTags.SelectedItem);
        }

        private void listBoxSearchReceptResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            Recept temp = receptlista.HämtaReceptAvNamn(listBoxSearchReceptResults.SelectedItem.ToString());
            lblRubrik.Text = temp.Titel; textBoxIngr.Text = "";
            textBoxTil.Text = temp.Instructions;
            foreach (ReceptSubStruct r in temp.IngrList)
            {
                //This part updates the ingrident box
                textBoxIngr.Text += r.ingrName + " ";
                textBoxIngr.Text += r.ingrNumber.ToString() + " ";
                textBoxIngr.Text += ingredienssida.ingredienslista.HämtaEnhet(r.ingrName);
                textBoxIngr.Text += Environment.NewLine;

                //This part updates the energy values
                textBoxNär.Text = "";
                textBoxNär.Text += ingredienssida.ingredienslista.GetTotalEnergy(temp) + " Energi \r\n";
                textBoxNär.Text += ingredienssida.ingredienslista.GetTotalKolhyd(temp) + " Kolhydrater \r\n";
                textBoxNär.Text += ingredienssida.ingredienslista.GetTotalProtein(temp) + " Proteiner \r\n";
                textBoxNär.Text += ingredienssida.ingredienslista.GetTotalFett(temp) + "% Fett \r\n";

            }
        }

        private void buttonSearchIngr_Click(object sender, EventArgs e)
        {
            List<Ingredient> ResultList = new List<Ingredient>();
            ResultList = ingredienssida.ingredienslista.Clone();
            ResultList = ingredienssida.ingredienslista.SökIngrNamn(ResultList, TboxSearchIngrName.Text);

        }

       
        
    }
}
