namespace TicTacToe
{
	using System.Collections.Generic;

	public class Player
	{
		private readonly List<Position> _ownedPositions = new List<Position>();
		private readonly string _name;

		public Player(string name)
		{
			_name = name;
		}

		public bool AddPosition(Position position, Player playerB)
		{
			if (playerB._ownedPositions.Contains(position))
			{
				return false;
			}

			_ownedPositions.Add(position);
			return true;
		}

        public IEnumerable<Position> OwnedPositions => _ownedPositions;

		public override string ToString()
		{
			return _name;
		}
	}
}
