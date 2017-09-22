namespace TicTacToe
{
	using System;
	using System.Linq;

	public class Game
	{
		private readonly Player _playerA = new Player("A");
		private readonly Player _playerB = new Player("B");
		private readonly Grid _grid;
		private readonly Player[] _players;
		private readonly VictoryPossibilities _victoryPossibilities = new VictoryPossibilities();

		public Game()
		{
			_grid = new Grid(_playerA, _playerB);
			_players = new[] { _playerA, _playerB };
		}

		public void Run(Func<string> input, Action<string> output)
		{
			for (var i = 0; ; i++)
			{
				output("Grid layout:");
				output(_grid.ToString());
				var activePlayer = _players[i % 2];
				GetActivePlayerChoice(input, output, activePlayer);
				if (!_victoryPossibilities.IsWinning(activePlayer))
				{
					continue;
				}

				output($"Player {activePlayer} won!!!");
				break;
			}

			output("Grid layout:");
			output(_grid.ToString());
			input();
		}

		private void GetActivePlayerChoice(Func<string> input, Action<string> output, Player activePlayer)
		{
			var inactivePlayer = _players.Except(new[] { activePlayer }).Single();
			Position position;
			do
			{
				output($"Player {activePlayer} enter position choice: ");
				position = Position.Parse(input());
			} while (!activePlayer.AddPosition(position, inactivePlayer));
		}
	}
}
