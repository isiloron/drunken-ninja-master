using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Grupp_7_Projekt
{
	public struct ReceptSubStruct //Denna strucks andvänds av recept klassen för att hålla reda på vilka ingridienser som ingår och hur många av dem.
	{
		public string ingrName; //Namnet
		public int ingrNumber; //Antal/Mängd
        //All annan information gällande ingedienserna sparas av ingridiens listan.

		public ReceptSubStruct(string name, int number)
		{
			ingrName = name;
			ingrNumber = number;
		}
	}
}
