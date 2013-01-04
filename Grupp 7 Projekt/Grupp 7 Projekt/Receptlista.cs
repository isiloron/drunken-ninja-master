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

        public void NyReceptbok()//Back-up metod
        {
            receptlista = new List<Recept>();//"Tömmer" receptlistan
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

        public void LäggTill(string titel, string instructions, List<ReceptSubStruct> IngrList, List<string> TagList)//En metod som lägger till ett recept i receptlistan(MONSTER)
        {
            receptlista.Add(new Recept(titel, instructions, List<ReceptSubStruct> IngrList, List<String> TagList));
        }

        public void TaBort(string titel)//En metod som tar bort ett recept ur receptlistan
        {
            foreach (Recept r in receptlista)//Loopar igenom receptlistan för en matchande titel för att sedan ta bort detta recept
            {
                if (r.Titel.Equals(titel))
                receptlista.Remove(r);
            }
        }

        public void SökRecept() //En metod som gör att man ska kunna söka efter specifika recept i receptlistan
        {
            
        }
    }

}
