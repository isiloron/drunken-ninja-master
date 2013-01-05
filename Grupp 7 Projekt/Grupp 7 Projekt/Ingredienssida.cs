using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace Grupp_7_Projekt
{
    class Ingredienssida
    {
        public IngrediensLista ingredienslista = new IngrediensLista();
        public Ingredienssida()
        {

            ingredienslista.LaddaIngrediens();
            ingredienslista.HämtaIngTitlar();



        }
        public void Skrivaren()
        {
            PrintDialog skrivut = new PrintDialog();
            PrintDocument skrivdokument = new PrintDocument();

            skrivut.Document = skrivdokument;
           
            
            DialogResult skrivresultat = skrivut.ShowDialog();

            if (skrivresultat == DialogResult.OK)
            {
                skrivdokument.Print();
                
            }
        }
    }
}

