using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZorkClone.MenuStates
{
	public class SoundOptionState : State
	{
		public SoundOptionState(string name) : base(name)
		{
		}

		public override void Enter()
		{
			Console.Clear();
			Console.WriteLine("Sound options:");
			Console.WriteLine("Do you want beeps?");
			CharacterInfo.SoundEnabled =  Menu.YesNo();

		}

		public override void Exit()
		{
		}

		public override bool Run()
		{
			bool run = true;

			Menu m = new Menu(new string[] { "Back" });
			var k = m.PrintMenuInt();
			switch (k)
			{
				case 0:
					StateMachine.MenuInstance.RemoveState();
					break;

				default:
					break;
			}
			return run;
		}
	}
}
