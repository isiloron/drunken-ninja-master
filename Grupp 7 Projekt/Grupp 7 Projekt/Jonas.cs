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
    public partial class Jonas : Form
    {
        public Jonas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtPassword1.Text == txtPassword2.Text)
            {
                label5.Text = "match";
            }
            else
            {
                label5.Text = "Lösenorden stämmer inte överens. Vänligen försök igen.";
            }
        }
    }
}
