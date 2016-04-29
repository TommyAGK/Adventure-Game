using System;

namespace ZorkClone.MenuStates
{
	public class MainMenuState : State
	{
		public MainMenuState(string name) : base(name)
		{

		}

		public override bool Run()
		{
			bool run = true;

			Menu m = new Menu(new string[] { "Play", "Options", "Exit"});
			var k = m.PrintMenuInt();
			switch (k)
			{
				case 0:
					StateMachine.MenuInstance.AddState(new PlayGameState("Play game"));
					break;
				case 1:
					StateMachine.MenuInstance.AddState(new OptionsState("Options"));
					break;
				case 2:
					StateMachine.MenuInstance.AddState(new ExitState("Exit"));
					run = false;
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
