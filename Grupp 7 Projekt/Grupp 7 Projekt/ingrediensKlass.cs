using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.ComponentModel;

namespace Grupp_7_Projekt
{

    public class Ingredient //Simon Palmér har hand om denna klass
    {
        //variabler som används
		int fett;
        int protein;
        int energy;
        int kolhydrater;
		string name;
		string unit;
		string description;

		//Egenskaper för medlemmarna.
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

		//Konstruktorer
		public Ingredient(string NewName, string NewDescription, string NewMessureUnit, int NewEnergy, int NewProtein, int NewFett, int NewKolhydrater)
        { //Konstruktor
            name = NewName;
            description = NewDescription;
            unit = NewMessureUnit;
            energy = NewEnergy;
            protein = NewProtein;
            fett = NewFett;
            kolhydrater = NewKolhydrater;
        }

		public Ingredient()
		{ //Tom kontruktor
			energy = 0;
			protein = 0;
            fett = 0;
			name = "SAKNAR NAMN";
			unit = "SAKNAR ENHET";
			description = "SAKNAR BESKRIVNING";
		}
    }
}
