namespace WindowsFormsUI
{
    partial class GameForm
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
            this.FlagsRemainingLabel = new System.Windows.Forms.Label();
            this.GridBoundaryPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // FlagsRemainingLabel
            // 
            this.FlagsRemainingLabel.AutoSize = true;
            this.FlagsRemainingLabel.Location = new System.Drawing.Point(352, 29);
            this.FlagsRemainingLabel.Name = "FlagsRemainingLabel";
            this.FlagsRemainingLabel.Size = new System.Drawing.Size(65, 45);
            this.FlagsRemainingLabel.TabIndex = 0;
            this.FlagsRemainingLabel.Text = "xxx";
            // 
            // GridBoundaryPanel
            // 
            this.GridBoundaryPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GridBoundaryPanel.Location = new System.Drawing.Point(58, 97);
            this.GridBoundaryPanel.Name = "GridBoundaryPanel";
            this.GridBoundaryPanel.Size = new System.Drawing.Size(684, 440);
            this.GridBoundaryPanel.TabIndex = 1;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 45F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.GridBoundaryPanel);
            this.Controls.Add(this.FlagsRemainingLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "GameForm";
            this.Text = "GameForm";
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FlagsRemainingLabel;
        private System.Windows.Forms.Panel GridBoundaryPanel;
    }
}