using BallsGame.Common;
using Microsoft.VisualBasic.Devices;
using System.Drawing.Drawing2D;

namespace GameCatchBallsWinFormsApp
{
    public partial class GameForm : Form
    {
        private List<RandomSizeMoveBall> moveBalls = new List<RandomSizeMoveBall>();
        private int ballsNumber = 0;
        private Random random = new Random();

        public GameForm()
        {
            InitializeComponent();
            MessageBox.Show("Создавай шарики кнопкой." +
                            "\nПоймай шарики, кликай на них поскорее!");
        }

        private void GetBallsButton_Click(object sender, EventArgs e)
        {
            ClearBalls();
            var ballsCount = random.Next(5, 20);
            for (int i = 0; i < ballsCount; i++)
            {
                var moveBall = new RandomSizeMoveBall(this);
                moveBalls.Add(moveBall);
                moveBall.Start();
            }
        }

        private void ClearBalls()
        {
            foreach (var ball in moveBalls)
            {
                ball.Stop();
                ball.Clear();
            }
            moveBalls.Clear();
        }

        private void GameForm_MouseDown(object sender, MouseEventArgs e)
        {
            foreach (var ball in moveBalls)
            {
                if (ball.Contains(e.X, e.Y))
                {
                    ballsNumber++;

                    ball.Stop();
                    ball.Clear();
                    moveBalls.Remove(ball);

                    numberBallsLabel.Text = ballsNumber.ToString();
                    return;
                }
            }
        }
    }
}