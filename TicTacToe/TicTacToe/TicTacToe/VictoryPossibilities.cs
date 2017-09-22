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
			_winCases.Add(new WinCase(GetVertical1().ToArray()));
			_winCases.Add(new WinCase(GetVertical2().ToArray()));
			_winCases.Add(new WinCase(GetVertical3().ToArray()));

			// horizontal
			_winCases.Add(new WinCase(GetHorizontal1().ToArray()));
			_winCases.Add(new WinCase(GetHorizontal2().ToArray()));
			_winCases.Add(new WinCase(GetHorizontal3().ToArray()));

			//diagonals
			_winCases.Add(new WinCase(new Position(0, 0), new Position(1, 1), new Position(2, 2)));
			_winCases.Add(new WinCase(new Position(0, 2), new Position(1, 1), new Position(2, 0)));
		}

		public bool IsWinning(Player player)
		{
            return _winCases.Any(w => w.ContainsPlayerPositions(player));
		}

		public static IEnumerable<IEnumerable<Position>> GetVerticals()
		{
			yield return GetVertical1();
			yield return GetVertical2();
			yield return GetVertical3();
		}

		public static IEnumerable<IEnumerable<Position>> GetHorizontals()
		{
			yield return GetHorizontal1();
			yield return GetHorizontal2();
			yield return GetHorizontal3();
		}

		private static IEnumerable<Position> GetHorizontal1()
		{
			yield return new Position(0, 0);
			yield return new Position(1, 0);
			yield return new Position(2, 0);
		}

		private static IEnumerable<Position> GetHorizontal2()
		{
			yield return new Position(0, 1);
			yield return new Position(1, 1);
			yield return new Position(2, 1);
		}

		private static IEnumerable<Position> GetHorizontal3()
		{
			yield return new Position(0, 2);
			yield return new Position(1, 2);
			yield return new Position(2, 2);
		}

		private static IEnumerable<Position> GetVertical1()
		{
			yield return new Position(0, 0);
			yield return new Position(0, 1);
			yield return new Position(0, 2);
		}

		private static IEnumerable<Position> GetVertical2()
		{
			yield return new Position(1, 0);
			yield return new Position(1, 1);
			yield return new Position(1, 2);
		}

		private static IEnumerable<Position> GetVertical3()
		{
			yield return new Position(2, 0);
			yield return new Position(2, 1);
			yield return new Position(2, 2);
		}
	}
}
