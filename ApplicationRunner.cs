using GuessTheNumber.Game;
using GuessTheNumber.History;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    public class ApplicationRunner : IApplicationRunner
    {
        private IStoryTeller _storyTeller;
        private IGame _game;

        public ApplicationRunner(IStoryTeller storyTeller, IGame game)
        {
            _storyTeller = storyTeller;
            _game = game;
        }

        public void Run()
        {
            _storyTeller.SayHello();
            _storyTeller.Start();
            bool result = _game.StartGameCycle();

            if (result)
                _storyTeller.PlayerWin();
            else
                _storyTeller.PlayerLose();
        }
    }
}
