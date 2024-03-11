using BallsGame.Common;

using Timer = System.Windows.Forms.Timer;

namespace DiffusionWinFormsApp
{
    public partial class DiffusionMainForm : Form
    {
        private List<Ball> balls = new List<Ball>();

        private Color leftSideBallsColor = Color.LightYellow;
        private Color rightSideBallsColor = Color.LightBlue;

        private Timer diffusinCheckTimer = new Timer();

        private bool isMoving = true;
        private int colorBallsNumber = 10;

        public DiffusionMainForm()
        {
            InitializeComponent();

            diffusinCheckTimer.Interval = 9;
            diffusinCheckTimer.Tick += DiffusinCheckTimer_Tick;
            diffusinCheckTimer.Start();

            ShowVerticalCenterLine();
        }

        private void ShowVerticalCenterLine()
        {
            var graphics = CreateGraphics();
            graphics.DrawLine(Pens.White, ClientSize.Width / 2, 0, ClientSize.Width / 2, ClientSize.Height);
        }

        private void DiffusinCheckTimer_Tick(object? sender, EventArgs e)
        {
            ShowVerticalCenterLine();

            var leftHalfLeftBallsCount = 0;
            var rightHalfLeftBallsCount = 0;

            var leftHalfRightBallCount = 0;
            var rightHalfRightBallCount = 0;

            foreach (DiffusionBall ball in balls)
            {
                if (ball.GetColor() == leftSideBallsColor)
                {
                    if (ball.LeftOfCenter())
                        leftHalfLeftBallsCount++;
                    else if (ball.RightOfCenter())
                        rightHalfLeftBallsCount++;
                }
                if (ball.GetColor() == rightSideBallsColor)
                {
                    if (ball.LeftOfCenter())
                        leftHalfRightBallCount++;
                    else if (ball.RightOfCenter())
                        rightHalfRightBallCount++;
                }
            }

            if (leftHalfLeftBallsCount == rightHalfLeftBallsCount && leftHalfRightBallCount == rightHalfRightBallCount)
                StopBalls();
        }

        private void DiffusionMainForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("1. Кликай мышкой по форме, чтобы запускать и останавливать перемещение шариков." +
                             "\n2. Когда количество шариков разного цвета сравняется на каждой половине поля, они сами остановятся," +
                             "\n произойдет диффузия." +
                             "\n3. На стенках  формы отображается количество ударов для каждого цвета.");

            ColorTextLabels();
            AddBalls();
            MoveBalls();
        }


        private void restartButton_Click(object sender, EventArgs e)
        {
            ClearBalls();
            ClearLabels();
            AddBalls();
            MoveBalls();
        }

        private void AddBalls()
        {
            for (int i = 0; i < colorBallsNumber; i++)
            {
                var ball = new DiffusionBall(this, leftSideBallsColor, Side.Left);
                ball.OnHited += LeftSideBall_OnHited;
                balls.Add(ball);

                ball = new DiffusionBall(this, rightSideBallsColor, Side.Right);
                ball.OnHited += RightSideBall_OnHited;
                balls.Add(ball);
            }
        }
        private void ClearBalls()
        {
            foreach (var ball in balls)
            {
                ball.Stop();
                ball.Clear();
            }
            balls.Clear();
        }

        private void StopBalls()
        {
            foreach (var ball in balls)
            {
                ball.Stop();
            }
        }

        private void MoveBalls()
        {
            foreach (var ball in balls)
            {
                ball.Start();
            }
        }

        private void DiffusionMainForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (isMoving)
            {
                StopBalls();
            }
            else
            {
                MoveBalls();
            }
            isMoving = !isMoving;
        }
        private void LeftSideBall_OnHited(object? sender, HitEventArgs e)
        {
            switch (e.Side)
            {
                case Side.Left:
                    leftPressureLeftSideBallsLabel.Text = (int.Parse(leftPressureLeftSideBallsLabel.Text) + 1).ToString();
                    break;
                case Side.Right:
                    rightPressureLeftSideBallsrLabel.Text = (int.Parse(rightPressureLeftSideBallsrLabel.Text) + 1).ToString();
                    break;
                case Side.Top:
                    topPressureLeftSideBallsLabel.Text = (int.Parse(topPressureLeftSideBallsLabel.Text) + 1).ToString();
                    break;
                case Side.Bottom:
                    bottomPressureLeftSideBallsLabel.Text = (int.Parse(bottomPressureLeftSideBallsLabel.Text) + 1).ToString();
                    break;
            }
        }

        private void RightSideBall_OnHited(object? sender, HitEventArgs e)
        {
            switch (e.Side)
            {
                case Side.Left:
                    leftPressureRightSideBallsLabel.Text = (int.Parse(leftPressureRightSideBallsLabel.Text) + 1).ToString();
                    break;
                case Side.Right:
                    rightPressureRightSideBallsLabel.Text = (int.Parse(rightPressureRightSideBallsLabel.Text) + 1).ToString();
                    break;
                case Side.Top:
                    topPressureRightSideBallsLabel.Text = (int.Parse(topPressureRightSideBallsLabel.Text) + 1).ToString();
                    break;
                case Side.Bottom:
                    bottomPressureRightSideBallsLabel.Text = (int.Parse(bottomPressureRightSideBallsLabel.Text) + 1).ToString();
                    break;
            }
        }

        private void ColorTextLabels()
        {
            leftPressureLeftSideBallsLabel.ForeColor = leftSideBallsColor;
            rightPressureLeftSideBallsrLabel.ForeColor = leftSideBallsColor;
            topPressureLeftSideBallsLabel.ForeColor = leftSideBallsColor;
            bottomPressureLeftSideBallsLabel.ForeColor = leftSideBallsColor;

            leftPressureRightSideBallsLabel.ForeColor = rightSideBallsColor;
            rightPressureRightSideBallsLabel.ForeColor = rightSideBallsColor;
            topPressureRightSideBallsLabel.ForeColor = rightSideBallsColor;
            bottomPressureRightSideBallsLabel.ForeColor = rightSideBallsColor;
        }

        private void ClearLabels()
        {
            leftPressureLeftSideBallsLabel.Text = "0";
            rightPressureLeftSideBallsrLabel.Text = "0";
            topPressureLeftSideBallsLabel.Text = "0";
            bottomPressureLeftSideBallsLabel.Text = "0";
            leftPressureRightSideBallsLabel.Text = "0";
            rightPressureRightSideBallsLabel.Text = "0";
            bottomPressureRightSideBallsLabel.Text = "0";
            topPressureRightSideBallsLabel.Text = "0";
        }

        private void DiffusionMainForm_Paint(object sender, PaintEventArgs e)
        {
            foreach (var ball in balls)
            {
                ball.Show();
            }
        }
    }
}