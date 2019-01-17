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
        public void Roll_2_6_Get_8()
        {
            _bowlingGame.Roll(2);
            _bowlingGame.Roll(6);
            ScoreShouldBe(8);
        }

        [TestMethod]
        public void Every_Roll_Hit_1_Get_20()
        {
            for (int i = 0; i < 20; i++)
            {
                _bowlingGame.Roll(1);
            }
            ScoreShouldBe(20);
        }

        [TestMethod]
        public void Roll_1_9_2_6_Get_20()
        {
            _bowlingGame.Roll(1);
            _bowlingGame.Roll(9);
            _bowlingGame.Roll(2);
            _bowlingGame.Roll(6);
            ScoreShouldBe(20);
        }

        private void ScoreShouldBe(int expected)
        {
            Assert.AreEqual(expected, _bowlingGame.Score());
        }
    }
}