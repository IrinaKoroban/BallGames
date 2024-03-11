

namespace BallsGame.Common
{
    public class StartFireworkBall : FireworkBall
	{
        public event EventHandler<TopReachedEventArgs> TopReached;
        private int offsetFromEdge = 20;

        public StartFireworkBall(Form form) : base(form, form.ClientSize.Width / 2, form.ClientSize.Height)
        {
            radius = 5;
            color = ColorHelper.GetRandomColor();

            vy = (float)random.NextDouble()*-6-7;
            vx = 0;
            centerX = (float)random.Next(offsetFromEdge, form.ClientSize.Width - offsetFromEdge);

		}

        protected override void Go()
        {
            base.Go();

            if (vy > 0)
            { 
                Stop();
                Clear();
                TopReached?.Invoke(this, new TopReachedEventArgs(centerX, centerY));
            }
        }
    }
}
