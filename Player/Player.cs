using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber.Player
{
    public class Player : IPlayer
    {
        int _attemps = 0;
        int _lastAnwser = 0;
        bool _death = true;

        public Player()
        {
            _attemps = 10;
            _death = false;
        }

        public int GetAttemps()
        {
            return _attemps;
        }

        public bool AnweredCorrectly(int rightNumber)
        {
            return _lastAnwser == rightNumber;
        }

        public void AttempsMinusOne()
        {
            if (_attemps - 1 > 0)
                _attemps--;
            else
                _death = true;
        }

        /// <summary>
        /// -1 если меньше, 1 если больше
        /// </summary>
        /// <param name="rightNumber"></param>
        /// <returns></returns>
        public int GetMoreOrLess(int rightNumber)
        {
            if (_lastAnwser > rightNumber)
                return -1;
            else
                return 1;
        }

        public void SetAnswer(int answer)
        {
            _lastAnwser = answer;
        }

        public bool GetDeathStatus()
        {
            return _death;
        }

    }
}
