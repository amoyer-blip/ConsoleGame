using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    class World2
    {
        private string[,] Grid2;
        private int Rows;
        private int Cols;

        public World2(string[,] grid2)
        {
            Grid2 = grid2;
            Rows = grid2.GetLength(0);
            Cols = grid2.GetLength(1);
        }

        public void Draw()
        {
            for (int y = 0; y < Rows; y++)
            {
                for (int x = 0; x < Cols; x++)
                {
                    string element = Grid2[y, x];
                    Console.SetCursorPosition(x, y);
                    //Write(element);

                    if (element == "X")
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }

                    Console.Write(element);
                }

            }
        }
        public string GetElementAt(int x, int y)
        {
            return Grid2[y, x];
        }

        public bool IsPositionWalkable(int x, int y)
        {
            if (x < 0 || y < 0 || x >= Cols || y >= Rows)
            {
                return false;
            }
            return Grid2[y, x] == " " || Grid2[y, x] == "X";
        }
    }
}
