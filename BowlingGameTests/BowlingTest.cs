using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BowlingGameTests
{
    [TestClass]
    public class BowlingTest
    {
        private BowlingGame _bowlingGame = new BowlingGame();

        [TestMethod]
        public void RollOneBallNotGetScore()
        {
            _bowlingGame.Roll(0);
            ScoreShouldBe(0);
        }

        private void ScoreShouldBe(int expected)
        {
            Assert.AreEqual(expected, _bowlingGame.Score());
        }
    }
}