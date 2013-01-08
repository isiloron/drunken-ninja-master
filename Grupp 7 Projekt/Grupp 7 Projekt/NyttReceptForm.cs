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
        
        private void buttonFinish_Click(object sender, EventArgs e)
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

            NewRecept = new Recept(TextBoxTitel.Text, TextBoxDescription.Text, IngrList, TagList);
            this.Hide();
        }


        public Recept Recept
        {
            get
            {
                return NewRecept; 
            }
        }

        private void Addingr_Click(object sender, EventArgs e)
        {            
            
            try
            {
                IngrList.Add(new ReceptSubStruct(comboBoxIngr.SelectedItem.ToString(), Int32.Parse(textBoxMängd.Text)));
                listBoxIngr.Items.Add(comboBoxIngr.SelectedItem + "  " + textBoxMängd.Text);
                textBoxMängd.Text = "";
                comboBoxIngr.SelectedItem = "";
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void AddTag_Click(object sender, EventArgs e)
        {
            listBoxTaggs.Items.Add(textBoxTaggs.Text);
            textBoxTaggs.Text = "";
        }

        private void RemoveTag_Click(object sender, EventArgs e)
        {
            if (listBoxTaggs.SelectedIndex !=0)
            listBoxTaggs.Items.RemoveAt(listBoxTaggs.SelectedIndex);
        }

        private void RemoveIngr_Click(object sender, EventArgs e)
        {
            if (listBoxIngr.SelectedIndex != 0)
            {
                IngrList.RemoveAt(listBoxIngr.SelectedIndex);
                listBoxIngr.Items.RemoveAt(listBoxIngr.SelectedIndex);
            }
        }

        private void NyttReceptForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonNewIngr_Click(object sender, EventArgs e)
        {
            NyIngridiensForm nig = new NyIngridiensForm();
            nig.ShowDialog();
            if (nig.newingr != null)
            {
                IngrRefList.Add(nig.newingr);
                comboBoxIngr.Items.Clear();
                foreach (Ingredient ingr in IngrRefList)
                {
                    comboBoxIngr.Items.Add(ingr.Name);
                }
            }
        }

        }
    }
