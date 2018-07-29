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

        private Panel GridPanel = new Panel();
        private int GridPanelWidth;
        private int GridPanelHeight;
        

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
            

            InitializeComponent();
        }

        private void GameForm_CellButtonClicked(object sender, EventArgs e)
        {
            // Cast eventargs and object to correct type.
            MouseEventArgs mouseEvent = (MouseEventArgs)e;
            Button buttonClicked = (Button)sender;

            switch (mouseEvent.Button)
            {
                // Left click to expose cell.
                case MouseButtons.Left:
                    // If button has been flagged do not allow left click.
                    if (buttonClicked.Text == "F")
                    {
                        break;
                    }

                    switch (ValueOfGridUnderButton(buttonClicked))
                    {
                        // There are no bombs surrounding button clicked.
                        case 0:
                            ButtonNoBombsAroundLeftClicked(buttonClicked);
                            break;
                        // Bomb on clicked location.
                        case -1:
                            buttonClicked.Hide();
                            MessageBox.Show("You lost");
                            break;
                        // Otherwise.
                        default:
                            buttonClicked.Hide();
                            break;  
                    }

                    break;

                // Right click to flag/unflag cell.
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
            }
        }

        private void ButtonNoBombsAroundLeftClicked(Button buttonClicked)
        {
            // Hide button from view to expose behind grid.
            buttonClicked.Hide();

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
                        ButtonNoBombsAroundLeftClicked(button);
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
