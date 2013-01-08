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

            // Hämtar ingredienser från ingredienslistan(ingredienslistan har hämtat data från ett XML-dokument). Ingredienssidan skickas i sin tur vidare till Receptsidan. 

        }
        
        }
    }


