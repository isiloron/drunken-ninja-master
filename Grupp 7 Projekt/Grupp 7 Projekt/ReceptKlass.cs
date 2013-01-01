using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.ComponentModel;

namespace Grupp_7_Projekt
{
    public class Recept
    {
        string titel; //Name of the recepie
        string instructions; //Instructions on how to make it
        List <string> IngrList = new List<string>(); //List of ingr to use
        List <int> IngrNumber = new List<int>(); //List to store number of each ingr
        List <string> Tags = new List<string>(); //Tags related to this recpie
		
		[XmlElement]
		public string Titel
		{
			get { return titel; }
			set { titel = value; }
		}

		[XmlElement]
		public string Instructions
		{
			get { return instructions; }
			set { instructions = value; }
		}
		
		public Recept()
		{ }

        public Recept(string Name, string instructions)
        {
            this.Titel = Name;
            this.instructions = instructions;
        }
        
        public void SetNumber(string IngrNameToChange, int NewNumber)
        {//Change the number of units for an ingr
            for (int z = 0; z <= IngrList.Count; z++)
            {
                if (IngrList[z] == IngrNameToChange)
                {
                    IngrNumber[z] = NewNumber;
                }
            }        
        }
		
        public bool RemoveIngrByName(string RemoveName) //Removes ingridiense by name, returns true of exisists, false if not
        {
            IngrList.Remove(RemoveName) ;
            return true;
        }

        public int GetTotalCal() //Returns total calories for whole recepie
        {
            int Totalcal = 0;
            for (int x = 0; x < IngrList.Count; x++)
            {
                //Make call to ingr list and ask for cal from an ingr.
            }
          return Totalcal;
        }
        public int GetTotalEnergyValue() //Returns energy value for whole recepie
        { 
            int TotalEngergy =0;
            for (int x = 0; x < IngrList.Count; x++)
            { 
                //how to do this?
            }
            return TotalEngergy;
        }

    }

}
