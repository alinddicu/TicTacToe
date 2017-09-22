namespace TicTacToe.Console
{
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;

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
		{
			var playerAOwnedPositions = _playerA.OwnedPositions.ToArray();
			var playerBOwnedPositions = _playerB.OwnedPositions.ToArray();

			var stringBuilder = new StringBuilder();
			foreach (var vertical in VictoryPossibilities.GetVerticals())
			{
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
			}

			return stringBuilder.ToString();
		}
	}
}
