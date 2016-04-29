using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZorkClone
{
	class Speciality
	{
		string name;
		string description;

		Dictionary<string, string> Abilites;


		public Speciality()
		{
			Abilites = new Dictionary<string, string>();
		}
		
	}
}
