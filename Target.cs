using System;

namespace ConsoleSnakeGame
{
    public class Target
    {
        public int targetX { get; private set; }
        public int targetY { get; private set; }

        private readonly Borders borders;
       public Random random = new Random();

        public Target(Borders borders)
        {
            this.borders = borders;
        }

        public void NewTarget()
        {
            targetX = random.Next(2,borders.Wedth-2);
            targetY = random.Next(2,borders.Heigth-2);
            WriteTarget();
        }
        private void WriteTarget()
        {
            Console.Clear();
            borders.WriteBorder();
            Console.SetCursorPosition(targetX, targetY);
            Console.Write("#");
        }

    }
}
