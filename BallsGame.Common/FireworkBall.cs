

namespace BallsGame.Common
{
    public class FireworkBall : MoveBall
    {
        private float g = 0.2f;
        public FireworkBall(Form form, float centerX, float centerY) : base(form)
        {
            radius = 10;
            color = ColorHelper.GetRandomColor();

            this.centerX = centerX;
            this.centerY = centerY;

            vy = -Math.Abs(vy);
        }

        protected override void Go()
        {
            base.Go();
            vy += g;
        }
    }
}
