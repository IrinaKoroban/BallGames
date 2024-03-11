namespace GameCatchBallsWinFormsApp
{
    partial class GameForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GetBallsButton = new System.Windows.Forms.Button();
            this.CatchBallsLabel = new System.Windows.Forms.Label();
            this.numberBallsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GetBallsButton
            // 
            this.GetBallsButton.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GetBallsButton.Location = new System.Drawing.Point(645, 12);
            this.GetBallsButton.Name = "GetBallsButton";
            this.GetBallsButton.Size = new System.Drawing.Size(124, 68);
            this.GetBallsButton.TabIndex = 0;
            this.GetBallsButton.Text = "Создать";
            this.GetBallsButton.UseVisualStyleBackColor = true;
            this.GetBallsButton.Click += new System.EventHandler(this.GetBallsButton_Click);
            // 
            // CatchBallsLabel
            // 
            this.CatchBallsLabel.AutoSize = true;
            this.CatchBallsLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CatchBallsLabel.Location = new System.Drawing.Point(450, 12);
            this.CatchBallsLabel.Name = "CatchBallsLabel";
            this.CatchBallsLabel.Size = new System.Drawing.Size(168, 25);
            this.CatchBallsLabel.TabIndex = 1;
            this.CatchBallsLabel.Text = "Поймано шариков";
            // 
            // numberBallsLabel
            // 
            this.numberBallsLabel.AutoSize = true;
            this.numberBallsLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numberBallsLabel.Location = new System.Drawing.Point(523, 52);
            this.numberBallsLabel.Name = "numberBallsLabel";
            this.numberBallsLabel.Size = new System.Drawing.Size(23, 28);
            this.numberBallsLabel.TabIndex = 3;
            this.numberBallsLabel.Text = "0";
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(781, 505);
            this.Controls.Add(this.numberBallsLabel);
            this.Controls.Add(this.CatchBallsLabel);
            this.Controls.Add(this.GetBallsButton);
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поймай шарик";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GameForm_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button GetBallsButton;
        private Label CatchBallsLabel;
        private Label numberBallsLabel;
    }
}