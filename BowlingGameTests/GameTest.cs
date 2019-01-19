using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BowlingGameTests
{
    [TestClass]
    internal class GameTest
    {
        [TestMethod]
        public void Test1()
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
    }
}