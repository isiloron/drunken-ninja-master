using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Recept
{
    public class Recept
    {
        string Titel; //Name of the recepie
        string instructions; //Instructions on how to make it
        List <string> IngrList = new List<string>(); //List of ingr to use
        List<string> Tags = new List<string>(); //Tags related to this recpie
        
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
        
        public string GetInstructions()
        {//Retunrs instructions
            return instructions;
        }
        
        public void AddIngr (string IngrName)
        {//Add new ingr to recepie
            //Must somehow check if ingr exists
            if (!true)
            {
                //Add ingr if it dont exist
            }
          IngrList.Add(IngrName);
        }
        
        public string ReturnIngrNameByID(int ListID)
        {//This one needs a better solution....
            return IngrList[ListID]; 
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
                //How to do this?
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
