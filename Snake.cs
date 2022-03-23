using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ussgame
{
    class Snake : Figure
    {
        Direction direction;
        Score sc = new Score();
        public Snake(Point tail, int lenght, Direction _direction)
        {
            direction = _direction;
            pList = new List<Point>(); //начальная точка направления.
            for (int i = 0; i < lenght; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                pList.Add(p);
            }
        }
        //изменение головы и тела змейки, куда идет направление, команда на паузу..
        internal void Move()
        {
            if (direction != Direction.PAUSE)
            {
                Point tail = pList.First();
                pList.Remove(tail);
                Point head = GetNextPoint();
                pList.Add(head);
                tail.Clear();//стирает хвост
                head.Draw();//рисует голову
            }
            else
            {
                sc.paused();
                Console.SetCursorPosition(pList.Last().x, pList.Last().y);
            }
        }
        //показывает голову змейки
        public Point GetNextPoint()
        {
            Point head = pList.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, direction);
            return nextPoint;
        }
        //если змейка двигается и косается еды, то возращается True и заодно прибавляется +1 точка, если не касается, значение такое же как и было
        internal bool Eat(Point food)
        {
            Point head = GetNextPoint();
            if (head.IsHit(food))
            {
                food.sym = head.sym;
                pList.Add(food);
                return true;
            }
            else
                return false;
        }
        //если укусил хвост - True, игра прекращается, если не кусал - False.
        internal bool IsHitTail()
        {
            var head = pList.Last();
            for (int i = 0; i < pList.Count - 2; i++)
            {
                if (head.IsHit(pList[i]))
                    return true;
            }
            return false;
        }
        //назначение клавиш в игруле
        public void HandleKey(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)
            {
                direction = Direction.LEFT;
            }
            else if (key == ConsoleKey.RightArrow)
            {
                direction = Direction.RIGHT;
            }
            else if (key == ConsoleKey.UpArrow)
            {
                direction = Direction.UP;
            }
            else if (key == ConsoleKey.DownArrow)
            {
                direction = Direction.DOWN;
            }
            else if (key == ConsoleKey.Spacebar)
            {
                direction = Direction.PAUSE;
            }
        }

    }
}
