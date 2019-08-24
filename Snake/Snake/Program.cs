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
            point1.Draw();
            var point2 = new Point(4, 5, '#');
            point2.Draw();

            Console.ReadLine();
        }
    }
}

