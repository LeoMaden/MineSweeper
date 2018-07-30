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
    public partial class GameSettingsForm : Form
    {
        private int SelectedWidth;
        private int SelectedHeight;
        private int SelectedMines;

        private const int MaxGridWidth = 25;
        private const int MaxGridHeight = 15;

        public GameSettingsForm()
        {
            InitializeComponent();
        }

        private void GameSettingsForm_Load(object sender, EventArgs e)
        {
            // Set default custom values.
            CustomWidthSelector.Value = 15;
            CustomHeightSelector.Value = 10;
            CustomMinesSelector.Value = 30;

            // Set maximum grid size allowed in custom.
            CustomWidthSelector.Maximum = MaxGridWidth;
            CustomWidthRangeLabel.Text = $"[9 - { MaxGridWidth }]";

            CustomHeightSelector.Maximum = MaxGridHeight;
            CustomHeightRangeLabel.Text = $"[9 - { MaxGridHeight }]";

            UpdateCustomMineValues();
        }

        private void CustomDifficultyRadio_CheckedChanged(object sender, EventArgs e)
        {
            // If custom option is selected.
            if (CustomDifficultyRadio.Checked == true)
            {
                CustomDifficultyGroup.Enabled = true;

                // Update selected values.
                SelectedWidth = int.Parse(SelectedCustomWidthLabel.Text);
                SelectedHeight = int.Parse(SelectedCustomHeightLabel.Text);
                SelectedMines = int.Parse(SelectedCustomMinesLabel.Text);

            }
            // If other difficulty selected.
            else
            {
                CustomDifficultyGroup.Enabled = false;
            }
        }

        #region Custom selectors ValueChanged events

        private void CustomWidthSelector_ValueChanged(object sender, EventArgs e)
        {
            // Update value in label for width scroll bar.
            int selectedWidth = CustomWidthSelector.Value;
            // Pad width with leading zeros before setting label text.
            SelectedCustomWidthLabel.Text = selectedWidth.ToString("000");
        }

        private void CustomHeightSelector_ValueChanged(object sender, EventArgs e)
        {
            // Update value in label for height scroll bar.
            int selectedHeight = CustomHeightSelector.Value;
            // Pad height with leading zeros before setting label text.
            SelectedCustomHeightLabel.Text = selectedHeight.ToString("000");
        }

        private void CustomMinesSelector_ValueChanged(object sender, EventArgs e)
        {
            // Update value in label for mines scroll bar.
            int selectedMines = CustomMinesSelector.Value;
            // Pad mines with leading zeros before setting label text.
            SelectedCustomMinesLabel.Text = selectedMines.ToString("000");
        }

        #endregion

        #region Custom labels TextChanged events

        private void SelectedCustomWidthLabel_TextChanged(object sender, EventArgs e)
        {
            // Update selected width field
            SelectedWidth = int.Parse(SelectedCustomWidthLabel.Text);

            UpdateCustomMineValues();
        }

        private void SelectedCustomHeightLabel_TextChanged(object sender, EventArgs e)
        {
            // Update selected height field
            SelectedHeight = int.Parse(SelectedCustomHeightLabel.Text);

            UpdateCustomMineValues();
        }

        private void SelectedCustomMinesLabel_TextChanged(object sender, EventArgs e)
        {
            // Update selected mines field
            SelectedMines = int.Parse(SelectedCustomMinesLabel.Text);
        }

        #endregion

        private int CalculateMaxMines()
        {
            int width = int.Parse(SelectedCustomWidthLabel.Text);
            int height = int.Parse(SelectedCustomHeightLabel.Text);

            // Max mines is 40% of available spaces.
            return (int)Math.Floor(0.4 * width * height);
        }

        private void UpdateCustomMineValues()
        {
            int maxMines = CalculateMaxMines();

            // Update max values of mines on selector and label.
            CustomMinesSelector.Maximum = maxMines;
            CustomMinesRangeLabel.Text = $"[9-{ maxMines }]";

            // Update label showing value of selector.
            if (int.Parse(SelectedCustomMinesLabel.Text) > maxMines)
            {
                SelectedCustomMinesLabel.Text = maxMines.ToString("000");
            }
        }

        private void StartNewGameButton_Click(object sender, EventArgs e)
        {
            // MessageBox.Show($"Width: { SelectedWidth }\nHeight: { SelectedHeight }\nMines: { SelectedMines }");

            GameForm newGame = new GameForm(SelectedWidth, SelectedHeight, SelectedMines);
            //newGame.ParentForm = this;

            this.Hide();
            newGame.ShowDialog(this);
            this.Show();
        }

        #region Preset difficulty buttons Click events

        private void EasyDifficultyRadio_Click(object sender, EventArgs e)
        {
            SelectedWidth = 9;
            SelectedHeight = 9;
            SelectedMines = 10;
        }

        private void MediumDifficultyRadio_Click(object sender, EventArgs e)
        {
            SelectedWidth = 16;
            SelectedHeight = 16;
            SelectedMines = 40;
        }

        private void HardDifficultyRadio_Click(object sender, EventArgs e)
        {
            SelectedWidth = 30;
            SelectedHeight = 16;
            SelectedMines = 99;
        }

        #endregion  
    }
}
