using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Grupp_7_Projekt
{
    class Receptlista
    {
        List<Recept> receptlista;
        //String.Join(Environment.NewLine, recept);
        
        public Receptlista()//Konstruktor
        {
            NyReceptbok();
        }

        public void LaddaRecept()//Tim måste använda denna metod i receptsidans konstruktor så att listan fylls i när programmet startar.
        {
            SparaOchLaddaRecept.LaddaXML(out receptlista);//Laddar in recepten till receptlistan (från XMLserialiseraren)
        }

        private void SparaRecept()
        {
            SparaOchLaddaRecept.SparaXML(ref receptlista);
        }

        public void NyReceptbok()//Back-up metod
        {
            receptlista = new List<Recept>();//"Tömmer" receptlistan
        }
        public void NyttReceptKlass(Recept ReceptToAdd)
        {
            receptlista.Add(ReceptToAdd);
            SparaRecept();
        }

        public List<Recept> Clone()
        {
            return receptlista;
        }


        public List<string>  HämtaTitlar()//En metod som returnerar en stringlista med alla recepttitlar från receptlistan (Tim använder sig av den här)
        {
            List<string> titellista = new List<string>();//initierar ny lista (titellista)
            foreach (Recept r in receptlista)//Loopar igenom receptlistan och lägger till alla titlar i en ny lista (titellistan)
           {
               titellista.Add(r.Titel);
           }
            return titellista;
        }
        public Recept HämtaReceptAvNamn(string NamnAttHänta)
        {
            foreach (Recept r in receptlista)
            {
                if (NamnAttHänta == r.Titel)
                    return r;
            }
            return null;
        }

        public void LäggTill(string titel, string instructions, List<ReceptSubStruct> IngrList, List<string> TagList)//En metod som lägger till ett recept i receptlistan
        {
            receptlista.Add(new Recept(titel, instructions, IngrList, TagList));
            SparaRecept();
        }

        public void TaBort(string titel)//En metod som tar bort ett recept ur receptlistan
        {
            for (int r = 0; r < receptlista.Count; r++ )//Loopar igenom receptlistan för en matchande titel för att sedan ta bort detta recept
            {
                if(receptlista[r].Titel == titel) 
                {
                    receptlista.RemoveAt(r);
                    SparaRecept();
                } 
            }
        }


        public List<Recept> SökReceptNamn(string searchstring) //En metod som gör att man ska kunna söka efter specifika recept i receptlistan
        {
            List<Recept> returnlist = new List<Recept>();
            foreach (Recept r in receptlista)
            {
                if (r.Titel.IndexOf(searchstring,StringComparison.OrdinalIgnoreCase)>=0)
                {
                    returnlist.Add(r);
                }
            }
            return returnlist;
         }

        public List<Recept> SökMinMaxFett(int MinValue, int MaxValue, List<Recept> searchlist, ref List<Ingredient> IngridensLista) //Söker på min/max fett och returerar en lista med alla matchande recept
        {
           List<Recept> ReturnList = new List<Recept>();
            foreach (Recept r in searchlist)
            {
                if (r.GetTotalFatt(ref IngridensLista) >= MinValue && r.GetTotalFatt(ref IngridensLista) <= MaxValue)
                {
                    ReturnList.Add(r);
                }
            }
            return ReturnList;
        }

        public List<Recept> SökMinMaxEnergi(int MinValue, int MaxValue, List<Recept> searchlist, List<Ingredient> ingridenslista) //Söker på min/max energi och returerar en lista med alla matchande recept
        {
            List<Recept> ReturLista = new List<Recept>();
            foreach (Recept r in searchlist)
            {
                int total = r.GetTotalEnergy(ref ingridenslista);
                if (total >= MinValue && total <= MaxValue)
                {
                    ReturLista.Add(r);
                }
            }

            return ReturLista;
        }

        public List<Recept> SökMinMaxProtein(int MinValue, int MaxValue, List<Recept> searchlist, ref List<Ingredient> ingridenslista) //Söker på min/max protein och returerar en lista med alla matchande recept
        {
            List<Recept> ReturLista = new List<Recept>();
            foreach (Recept r in searchlist)
            {
                int total = r.GetTotalProtein(ref ingridenslista);
                if (total >= MinValue && total <= MaxValue)
                {
                    ReturLista.Add(r);
                }
            }
            return ReturLista;
        }

        public List<Recept> SökMinMaxKolhydrater(int MinValue, int MaxValue , List<Recept> searchlist, ref List<Ingredient> ingridienslista) //Söker på min/max kolhydrater och returerar en lista med alla matchande recept
        {
            List<Recept> ReturLista = new List<Recept>();
            foreach (Recept r in searchlist)
            {
                int total = r.GetTotalKolhyderater(ref ingridienslista);
                if (total >= MinValue && total <= MaxValue)
                {
                    ReturLista.Add(r);
                }
            }
            return ReturLista;
        }

        public List<Recept> SökReceptSomInehållerSpeseficIngr(List<string> stringstosearch, List<Recept> receptlisttoseach) //Tar in en lista med stränger(ingridienser) och returerar en lista med alla recept som inehåller samntliga ingridienser
        {
            List<Recept> ReturLista = new List<Recept>();

            for (int z = 0; z < receptlisttoseach.Count; z++)
            {
                int matches = 0;
                for (int x = 0; x < receptlisttoseach[z].IngrList.Count; x++)
                {
                    for (int c = 0; c < stringstosearch.Count; c++)
                    {
                        if (stringstosearch[c] == receptlisttoseach[z].IngrList[x].ingrName)
                        {
                            matches++;
                        }
                    }
                }
                if (matches == stringstosearch.Count)
                {
                    ReturLista.Add(receptlista[z]);
                }
            }
            return ReturLista;
        }
        public List<Recept> SökReceptSomHarTag (List<string> StringListToSeach, List<Recept> receptlisttoseach)
        { 
            List<Recept> ReturnList = new List<Recept>();
            foreach (Recept recept in receptlisttoseach )
            {
                int matches = 0;
                foreach (string str in recept.TagList)
                {

                   foreach (string searchstring in StringListToSeach)
                   {
                       if (str.IndexOf(searchstring, StringComparison.OrdinalIgnoreCase) >= 0)
                       {
                           matches++;
                       }
                   }
                }
                if (matches == StringListToSeach.Count)
                {
                    ReturnList.Add(recept);
                }
            
            }
            return ReturnList;
        }
    }

}
