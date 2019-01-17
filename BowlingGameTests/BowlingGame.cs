using System;
using System.Collections.Generic;
using System.Linq;

namespace BowlingGameTests
{
    internal class BowlingGame
    {
        private List<int> _scoreList = new List<int>();
        private List<Bonus> _bonusList = new List<Bonus>();

        public BowlingGame()
        {
        }

        public void Roll(int hitPinNumber)
        {
            _scoreList.Add(hitPinNumber);
            if (_scoreList.Count() % 2 == 0
                && _scoreList.LastOrDefault() + _scoreList.ElementAt(_scoreList.Count() - 2) == 10)
            {
                _bonusList.Add(new Bonus()
                {
                    Round = Round,
                    Times = 1,
                    Score = 0
                });
            }

            foreach (var bonus in _bonusList.Where(a => a.Round != Round && a.Times > 0))
            {
                bonus.Times--;
                bonus.Score += hitPinNumber;
            }
        }

        private int Round => (int)Math.Ceiling((_scoreList.Count() / 2m));

        public int Score()
        {
            return _scoreList.Sum() + _bonusList.Sum(a => a.Score);
        }
    }

    internal class Bonus
    {
        public int Round { get; set; }
        public int Times { get; internal set; }
        public int Score { get; internal set; }
    }
}