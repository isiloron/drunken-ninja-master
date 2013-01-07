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

		[XmlElement]
		public List<ReceptSubStruct> IngrList = new List<ReceptSubStruct>(); //List of ingr to use
		
		[XmlElement]
		public List<string> TagList = new List<string>(); //Tags related to this recpie

		public Recept()
		{ }

        public Recept(string NewTitel, string NewInstructions)
        {
            Titel = NewTitel;
            instructions = NewInstructions;
        }

        public Recept(string NewTitel, string NewInstructions, List<ReceptSubStruct>NewIngrList, List<string>NewTagList)
        {
            titel = NewTitel;
            instructions = NewInstructions;
            IngrList = NewIngrList;
            TagList = NewTagList;
        }

        public bool RemoveIngrByName(string RemoveName) //Removes ingridiense by name, returns true of exisists, false if not
        {
            for (int z = 0; IngrList.Count > z; )
            {
                if (RemoveName == IngrList[z].ingrName)
                {
                    IngrList.RemoveAt(z);
                    return true;
                }
            }
            return false;
        }

        public void AddIngr(string NewName, int NewNumber)
        {
            IngrList.Add(new ReceptSubStruct(NewName, NewNumber));
        }


        public int GetTotalProtein() //Returns total calories for whole recepie
        {
            int TotalProtein = 0;
            for (int z = 0; z < IngrList.Count; z++)
            {
                //Totalcal += ingridens
            }
          return TotalProtein;
        }

        
        public int GetTotalFatt() //Returns energy value for whole recepie
        { 
            int TotalFatt =0;
            for (int z = 0; z < IngrList.Count; z++)
            {
               // TotalFatt += GetFatValueFromIngrList(IngrList[<].IngrName) * IngrList[z].ingrNumber;
            }
            return TotalFatt;
        }
        public int GetTotalEnergy()
        {
            int TotalEnergy = 0;
            for (int z = 0; z < IngrList.Count; z++)
            { 
            //TotalEnergy += GetEnergyValueFromIngrList(IngrList[z].IngrName * IngrList[z].ingrNumber;
            }
            return TotalEnergy;
        }

        public int GetTotalKolhyderater()
        {
            int TotalKolhyderater = 0;
            for (int z = 0; z < IngrList.Count; z++)
            {
                //TotalCarbon += GetCarbonValueFromIngrList(IngrList[z].IngrName * IngrList[z].ingrNumber;
            }
            return TotalKolhyderater;
        }

        public void AddTag(string TagName)
        {
            //Check and see if tag already exist
            bool exists = false;
            foreach (string tag in TagList)
            {
                if (TagName == tag)
                {
                    exists = true;
                }
            }
            if (exists == false)
            {
                TagList.Add(TagName);
            }
        }
        
        public bool RemoveTag(string RemoveName)
        {
            for (int z = 0; z < TagList.Count; z++)
            {
                if (TagList[z] == RemoveName)
                {
                    TagList.RemoveAt(z);
                    return true;
                }
            }
            return false;
        }

    }

}
