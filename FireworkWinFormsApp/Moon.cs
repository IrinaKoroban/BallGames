using BallsGame.Common;

namespace FireworkWinFormsApp
{
    public class Moon : Ball
    {
        public Moon(Form form, int centerX, int centerY) : base(form)
        {
            color = Color.LightGoldenrodYellow;
            radius = 30;
            this.centerX = centerX;
            this.centerY = centerY;
        }
    }
}
