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

	    public override string ToString()
	    {
		    return $"{_x},{_y}";
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

        public override int GetHashCode()
        {
            return _x.GetHashCode() * _y.GetHashCode();
        }

	    public static Position Parse(string input)
	    {
		    var splits = input.Split(',');
		    return new Position(int.Parse(splits[0].Trim()), int.Parse(splits[1].Trim()));
	    }
    }
}
