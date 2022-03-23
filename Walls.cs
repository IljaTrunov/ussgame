using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ussgame
{
    class Walls //создаем класс для созданий стен.
    {
        List<Figure> wallList;
        //тут происходит создание стен
        public Walls(int mapW, int mapH)
        {
            Console.ForegroundColor = ConsoleColor.White;
            wallList = new List<Figure>();
            HorizontalLine hUpLine = new HorizontalLine(0, mapW - 2, 0, '-');
            HorizontalLine hDownLine = new HorizontalLine(0, mapW - 2, mapH - 1, '-');
            VerticalLine vLeftLine = new VerticalLine(0, mapH - 1, 0, '|');
            VerticalLine vRightLine = new VerticalLine(0, mapH - 1, mapW - 2, '|');
            //тут рисуются рамка по вертикали и горизонтали, можно поставить любой символ, нельзя поставить пустое поле, иначе код не будет работать
            wallList.Add(hUpLine);
            wallList.Add(hDownLine);
            wallList.Add(vLeftLine);
            wallList.Add(vRightLine);
        }
        internal bool IsHit(Figure figure)
        {
            foreach (var wall in wallList)
            {
                if (wall.IsHit(figure))
                {
                    return true;
                }
            }
            return false;
        }
        //создается проверка на прикосновение стенки, если игрок коснулся стенки то возращает True, а если нет то False.
        public void Draw()
        {
            foreach (var wall in wallList)
            {
                wall.Draw();
            }
        }//сортировка рамки
    }
}
