namespace TicTacToe.Console
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	public class Game
	{
		private readonly Player _playerA = new Player("A");
		private readonly Player _playerB = new Player("B");

		public Game()
		{
			Grid = new Grid(_playerA, _playerB);
		}

		public Grid Grid { get; private set; }
	}
}
