using BallsGame.Common;
using Timer = System.Windows.Forms.Timer;

namespace FireworkWinFormsApp
{
    public partial class FireworkForm : Form
    {
        private List<Ball> nightSky = new();

        private int ballsMinimumNumber = 10;
        private int ballsMaximumNumber = 30;

        private Timer nightSkyTimer = new();
        private Random random = new();


        public FireworkForm()
        {
            InitializeComponent();

            nightSky = NightSky.GetSky(this);

            nightSkyTimer.Interval = 10;
            nightSkyTimer.Tick += ShowNightSky;
            nightSkyTimer.Start();
        }

        private void ShowNightSky(object? sender, EventArgs e)
        {
            foreach (var ball in nightSky)
            {
                ball.Show();
            }
        }

        private async void FireworkForm_MouseDown(object sender, MouseEventArgs e)
        {
            var startFirework = new StartFireworkBall(this);
			startFirework.TopReached += StartFirework_TopReached; 
            startFirework.Start();

        }

		private void StartFirework_TopReached(object? sender, BallsGame.Common.TopReachedEventArgs e)
		{
			var ballsCount = random.Next(ballsMinimumNumber, ballsMaximumNumber);
			for (int i = 0; i < ballsCount; i++)
			{
				var fireworkBall = new FireworkBall(this, e.X, e.Y);
				fireworkBall.Start();
			}
		}

		private void FireworkForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Нажимай на форму!" +
                "\nСалют!");
        }
    }
}