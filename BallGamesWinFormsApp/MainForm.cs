using BallsGame.Common;


namespace BallGamesWinFormsApp
{
    public partial class MainForm : Form
    {
        private List<MoveBall> moveBalls = new List<MoveBall>();
        private int numberBalls = 0;

        public MainForm()
        {
            InitializeComponent();
            MessageBox.Show("Создавай шарики кнопкой." +
                "\nЛови шары!"+
                "\nШарик считается пойманным, когда он целиком находится в форме.");
        }

        private void createRandomBallsButton_Click(object sender, EventArgs e)
        {
            ClearBalls();

            for (int i = 0; i < 10; i++)
            {
                var moveBall = new MoveBall(this);
                moveBalls.Add(moveBall);
                moveBall.Start();
            }
        }

        private void stopBallsButton_Click(object sender, EventArgs e)
        {
            foreach (var ball in moveBalls)
            {
                ball.Stop();
            }

            CountBalls();
            numberBallsLabel.Text = numberBalls.ToString();

            numberBalls = 0;
        }

        private void CountBalls()
        {
            foreach (var ball in moveBalls)
            {
                if (ball.OnForm())
                {
                    numberBalls++;
                }
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
    }
}