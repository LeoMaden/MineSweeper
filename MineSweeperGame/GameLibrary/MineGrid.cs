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
        }

        private void PlaceMines()
        {
            // Loop over how many mines there are.
            for (int i = 0; i < NumberOfMines; i++)
            {
                Random rand = new Random();

                int randX = rand.Next(Width);
                int randY = rand.Next(Height);


            }
        }
    }
}
