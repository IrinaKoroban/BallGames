using BallsGame.Common;
using Timer = System.Windows.Forms.Timer;

namespace FruitNinjaWinFormsApp
{
    public partial class FruitNinjaForm : Form
    {
        private List<Ball> fruitNinjaBalls = new();
        private int ballsCount = 10;
        private int userScore = 0;

        private Timer showBallsTimer = new();
        private Timer slowDownModeTimer = new();
        private int slowModeCount;

        private Random random = new Random();

        public FruitNinjaForm()
        {
            MessageBox.Show("Лови шарики движением мыши! " +
                "\nИзбегай чёрных шаров-бомб, иначе игра закончится." +
                "\nЖелтые шары - замедляют игру.");
            InitializeComponent();

            showBallsTimer.Interval = random.Next(2000, 4000);
            showBallsTimer.Tick += showBallsTimer_Tick;
            showBallsTimer.Start();
        }

        private void showBallsTimer_Tick(object? sender, EventArgs e)
        {
            for (int i = 0; i < ballsCount; i++)
            {
                Ball fruitBall;
                var ballDropProbability = random.Next(1, 10);
                if (ballDropProbability == 9)
                {
                    fruitBall = new FruitBomb(this);
                }
                else if (ballDropProbability % 4 == 0)
                {
                    fruitBall = new BananaBall(this);
                }
                else
                {
                    fruitBall = new FruitBall(this);
                }

                fruitBall.Start();
                fruitNinjaBalls.Add(fruitBall);
            }
            showBallsTimer.Interval = random.Next(1000, 4000);
        }

        private void FruitNinjaForm_MouseMove(object sender, MouseEventArgs e)
        {
            foreach (var fruitBall in fruitNinjaBalls)
            {
                if (fruitBall.Contains(e.X, e.Y) && fruitBall.IsMoving())
                {
                    if (fruitBall is FruitBomb)
                    {
                        StopGame();
                        return;
                    }
                    if (fruitBall is BananaBall)
                    {
                        SlowDownGame();
                    }

                    fruitBall.Stop();
                    fruitBall.Clear();
                    userScore++;
                }
            }
            userScoreLabel.Text = $"Поймано {userScore} шариков";
        }

        private void SlowDownGame()
        {
            slowModeCount = 500;
            slowDownModeTimer.Interval = 10;
            slowDownModeTimer.Tick += SlowDownModeTimer_Tick;
            slowDownModeTimer.Start();
        }

        private void SlowDownModeTimer_Tick(object? sender, EventArgs e)
        {
            slowModeCount--;
            SlowDownBalls();
            if (slowModeCount == 0)
            {
                slowDownModeTimer.Stop();
                slowModeCount = 500;
                SpeedUpBalls();
            }
        }

        private void SlowDownBalls()
        {
            foreach (var fruitBall in fruitNinjaBalls)
            {
                fruitBall.SlowDown();
            }
        }

        private void SpeedUpBalls()
        {
            foreach (var fruitBall in fruitNinjaBalls)
            {
                fruitBall.SpeedUp();
            }
        }

        private void StopGame()
        {
            showBallsTimer.Stop();
            foreach (var fruitBall in fruitNinjaBalls)
            {
                fruitBall.Stop();
                fruitBall.Clear();
            }
            MessageBox.Show("Вы проиграли!");
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}