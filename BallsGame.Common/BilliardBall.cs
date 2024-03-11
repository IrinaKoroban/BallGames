namespace BallsGame.Common
{
    public class BilliardBall : MoveBall
    {
        public event EventHandler<HitEventArgs> OnHited;
        public BilliardBall(Form form) : base(form)
        {
            color = Color.Gray;
        }
        protected override void Go()
        {
           base.Go();

            if (centerX <= LeftSide())
            {
                centerX = LeftSide();
                vx = -vx;
                OnHited?.Invoke(this, new HitEventArgs(Side.Left));
            }
            if (centerX >= RightSide())
            {
                centerX = RightSide();
                vx = -vx;
                OnHited?.Invoke(this, new HitEventArgs(Side.Right));
            }
            if (centerY <= TopSide())
            {
                centerY = TopSide();
                vy = -vy;
                OnHited?.Invoke(this, new HitEventArgs(Side.Top));
            }
            if (centerY >= BottomSide())
            {
                centerY = BottomSide();
                vy = -vy;
                OnHited?.Invoke(this, new HitEventArgs(Side.Bottom));
            }
        }
    }
}
