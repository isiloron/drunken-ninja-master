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
        int kolhydrater;
		string name;
		string unit;
		string description;

        [XmlElement]
        public int Kolhydrater
        {
            get { return kolhydrater; }
            set { kolhydrater = value; }
        }


		[XmlElement]
        public int Energy
        {
            get { return energy; }
            set { energy = value; }
        }

		[XmlElement]
        public int Fett
        {
            get { return fett; }
            set { fett = value; }
        }

        [XmlElement]
        public int Protein
        {
            get { return protein; }
            set { protein = value; }
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
        public Ingredient(string NewName, string NewDescription, string NewMessureUnit, int NewEnergy, int NewProtein, int NewFett, int NewKolhydrater)
        {
            name = NewName;
            description = NewDescription;
            unit = NewMessureUnit;
            energy = NewEnergy;
            protein = NewProtein;
            fett = NewFett;
            kolhydrater = NewKolhydrater;
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
