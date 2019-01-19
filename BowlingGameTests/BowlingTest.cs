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
            RollMany(20, 1);
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
            RollMany(18, 0);
            _bowlingGame.Roll(10);
            _bowlingGame.Roll(10);
            _bowlingGame.Roll(10);
            ScoreShouldBe(30);
        }

        private void RollMany(int times, int pins)
        {
            for (int i = 0; i < times; i++)
            {
                _bowlingGame.Roll(pins);
            }
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

        [TestMethod]
        public void GameTest()
        {
            var game = new Game();
            for (int i = 0; i < 18; i++)
            {
                game.roll(0);
            }

            //for (int i = 0; i < 3; i++)
            //{
            //    game.roll(10);
            //}
            game.roll(3);
            game.roll(7);
            game.roll(10);

            Assert.AreEqual(20, game.score());
        }

        private void ScoreShouldBe(int expected)
        {
            Assert.AreEqual(expected, _bowlingGame.Score());
        }
    }
}