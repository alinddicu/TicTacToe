namespace TicTacToe
{
	using System;
	using System.Linq;

	public class Game
	{
		private readonly Func<string> _input;
		private readonly Action<string> _output;
		private readonly Player _playerA = new Player("A");
		private readonly Player _playerB = new Player("B");
		private readonly Grid _grid;
		private readonly Player[] _players;
		private readonly VictoryPossibilities _victoryPossibilities = new VictoryPossibilities();

		public Game(Func<string> input, Action<string> output)
		{
			_input = input;
			_output = output;
			_grid = new Grid(_playerA, _playerB);
			_players = new[] { _playerA, _playerB };
		}

		public void Run()
		{
			for (var i = 0; ; i++)
			{
				_output("Grid layout:");
				_output(_grid.ToString());
				var activePlayer = _players[i % 2];
				GetPositionForActivePlayer(activePlayer);
				if (!_victoryPossibilities.IsWinning(activePlayer))
				{
					continue;
				}

				_output($"Player {activePlayer} won!!!");
				break;
			}

			_output("Grid layout:");
			_output(_grid.ToString());
			_input();
		}

		private void GetPositionForActivePlayer(Player activePlayer)
		{
			var inactivePlayer = _players.Except(new[] { activePlayer }).Single();
			Position position;
			do
			{
				_output($"Player {activePlayer} enter position choice: ");
				position = Position.Parse(_input());
			} while (!activePlayer.AddPosition(position, inactivePlayer));
		}
	}
}
