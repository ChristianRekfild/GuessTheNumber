using GuessTheNumber.Player;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber.Game
{
    internal class Game : IGame
    {
        IPlayer _player;
        int _privateNumber;

        public Game(IPlayer player)
        {
            _player = player;
            _privateNumber = new Random().Next(1, 100);
        }

        /// <summary>
        /// True - если игрок победил, Иначе - False
        /// </summary>
        public bool StartGameCycle()
        {
            bool playerIsWin = false;
            while(!playerIsWin && _player.GetDeathStatus() != true)
            {
                Console.WriteLine("\n");
                Console.WriteLine($"Осталось попыток: {_player.GetAttemps()}");
                Console.WriteLine("Введите число!");


                int number;
                try
                {
                    string numberString = Console.ReadLine();
                    number = int.Parse(numberString);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Да... Такими темпами ты не скоро выиграешь!...");
                    continue;
                }

                // Проверяем, победил ли игрок
                _player.SetAnswer(number);
                if (_player.AnweredCorrectly(_privateNumber))
                {
                    return true;
                }
                
                Console.WriteLine("Ты пока не победил. Продолжаем");

                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                int moreOrLess = _player.GetMoreOrLess(_privateNumber);
                string whereString = moreOrLess < 0 ? "Меньше" : "Больше";
                Console.WriteLine($"{whereString}...");
                Console.ResetColor();

                _player.AttempsMinusOne();
            }

            return false;
        }
    }
}
