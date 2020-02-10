using System;

namespace ConsoleSnakeGame
{
    public class Borders
    {
        public int Wedth { get; private set; }
        public int Heigth { get; private set; }
        public Borders(int wedth = 50, int heigth=20)
        {
            this.Wedth = wedth;
            this.Heigth = heigth;
        }
        public void WriteBorder()
        {
            Console.Clear();
            for (int i = 1; i <= Wedth; i++)
            {
                Console.SetCursorPosition(i, 1);
                Console.Write("-");
            }
            for(var i = 1; i<=Heigth; i++)
            {
                Console.SetCursorPosition(Wedth,i);
                Console.Write("|");     
            }
            for (int i = 1; i <= Wedth; i++)
            {
                Console.SetCursorPosition(i,Heigth);
                Console.Write("-");
            }
            for (int i = 1; i <= Heigth; i++)
            {
                Console.SetCursorPosition(1,i);
                Console.Write("|");

            }
        }
    }
}
