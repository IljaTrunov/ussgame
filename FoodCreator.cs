using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ussgame
{
    class FoodCreator
    {
        private int mapW;
        private int mapH;
        private char sym;

        Random rnd = new Random(); //рандом для чего-либо.

        public FoodCreator(int mapW, int mapH, char sym)
        {
            this.mapH = mapH;
            this.mapW = mapW;
            this.sym = sym;
        }

        public Point CreateFood() //создает рандомное местоположение еды.
        {
            int x = rnd.Next(2, mapW - 2);
            int y = rnd.Next(2, mapH - 2);
            return new Point(x, y, sym);
        }
    }
}