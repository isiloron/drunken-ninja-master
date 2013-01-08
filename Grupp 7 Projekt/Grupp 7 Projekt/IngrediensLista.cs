using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Grupp_7_Projekt
{
    class IngrediensLista
    {
       public List<Ingredient> ingredienslista; // deklarerar en ny lista

       public IngrediensLista()// konstruktor
       {
           NyIngrediensBok(); //skapar en tom lista
       }
        
        public void LaddaIngrediens()
        {
            SparaOchLaddaIngredienser.LaddaXML(out ingredienslista); //Laddar Ingredienser till listan från XMLSerialiserare.cs
        }
        public void SparaIngrediens()
        {
            SparaOchLaddaIngredienser.SparaXML(ref ingredienslista); //Sparar Ingredienser från Listan till XMLSerialiserare.cs
        }

        public void NyIngrediensBok()//Metod som skapar en tömmer ingredienslistan
        {
            ingredienslista = new List<Ingredient>();
        }

        public List<string> HämtaIngTitlar()  //en metod för att hämta ingrediens titlarna
        {
            List<string> TitelIngLista = new List<string>();//Initierar en ny lista för titlar
            foreach (Ingredient i in ingredienslista)//Loppar igenom IngrediensLista 
            {
                TitelIngLista.Add(i.Name); //Lägger alla ingrediens titlar i Name i ReceptKlass
            }
            return TitelIngLista; //returnerar till stringlista
                                  
        }
        public List<Ingredient> Clone()
        {
            return ingredienslista;
        }
        public Ingredient HämtaIngrKlass(string NamnAttHämta)
        {
            foreach (Ingredient ingr in ingredienslista)
            {
                if (ingr.Name == NamnAttHämta)
                {
                    return ingr;
                }
            }
            return null;
        
        }

        public List<Ingredient> SökIngrNamn(List<Ingredient> ListaAttsöka, string SökNamn)
        { 
            List<Ingredient> ReturnList = new List<Ingredient>();
            foreach (Ingredient ingr in ListaAttsöka)
            {
                if (ingr.Name == SökNamn)
                {
                    ReturnList.Add(ingr);
                }
            }

            return ReturnList;
        }

       public void LäggTillIng(string name,string unit, string description,	int fett, int protein, int energy, int carbon)
        { 
            ingredienslista.Add(new Ingredient(name, unit, description, fett, protein, energy, carbon));
            SparaIngrediens();
        }

       public void LäggTillIngrKlass(Ingredient NewIngr)
       {
           ingredienslista.Add(NewIngr);
           SparaIngrediens();
       }
       
        public void TaBortIng(string name)
        {
            for (int i = 0; i < ingredienslista.Count; i++)//Loopar igenom ingredienslistan för en matchande titel för att sedan ta bort detta recept
            {

                if (ingredienslista[i].Name == name)
                {
                    ingredienslista.RemoveAt(i);
                    SparaIngrediens();

                }
            }
        }
        public string HämtaEnhet(string IngrName)
        {
            foreach (Ingredient ing in ingredienslista)
            {
				if (IngrName == ing.Name)
				{
					return ing.Unit;
				}
            }
			return "Saknas";
        }

        public int GetTotalEnergy(Recept recept)
        {
            int Total = 0;
            foreach (ReceptSubStruct rss in recept.IngrList)
            {
                foreach (Ingredient ingr in ingredienslista)
                {
                    if (ingr.Name == rss.ingrName)
                    {
                        Total += ingr.Energy;
                    }
                }
            }
            return Total;
        }

            public int GetTotalFett(Recept recept)
        {
            int Total = 0;
            foreach (ReceptSubStruct rss in recept.IngrList)
            {
                foreach (Ingredient ingr in ingredienslista)
                {
                    if (ingr.Name == rss.ingrName)
                    {
                        Total += ingr.Fett;
                    }
                }
            }
               Total = (int)(Total / recept.IngrList.Count);
            return Total;
        }

            public int GetTotalKolhyd(Recept recept)
            {
                int Total = 0;
                foreach (ReceptSubStruct rss in recept.IngrList)
                {
                    foreach (Ingredient ingr in ingredienslista)
                    {
                        if (ingr.Name == rss.ingrName)
                        {
                            Total += ingr.Kolhydrater;
                        }
                    }
                }

                return Total;
            }
            public int GetTotalProtein(Recept recept)
            {
                int Total = 0;
                foreach (ReceptSubStruct rss in recept.IngrList)
                {
                    foreach (Ingredient ingr in ingredienslista)
                    {
                        if (ingr.Name == rss.ingrName)
                        {
                            Total += ingr.Protein;
                        }
                    }
                }

                return Total;
            }
    }
}
