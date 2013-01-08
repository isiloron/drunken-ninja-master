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
        static Receptlista receptlista = new Receptlista();                 //Deklarerar Receptlistan
        static Ingredienssida ingredienssida = new Ingredienssida();        //Deklarerar Ingredienslistan


        public Receptsida(bool loggedIn) //Konstruktor
        {
            receptlista.LaddaRecept();
            InitializeComponent();
            ListBoxRecept.DataSource = receptlista.HämtaTitlar();

            listBoxIngr.DataSource = (ingredienssida.ingredienslista.HämtaIngTitlar());
            comboBoxPort.SelectedIndex = 1;                             //Sätter ett defaultvärde på ComboBoxen
            comboBoxPort.SelectedValue = 1;    //Sätter värdet på ComboBoxen beroende på Index


            if (!loggedIn)
            {
                ButtonNyttRecept.Visible = false;
                ButtonRemoveRecepie.Visible = false;
                ButtonNewingr.Visible = false;
                ButtonRemoveIngr.Visible = false;
             }

            try
            {
                Recept temp = receptlista.HämtaReceptAvNamn(ListBoxRecept.SelectedItem.ToString());
                lblRubrik.Text = temp.Titel; textBoxIngr.Text = "";
                textBoxTil.Text = temp.Instructions;

                //Uppdaterar bilden
                if (temp.Bildsökväg == "")
                    pictureBox1.Image = Grupp_7_Projekt.Properties.Resources.chopped_fingers;
                else
                    pictureBox1.Image = Image.FromFile(temp.Bildsökväg);

                foreach (ReceptSubStruct r in temp.IngrList)
                {
                    //Uppdaterar ingredienstextboxen
                    textBoxIngr.Text += r.ingrName + " ";
                    textBoxIngr.Text += r.ingrNumber.ToString() + " ";
                    textBoxIngr.Text += ingredienssida.ingredienslista.HämtaEnhet(r.ingrName);
                    textBoxIngr.Text += Environment.NewLine;

                    //Uppdaterar näringsvärdena
                    textBoxNär.Text = "";
                    textBoxNär.Text += "Energi: " + ingredienssida.ingredienslista.GetTotalEnergy(temp) + " kCal \r\n";
                    textBoxNär.Text += "Kolhydrater: " + ingredienssida.ingredienslista.GetTotalKolhyd(temp) + " g \r\n";
                    textBoxNär.Text += "Protein: " + ingredienssida.ingredienslista.GetTotalProtein(temp) + " g \r\n";
                    textBoxNär.Text += "Fett: " + ingredienssida.ingredienslista.GetTotalFett(temp) + " g \r\n";

                }
            }
            catch { }    
        }

        private void IndexChange(object sender, EventArgs e) // Metod som fixar flikarna och deras innehåll
        {
            if (tabControl1.SelectedIndex == 0)
            {
                lblAntPort.Show();          //Visar AntPort label i Recepttaben
                comboBoxPort.Show();        //Visar ComboBox i Recepttaben
                lblIng.Show();              //Visar Bngredienlabelsen
                textBoxIngr.Show();         //Visar Ingredienstextboxen
                lblTil.Text = "Tillagning"; //Textboxen för Tillagning
                lblNär.Text = "Näringsvärde / portion:"; //Överskrift för näringsvärden recept
                listBoxRecept_SelectedIndexChanged(null, null);
            }
            if (tabControl1.SelectedIndex == 1)
            {
                lblIng.Hide();                  //Gömmer Ingredienslabeln (när man tabbar till ingrediensfliken)
                textBoxIngr.Hide();             //Gömmer Ingredienstextboxen (när man tabbar till ingrediensfliken)
                lblTil.Text = "Beskrivning";    //Beskrivniningsruta
                lblNär.Text = "Näringsvärde / 100g: "; //Överskrift för näringsvärden recept
                comboBoxPort.Hide();            //Gömmer ComboBox från Ingredienstaben
                lblAntPort.Hide();              //Gömmer AntPort label från Ingredienstaben
                listBoxIngr_SelectedIndexChanged(null, null );
            }
            if (tabControl1.SelectedIndex == 2)
            {
                lblAntPort.Show();          //Visar AntPort label i Recepttaben
                comboBoxPort.Show();        //Visar ComboBox i Recepttaben
                lblIng.Show();              //Visar Bngredienlabelsen
                textBoxIngr.Show();         //Visar Ingredienstextboxen
                lblTil.Text = "Tillagning"; //Textboxen för Tillagning
                lblNär.Text = "Näringsvärde / portion:"; //Överskrift för näringsvärden recept
                listBoxRecept_SelectedIndexChanged(null, null);
            }
        
        }


        public void listBoxRecept_SelectedIndexChanged(object sender, EventArgs e)     //Updaterar visningsfönstret, kallas på när användaren markerat ett nytt recept
        {

			try
			{
				Recept temp = receptlista.HämtaReceptAvNamn(ListBoxRecept.SelectedItem.ToString());
				lblRubrik.Text = temp.Titel; textBoxIngr.Text = "";
				textBoxTil.Text = temp.Instructions;

                //Uppdaterar bilden
                if (temp.Bildsökväg == "")
                    pictureBox1.Image = Grupp_7_Projekt.Properties.Resources.chopped_fingers;
                else
                    pictureBox1.Image = Image.FromFile(temp.Bildsökväg);

				foreach (ReceptSubStruct r in temp.IngrList)
				{
					//Uppdaterar ingredienstextboxen
					textBoxIngr.Text += r.ingrName + " ";
					textBoxIngr.Text += r.ingrNumber.ToString() + " ";
					textBoxIngr.Text += ingredienssida.ingredienslista.HämtaEnhet(r.ingrName);
					textBoxIngr.Text += Environment.NewLine;

					//Uppdaterar näringsvärdena
					textBoxNär.Text = "";
                    textBoxNär.Text += "Energi: " + ingredienssida.ingredienslista.GetTotalEnergy(temp) + " kCal \r\n";
                    textBoxNär.Text += "Kolhydrater: " + ingredienssida.ingredienslista.GetTotalKolhyd(temp) + " g \r\n";
                    textBoxNär.Text += "Protein: " + ingredienssida.ingredienslista.GetTotalProtein(temp) + " g \r\n";
                    textBoxNär.Text += "Fett: " + ingredienssida.ingredienslista.GetTotalFett(temp) + " g \r\n";
                                        
				}
			}
			catch { }    
        }

        public void ButtonNyttRecept_Click(object sender, EventArgs e) //Lägg till recept
        {
            NyttReceptForm nrf = new NyttReceptForm(ref ingredienssida.ingredienslista.ingredienslista); // Initierar ny receptform för att läga till recept
            nrf.ShowDialog();
            if (nrf.Recept != null)
            {
                receptlista.NyttReceptKlass(nrf.Recept);  // Hämtar NyttReceptmetoden
                ListBoxRecept.DataSource = receptlista.HämtaTitlar(); // Laddar om receptlistan efter man lagt till ett recept
            }
            listBoxIngr.DataSource = ingredienssida.ingredienslista.HämtaIngTitlar(); //Updaterar ingrediens listan ifall en eller flera lades till

        }

        private void listBoxIngr_SelectedIndexChanged(object sender, EventArgs e) //Updaterar visningsfönstret när användaren väljer ny ingr
        {
			try
			{
				Ingredient temp = ingredienssida.ingredienslista.HämtaIngrKlass(listBoxIngr.SelectedItem.ToString());
				lblRubrik.Text = temp.Name;
				textBoxTil.Text = temp.Description;
				textBoxNär.Text = "";
                textBoxNär.Text += "Energi: " + temp.Energy + " kCal \r\n" + "Kolhydrater: " + temp.Kolhydrater + " g \r\n" + "Protein: " + temp.Protein + " g \r\n" + "Fett: " + temp.Fett + " g";
			}
			catch { }
            
       
        }

        private void ButtonRemoveRecepie_Click(object sender, EventArgs e) // TaBortReceptmetoden
        {
            DialogResult dialogResult = MessageBox.Show("Är du säker på att du vill ta bort markerat recept?", "Ta bort recept", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes) // Frågar om man vill ta bort recept
            {
                receptlista.TaBort(ListBoxRecept.SelectedItem.ToString()); // Tar bort receptet
                ListBoxRecept.DataSource = receptlista.HämtaTitlar();      // Laddar om receptlistan
            }
        }

        private void ButtonRemoveIngr_Click(object sender, EventArgs e) // Ta bort ingrediens metod 
        {
            DialogResult dialogResult = MessageBox.Show("Är du säker på att du vill ta bort markerad ingridiens?", "Ta bort ingridiens", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes) //Frågar om man vill ta bort ingrediens
            {
                ingredienssida.ingredienslista.TaBortIng(listBoxIngr.SelectedItem.ToString()); // Tar bort ingrediensen
                listBoxIngr.DataSource = ingredienssida.ingredienslista.HämtaIngTitlar(); // Laddar om recept
            }
        }

        private void ButtonNewingr_Click(object sender, EventArgs e) // Lägg till ingrediensknapp
        {
            NyIngridiensForm nig = new NyIngridiensForm();      // Initierar ny form
            nig.ShowDialog();
            if (nig.newingr != null)
            {
                ingredienssida.ingredienslista.LäggTillIngrKlass(nig.newingr); // Lägger till ingrediens
                listBoxIngr.DataSource = ingredienssida.ingredienslista.HämtaIngTitlar(); // Laddar om ingredienser
            }

        }

        private void ButtonSearchRecept_Click(object sender, EventArgs e) //Sökfunktionen, skapar en ny lista som skickas ner genom alla sökfunkioner
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
                    ResultList = receptlista.SökMinMaxEnergi(Int32.Parse(TboxSearchReceptMinEnergi.Text), Int32.Parse(TboxSearchReceptMAXEnergi.Text), ResultList, ingredienssida.ingredienslista.ingredienslista);

                }
                if (TboxSearchReceptMinFett.Text != "" && TboxSearchReceptMAXFett.Text != "") //Om min/max fett angets, sök
                {
                    ResultList = receptlista.SökMinMaxFett(Int32.Parse(TboxSearchReceptMinFett.Text), Int32.Parse(TboxSearchReceptMAXFett.Text), ResultList, ref ingredienssida.ingredienslista.ingredienslista);
                }
                if (TBoxSearchReceptMinProtein.Text != "" && TBoxSearchReceptMAXProtein.Text != "") //Om min/max protein angets, sök
                {
                    ResultList = receptlista.SökMinMaxProtein(Int32.Parse(TBoxSearchReceptMinProtein.Text), Int32.Parse(TBoxSearchReceptMAXProtein.Text), ResultList, ref ingredienssida.ingredienslista.ingredienslista);
                }
                if (TBoxSearchReceptMinKolhyd.Text != "" && TBoxSearchReceptMAXKolhyd.Text != "") //Om minmax kolhydrater angets, sök
                {
                ResultList = receptlista.SökMinMaxKolhydrater(Int32.Parse(TBoxSearchReceptMinKolhyd.Text), Int32.Parse(TBoxSearchReceptMAXKolhyd.Text), ResultList, ref ingredienssida.ingredienslista.ingredienslista);
                }
                if (listBoxSearchTags.Items.Count != 0) //Om taggar angets, sök
                {
                    
                    List<string> seachtags = new List<string>();
                    for (int z = 0; z < listBoxSearchTags.Items.Count; z++ )
                    {
                        listBoxSearchTags.SelectedIndex = z;
                        seachtags.Add(listBoxSearchTags.SelectedItem.ToString());
                    }
                    ResultList = receptlista.SökReceptSomHarTag(seachtags, ResultList);

                }
                foreach (Recept rep in ResultList) //Updaterar resultatboxen
                {
                    listBoxSearchReceptResults.Items.Add(rep.Titel);
                }
            }
            catch
            {
                MessageBox.Show("Sökningen misslyckades");
            }
        }

        private void SkrivUt_Click(object sender, EventArgs e)
        {
            
            Utskrftsform utskrift = new Utskrftsform( textBoxIngr, comboBoxPort, lblRubrik, textBoxNär, textBoxTil, pictureBox1);
            utskrift.Show();
        }

        private void buttonAddSearchTag_Click(object sender, EventArgs e) //Lägger till en tag att söka på
        {
            listBoxSearchTags.Items.Add(TBoxSearchReceptTags.Text);
            TBoxSearchReceptTags.Text = "";
        }

        private void buttonRemoveSearchTag_Click(object sender, EventArgs e) //tar bort en tag från söklistan
        {
            listBoxSearchTags.Items.Remove(listBoxSearchTags.SelectedItem);
        }

        private void listBoxSearchReceptResults_SelectedIndexChanged(object sender, EventArgs e) //Uppdaterar visningen av recept från sökresulten
        {
            Recept temp = receptlista.HämtaReceptAvNamn(listBoxSearchReceptResults.SelectedItem.ToString());
            lblRubrik.Text = temp.Titel; textBoxIngr.Text = "";
            textBoxTil.Text = temp.Instructions;
            foreach (ReceptSubStruct r in temp.IngrList)
            {
                //Den här koden uppdaterar ingrediensboxen
                textBoxIngr.Text += r.ingrName + " ";
                textBoxIngr.Text += r.ingrNumber.ToString() + " ";
                textBoxIngr.Text += ingredienssida.ingredienslista.HämtaEnhet(r.ingrName);
                textBoxIngr.Text += Environment.NewLine;

                //Uppdaterar näringsvärden
                textBoxNär.Text = "";
                textBoxNär.Text += "Energi: " + ingredienssida.ingredienslista.GetTotalEnergy(temp) + " kCal \r\n";
                textBoxNär.Text += "Kolhydrater: " + ingredienssida.ingredienslista.GetTotalKolhyd(temp) + " g \r\n";
                textBoxNär.Text += "Proteiner: " + ingredienssida.ingredienslista.GetTotalProtein(temp) + " g \r\n";
                textBoxNär.Text += "Fett: " + ingredienssida.ingredienslista.GetTotalFett(temp) + " g \r\n";

            }
        }

        private void buttonSearchIngr_Click(object sender, EventArgs e) //Sök ingr (inte 100% fungerande!)
        {
            List<Ingredient> ResultList = new List<Ingredient>();
            ResultList = ingredienssida.ingredienslista.Clone();
            ResultList = ingredienssida.ingredienslista.SökIngrNamn(ResultList, TboxSearchIngrName.Text);

        }

        public void comboBoxPort_SelectedIndexChanged(object sender, EventArgs e) //Beräknar antal portioner
        {
            try
            {
                int antport1;
                antport1 = int.Parse(comboBoxPort.SelectedItem.ToString());
                Recept temp = receptlista.HämtaReceptAvNamn(ListBoxRecept.SelectedItem.ToString());
                textBoxIngr.Clear();
                foreach (ReceptSubStruct r in temp.IngrList)
                {
                    //Uppdaterar ingredienstextboxen
                    textBoxIngr.Text += r.ingrName + " ";
                    textBoxIngr.Text += r.ingrNumber * antport1 + " ";
                    textBoxIngr.Text += ingredienssida.ingredienslista.HämtaEnhet(r.ingrName);
                    textBoxIngr.Text += Environment.NewLine;

                }
            }
            catch { }

        }


       
        
    }
}
