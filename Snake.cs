using System;
using System.Threading;

namespace ConsoleSnakeGame
{
    public class Snake
    {
        private readonly Target target;
        char key = 's';
        int  parts = 3;
        int sped = 100;
        int[] snakeX = new int[50];
        int[] snakeY = new int[50];

        public Snake(Target target)
        {
            this.target = target;
            snakeX[0] = 5;
            snakeY[0] = 5;
            Console.CursorVisible = false;
        }
        public void Input()
        {
            if (Console.KeyAvailable)
            {
                var keyInfo = Console.ReadKey(true);
                key = keyInfo.KeyChar;
            }
        }

        public void WritePoint(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write("*");
        }

        public void Logic()
        {
            if (snakeX[0] == target.targetX &&
                snakeY[0] == target.targetY)
            {
                target.NewTarget();
                Console.Beep();
                sped -= 5;
                Console.WriteLine(sped); 
            }

            switch (key)
            {
                case 'w':
                    snakeY[0]--;
                    break;
                case 'a':
                    snakeX[0]--;
                    break;
                case 'd':
                    snakeX[0]++;
                    break;
                case 's':
                    snakeY[0]++;
                    break;
            }

            for (int i = 0; i <= parts; i++)
            {
                if(snakeX[i] !=0  && snakeY[i] != 0)
                {
                    WritePoint(snakeX[i], snakeY[i]);
                }
            }

            Thread.Sleep(sped);
        }
    }
}
