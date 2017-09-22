namespace TicTacToe.Console
{
	using System;

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
