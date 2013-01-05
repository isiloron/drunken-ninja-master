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
            comboBoxEnhet.Items.Add("Mililiter");
            comboBoxEnhet.Items.Add("Gram");
        }
        private void ComboBoxEnhet_Change(object sender, EventArgs e)
        {
            WarningLable.Show();
        if (comboBoxEnhet.SelectedItem.ToString() == "Styck")
            WarningLable.Text = "OBS! Ange energivärden per styck!";

        if (comboBoxEnhet.SelectedItem.ToString() == "Mililiter")
        WarningLable.Text = "OBS! Ange energivärden per 100 mililiter!";

        if (comboBoxEnhet.SelectedItem.ToString() == "Gram")
        WarningLable.Text = "OBS! Ange energivärden per 100g!";
        
        }
        
        public Ingredient newingr;
        
        
        private void button1_Click(object sender, EventArgs e)
        {
            
                try
                {
                    if (Int32.Parse(textBoxFett.Text) < 100 && Int32.Parse(textBoxFett.Text) >= 0)
                {
                    newingr = new Ingredient(TextBoxNamn.Text, TextBoxBeskr.Text, comboBoxEnhet.SelectedItem.ToString() , Int32.Parse(textBoxEnergy.Text), Int32.Parse(textBoxProtein.Text), Int32.Parse(textBoxFett.Text), Int32.Parse(textBoxKolh.Text));
                    this.Close();
                }
                    else
                    {
                        MessageBox.Show("Fett värded är i % och måste vara mellan 0 och 100");
                    }
                }
                catch
                {
                    MessageBox.Show("Misslyckat, kolla så att alla världen är korrekta!");
                }
                

            }

        
        }
    }