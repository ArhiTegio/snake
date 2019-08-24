﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class HorizontalLine
    {
        List<Point> pList = new List<Point>();

        public HorizontalLine(int xLeft, int xRight, int y, char sym)
        {
            for (int x = xLeft; x <= xRight; x++)
            {
                pList.Add(new Point( x, y, sym ));
            }
        }

        public void Draw()
        {
            foreach(Point p in pList)
            {
                p.Draw();
            }
        }
    }
}