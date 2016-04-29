using System.Collections.Generic;

namespace ZorkClone.FSM.PlayStates
{
	abstract class RoomState : State
	{
		protected List<string> thingsInRoom;
		protected List<CharacterInfo.Moves> availableMoves;
		protected List<CharacterInfo.Actions> availableActions;

		public RoomState(string name, List<CharacterInfo.Actions> actionList, List<CharacterInfo.Moves> moveList, List<string> things ) : base(name)
		{
			thingsInRoom = things;
			availableActions = actionList;
			availableMoves = moveList;
		}

		public abstract override void Enter();

		public abstract override void Exit();


		public abstract override bool Run();
	
	}
}
