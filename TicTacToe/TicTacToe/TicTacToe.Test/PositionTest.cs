namespace TicTacToe.Test
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class PositionTest
    {
        [TestMethod]
        public void CheckPositionEquality()
        {
            Assert.AreEqual(new Position(0, 0), new Position(0, 0));
            Assert.AreNotEqual(new Position(1, 0), new Position(0, 0));
            Assert.AreNotEqual(new Position(0, 1), new Position(0, 0));
            Assert.AreNotEqual(new Position(0, 0), new Position(1, 0));
            Assert.AreNotEqual(new Position(0, 0), new Position(0, 1));
            Assert.AreNotEqual(null, new Position(0, 0));
            Assert.AreNotEqual(new Position(1, 0), null);
            Assert.AreNotEqual(new Position(1, 0), new Player("a"));
        }
    }
}
