namespace TicTacToe.Console
{
	using System;

	public class Program
	{
		public static void Main()
		{
			var game = new Game(Console.ReadLine, Console.WriteLine);
			game.Run();
		}
	}
}
