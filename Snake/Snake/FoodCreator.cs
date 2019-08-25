using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class FoodCreator
    {
        int mapWidth;
        int mapHeigth;
        char sym;

        Random random = new Random();

        public FoodCreator(int mapWidth, int mapHeigth, char sym)
        {
            this.mapWidth = mapWidth;
            this.mapHeigth = mapHeigth;
            this.sym = sym;
        }

        public Point CreateFood()
        {
            var x = random.Next(2, mapWidth - 2);
            var y = random.Next(2, mapHeigth - 2);

            return new Point(x,y,sym);
        }
    }
}
