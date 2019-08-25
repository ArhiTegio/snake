using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Figure
    {
        Direction direction;

        internal Direction Direction { get => direction; set => direction = value; }

        public Snake(Point tail, int length, Direction direction)
        {
            this.Direction = direction;
            for (int i = 0; i < length; ++i)
            {
                var p = new Point( tail );
                p.Move( i, direction );
                pList.Add( p );
            }
        }

        internal void Move()
        {
            Point tail = pList.First();
            pList.Remove(tail);
            Point head = GetNextPoint();
            pList.Add( head );
            tail.Clear();
            head.Draw();
        }

        public Point GetNextPoint()
        {
            Point head = pList.Last();
            Point nextPoint = new Point( head );
            nextPoint.Move(1, Direction);
            return nextPoint;
        }

        public void Heandl(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)
                Direction = Direction.LEFT;
            else if (key == ConsoleKey.RightArrow)
                Direction = Direction.RIGTH;
            else if (key == ConsoleKey.DownArrow)
                Direction = Direction.DOWN;
            else if (key == ConsoleKey.UpArrow)
                Direction = Direction.UP;
        }

        internal bool IsHitTail()
        {
            var head = pList.Last();
            for(var i = 0; i< pList.Count - 2; ++i)
            {
                if (head.IsHit(pList[i]))
                {
                    return true;
                }
            }
            return false;
        }

        internal bool Eat(Point food)
        {
            var head = GetNextPoint();
            if (head.IsHit(food))
            {
                food.Symbol = head.Symbol;
                pList.Add(food);
                return true;

            }
            else
                return false;
        }
    }
}
