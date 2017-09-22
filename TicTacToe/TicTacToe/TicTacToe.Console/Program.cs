namespace TicTacToe.Console
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	public class Program
	{
		public static void Main(string[] args)
		{
			var game = new Game();
			Console.WriteLine(game.Grid);
			Console.ReadLine();
		}
	}
}
