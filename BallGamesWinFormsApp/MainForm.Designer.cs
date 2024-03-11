namespace BallGamesWinFormsApp
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.ballMoveTimer = new System.Windows.Forms.Timer(this.components);
            this.stopBallsButton = new System.Windows.Forms.Button();
            this.createRandomBallsButton = new System.Windows.Forms.Button();
            this.catchBallLabel = new System.Windows.Forms.Label();
            this.numberBallsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ballMoveTimer
            // 
            this.ballMoveTimer.Interval = 10;
            // 
            // stopBallsButton
            // 
            this.stopBallsButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.stopBallsButton.Location = new System.Drawing.Point(578, 14);
            this.stopBallsButton.Name = "stopBallsButton";
            this.stopBallsButton.Size = new System.Drawing.Size(126, 66);
            this.stopBallsButton.TabIndex = 0;
            this.stopBallsButton.Text = "Остановить";
            this.stopBallsButton.UseVisualStyleBackColor = true;
            this.stopBallsButton.Click += new System.EventHandler(this.stopBallsButton_Click);
            // 
            // createRandomBallsButton
            // 
            this.createRandomBallsButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createRandomBallsButton.Location = new System.Drawing.Point(435, 14);
            this.createRandomBallsButton.Name = "createRandomBallsButton";
            this.createRandomBallsButton.Size = new System.Drawing.Size(114, 66);
            this.createRandomBallsButton.TabIndex = 2;
            this.createRandomBallsButton.Text = "Создать";
            this.createRandomBallsButton.UseVisualStyleBackColor = true;
            this.createRandomBallsButton.Click += new System.EventHandler(this.createRandomBallsButton_Click);
            // 
            // catchBallLabel
            // 
            this.catchBallLabel.AutoSize = true;
            this.catchBallLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.catchBallLabel.Location = new System.Drawing.Point(238, 14);
            this.catchBallLabel.Name = "catchBallLabel";
            this.catchBallLabel.Size = new System.Drawing.Size(158, 23);
            this.catchBallLabel.TabIndex = 3;
            this.catchBallLabel.Text = "Поймано шариков";
            // 
            // numberBallsLabel
            // 
            this.numberBallsLabel.AutoSize = true;
            this.numberBallsLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numberBallsLabel.Location = new System.Drawing.Point(295, 52);
            this.numberBallsLabel.Name = "numberBallsLabel";
            this.numberBallsLabel.Size = new System.Drawing.Size(23, 28);
            this.numberBallsLabel.TabIndex = 4;
            this.numberBallsLabel.Text = "0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(725, 468);
            this.Controls.Add(this.numberBallsLabel);
            this.Controls.Add(this.catchBallLabel);
            this.Controls.Add(this.createRandomBallsButton);
            this.Controls.Add(this.stopBallsButton);
            this.Name = "MainForm";
            this.Text = "Мячики";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer ballMoveTimer;
        private Button stopBallsButton;
        private Button createRandomBallsButton;
        private Label catchBallLabel;
        private Label numberBallsLabel;
    }
}