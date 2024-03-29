﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

            var walls = new Walls(80, 25);
            walls.Draw();

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
            snake.Draw();

            var foodCreator = new FoodCreator(80, 25, '$');
            var food = foodCreator.CreateFood();
            food.Draw();

            while(true)
            {
                if (walls.IsHit(snake) || snake.IsHitTail())
                {
                    break;
                }

                if(snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }

                if(Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.Heandl(key.Key);
                }

                Thread.Sleep(100);
                //snake.Move();
            }

            //Console.ReadLine();
        }
    }
}

