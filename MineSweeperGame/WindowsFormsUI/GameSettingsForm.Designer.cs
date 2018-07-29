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
            this.CustomDifficultyRadio = new System.Windows.Forms.RadioButton();
            this.CustomDifficultyGroup = new System.Windows.Forms.Panel();
            this.CustomWidthLabel = new System.Windows.Forms.Label();
            this.CustomHeightLabel = new System.Windows.Forms.Label();
            this.CustomMinesLabel = new System.Windows.Forms.Label();
            this.CustomWidthRangeLabel = new System.Windows.Forms.Label();
            this.CustomHeightRangeLabel = new System.Windows.Forms.Label();
            this.CustomMinesRangeLabel = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.CustomDifficultyGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
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
            // CustomDifficultyRadio
            // 
            this.CustomDifficultyRadio.Appearance = System.Windows.Forms.Appearance.Button;
            this.CustomDifficultyRadio.BackColor = System.Drawing.Color.SeaGreen;
            this.CustomDifficultyRadio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CustomDifficultyRadio.Location = new System.Drawing.Point(420, 152);
            this.CustomDifficultyRadio.Name = "CustomDifficultyRadio";
            this.CustomDifficultyRadio.Size = new System.Drawing.Size(245, 57);
            this.CustomDifficultyRadio.TabIndex = 7;
            this.CustomDifficultyRadio.TabStop = true;
            this.CustomDifficultyRadio.Text = "Custom";
            this.CustomDifficultyRadio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CustomDifficultyRadio.UseVisualStyleBackColor = false;
            this.CustomDifficultyRadio.CheckedChanged += new System.EventHandler(this.CustomDifficultyRadio_CheckedChanged);
            // 
            // CustomDifficultyGroup
            // 
            this.CustomDifficultyGroup.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.CustomDifficultyGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CustomDifficultyGroup.Controls.Add(this.trackBar1);
            this.CustomDifficultyGroup.Controls.Add(this.CustomMinesRangeLabel);
            this.CustomDifficultyGroup.Controls.Add(this.CustomHeightRangeLabel);
            this.CustomDifficultyGroup.Controls.Add(this.CustomWidthRangeLabel);
            this.CustomDifficultyGroup.Controls.Add(this.CustomMinesLabel);
            this.CustomDifficultyGroup.Controls.Add(this.CustomHeightLabel);
            this.CustomDifficultyGroup.Controls.Add(this.CustomWidthLabel);
            this.CustomDifficultyGroup.Enabled = false;
            this.CustomDifficultyGroup.Location = new System.Drawing.Point(391, 215);
            this.CustomDifficultyGroup.Name = "CustomDifficultyGroup";
            this.CustomDifficultyGroup.Size = new System.Drawing.Size(303, 185);
            this.CustomDifficultyGroup.TabIndex = 8;
            // 
            // CustomWidthLabel
            // 
            this.CustomWidthLabel.AutoSize = true;
            this.CustomWidthLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomWidthLabel.Location = new System.Drawing.Point(3, 10);
            this.CustomWidthLabel.Name = "CustomWidthLabel";
            this.CustomWidthLabel.Size = new System.Drawing.Size(79, 32);
            this.CustomWidthLabel.TabIndex = 0;
            this.CustomWidthLabel.Text = "Width";
            // 
            // CustomHeightLabel
            // 
            this.CustomHeightLabel.AutoSize = true;
            this.CustomHeightLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomHeightLabel.Location = new System.Drawing.Point(3, 63);
            this.CustomHeightLabel.Name = "CustomHeightLabel";
            this.CustomHeightLabel.Size = new System.Drawing.Size(87, 32);
            this.CustomHeightLabel.TabIndex = 1;
            this.CustomHeightLabel.Text = "Height";
            // 
            // CustomMinesLabel
            // 
            this.CustomMinesLabel.AutoSize = true;
            this.CustomMinesLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomMinesLabel.Location = new System.Drawing.Point(3, 116);
            this.CustomMinesLabel.Name = "CustomMinesLabel";
            this.CustomMinesLabel.Size = new System.Drawing.Size(80, 32);
            this.CustomMinesLabel.TabIndex = 2;
            this.CustomMinesLabel.Text = "Mines";
            // 
            // CustomWidthRangeLabel
            // 
            this.CustomWidthRangeLabel.AutoSize = true;
            this.CustomWidthRangeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomWidthRangeLabel.Location = new System.Drawing.Point(9, 42);
            this.CustomWidthRangeLabel.Name = "CustomWidthRangeLabel";
            this.CustomWidthRangeLabel.Size = new System.Drawing.Size(49, 21);
            this.CustomWidthRangeLabel.TabIndex = 3;
            this.CustomWidthRangeLabel.Text = "[9-xx]";
            // 
            // CustomHeightRangeLabel
            // 
            this.CustomHeightRangeLabel.AutoSize = true;
            this.CustomHeightRangeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomHeightRangeLabel.Location = new System.Drawing.Point(9, 95);
            this.CustomHeightRangeLabel.Name = "CustomHeightRangeLabel";
            this.CustomHeightRangeLabel.Size = new System.Drawing.Size(49, 21);
            this.CustomHeightRangeLabel.TabIndex = 3;
            this.CustomHeightRangeLabel.Text = "[9-xx]";
            // 
            // CustomMinesRangeLabel
            // 
            this.CustomMinesRangeLabel.AutoSize = true;
            this.CustomMinesRangeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomMinesRangeLabel.Location = new System.Drawing.Point(9, 148);
            this.CustomMinesRangeLabel.Name = "CustomMinesRangeLabel";
            this.CustomMinesRangeLabel.Size = new System.Drawing.Size(49, 21);
            this.CustomMinesRangeLabel.TabIndex = 3;
            this.CustomMinesRangeLabel.Text = "[9-xx]";
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 1;
            this.trackBar1.Location = new System.Drawing.Point(88, 24);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(159, 45);
            this.trackBar1.TabIndex = 4;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // GameSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 45F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.CustomDifficultyGroup);
            this.Controls.Add(this.CustomDifficultyRadio);
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
            this.CustomDifficultyGroup.ResumeLayout(false);
            this.CustomDifficultyGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
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
        private System.Windows.Forms.RadioButton CustomDifficultyRadio;
        private System.Windows.Forms.Panel CustomDifficultyGroup;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label CustomMinesRangeLabel;
        private System.Windows.Forms.Label CustomHeightRangeLabel;
        private System.Windows.Forms.Label CustomWidthRangeLabel;
        private System.Windows.Forms.Label CustomMinesLabel;
        private System.Windows.Forms.Label CustomHeightLabel;
        private System.Windows.Forms.Label CustomWidthLabel;
    }
}