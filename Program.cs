using System;

namespace ConsoleSnakeGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            var res = new Borders();
            var target = new Target(res);
            var snake = new Snake(target);
            res.WriteBorder();
            target.NewTarget();
            while (true)
            {
                snake.Input();
                snake.Logic();

            }

        }
    }
}
