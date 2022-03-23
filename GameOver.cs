using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ussgame
{
	class GameOver
	{
        private int scoreX;

        public GameOver(int scoreX)
        {
            this.scoreX = scoreX;
        }

        public void Ending()
        {
            Console.Clear();
			Console.SetWindowSize(80, 25);
			int xOff = 6;
			int yOff = 12;
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.SetCursorPosition(xOff, yOff++);
			WriteText("=====================================", xOff + 20, yOff++);
            WriteText("G A M E     O V E R", xOff + 30, yOff++);
            WriteText("=====================================", xOff + 20, yOff++);
		}

		static void WriteText(string text, int xOff, int yOff)
		{
			Console.SetCursorPosition(xOff, yOff);
			Console.WriteLine(text);
		} //выводится на экран, посередине экрана после проигрыша.
	}
}
