namespace TicTacToe.Test
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class WinCaseTest
    {
        [TestMethod]
        public void CheckWinCase()
        {
            var winCase = new WinCase(new Position(0, 0), new Position(0, 1), new Position(0, 2));
        }
    }
}
