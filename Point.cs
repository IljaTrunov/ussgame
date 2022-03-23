using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ussgame
{
    class Point
    {
        public int x;//создаем значения которые потом преобразуем в точки.
        public int y;
        public char sym;
        public Point(int _x, int _y, char _sym)
        {
            x = _x;
            y = _y;
            sym = _sym;
        }

        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }
        //^^создание точки, класс Point, указывает на направлене, изменение координат в зависимости от направления

        //управление
        public void Move(int offset, Direction direction)
        {
            if (direction == Direction.RIGHT)
            {
                x = x + offset;
            }
            else if (direction == Direction.LEFT)
            {
                x = x - offset;
            }
            else if (direction == Direction.UP)
            {
                y = y - offset;
            }
            else if (direction == Direction.DOWN)
            {
                y = y + offset;
            }
        }
        //рисует значения в заданном месте.. 
        public void Draw()//oтображает точки
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
        //прикосновение точек
        public bool IsHit(Point p)
        {
            return p.x == this.x && p.y == this.y;
        }
        //переменные преобразует в текст
        public override string ToString()
        {
            return x + ", " + y + ", " + sym;
        }

        public void Clear()
        {
            sym = ' ';
            Draw();
        }
    }
}
