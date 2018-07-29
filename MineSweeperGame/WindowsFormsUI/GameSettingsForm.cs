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
        public GameSettingsForm()
        {
            InitializeComponent();
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

        private void CustomWidthSelector_Scroll(object sender, EventArgs e)
        {
            // Update value in label for width scroll bar.
            int selectedWidth = CustomWidthSelector.Value;
            // Pad width with leading zeros before setting label text.
            SelectedCustomWidthLabel.Text = selectedWidth.ToString("000");
        }

        private void CustomHeightSelector_Scroll(object sender, EventArgs e)
        {
            // Update value in label for height scroll bar.
            int selectedHeight = CustomHeightSelector.Value;
            // Pad height with leading zeros before setting label text.
            SelectedCustomHeightLabel.Text = selectedHeight.ToString("000");
        }

        private void CustomMinesSelector_Scroll(object sender, EventArgs e)
        {
            // Update value in label for mines scroll bar.
            int selectedMines = CustomMinesSelector.Value;
            // Pad mines with leading zeros before setting label text.
            SelectedCustomMinesLabel.Text = selectedMines.ToString("000");
        }
    }
}
