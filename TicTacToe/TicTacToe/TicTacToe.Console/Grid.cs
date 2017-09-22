namespace TicTacToe.Console
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	public class Grid
	{
		private readonly Player _playerA;
		private readonly Player _playerB;

		public Grid(Player playerA, Player playerB)
		{
			_playerA = playerA;
			_playerB = playerB;
		}

		public override string ToString()
		{;
			var playerAOwnedPositions = _playerA.OwnedPositions.ToArray();
			var playerBOwnedPositions = _playerB.OwnedPositions.ToArray();

			var stringBuilder = new StringBuilder();
			//stringBuilder.AppendLine("_____");
			foreach (var vertical in GetVerticals())
			{
				//stringBuilder.Append("|");
				foreach (var gridPosition in vertical)
				{
					if (playerAOwnedPositions.Contains(gridPosition))
					{
						stringBuilder.Append(_playerA);
					}
					else if (playerBOwnedPositions.Contains(gridPosition))
					{
						stringBuilder.Append(_playerB);
					}
					else
					{
						stringBuilder.Append(" ");
					}
				}

				stringBuilder.Append("|");
				stringBuilder.AppendLine();
				//stringBuilder.AppendLine(Environment.NewLine);
			}

			//stringBuilder.Append("_____");

			return stringBuilder.ToString();
		}

		private IEnumerable<IEnumerable<Position>> GetVerticals()
		{
			yield return GetVertical1();
			yield return GetVertical2();
			yield return GetVertical3();
		}

		private IEnumerable<Position> GetVertical1()
		{
			yield return new Position(0, 0);
			yield return new Position(0, 1);
			yield return new Position(0, 2);
		}

		private IEnumerable<Position> GetVertical2()
		{
			yield return new Position(1, 0);
			yield return new Position(1, 1);
			yield return new Position(1, 2);
		}

		private IEnumerable<Position> GetVertical3()
		{
			yield return new Position(2, 0);
			yield return new Position(2, 1);
			yield return new Position(2, 2);
		}
	}
}
