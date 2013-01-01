using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Recept
{
    public class Ingridient
    {
        public int Cal
        {
            get { return Cal; }
            set { Cal = value; }
        }
        public int energy
        {
            get { return energy; }
            set { energy = value; }
        }
        public string IngrName
         {
            get { return IngrName; }
            set { IngrName = value; }
        }
        public string Unit
        {
            get { return Unit; }
            set { Unit = value; }
        }
        public string Description
        {
            get { return Description; }
            set { Description = value; }
        }

        public string Titel
        {
            get { return Titel; }
            set { Titel = value; }
        }

        public Ingridient(string NewName, string NewMessureUnit)
        {
            IngrName = NewName;
            Unit = NewMessureUnit;
        }
        public Ingridient(string NewName, string NewMessureUnit, string NewDescription, int NewCal, int NewEnergy)
        {
            IngrName = NewName;
            Unit = NewMessureUnit;
            Description = NewDescription;
            Cal = NewCal;
            energy = NewEnergy;
        
        }
    }
}
