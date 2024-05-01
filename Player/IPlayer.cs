using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber.Player
{
    public interface IPlayer
    {
        int GetAttemps();
        bool GetDeathStatus();
        void SetAnswer(int answer);
        void AttempsMinusOne();
        bool AnweredCorrectly(int rightNumber);
        int GetMoreOrLess(int rightNumber);
    }
}
