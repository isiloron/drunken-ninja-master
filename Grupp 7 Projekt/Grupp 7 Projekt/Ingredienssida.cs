using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Grupp_7_Projekt
{
    class Ingredienssida
    {
        public IngrediensLista ingredienslista = new IngrediensLista();
        public Ingredienssida() {

            //ingredienslista.LaddaIngrediens();
            ingredienslista.HämtaIngTitlar();
            
            
        
        }
    }
}
