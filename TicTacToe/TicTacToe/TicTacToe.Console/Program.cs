namespace TicTacToe.Console
{
	using System;

	public class Program
	{
		public static void Main()
		{
			var game = new Game();
			game.Run(Console.ReadLine, Console.WriteLine);
		}
	}
}
