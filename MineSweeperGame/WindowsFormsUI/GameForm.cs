using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameLibrary;

namespace WindowsFormsUI
{
    public partial class GameForm : Form
    {
        private MineGrid MineGrid;

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

            // Initialise MineGrid.
            MineGrid = new MineGrid(GridWidth, GridHeight, GridMines);

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
            int gridPanelHeight = CellHeight * GridHeight;

            // Create grid panel container.
            Panel gridPanel = new Panel();

            gridPanel.Size = new Size(gridPanelWidth, gridPanelHeight);

            gridPanel.Left = (this.Width - gridPanelWidth) / 2;
            gridPanel.Top = 120;
            gridPanel.Padding = new Padding(0);
            gridPanel.Margin = new Padding(0);
            gridPanel.BorderStyle = BorderStyle.FixedSingle;

            Controls.Add(gridPanel);
            

            for (int x = 0; x < GridWidth; x++)
            {
                for (int y = 0; y < GridHeight; y++)
                {
                    Label label = new Label();

                    label.BackColor = SystemColors.ControlDark;
                    label.BorderStyle = BorderStyle.FixedSingle;
                    label.FlatStyle = FlatStyle.Flat;
                    label.Location = new Point(x * CellWidth, y * CellHeight);
                    label.Margin = new Padding(0);
                    label.Name = $"gridCell{ x }{ y }";
                    label.Padding = new Padding(2);
                    label.Size = new Size(CellWidth, CellHeight);
                    label.TabIndex = 0;
                    label.TextAlign = ContentAlignment.MiddleCenter;
                    label.Font = new Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    
                    // Decide what to populate text of cell with.
                    switch (MineGrid.GameGrid[x, y])
                    {
                        case -1:
                            // TODO - Bomb image
                            label.Text = "B";
                            break;

                        case 0:
                            // No bombs nearby.
                            label.Text = "";
                            break;

                        default:
                            label.Text = MineGrid.GameGrid[x, y].ToString();
                            break;
                    }

                    gridPanel.Controls.Add(label);
                }
            }
        }
    }
}
