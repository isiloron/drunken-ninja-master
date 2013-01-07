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
    public partial class Utskrftsform : Form
    {
        public Utskrftsform(Recept recept)
        {
            InitializeComponent();
            richTextBox1.AppendText(recept.Titel);
            richTextBox1.AppendText(Environment.NewLine);
            richTextBox1.AppendText(recept.Instructions);

        }

        private void Utskrftsform_Load(object sender, EventArgs e)
        {

        }
    }
}
