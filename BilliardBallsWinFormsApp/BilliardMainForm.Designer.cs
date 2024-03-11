namespace BilliardBallsWinFormsApp
{
    partial class BilliardMainForm
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
            topLabel = new Label();
            bottomLabel = new Label();
            leftLabel = new Label();
            rightLabel = new Label();
            RestartButton = new Button();
            SuspendLayout();
            // 
            // topLabel
            // 
            topLabel.AutoSize = true;
            topLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            topLabel.Location = new Point(374, 15);
            topLabel.Name = "topLabel";
            topLabel.Size = new Size(17, 20);
            topLabel.TabIndex = 0;
            topLabel.Text = "0";
            // 
            // bottomLabel
            // 
            bottomLabel.AutoSize = true;
            bottomLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            bottomLabel.Location = new Point(374, 369);
            bottomLabel.Name = "bottomLabel";
            bottomLabel.Size = new Size(17, 20);
            bottomLabel.TabIndex = 1;
            bottomLabel.Text = "0";
            // 
            // leftLabel
            // 
            leftLabel.AutoSize = true;
            leftLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            leftLabel.Location = new Point(10, 189);
            leftLabel.Name = "leftLabel";
            leftLabel.Size = new Size(17, 20);
            leftLabel.TabIndex = 2;
            leftLabel.Text = "0";
            // 
            // rightLabel
            // 
            rightLabel.AutoSize = true;
            rightLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            rightLabel.Location = new Point(766, 189);
            rightLabel.Name = "rightLabel";
            rightLabel.Size = new Size(17, 20);
            rightLabel.TabIndex = 3;
            rightLabel.Text = "0";
            // 
            // RestartButton
            // 
            RestartButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            RestartButton.Location = new Point(657, 12);
            RestartButton.Name = "RestartButton";
            RestartButton.Size = new Size(123, 46);
            RestartButton.TabIndex = 4;
            RestartButton.Text = "Заново";
            RestartButton.UseVisualStyleBackColor = true;
            RestartButton.Click += RestartButton_Click;
            // 
            // BilliardMainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(796, 394);
            Controls.Add(RestartButton);
            Controls.Add(rightLabel);
            Controls.Add(leftLabel);
            Controls.Add(bottomLabel);
            Controls.Add(topLabel);
            Margin = new Padding(3, 2, 3, 2);
            Name = "BilliardMainForm";
            Text = "Бильярд";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label topLabel;
        private Label bottomLabel;
        private Label leftLabel;
        private Label rightLabel;
        private Button RestartButton;
    }
}