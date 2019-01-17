using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BowlingGameTests
{
    [TestClass]
    public class BowlingTest
    {
        [TestMethod]
        public void RollOneBallNotGetScore()
        {
            var game = new BowlingGame();
            game.Roll(0);
            var actual = game.Score();
            var expected = 0;
            Assert.AreEqual(expected, actual);
        }
    }
}
