using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BowlingGameTests
{
    [TestClass]
    public class BowlingTest
    {
        private BowlingGame _bowlingGame = new BowlingGame();

        [TestMethod]
        public void RollOneBallHitNothing()
        {
            _bowlingGame.Roll(0);
            ScoreShouldBe(0);
        }

        [TestMethod]
        public void RollOneBallHitTwoPin()
        {
            _bowlingGame.Roll(2);
            ScoreShouldBe(2);
        }

        [TestMethod]
        public void FirstRound_Roll_2_6_Get_8()
        {
            _bowlingGame.Roll(2);
            _bowlingGame.Roll(6);
            ScoreShouldBe(8);
        }

        private void ScoreShouldBe(int expected)
        {
            Assert.AreEqual(expected, _bowlingGame.Score());
        }
    }
}