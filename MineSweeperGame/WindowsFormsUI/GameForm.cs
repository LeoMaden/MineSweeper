﻿using System;
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

        private int CellWidth;
        private int CellHeight;

        private Panel GridPanel = new Panel();
        private int GridPanelWidth;
        private int GridPanelHeight;

        private int CellsUncovered = 0;
        private int FlagsRemaining;

        private int[] BombMarkerColours = new int[8]
        {
            0x0B4CEC, // 1 bomb: Dark blue
            0x0BA8EC, // 2 bombs: Light blue
            0x1AD636, // 3 bombs: Light green
            0xF0B50A, // 4 bombs: Orange
            0xF96E09, // 5 bombs: Deep orange
            0xFC1B0C, // 6 bombs: Light red
            0xAE0B00, // 7 bombs: Deep red
            0xF518D3  // 8 bombs: Deep pink
        };

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

            // Get possible cell sizes from how many could fit inside boundary.
            int cellSize2 = GridBoundaryPanel.Width / GridWidth;
            int cellSize1 = GridBoundaryPanel.Height / GridHeight;

            int minCellSize = Math.Min(cellSize1, cellSize2);

            CellWidth = minCellSize;
            CellHeight = minCellSize;

            InitialiseGridPanel();
            DrawFrontGrid();

            // Set number of flags left to number of bombs on grid.
            FlagsRemaining = GridMines;
            UpdateFlagsRemainingLabel();
        }

        private void GameForm_CellButtonClicked(object sender, EventArgs e)
        {
            // Cast eventargs and object to correct type.
            MouseEventArgs mouseEvent = (MouseEventArgs)e;
            Button buttonClicked = (Button)sender;

            // If this is the user's first move.
            if (CellsUncovered == 0)
            {
                // Coords of click.
                int userX = ((Tuple<int, int>)(buttonClicked.Tag)).Item1;
                int userY = ((Tuple<int, int>)(buttonClicked.Tag)).Item2;

                // Place mines, not where user clicked.
                MineGrid.PlaceMines(userX, userY);

                // Generate markers of how many bombs are around location.
                MineGrid.GenerateBombMarkers();

                DrawBehindGrid();
            }

            switch (mouseEvent.Button)
            {
                // Left click to expose cell.
                case MouseButtons.Left:
                    CellLeftClick(buttonClicked);
                    break;

                // Right click to flag/unflag cell.
                case MouseButtons.Right:
                    CellRightClick(buttonClicked);
                    break;
            }
        }

        private void CellRightClick(Button buttonClicked)
        {
            // If there is no image and there are flags remaining.
            if ((buttonClicked.Image == null) && (FlagsRemaining > 0))
            {
                // Get flag image from resources.
                Image img = Resources.FlagImage;

                // Set image of button to FlagImage but resized to correct size.
                buttonClicked.Image = new Bitmap(img, new Size(CellWidth, CellHeight));

                FlagsRemaining--;
                UpdateFlagsRemainingLabel();
            }
            // If there is an image in the button.
            else if (buttonClicked.Image != null)
            {
                // Remove image.
                buttonClicked.Image = null;

                FlagsRemaining++;
                UpdateFlagsRemainingLabel();
            }
        }

        private void CellLeftClick(Button buttonClicked)
        {
            // If button has been flagged do not allow left click.
            if (buttonClicked.Image != null)
            {
                return;
            }

            switch (ValueOfGridUnderButton(buttonClicked))
            {
                // There are no bombs surrounding button clicked.
                case 0:
                    EmptyCellLeftClick(buttonClicked);
                    break;
                // Bomb on clicked location.
                case -1:
                    buttonClicked.Hide();

                    foreach (Control control in GridPanel.Controls)
                    {
                        if (control is Button button)
                        {
                            button.Hide();
                        }
                    }

                    MessageBox.Show("You lost");

                    this.DestroyHandle();
                    break;
                // Otherwise.
                default:
                    buttonClicked.Hide();

                    // Update number of cells uncovered.
                    CellsUncovered++;
                    break;
            }

            CheckForWin();
        }

        private void UpdateFlagsRemainingLabel()
        {
            FlagsRemainingLabel.Text = FlagsRemaining.ToString("000");
        }

        private void CheckForWin()
        {
            // If all cells have been uncovered and no bombs hit.
            if (CellsUncovered == ((GridWidth * GridHeight) - GridMines))
            {
                MessageBox.Show("You WIN!");
                this.DestroyHandle();
            }
        }

        private void EmptyCellLeftClick(Button buttonClicked)
        {
            // Hide button from view to expose behind grid.
            buttonClicked.Hide();

            // Update number of cells uncovered.
            CellsUncovered++;

            // Coords of button which was clicked.
            Tuple<int, int> gridCoords = (Tuple<int, int>)buttonClicked.Tag;

            // Get coords of surrounding buttons to one clicked.
            List<Tuple<int, int>> surrounding = MineGrid.SurroundingCells(gridCoords);

            // Get button objects adjacent to button which was clicked.
            IEnumerable<Button> adjButtons = from Control control in GridPanel.Controls
                                             where control.GetType() == typeof(Button) 
                                                && surrounding.Contains(control.Tag)
                                             select (Button)control;
                                             

            foreach (Button button in adjButtons)
            {
                // Only hide and check button if it is visible.
                if (button.Visible == true)
                {
                    button.Hide();
                    
                    // No bombs around button, recursively click it.
                    if (ValueOfGridUnderButton(button) == 0)
                    {
                        EmptyCellLeftClick(button);
                    }
                    else
                    {
                        // Update number of cells uncovered.
                        CellsUncovered++;
                    }
                }
            }
        }

        private int ValueOfGridUnderButton(Button button)
        {
            Tuple<int, int> coords = (Tuple<int, int>)(button.Tag);

            return MineGrid.GameGrid[coords.Item1, coords.Item2];
        }

        private void InitialiseGridPanel()
        {
            // Calculate dimensions of grid panel container.
            GridPanelWidth = CellWidth * GridWidth;
            GridPanelHeight = CellHeight * GridHeight;

            // Set properties of GridPanel.
            GridPanel.Size = new Size(GridPanelWidth, GridPanelHeight);

            GridPanel.Left = (GridBoundaryPanel.Width - GridPanelWidth) / 2;
            GridPanel.Top = (GridBoundaryPanel.Height - GridPanelHeight) / 2;
            GridPanel.Padding = new Padding(0);
            GridPanel.Margin = new Padding(0);
            GridPanel.BorderStyle = BorderStyle.FixedSingle;

            GridBoundaryPanel.Controls.Add(GridPanel);
        }

        private void DrawBehindGrid()
        {
            // Loop through each cell in grid.
            for (int x = 0; x < GridWidth; x++)
            {
                for (int y = 0; y < GridHeight; y++)
                {
                    Label label = new Label
                    {
                        BackColor = Color.White,
                        ForeColor = Color.Black,
                        BorderStyle = BorderStyle.FixedSingle,
                        FlatStyle = FlatStyle.Flat,
                        Location = new Point(x * CellWidth, y * CellHeight),
                        Margin = new Padding(0),
                        Name = $"gridCell{ x }{ y }",
                        Padding = new Padding(2),
                        Size = new Size(CellWidth, CellHeight),
                        TabIndex = 0,
                        TextAlign = ContentAlignment.MiddleCenter,
                        Font = new Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)))
                    };

                    // Decide what to populate text of cell with.
                    switch (MineGrid.GameGrid[x, y])
                    {
                        case -1:
                            // Get the BombImage resource.
                            Image img = Resources.bombImage;

                            // Resize bomb image to correct size and set it to label's background.
                            label.Image = new Bitmap(img, new Size(CellWidth, CellHeight));
                            break;

                        case 0:
                            // No bombs nearby.
                            label.Text = "";
                            break;

                        default:
                            int value = MineGrid.GameGrid[x, y];
                            label.Text = value.ToString();
                            label.ForeColor = Color.FromArgb(BombMarkerColours[value - 1]);
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
                    button.MouseDown += GameForm_CellButtonClicked;
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
