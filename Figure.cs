using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ussgame
{
    class Figure
    {
        protected List<Point> pList;
        //рисует точки, записанные в листе
        public void Draw()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }
        //если змейка с собой сталкивается, игра заканчивается..
        internal bool IsHit(Figure figure)
        {
            foreach (var p in pList)
            {
                if (figure.IsHit(p))
                    return true;
            }
            return false;
        }
        //если змейка сталкивается с едой, создается новая звездочка (еда), в рандомном месте.
        private bool IsHit(Point point)
        {
            foreach (var p in pList)
            {
                if (p.IsHit(point))
                    return true;
            }
            return false;
        }
    }
}
