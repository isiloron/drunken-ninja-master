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
            for (int i = 0; i < ingredienslista.Count; i++)//Loopar igenom receptlistan för en matchande titel för att sedan ta bort detta recept
            {
                if (ingredienslista[i].Name == name)
                {
                    ingredienslista.RemoveAt(i);
                }
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
