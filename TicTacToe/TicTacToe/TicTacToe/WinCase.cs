namespace TicTacToe
{
    using System.Collections.Generic;
    using System.Linq;

	public class WinCase
	{
		private readonly List<Position> _positions = new List<Position>();

		public WinCase(params Position[] positions)
		{
			_positions.AddRange(positions);
		}

        public bool ContainsPlayerPositions(Player player)
        {
            var playerOwnedPositions = player.OwnedPositions.ToArray();
            return playerOwnedPositions.Contains(_positions[0])
                && playerOwnedPositions.Contains(_positions[1])
                && playerOwnedPositions.Contains(_positions[2]);
        }
	}
}
