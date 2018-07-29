﻿using System;
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
        public GameSettingsForm()
        {
            InitializeComponent();
        }

        private void GameSettingsForm_Load(object sender, EventArgs e)
        {
            CustomWidthSelector.Value = 15;
            CustomHeightSelector.Value = 10;

            UpdateCustomMineValues();
        }

        private void CustomDifficultyRadio_CheckedChanged(object sender, EventArgs e)
        {
            // If custom option is selected.
            if (CustomDifficultyRadio.Checked == true)
            {
                CustomDifficultyGroup.Enabled = true;
            }
            // If other difficulty selected.
            else
            {
                CustomDifficultyGroup.Enabled = false;
            }
        }

        private void CustomWidthSelector_ValueChanged(object sender, EventArgs e)
        {
            // Update value in label for width scroll bar.
            int selectedWidth = CustomWidthSelector.Value;
            // Pad width with leading zeros before setting label text.
            SelectedCustomWidthLabel.Text = selectedWidth.ToString("000");

            UpdateCustomMineValues();
        }

        private void CustomHeightSelector_ValueChanged(object sender, EventArgs e)
        {
            // Update value in label for height scroll bar.
            int selectedHeight = CustomHeightSelector.Value;
            // Pad height with leading zeros before setting label text.
            SelectedCustomHeightLabel.Text = selectedHeight.ToString("000");

            UpdateCustomMineValues();
        }

        private void CustomMinesSelector_ValueChanged(object sender, EventArgs e)
        {
            // Update value in label for mines scroll bar.
            int selectedMines = CustomMinesSelector.Value;
            // Pad mines with leading zeros before setting label text.
            SelectedCustomMinesLabel.Text = selectedMines.ToString("000");
        }

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
    }
}
