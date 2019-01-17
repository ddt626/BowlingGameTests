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
            Bonus();
            CalculateBonus(hitPinNumber);
        }

        private void Bonus()
        {
            if (Round >= 10)
            {
                return;
            }

            if (IsSpare())
            {
                AddBonus(1);
            }

            if (IsStrike())
            {
                AddBonus(2);
                _scoreList.Add(0);
            }
        }

        private void AddBonus(int times)
        {
            _bonusList.Add(new Bonus(Round, times));
        }

        private bool IsStrike()
        {
            return _scoreList.Count() % 2 == 1
                   && _scoreList.LastOrDefault() == 10;
        }

        private void CalculateBonus(int hitPinNumber)
        {
            foreach (var bonus in _bonusList.Where(a => a.Round != Round && a.Times > 0))
            {
                bonus.Times--;
                bonus.Score += hitPinNumber;
            }
        }

        private bool IsSpare()
        {
            return _scoreList.Count() % 2 == 0
                   && _scoreList.LastOrDefault() + _scoreList.ElementAt(_scoreList.Count() - 2) == 10;
        }

        private int Round => (int)Math.Ceiling((_scoreList.Count() / 2m));

        public int Score()
        {
            return _scoreList.Sum() + _bonusList.Sum(a => a.Score);
        }
    }

    internal class Bonus
    {
        public Bonus(int round, int times)
        {
            Round = round;
            Times = times;
        }

        public int Round { get; set; }
        public int Times { get; internal set; }
        public int Score { get; internal set; }
    }
}