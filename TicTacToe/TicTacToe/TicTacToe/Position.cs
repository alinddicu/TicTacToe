namespace TicTacToe
{
	public class Position
	{
		private readonly int _x;
		private readonly int _y;

		public Position(int x, int y)
		{
			_x = x;
			_y = y;
		}

        public override bool Equals(object obj)
        {
            if (obj == null || obj.GetType() != GetType())
            {
                return false;
            }

            var other = (Position)obj;
            return _x == other._x && _y == other._y;
        }
    }
}
