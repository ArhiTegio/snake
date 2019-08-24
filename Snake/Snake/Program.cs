using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            var point1 = new Point(1, 3, '*');
            var point2 = new Point(4, 5, '#');
            point1.Draw();
            point2.Draw();

            Console.ReadLine();
        }

        static void DrawPoint(Point point)
        {
            Console.SetCursorPosition(point.X, point.Y);
            Console.Write(point.Symbol);
        }
    }

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

