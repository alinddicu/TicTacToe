namespace TicTacToe.Console.Test
{
	using System;
	using Microsoft.VisualStudio.TestTools.UnitTesting;
	using NFluent;

	[TestClass]
	public class GridTest
	{
		[TestMethod]
		public void CheckGridToStringMethodOnPlayerAFullGrid()
		{
			var playerA = new Player("A");
			var playerB = new Player("B");
			playerA.AddPosition(new Position(0, 0), playerB);
			playerA.AddPosition(new Position(0, 1), playerB);
			playerA.AddPosition(new Position(0, 2), playerB);

			playerA.AddPosition(new Position(1, 0), playerB);
			playerA.AddPosition(new Position(1, 1), playerB);
			playerA.AddPosition(new Position(1, 2), playerB);

			playerA.AddPosition(new Position(2, 0), playerB);
			playerA.AddPosition(new Position(2, 1), playerB);
			playerA.AddPosition(new Position(2, 2), playerB);

			var grid = new Grid(playerA, playerB);

			var expectedValue = 
				"AAA|" + Environment.NewLine + 
				"AAA|" + Environment.NewLine + 
				"AAA|" + Environment.NewLine;
			Check.That(grid.ToString()).Equals(expectedValue);
		}

		[TestMethod]
		public void CheckGridToStringMethodOnPlayerALines1And3AndPlayerBLine2()
		{
			var playerA = new Player("A");
			var playerB = new Player("B");
			playerA.AddPosition(new Position(0, 0), playerB);
			playerA.AddPosition(new Position(0, 1), playerB);
			playerA.AddPosition(new Position(0, 2), playerB);

			playerB.AddPosition(new Position(1, 0), playerA);
			playerB.AddPosition(new Position(1, 1), playerA);
			playerB.AddPosition(new Position(1, 2), playerA);

			playerA.AddPosition(new Position(2, 0), playerB);
			playerA.AddPosition(new Position(2, 1), playerB);
			playerA.AddPosition(new Position(2, 2), playerB);

			var grid = new Grid(playerA, playerB);

			var expectedValue =
				"AAA|" + Environment.NewLine +
				"BBB|" + Environment.NewLine +
				"AAA|" + Environment.NewLine;
			Check.That(grid.ToString()).Equals(expectedValue);
		}
	}
}
