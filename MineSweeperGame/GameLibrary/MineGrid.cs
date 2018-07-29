using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    public class MineGrid
    {
        public int[,] GameGrid { get; set; }

        public int Width => GameGrid.GetLength(0);

        public int Height => GameGrid.GetLength(1);

        public int NumberOfMines { get; private set; }


        public MineGrid(int width, int height, int numMines)
        {
            // Initialise fields in constructor.
            GameGrid = new int[width, height];
            NumberOfMines = numMines;

            // If there are too many mines.
            if (NumberOfMines > (0.4 * Width * Height))
            {
                throw new InvalidOperationException("Too many mines");
            }

            // Initialise grid.
            PlaceMines();
            GenerateBombMarkers();
        }

        private void PlaceMines()
        {
            // Repeat for each mine to be placed.
            for (int i = 0; i < NumberOfMines; i++)
            {
                Random rand = new Random();

                // Loop until empty location found.
                while (true)
                {
                    // Generate random grid coordinates.
                    int randX = rand.Next(Width);
                    int randY = rand.Next(Height);

                    // If position is empty.
                    if (GameGrid[randX, randY] == 0)
                    {
                        // Set position to bomb.
                        GameGrid[randX, randY] = -1;
                        break;
                    } 
                }
            }
        }

        private void GenerateBombMarkers()
        {
            for (int x = 0; x < Width; x++)
            {
                for (int y = 0; y < Height; y++)
                {
                    // Not a bomb at location.
                    if (GameGrid[x, y] != -1)
                    {
                        GameGrid[x, y] = MinesAroundPosition(x, y);
                    }
                }
            }
        }

        private int MinesAroundPosition(int x, int y)
        {
            int output = 0;

            // Loop from left to right in 3x3 grid around (x,y).
            for (int i = x - 1; i <= x + 1; i++)
            {
                // Loop from top to bottom in 3x3 grid around (x,y).
                for (int j = y - 1; j <= y + 1; j++)
                {
                    // Check (i,j) is within grid.
                    if (i >= 0 && j >= 0 && i < Width && j < Height)
                    {
                        // If bomb at (i,j).
                        if (GameGrid[i, j] == -1)
                        {
                            output++;
                        }
                    }
                }
            }

            return output;
        }

        public List<Tuple<int, int>> SurroundingCells(int x, int y)
        {
            List<Tuple<int, int>> output = new List<Tuple<int, int>>();

            // Loop from left to right in 3x3 grid around (x,y).
            for (int i = x - 1; i <= x + 1; i++)
            {
                // Loop from top to bottom in 3x3 grid around (x,y).
                for (int j = y - 1; j <= y + 1; j++)
                {
                    // Check (i,j) is within grid.
                    if (i >= 0 && j >= 0 && i < Width && j < Height)
                    {
                        // (i,j) is not (x,y).
                        if (i != x && j != y)
                        {
                            output.Add(Tuple.Create(i, j));
                        }
                    }
                }
            }

            return output;
        }
    }
}
