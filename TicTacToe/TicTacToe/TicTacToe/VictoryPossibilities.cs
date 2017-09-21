namespace TicTacToe
{
	using System.Linq;
	using System.Collections.Generic;

	public class VictoryPossibilities
	{
		private readonly List<WinCase> _winCases = new List<WinCase>();

		public VictoryPossibilities()
		{
			// vertical
			_winCases.Add(new WinCase(new Position(0, 0), new Position(0, 1), new Position(0, 2)));
			_winCases.Add(new WinCase(new Position(1, 0), new Position(1, 1), new Position(1, 2)));
			_winCases.Add(new WinCase(new Position(2, 0), new Position(2, 1), new Position(2, 2)));
			
			// horizontal
			_winCases.Add(new WinCase(new Position(0, 0), new Position(1, 0), new Position(2, 0)));
			_winCases.Add(new WinCase(new Position(0, 1), new Position(1, 1), new Position(2, 1)));
			_winCases.Add(new WinCase(new Position(0, 2), new Position(1, 2), new Position(2, 2)));

			//diagonals
			_winCases.Add(new WinCase(new Position(0, 0), new Position(1, 1), new Position(2, 2)));
			_winCases.Add(new WinCase(new Position(0, 2), new Position(1, 1), new Position(2, 0)));
		}

		public bool IsWinning(Player player)
		{
            var playerOwnedPositions = player.OwnedPositions.ToArray();
            return _winCases.Any(w => w.ContainsPlayerPositions(player));
		}
	}
}
