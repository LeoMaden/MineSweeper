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

        private event EventHandler CellButtonClicked;

        private Panel GridPanel = new Panel();
        private int GridPanelWidth;
        private int GridPanelHeight;

        private Button[,] FrontButtonGrid;
        

        private void GameForm_Load(object sender, EventArgs e)
        {
            // Set usable area to full size of form.
            this.ClientSize = this.Size;

            InitialiseGridPanel();
            DrawBehindGrid();
            DrawFrontGrid();
        }

        public GameForm(int gridWidth, int gridHeight, int gridMines)
        {
            // Set fields from constructor parameters.
            GridWidth = gridWidth;
            GridHeight = gridHeight;
            GridMines = gridMines;

            // Initialise MineGrid.
            MineGrid = new MineGrid(GridWidth, GridHeight, GridMines);

            // Add event handler to cell button clicked event.
            CellButtonClicked += GameForm_CellButtonClicked;
            

            InitializeComponent();
        }

        private void GameForm_CellButtonClicked(object sender, EventArgs e)
        {
            MouseEventArgs mouseEvent = (MouseEventArgs)e;
            Button buttonClicked = (Button)sender;

            switch (mouseEvent.Button)
            {
                case MouseButtons.Left:
                    Tuple<int, int> gridCoords = (Tuple<int, int>)buttonClicked.Tag;

                    int x = gridCoords.Item1;
                    int y = gridCoords.Item2;

                    MessageBox.Show($"{ x }, { y }");

                    break;
                case MouseButtons.None:
                    break;
                // Right click to flag cell.
                case MouseButtons.Right:
                    if (buttonClicked.Text == "")
                    {
                        // TODO - Flag image.
                        buttonClicked.Text = "F";
                    }
                    else
                    {
                        buttonClicked.Text = "";
                    }

                    break;
                case MouseButtons.Middle:
                    break;
                case MouseButtons.XButton1:
                    break;
                case MouseButtons.XButton2:
                    break;
                default:
                    break;
            }
        }

        private void InitialiseGridPanel()
        {
            // Calculate dimensions of grid panel container.
            GridPanelWidth = CellWidth * GridWidth;
            GridPanelHeight = CellHeight * GridHeight;

            // Set properties of GridPanel.
            GridPanel.Size = new Size(GridPanelWidth, GridPanelHeight);

            GridPanel.Left = (this.Width - GridPanelWidth) / 2;
            GridPanel.Top = 120;
            GridPanel.Padding = new Padding(0);
            GridPanel.Margin = new Padding(0);
            GridPanel.BorderStyle = BorderStyle.FixedSingle;

            Controls.Add(GridPanel);
        }

        private void DrawBehindGrid()
        {
            // Loop through each cell in grid.
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

                    GridPanel.Controls.Add(label);
                }
            }
        }

        private void DrawFrontGrid()
        {
            for (int x = 0; x < GridWidth; x++)
            {
                for (int y = 0; y < GridHeight; y++)
                {
                    Button button = new Button();

                    button.BackColor = SystemColors.ControlDark;
                    button.FlatStyle = FlatStyle.Flat;
                    button.Location = new Point(x * CellWidth, y * CellHeight);
                    button.Margin = new Padding(0);
                    button.Name = $"gridButton{ x }{ y }";
                    button.Padding = new Padding(0);
                    button.Size = new Size(CellWidth, CellHeight);
                    button.TabIndex = 0;
                    button.TextAlign = ContentAlignment.MiddleCenter;
                    button.Click += GameForm_CellButtonClicked;
                    button.Tag = Tuple.Create(x, y);
                    button.Text = "";
                    button.Font = new Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                    GridPanel.Controls.Add(button);
                }
            }

            foreach (Control c in GridPanel.Controls)
	        {
                if (c is Button button)
                {
                    button.BringToFront();
                }
	        }
        }

    }
}
