using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    public class MineGrid
    {
        private int[,] GameGrid { get; set; }

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
    }
}
