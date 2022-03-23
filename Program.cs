using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
//using WMPLib;

namespace ussgame
{
    class Program
    {
        static int map;
        static int speed;
        public static int mapX;
        public static int mapY;
        static private int scoreX;
        static void Main(string[] args)
        {
            //Sounds player = new Sounds();
            //player.Play();
            Console.OutputEncoding = Encoding.UTF8;//чтобы показывалось на русском языке
            Console.WriteLine("Tere! Ole valmis mangima ussi? Kirjuta kiirus 1-3!");
            speed = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Praegu valida pindala! \n1-Suur \n2-Keskmine \n3-Väike ");
            map = Convert.ToInt32(Console.ReadLine());
            Difficulty diff = new Difficulty(speed, map);
            diff.diffSet(speed, map);
            mapX = diff.mapX;
            mapY = diff.mapY;
            Console.Clear();
            Walls walls = new Walls(mapX - 10, mapY);
            walls.Draw();
            //создает еду для змейки
            FoodCreator foodCreator = new FoodCreator(mapX - 10, mapY, '0');
            Point food = foodCreator.CreateFood();
            food.Draw();

            Score score = new Score(0);

            Console.ForegroundColor = ConsoleColor.Green;
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();

            while (true)
            {
                if (walls.IsHit(snake) || snake.IsHitTail())
                {
                    scoreX = score.score;
                    break;
                }
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                    score.oneUp();
                }
                else
                {
                    score.scUpdate();
                    snake.Move();
                }
                Thread.Sleep(diff.snSpeed);
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
            }
            GameOver over = new GameOver(scoreX);
            over.Ending();
            Console.ReadLine();
        }
    }
}