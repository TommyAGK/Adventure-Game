using System;
using ZorkClone.MenuStates;

namespace ZorkClone
{
	class Game
	{

		

	

		public Game()
		{
			StateMachine.MenuInstance.AddState(new MainMenuState("Main menu"));
					//mainMenu = new Menu(new string[] { "Start game", "Options", "Credits", "Help", "Exit" });
		}

		public void GameLoop()
		{
		
			while (StateMachine.MenuInstance.Update())
			{

			}
		

			

		}

		void Init()
		{
			Console.Clear();
			Console.Title = "Tork the game";
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine("Welcome to Tork!");
			


		}




		//void HandleMenu()
		//{
		//	MenuChoice.Main choice = mainMenu.PrintMenu(new MenuChoice.Main());

		//	switch (choice)
		//	{
		//		case MenuChoice.Main.Play:
		//			currentState = GameState.PLAY;
		//			break;
		//		case MenuChoice.Main.Options:
		//			currentState = GameState.OPTIONS;
		//			break;
		//		case MenuChoice.Main.Credits:
		//			currentState = GameState.CREDITS;
		//			break;
		//		case MenuChoice.Main.Help:
		//			currentState = GameState.HELP;
		//			break;
		//		case MenuChoice.Main.Exit:
		//			if (currentState != GameState.EXIT)
		//			{
		//				if (YesNo())
		//				{
		//					currentState = GameState.EXIT;
		//				}
		//				else
		//				{
		//					Console.Clear();
		//					Console.SetCursorPosition(0, Console.CursorTop);
		//					HandleMenu();
		//				}
		//			}
		//			break;

		//		default:
		//			break;
		//	}
		//}

		private void DisplayHelp()
		{
			throw new NotImplementedException();
		}

		private void DisplayCredits()
		{
			throw new NotImplementedException();
		}

		//private void SetupGame()
		//{
		//	Init();
		//	Menu options = new Menu(new string[] { "Sound", "Controls", "Back" });

		//	MenuChoice.Options choice = options.PrintMenu(new MenuChoice.Options());

		//	switch (choice)
		//	{
		//		case MenuChoice.Options.Sound:
		//			SoundOptions();
					
		//			break;
		//		case MenuChoice.Options.Controls:
		//			Console.WriteLine("Up go up, down go down, left go right, right go that way!");
		//			break;
		//		case MenuChoice.Options.Back:
		//			currentState = GameState.MENU;
		//			break;
		//		default:
		//			break;
		//	}



		//}

		//private void SoundOptions()
		//{
		//	Init();
		//	Menu soundOptions = new Menu(new string[] { "Volume", "Mute", "Music", "Back" });
		//	MenuChoice.SubOptions choice = soundOptions.PrintMenu(new MenuChoice.SubOptions());
		//	switch (choice)
		//	{
		//		case MenuChoice.SubOptions.Volume:
		//			break;
		//		case MenuChoice.SubOptions.Mute:
		//			break;
		//		case MenuChoice.SubOptions.Music:
		//			break;
		//		case MenuChoice.SubOptions.Back:
		//			SetupGame();
		//			break;
		//		default:
		//			break;
		//	}
		//}

		private void InitGame()
		{
			throw new NotImplementedException();
		}
	}
}
