using System;

namespace ZorkClone
{
	class Program
	{
		static Game game;
		static void Main(string[] args)
		{
			game = new Game();
			game.GameLoop();
		}
	}
}

