using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber.History
{
    public class StoryTeller : IStoryTeller
    {
        public void SayHello()
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Я хочу сыграть с тобой в игру...");
            Console.ResetColor();

            Console.WriteLine("Правила очень просты.");
            Console.WriteLine("Угадываешь число от 1 до до 100 за 10 попыток - идёшь своей дорогой.");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Нет - Изучаешь Hello World на Ассемблере =)");
            Console.ResetColor();
        }

        public void Start()
        {
            Console.WriteLine("Мы начинаем");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Я загадал число, от 1 до до 100. Удачи....");
            Console.ResetColor();
        }

        public void PlayerLose()
        {
            Console.WriteLine("По условиям договора - теперь ты пишешь Алгоритм бинарного поиска на Ассемблере!");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("МУ-ХА-ХА-ХА-ХА-Ха!");
            Console.ResetColor();
        }

        public void PlayerWin()
        {
            Console.ForegroundColor= ConsoleColor.Green;
            Console.WriteLine("В этот раз ты победил! Но я ещё вернусь, чтобы рассказать тебе о других алгоритмах!!!");
            Console.ResetColor();
        }

    }
}
