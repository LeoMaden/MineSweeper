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
    }
}
