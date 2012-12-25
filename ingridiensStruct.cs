using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Recept
{
    public class Ingridient
    {
        public int Cal;
        public int energy;
        public string Name;
        public string unit;
        public string Description;

        public Ingridient(string NewName, string NewMessureUnit)
        {
            Name = NewName;
            Unit = NewMessureUnit;
        }
        public Ingridient(string NewName, string NewMessureUnit, string NewDescription, int NewCal, int NewEnergy)
        {
            Name = NewName;
            Unit = NewMessureUnit;
            Description = NewDescription;
            Cal = NewCal;
            energy = NewEnergy;
        
        }
    }
}
