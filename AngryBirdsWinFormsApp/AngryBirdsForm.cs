
using Timer = System.Windows.Forms.Timer;

namespace AngryBirdsWinFormsApp
{
    public partial class AngryBirdsForm : Form
    {
        private Bird bird;
        private Pig pig;
        private bool isBirdLaunched = false;
        private bool endGame = false;
        private int startPosition;

        private Timer timer = new Timer();

        public AngryBirdsForm()
        {
            InitializeComponent();
            MessageBox.Show("Двигай шарик движением мыши." +
                "\nЗапускай шарик левой кнопкой мыши." +
                "\nВозвращай на исходную похицию правой кнопкой." +
                "\nУ тебя 5 попыток, чтобы попасть в 4 свинки.");

            SetLabels();

            timer.Interval = 30;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void SetLabels()
        {
            birdsNumberLabel.Text = "5";
            pigsNumberLabel.Text = "4";
            userScoreLabel.Text = "0";

            birdsNumberLabel.ForeColor = Color.DarkRed;
            pigsNumberLabel.ForeColor = Color.DarkGreen;
            userScoreLabel.ForeColor = Color.DarkBlue;
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            Graphics circlesAtStartPosition = CreateGraphics();
            circlesAtStartPosition.DrawEllipse(new Pen(Color.DarkGray, 2), 0, ClientSize.Height - startPosition * 2, startPosition * 2, startPosition * 2);
            circlesAtStartPosition.DrawEllipse(new Pen(Color.Black, 2), startPosition, (ClientSize.Height - startPosition), 3, 3);
            circlesAtStartPosition.Dispose();

            CheckEndGame();
        }

        private void AngryBirdsForm_Load(object sender, EventArgs e)
        {
            SetNewBalls();
            startPosition = bird.GetStartPosition();
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            endGame = false;
            SetLabels();
            SetNewBalls();
        }

        private void SetNewBalls()
        {
            if (!endGame)
            {
                pig?.Clear();
                bird?.Stop();
                bird?.Clear();

                pig = new Pig(this);
                bird = new Bird(this);
                bird.GetTarget(pig);
                bird.StatusChanged += Bird_Status;

                pig.Show();
                bird.Show();
            }
        }

        private void Bird_Status(object? sender, StatusChangedEventArgs e)
        {
            isBirdLaunched = false;
            if (!endGame)
            {
                if (e.Status == Status.Stoped || e.Status == Status.OutsideForm)
                {
                    birdsNumberLabel.Text = (int.Parse(birdsNumberLabel.Text) - 1).ToString();
                }

                if (e.Status == Status.HitTarget)
                {
                    userScoreLabel.Text = (int.Parse(userScoreLabel.Text) + 1).ToString();
                    pigsNumberLabel.Text = (int.Parse(pigsNumberLabel.Text) - 1).ToString();
                    birdsNumberLabel.Text = (int.Parse(birdsNumberLabel.Text) - 1).ToString();
                    SetNewBalls();
                }
            }
        }

        private void AngryBirdsForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (bird.Contains(e.X, e.Y) && !isBirdLaunched && IsInStartArea())
            {
                bird.Clear();
                bird.SetPosition(e.X, e.Y);
                bird.Show();
            }

            else if (!IsInStartArea() && !isBirdLaunched)
            {
                bird.GoToStartPosition();
            }
        }

        private bool IsInStartArea()
        {
            return (startPosition - bird.GetCenterX()) * (startPosition - bird.GetCenterX()) + (ClientSize.Height - startPosition - bird.GetCenterY()) *
                (ClientSize.Height - startPosition - bird.GetCenterY()) < startPosition * startPosition;
        }


        private void AngryBirdsForm_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (!isBirdLaunched && !endGame)
                {
                    bird.SetTrajectory();
                    bird.Start();
                    isBirdLaunched = true;
                }
            }
            if (e.Button == MouseButtons.Right)
            {
                bird.GoToStartPosition();
            }
        }

        private void AngryBirdsForm_Paint(object sender, PaintEventArgs e)
        {
            pig.Show();
            bird.Show();
        }

        private void CheckEndGame()
        {
            if (int.Parse(pigsNumberLabel.Text) == 0 && endGame == false)
            {
                endGame = true;
                MessageBox.Show("Поздравляем! Вы выиграли!");
            }
            else if (int.Parse(birdsNumberLabel.Text) == 0 && endGame == false)
            {
                endGame = true;
                MessageBox.Show("К сожалению, вы проиграли!");
            }
        }
    }
}