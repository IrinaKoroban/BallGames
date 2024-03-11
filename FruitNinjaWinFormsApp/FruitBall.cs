using BallsGame.Common;

namespace FruitNinjaWinFormsApp
{
    public class FruitBall : FireworkBall
    {
        private float g = 0.2f;
        private int offsetFromEdge = 20;

        public FruitBall(Form form) : base(form, form.ClientSize.Width / 2, form.ClientSize.Height)
        {
            centerX = (float)random.Next(offsetFromEdge, form.ClientSize.Width - offsetFromEdge);
            radius = random.Next(10, 20);
            vy = -Math.Abs(random.Next(7, 20));
            vx = random.Next(-5, 5);
            timer.Interval = 15;
        }

        protected override void Go()
        {
            base.Go();
            vy += g;

            OutsideOfForm();
        }
    }
}
