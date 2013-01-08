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
    public partial class NyIngridiensForm : Form
    {
        public NyIngridiensForm()
        {
            InitializeComponent();
        }
        private void NyIngridiensForm_Load(object sender, EventArgs e)
        {
            comboBoxEnhet.Items.Add("Styck");
            comboBoxEnhet.Items.Add("Knippe");
            comboBoxEnhet.Items.Add("Klyfta");
            comboBoxEnhet.Items.Add("Liter");
            comboBoxEnhet.Items.Add("dl");
            comboBoxEnhet.Items.Add("cl");
            comboBoxEnhet.Items.Add("ml");
            comboBoxEnhet.Items.Add("kg");
            comboBoxEnhet.Items.Add("g");
            comboBoxEnhet.Items.Add("Matsked");
            comboBoxEnhet.Items.Add("Tesked");
            comboBoxEnhet.Items.Add("Kryddmått");
        }
        
        public Ingredient newingr;
        
        
        private void button1_Click(object sender, EventArgs e)
        {
            
                try
                {
                    newingr = new Ingredient(TextBoxNamn.Text, TextBoxBeskr.Text, comboBoxEnhet.SelectedItem.ToString() , Int32.Parse(textBoxEnergy.Text), Int32.Parse(textBoxProtein.Text), Int32.Parse(textBoxFett.Text), Int32.Parse(textBoxKolh.Text));
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Misslyckat, kolla så att alla värden är korrekta!");
                }
                

            }

        
        }
    }