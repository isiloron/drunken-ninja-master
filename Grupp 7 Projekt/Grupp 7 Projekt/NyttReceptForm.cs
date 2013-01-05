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
        public NyttReceptForm()
        {
            InitializeComponent();
            NewRecept = null;
        }

        List<ReceptSubStruct> IngrList = new List<ReceptSubStruct>();
        Recept NewRecept;
        private void buttonFinish_Click(object sender, EventArgs e)
        {
            List<string> TagList = new List<string>();
            foreach (object obj in listBoxTaggs.Items)
            {
                TagList.Add(obj.ToString());
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
                IngrList.Add(new ReceptSubStruct(TextboxIngr.Text, Int32.Parse(textBoxMängd.Text)));
                listBoxIngr.Items.Add(TextboxIngr.Text);
                textBoxMängd.Text = "";
                TextboxIngr.Text = "";
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

        }
    }
