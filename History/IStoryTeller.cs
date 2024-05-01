using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber.History
{
    public interface IStoryTeller
    {
        void SayHello();
        void Start();
        void PlayerLose();
        void PlayerWin();
    }
}
