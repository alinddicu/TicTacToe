namespace TicTacToe
{
    using System.Collections.Generic;
    using System.Linq;

	public class WinCase
	{
		private readonly List<Position> _positions = new List<Position>();

		public WinCase(Position pos1, Position pos2, Position pos3)
		{
			_positions.AddRange(new[] { pos1, pos2, pos3 });
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
