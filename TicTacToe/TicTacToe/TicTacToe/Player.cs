namespace TicTacToe
{
	using System.Collections.Generic;

	public class Player
	{
		private readonly List<Position> _ownedPositions = new List<Position>();

		public bool AddPosition(Position position, Player playerB)
		{
			if (playerB._ownedPositions.Contains(position))
			{
				return false;
			}

			_ownedPositions.Add(position);
			return true;
		}

        public IEnumerable<Position> OwnedPositions
        {
            get
            {
                return _ownedPositions;
            }
        }
    }
}
