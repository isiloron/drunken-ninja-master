using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Grupp_7_Projekt
{
	public struct ReceptSubStruct
	{
		public string ingrName;
		public int ingrNumber;

		public ReceptSubStruct(string name, int number)
		{
			ingrName = name;
			ingrNumber = number;
		}
	}
}
