using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.ComponentModel;

namespace Grupp_7_Projekt
{

    public class Ingredient
    {
		int cal;
		int energy;
		string name;
		string unit;
		string description;

		[XmlElement]
        public int Cal
        {
            get { return cal; }
            set { cal = value; }
        }

		[XmlElement]
        public int Energy
        {
            get { return energy; }
            set { energy = value; }
        }

		[XmlElement]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

		[XmlElement]
        public string Unit
        {
            get { return unit; }
            set { unit = value; }
        }

		[XmlElement]
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
		
		public Ingredient()
		{
			cal = 0;
			energy = 0;
			name = "MISSING NAME";
			unit = "NONE";
			description = "MISSING DESCRIPTION";
		}

        public Ingredient(string NewName, string NewMessureUnit)
        {
            name = NewName;
            unit = NewMessureUnit;
        }
        public Ingredient(string NewName, string NewMessureUnit, string NewDescription, int NewCal, int NewEnergy)
        {
            name = NewName;
            unit = NewMessureUnit;
            description = NewDescription;
            cal = NewCal;
            energy = NewEnergy;
        
        }
    }
}
