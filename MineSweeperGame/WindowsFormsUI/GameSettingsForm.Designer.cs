namespace WindowsFormsUI
{
    partial class GameSettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.StartNewGameButton = new System.Windows.Forms.Button();
            this.HardDifficultyRadio = new System.Windows.Forms.RadioButton();
            this.MediumDifficultyRadio = new System.Windows.Forms.RadioButton();
            this.EasyDifficultyRadio = new System.Windows.Forms.RadioButton();
            this.EasyDifficultyLabel = new System.Windows.Forms.Label();
            this.MediumDifficultyLabel = new System.Windows.Forms.Label();
            this.HardDifficultyLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StartNewGameButton
            // 
            this.StartNewGameButton.BackColor = System.Drawing.Color.SeaGreen;
            this.StartNewGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartNewGameButton.Location = new System.Drawing.Point(311, 444);
            this.StartNewGameButton.Name = "StartNewGameButton";
            this.StartNewGameButton.Size = new System.Drawing.Size(139, 57);
            this.StartNewGameButton.TabIndex = 0;
            this.StartNewGameButton.Text = "Start";
            this.StartNewGameButton.UseVisualStyleBackColor = false;
            // 
            // HardDifficultyRadio
            // 
            this.HardDifficultyRadio.Appearance = System.Windows.Forms.Appearance.Button;
            this.HardDifficultyRadio.BackColor = System.Drawing.Color.SeaGreen;
            this.HardDifficultyRadio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HardDifficultyRadio.Location = new System.Drawing.Point(82, 328);
            this.HardDifficultyRadio.Name = "HardDifficultyRadio";
            this.HardDifficultyRadio.Size = new System.Drawing.Size(245, 57);
            this.HardDifficultyRadio.TabIndex = 1;
            this.HardDifficultyRadio.TabStop = true;
            this.HardDifficultyRadio.Text = "Hard";
            this.HardDifficultyRadio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.HardDifficultyRadio.UseVisualStyleBackColor = false;
            // 
            // MediumDifficultyRadio
            // 
            this.MediumDifficultyRadio.Appearance = System.Windows.Forms.Appearance.Button;
            this.MediumDifficultyRadio.BackColor = System.Drawing.Color.SeaGreen;
            this.MediumDifficultyRadio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MediumDifficultyRadio.Location = new System.Drawing.Point(82, 240);
            this.MediumDifficultyRadio.Name = "MediumDifficultyRadio";
            this.MediumDifficultyRadio.Size = new System.Drawing.Size(245, 57);
            this.MediumDifficultyRadio.TabIndex = 2;
            this.MediumDifficultyRadio.TabStop = true;
            this.MediumDifficultyRadio.Text = "Medium";
            this.MediumDifficultyRadio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MediumDifficultyRadio.UseVisualStyleBackColor = false;
            // 
            // EasyDifficultyRadio
            // 
            this.EasyDifficultyRadio.Appearance = System.Windows.Forms.Appearance.Button;
            this.EasyDifficultyRadio.BackColor = System.Drawing.Color.SeaGreen;
            this.EasyDifficultyRadio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EasyDifficultyRadio.Location = new System.Drawing.Point(82, 152);
            this.EasyDifficultyRadio.Name = "EasyDifficultyRadio";
            this.EasyDifficultyRadio.Size = new System.Drawing.Size(245, 57);
            this.EasyDifficultyRadio.TabIndex = 3;
            this.EasyDifficultyRadio.TabStop = true;
            this.EasyDifficultyRadio.Text = "Easy";
            this.EasyDifficultyRadio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EasyDifficultyRadio.UseVisualStyleBackColor = false;
            // 
            // EasyDifficultyLabel
            // 
            this.EasyDifficultyLabel.AutoSize = true;
            this.EasyDifficultyLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EasyDifficultyLabel.Location = new System.Drawing.Point(120, 212);
            this.EasyDifficultyLabel.Name = "EasyDifficultyLabel";
            this.EasyDifficultyLabel.Size = new System.Drawing.Size(176, 25);
            this.EasyDifficultyLabel.TabIndex = 4;
            this.EasyDifficultyLabel.Text = "9x9 Grid - 10 Mines";
            // 
            // MediumDifficultyLabel
            // 
            this.MediumDifficultyLabel.AutoSize = true;
            this.MediumDifficultyLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MediumDifficultyLabel.Location = new System.Drawing.Point(110, 300);
            this.MediumDifficultyLabel.Name = "MediumDifficultyLabel";
            this.MediumDifficultyLabel.Size = new System.Drawing.Size(196, 25);
            this.MediumDifficultyLabel.TabIndex = 5;
            this.MediumDifficultyLabel.Text = "16x16 Grid - 40 Mines";
            // 
            // HardDifficultyLabel
            // 
            this.HardDifficultyLabel.AutoSize = true;
            this.HardDifficultyLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HardDifficultyLabel.Location = new System.Drawing.Point(110, 388);
            this.HardDifficultyLabel.Name = "HardDifficultyLabel";
            this.HardDifficultyLabel.Size = new System.Drawing.Size(196, 25);
            this.HardDifficultyLabel.TabIndex = 6;
            this.HardDifficultyLabel.Text = "30x16 Grid - 99 Mines";
            // 
            // GameSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 45F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.HardDifficultyLabel);
            this.Controls.Add(this.MediumDifficultyLabel);
            this.Controls.Add(this.EasyDifficultyLabel);
            this.Controls.Add(this.EasyDifficultyRadio);
            this.Controls.Add(this.MediumDifficultyRadio);
            this.Controls.Add(this.HardDifficultyRadio);
            this.Controls.Add(this.StartNewGameButton);
            this.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "GameSettingsForm";
            this.Text = "GameSettingsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartNewGameButton;
        private System.Windows.Forms.RadioButton HardDifficultyRadio;
        private System.Windows.Forms.RadioButton MediumDifficultyRadio;
        private System.Windows.Forms.RadioButton EasyDifficultyRadio;
        private System.Windows.Forms.Label EasyDifficultyLabel;
        private System.Windows.Forms.Label MediumDifficultyLabel;
        private System.Windows.Forms.Label HardDifficultyLabel;
    }
}