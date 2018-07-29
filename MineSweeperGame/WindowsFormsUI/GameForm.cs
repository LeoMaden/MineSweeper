using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsUI
{
    public partial class GameForm : Form
    {
        private int GridWidth;
        private int GridHeight;
        private int GridMines;

        private int CellWidth = 10;
        private int CellHeight = 10;


        public GameForm(int gridWidth, int gridHeight, int gridMines)
        {
            // Set fields from constructor parameters.
            GridWidth = gridWidth;
            GridHeight = gridHeight;
            GridMines = gridMines;

            InitializeComponent();
        }

        private void DrawBehindGrid()
        {

        }
    }
}
