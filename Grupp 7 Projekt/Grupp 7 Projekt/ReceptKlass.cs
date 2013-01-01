using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Grupp_7_Projekt
{
    public class Recept
    {
        string Titel; //Name of the recepie
        string instructions; //Instructions on how to make it
        List <string> IngrList = new List<string>(); //List of ingr to use
        List <int> IngrNumber = new List<int>(); //List to store number of each ingr
        List <string> Tags = new List<string>(); //Tags related to this recpie
        
        public Recept(string Name, string instructions)
        {
            this.Titel = Name;
            this.instructions = instructions;
        }
        
        public void SetName(string NewName)
        {//Used to Set a new name to recepie
            Titel = NewName;        
        }
        
        public void SetInstructions(string NewInstructions)
        {//used to set new instructions
            instructions = NewInstructions;
        }
        
        public string GetName()
        {//Returns the recepies name
            return Titel;
        }
        
        public void SetNumber(string IngrNameToChange, int NewNumber)
        {//Change the number of units for an ingr
            foreach (int z in IngrList)
            {
                if (IngrList<z> == IngrNameToChange)
                {
                    IngrNumber = NewNumber;
                }
            }        
        }
        
        public string GetInstructions()
        {//Retunrs instructions
            return instructions;
        }
        
        public void AddIngr (string IngrName, int Number)
        {//Add new ingr to recepie
            //Must somehow check if ingr exists
            if (!true)
            {
                //Add ingr if it dont exist
            }
          IngrList.Add(IngrName);
          IngrNumber.add(Number);
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
