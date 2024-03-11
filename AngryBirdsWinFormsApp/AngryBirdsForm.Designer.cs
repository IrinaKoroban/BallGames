namespace AngryBirdsWinFormsApp
{
    partial class AngryBirdsForm
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
            this.restartButton = new System.Windows.Forms.Button();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.birdsLabel = new System.Windows.Forms.Label();
            this.pigsLabel = new System.Windows.Forms.Label();
            this.pigsNumberLabel = new System.Windows.Forms.Label();
            this.birdsNumberLabel = new System.Windows.Forms.Label();
            this.userScoreLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // restartButton
            // 
            this.restartButton.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.restartButton.Location = new System.Drawing.Point(853, 12);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(118, 38);
            this.restartButton.TabIndex = 0;
            this.restartButton.Text = "Заново";
            this.restartButton.UseVisualStyleBackColor = true;
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.scoreLabel.Location = new System.Drawing.Point(23, 12);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(74, 25);
            this.scoreLabel.TabIndex = 1;
            this.scoreLabel.Text = "Очки:";
            // 
            // birdsLabel
            // 
            this.birdsLabel.AutoSize = true;
            this.birdsLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.birdsLabel.Location = new System.Drawing.Point(426, 12);
            this.birdsLabel.Name = "birdsLabel";
            this.birdsLabel.Size = new System.Drawing.Size(88, 25);
            this.birdsLabel.TabIndex = 2;
            this.birdsLabel.Text = "Птицы:";
            // 
            // pigsLabel
            // 
            this.pigsLabel.AutoSize = true;
            this.pigsLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pigsLabel.Location = new System.Drawing.Point(648, 12);
            this.pigsLabel.Name = "pigsLabel";
            this.pigsLabel.Size = new System.Drawing.Size(98, 25);
            this.pigsLabel.TabIndex = 3;
            this.pigsLabel.Text = "Свинки:";
            // 
            // pigsNumberLabel
            // 
            this.pigsNumberLabel.AutoSize = true;
            this.pigsNumberLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pigsNumberLabel.Location = new System.Drawing.Point(752, 12);
            this.pigsNumberLabel.Name = "pigsNumberLabel";
            this.pigsNumberLabel.Size = new System.Drawing.Size(25, 25);
            this.pigsNumberLabel.TabIndex = 5;
            this.pigsNumberLabel.Text = "0";
            // 
            // birdsNumberLabel
            // 
            this.birdsNumberLabel.AutoSize = true;
            this.birdsNumberLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.birdsNumberLabel.Location = new System.Drawing.Point(520, 12);
            this.birdsNumberLabel.Name = "birdsNumberLabel";
            this.birdsNumberLabel.Size = new System.Drawing.Size(25, 25);
            this.birdsNumberLabel.TabIndex = 4;
            this.birdsNumberLabel.Text = "0";
            // 
            // userScoreLabel
            // 
            this.userScoreLabel.AutoSize = true;
            this.userScoreLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userScoreLabel.Location = new System.Drawing.Point(103, 12);
            this.userScoreLabel.Name = "userScoreLabel";
            this.userScoreLabel.Size = new System.Drawing.Size(25, 25);
            this.userScoreLabel.TabIndex = 6;
            this.userScoreLabel.Text = "0";
            // 
            // AngryBirdsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(983, 491);
            this.Controls.Add(this.userScoreLabel);
            this.Controls.Add(this.pigsNumberLabel);
            this.Controls.Add(this.birdsNumberLabel);
            this.Controls.Add(this.pigsLabel);
            this.Controls.Add(this.birdsLabel);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.restartButton);
            this.Name = "AngryBirdsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Angry Birds";
            this.Load += new System.EventHandler(this.AngryBirdsForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.AngryBirdsForm_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AngryBirdsForm_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AngryBirdsForm_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button restartButton;
        private Label scoreLabel;
        private Label birdsLabel;
        private Label pigsLabel;
        private Label pigsNumberLabel;
        private Label birdsNumberLabel;
        private Label userScoreLabel;
    }
}