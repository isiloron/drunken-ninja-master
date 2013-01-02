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
		int fett;
        int protein;
        int energy;
		string name;
		string unit;
		string description;

		[XmlElement]
        public int Energy
        {
            get { return energy; }
            set { energy = value; }
        }

		[XmlElement]
        public int Fett
        {
            get { return Fett; }
            set { Fett = value; }
        }

        [XmlElement]
        public string Protein
        {
            get { return Protein; }
            set { Protein = value; }
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
            get { return Unit; }
            set { Unit = value; }
        }

		[XmlElement]
        public string Description
        {
            get { return Description; }
            set { Description = value; }
        }
		
		public Ingredient()
		{
			energy = 0;
			protein = 0;
            fett = 0;
			name = "MISSING NAME";
			unit = "NONE";
			description = "MISSING DESCRIPTION";
		}

        public Ingredient(string NewName, string NewMessureUnit)
        {
            name = NewName;
            unit = NewMessureUnit;
        }
        public Ingredient(string NewName, string NewMessureUnit, string NewDescription, int NewCal, int NewProtein, int NewFett)
        {
            name = NewName;
            unit = NewMessureUnit;
            description = NewDescription;
            energy = NewCal;
            protein = NewProtein;
            fett = NewFett;
        
        }
    }
}
