using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Walls
    {
        List<Figure> wallList;

        public Walls(int mapWidth, int mapHeigth)
        {
            wallList = new List<Figure>();

            //Отрисовка рамочки
            wallList.Add(new HorizontalLine(0, mapWidth - 2, 0, '+'));
            wallList.Add(new HorizontalLine(0, mapWidth - 2, mapHeigth - 1, '+'));
            wallList.Add(new VerticalLine(0, mapHeigth - 1, 0, '+'));
            wallList.Add(new VerticalLine(0, mapHeigth - 1, mapWidth - 2, '+'));
        }

        internal bool IsHit(Figure figure)
        {
            foreach(var wall in wallList)
            {
                if (wall.IsHit(figure))
                {
                    return true;
                }
            }
            return false;
        }

        public void Draw()
        {
            foreach(var wall in wallList)
            {
                wall.Draw();
            }
        }

    }
}
