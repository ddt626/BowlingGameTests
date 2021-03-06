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

        [TestMethod]
        public void Roll_10_7_2_Get_28()
        {
            _bowlingGame.Roll(10);
            _bowlingGame.Roll(7);
            _bowlingGame.Roll(2);
            ScoreShouldBe(28);
        }

        [TestMethod]
        public void Roll_18_times_0_and_final_10_10_10_Get_30()
        {
            for (int i = 0; i < 18; i++)
            {
                _bowlingGame.Roll(0);
            }
            _bowlingGame.Roll(10);
            _bowlingGame.Roll(10);
            _bowlingGame.Roll(10);
            ScoreShouldBe(30);
        }

        [TestMethod]
        public void Perfect_Game()
        {
            for (int i = 0; i < 12; i++)
            {
                _bowlingGame.Roll(10);
            }
            ScoreShouldBe(300);
        }

        private void ScoreShouldBe(int expected)
        {
            Assert.AreEqual(expected, _bowlingGame.Score());
        }
    }
}