using System;

namespace ZorkClone.MenuStates
{
	public class OptionsState : State
	{
		public OptionsState(string name) : base(name)
		{
		}
		public override bool Run()
		{
			bool run = true;

			Menu m = new Menu(new string[] { "Sound", "Controls", "Back" });
			var k = m.PrintMenuInt();
			switch (k)
			{
				case 0:
					StateMachine.MenuInstance.AddState(new SoundOptionState("Sound"));
					break;
				case 1:
					StateMachine.MenuInstance.AddState(new ControlOptionState("Controls"));
					break;
				case 2:
					StateMachine.MenuInstance.RemoveState();
					
					break;

				default:
					break;
			}
			return run;
		}

		public override void Enter()
		{
			Console.Clear();
		}

		public override void Exit()
		{

		}
	}
}
