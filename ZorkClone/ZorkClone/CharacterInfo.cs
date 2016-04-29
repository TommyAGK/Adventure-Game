using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZorkClone
{
	public class CharacterInfo
	{

		public enum Moves
		{
			North,
			South,
			East,
			West
		}
		public enum Actions
		{
			Look,
			Take,
			Drop,
			Attack,
			Hide
		}

		public Dictionary<Moves, string> moveDict = new Dictionary<Moves, string>();
		public Dictionary<Actions, string> actionDict = new Dictionary<Actions, string>();

		public List<string> roomsVisited = new List<string>();
		public static List<string> Inventory = new List<string>();
		public static List<string> Equipped = new List<string>();

		public static bool SoundEnabled = true;

		public static List<State> statesIhaveSeen = new List<State>();




	}
}
