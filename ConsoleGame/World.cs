﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace ConsoleGame
{
    class World
    {
        private string[,] Grid;
        private int Rows;
        private int Cols;

        public World(string[,] grid)
        {
            Grid = grid;
            Rows = Grid.GetLength(0);
            Cols = Grid.GetLength(1);
        }

        public void Draw()
        {
            for (int y = 0; y < Rows; y++)
            {
                for (int x = 0; x < Cols; x++)
                {
                    string element = Grid[y, x];
                    Console.SetCursorPosition(x, y);
                    //Write(element);

                    if (element == "X")
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                    }

                    Console.Write(element);
                }

            }
        }
        //Tracking if "grid position" is empty or not. Empty = okay to move, otherwise blocked. 
        public string GetElementAt(int x, int y)
        {
            return Grid[y, x];
        }

        public bool IsPositionWalkable(int x, int y)
        {
            //Check bounds to ensure x and y are actually in the grid 
            if(x < 0 || y < 0 || x>= Cols || y>= Rows)
            {
                return false;
            }

            //Check if the grid is a walkable tile. 
            return Grid[y, x] == " " || Grid[y, x] == "X";
        }
    }
}
