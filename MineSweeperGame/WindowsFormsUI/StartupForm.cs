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
    public partial class StartupForm : Form
    {
        public StartupForm()
        {
            InitializeComponent();
        }

        private void NewGameButton_Click(object sender, EventArgs e)
        {
            GameSettingsForm newGameSettings = new GameSettingsForm();

            this.Hide();
            newGameSettings.ShowDialog(this);
            this.DestroyHandle();
        }
    }
}
