namespace BowlingGameTests
{
    internal class BowlingGame
    {
        private int _score;

        public BowlingGame()
        {
        }

        public void Roll(int hitPinNumber)
        {
            _score += hitPinNumber;
        }

        public int Score()
        {
            return _score;
        }
    }
}