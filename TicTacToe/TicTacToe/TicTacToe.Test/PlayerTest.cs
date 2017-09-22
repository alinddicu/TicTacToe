namespace TicTacToe.Test
{
    using System.Linq;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class PlayerTest
    {
        [TestMethod]
        public void CheckPlayerOwnedPositions()
        {
            var playerA = new Player("a");
            var playerB = new Player("b");
            Assert.IsTrue(playerA.AddPosition(new Position(0, 0), playerB));
            Assert.IsTrue(playerA.AddPosition(new Position(0, 1), playerB));
            CheckPlayerAPositions(playerA);
            Assert.IsFalse(playerB.AddPosition(new Position(0, 0), playerA));
            CheckPlayerAPositions(playerA);
        }

        private static void CheckPlayerAPositions(Player playerA)
        {
            Assert.AreEqual(playerA.OwnedPositions.Count(), 2);
            Assert.IsTrue(playerA.OwnedPositions.Contains(new Position(0, 0)));
            Assert.IsTrue(playerA.OwnedPositions.Contains(new Position(0, 1)));
        }
    }
}
