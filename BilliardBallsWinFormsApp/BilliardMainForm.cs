using BallsGame.Common;

namespace BilliardBallsWinFormsApp
{
    public partial class BilliardMainForm : Form
    {
        private List<Ball> Balls = new List<Ball>();

        public BilliardMainForm()
        {
            InitializeComponent();
            MessageBox.Show("Это простая визуализация отталкивания объектов от стенки формы." +
                "\nНа каждой стенке считается количество отскоков шариков о стенку.");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Start();
        }

        private void Ball_OnHited(object? sender, HitEventArgs e)
        {
            switch (e.Side)
            {
                case Side.Left:
                    leftLabel.Text = (int.Parse(leftLabel.Text) + 1).ToString();
                    break;
                case Side.Right:
                    rightLabel.Text = (int.Parse(rightLabel.Text) + 1).ToString();
                    break;
                case Side.Top:
                    topLabel.Text = (int.Parse(topLabel.Text) + 1).ToString();
                    break;
                case Side.Bottom:
                    bottomLabel.Text = (int.Parse(bottomLabel.Text) + 1).ToString();
                    break;
            }
        }

        private void RestartButton_Click(object sender, EventArgs e)
        {
            ClearBalls();
            ClearLabels();
            Start();
        }

        private void Start()
        {
            for (int i = 0; i < 10; i++)
            {
                var ball = new BilliardBall(this);
                ball.OnHited += Ball_OnHited;
                ball.Start();
                Balls.Add(ball);
            }
        }
        private void ClearBalls()
        {
            foreach (var ball in Balls)
            {
                ball.Stop();
                ball.Clear();
            }

            Balls.Clear();
        }
        private void ClearLabels()
        {
            leftLabel.Text = "0";
            rightLabel.Text = "0";
            topLabel.Text = "0";
            bottomLabel.Text = "0";
        }
    }
}