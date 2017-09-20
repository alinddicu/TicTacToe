namespace TicTacToe
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

	public class WinCase
	{
		private readonly List<Position> _positions = new List<Position>();

		public WinCase(Position pos1, Position pos2, Position pos3)
		{
			_positions.AddRange(new[] { pos1, pos2, pos3 });
		}

		public override bool Equals(object obj)
		{
			if (obj == null)
			{
				return false;
			}

			if (typeof(WinCase) != obj.GetType())
			{
				return false;
			}

			var winCase = (WinCase) obj;
			return _positions.Contains(winCase._positions[0]) &&
			       _positions.Contains(winCase._positions[1]) &&
			       _positions.Contains(winCase._positions[2]);
		}

        public bool Contains(params Position[] positions)
        {
            throw new NotImplementedException();
        }
	}
}
