﻿using System;
using ZorkClone.FSM.PlayStates;

namespace ZorkClone.MenuStates
{
	public class PlayGameState : State
	{
		public PlayGameState(string name) : base(name)
		{
		}

		public override bool Run()
		{
			while (StateMachine.PlayInstance.Update())
			{
				return true;
			}
			return true;
		}

		public override void Enter()
		{
			StateMachine.PlayInstance.AddState(new  GameStartState("New Game"));
		}
		public override void Exit()
		{

		}

	}
}
