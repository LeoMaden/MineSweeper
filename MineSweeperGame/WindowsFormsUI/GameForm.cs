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

        private int CellWidth = 20;
        private int CellHeight = 20;


        public GameForm(int gridWidth, int gridHeight, int gridMines)
        {
            // Set fields from constructor parameters.
            GridWidth = gridWidth;
            GridHeight = gridHeight;
            GridMines = gridMines;

            InitializeComponent();
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            // Set usable area to full size of form.
            this.ClientSize = this.Size;

            DrawBehindGrid();
        }

        private void DrawBehindGrid()
        {
            // Calculate dimensions of grid panel container.
            int gridPanelWidth = CellWidth * GridWidth;
            int gridPanelHeight = CellHeight * CellHeight;

            // Create grid panel container.
            Panel gridPanel = new Panel();

            gridPanel.Size = new Size(gridPanelWidth, gridPanelHeight);

            gridPanel.Left = (this.Width - gridPanelWidth) / 2;
            gridPanel.Top = 120;
            gridPanel.Padding = new Padding(0);
            gridPanel.Margin = new Padding(0);
            gridPanel.BorderStyle = BorderStyle.FixedSingle;

            Controls.Add(gridPanel);
        }
    }
}
