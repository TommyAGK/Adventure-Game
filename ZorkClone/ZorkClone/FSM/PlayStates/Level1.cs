﻿using System;
using System.Collections.Generic;

namespace ZorkClone.FSM.PlayStates
{
	class Level1 : RoomState
	{
		public Level1(string name, List<CharacterInfo.Actions> actionList, List<CharacterInfo.Moves> moveList, List<string> things) : 
			base(name, actionList, moveList, things)
		{
		}

		public override void Enter()
		{
			//Console.WriteLine("You came from the south direction, through the Window of all things");
			Console.Write("Available actions are");
			foreach (var act in availableActions)
			{
				Console.Write(", " + act.ToString() );
			}
			Console.WriteLine();
			
		}

		public override void Exit()
		{
			Console.Clear();
			Console.WriteLine("You go up to the window and climb out");

		}

		public override bool Run()
		{

			bool run = true;
			string read = Console.ReadLine().ToLower();
			
			
			switch (read)
			{
				case "south":
					CharacterInfo.statesIhaveSeen.Add(this);
					StateMachine.PlayInstance.AddState(CharacterInfo.statesIhaveSeen[CharacterInfo.statesIhaveSeen.Count -2]); // go to previous room again
					break;
				case "west":
					State state = new Level2("second room",
														new List<CharacterInfo.Actions>() { CharacterInfo.Actions.Take, CharacterInfo.Actions.Look, CharacterInfo.Actions.Hide },
														new List<CharacterInfo.Moves>() { CharacterInfo.Moves.North, CharacterInfo.Moves.South, CharacterInfo.Moves.East, CharacterInfo.Moves.West },
														new List<string>() { "Fork", "Shovel", "Map" });
					StateMachine.PlayInstance.AddState(state);
					//StateMachine.MenuInstance.AddState(new ControlOptionState("Controls"));
					break;
				case "these":
					//StateMachine.MenuInstance.RemoveState();

					break;

				default:
					break;
			}
			return run;
		}
	}
}
