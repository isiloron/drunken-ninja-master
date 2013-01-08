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
    public partial class NyttReceptForm : Form
    {
        static Receptsida receptsida = new Receptsida(true);
        public NyttReceptForm(ref List<Ingredient> FullIngrList)
        {
            InitializeComponent();
            NewRecept = null;
            IngrRefList = FullIngrList;
            foreach (Ingredient ingr in FullIngrList)
            {
                comboBoxIngr.Items.Add(ingr.Name);
            }
        }

        List<Ingredient> IngrRefList;
        List<ReceptSubStruct> IngrList = new List<ReceptSubStruct>();
        Recept NewRecept;
        string bildsökväg;

        private void buttonFinish_Click(object sender, EventArgs e) //När användaren är klar, försök skapa nytt recept
        {
            try
            {
                int portioner = Int32.Parse(TextBoxPortioner.Text);
                List<string> TagList = new List<string>();
                foreach (object obj in listBoxTaggs.Items)
                {
                    TagList.Add(obj.ToString());
                }
                for (int z = 0; z < IngrList.Count; z++)
                {
                    IngrList[z] = new ReceptSubStruct(IngrList[z].ingrName, IngrList[z].ingrNumber / portioner);
                }

                NewRecept = new Recept(TextBoxTitel.Text, TextBoxDescription.Text, IngrList, TagList, bildsökväg);
                this.Hide();
                
            }
            catch
            {
                MessageBox.Show("Ett eller flera värden är inte giltliga!");
            }         
        }


        public Recept Recept
        {
            get
            {
                return NewRecept;
            }
        }

        private void Addingr_Click(object sender, EventArgs e) //Lägg till ingr
        {

            try
            {
                IngrList.Add(new ReceptSubStruct(comboBoxIngr.SelectedItem.ToString(), Int32.Parse(textBoxMängd.Text)));
                listBoxIngr.Items.Add(IngrList[IngrList.Count - 1].ingrName + "  " + textBoxMängd.Text);
                textBoxMängd.Text = "";
                comboBoxIngr.SelectedItem = "";
            }
            catch
            {
                MessageBox.Show("Error"); //Används i första hand för att se till att mängden går att parsa
            }
        }

        private void AddTag_Click(object sender, EventArgs e) //Läggtill tag
        {
            listBoxTaggs.Items.Add(textBoxTaggs.Text);
            textBoxTaggs.Text = "";
        }

        private void RemoveTag_Click(object sender, EventArgs e) //tabort tagg
        {
            if (listBoxTaggs.SelectedIndex != 0)
                listBoxTaggs.Items.RemoveAt(listBoxTaggs.SelectedIndex);
        }

        private void RemoveIngr_Click(object sender, EventArgs e) //Tabort markerad ingr
        {
            if (listBoxIngr.SelectedIndex >= 0)
            {
                IngrList.RemoveAt(listBoxIngr.SelectedIndex);
                listBoxIngr.Items.RemoveAt(listBoxIngr.SelectedIndex);
            }
        }

        private void buttonNewIngr_Click(object sender, EventArgs e) //Om användaren vill skapa ny ingr att använda
        {
            NyIngridiensForm nig = new NyIngridiensForm(); //Declarera nytt ingr form
            nig.ShowDialog();
            if (nig.newingr != null) //Kolla ifall ingr skapades, I så fall, lägg till i centrala ingr listan och uppdatera ingrComboboxen
            {
                IngrRefList.Add(nig.newingr);
                comboBoxIngr.Items.Clear();
                foreach (Ingredient ingr in IngrRefList)
                {
                    comboBoxIngr.Items.Add(ingr.Name);
                }
            }
        }
        private void IngrComboBox_Change(object sender, EventArgs e) //Updaterar enhetsvisaren när användaren byter ingridiens
        {
            foreach (Ingredient ingr in IngrRefList)
            {
                if (ingr.Name == comboBoxIngr.SelectedItem.ToString())
                {
                    labelIngrUnit.Text = ingr.Unit;
                    break;
                }
            }
        }

        public void NyBild_Click(object sender, EventArgs e)
        {


            OpenFileDialog OppnaBild = new OpenFileDialog();
            
            OppnaBild.Filter = "Image Files|*.jpg;*.gif;*.bmp;*.png;*.jpeg|All Files|*.*";
            OppnaBild.InitialDirectory = @"C:\";
            

            if (OppnaBild.ShowDialog() == DialogResult.OK)
            {
                
                bildsökväg = OppnaBild.FileName;
            
               
            }

        }
    }
}
