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
            Console.SetWindowSize(1, 1);
            Console.SetBufferSize(80, 25);
            Console.SetWindowSize(80, 25);

            //Отрисовка рамки
            var upLine = new HorizontalLine(0, 78, 0, '+');
            var downLine = new HorizontalLine(0, 78, 24, '+');
            var liftLine = new VerticalLine(0, 24, 0, '+');
            var rightLine = new VerticalLine(0, 24, 78, '+');
            upLine.Draw();
            downLine.Draw();
            liftLine.Draw();
            rightLine.Draw();

            //Отрисовка точек
            var p = new Point(4,5, '*');
            var snake = new Snake(p, 4, Direction.RIGTH);

            Console.ReadLine();
        }
    }
}

