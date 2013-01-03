using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Grupp_7_Projekt
{
    class Receptlista
    {
        List<Recept> receptlista;
        /*String.Join(Environment.NewLine, recept);*/
       

        public void hämta_receptlista()//En metod som hämtar receptlista från XMLserialiseraren(Linus kommer skriva en metod som gör att jag kan hämta alla recept
        {
            foreach (Recept r in receptlista);
         
        }

        public visa_titlar()//En metod som returnerar en stringlista med alla recepttitlar från receptlistan (Tim använder sig av den här)
        {
            //String.Join(Environment.NewLine, Recept);
        }

        public void Lagg_till()
        {

        }

        public void Ta_bort()
        {

        }

        public void sök_recept() //En metod som gör att man ska kunna söka i receptlistan
        {
 
        }
    }

}
