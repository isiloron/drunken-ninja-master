using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Grupp_7_Projekt
{
    class IngrediensLista
    {
       List<Ingredient> ingredienslista;

       public IngrediensLista()
       {
           NyIngrediensBok();
       }
        
        public void LaddaIngrediens()
        {
            SparaOchLaddaIngredienser.LaddaXML(out ingredienslista);
        }

        public void NyIngrediensBok()
        {
            ingredienslista = new List<Ingredient>();
        }

        public List<string> HämtaIngTitlar()
        {
            List<string> TitelIngLista = new List<string>();
            foreach (Ingredient i in ingredienslista)
            {
                TitelIngLista.Add(i.Name);
            }
            return TitelIngLista;
                                  
        }

       public void LäggTillIng(int fett, int protein, int energy, int carbon, string name,	string unit, string description)
        { 
            ingredienslista.Add(new Ingredient(fett, protein, energy, carbon, name, unit, description));
        }
       
        public void TaBortIng(string name)
        {
            foreach (Ingredient i in ingredienslista)
            {
                if (i.Name.Equals(name))
                    ingredienslista.Remove(i);
            }
        }
        
       /* public  SökIngrediens(string ingrediensnamn)
        {
            foreach (Ingredient i in ingredienslista)
            {
                if (i.Name.Equals(ingrediensnamn))
                {
                    return i;
                }
            }
        }*/
    }
}
