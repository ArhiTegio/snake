using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point
    {
        int x = 0;
        int y = 0;
        char symbol;

        public Point() { }

        public Point(int x, int y, char symbol)
        {
            X = x;
            Y = y;
            Symbol = symbol;
        }

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public char Symbol { get => symbol; set => symbol = value; }

        public void Draw()
        {
            Console.SetCursorPosition(this.X, this.Y);
            Console.Write(this.Symbol);
        }
    }
}
