using BallsGame.Common;

namespace FireworkWinFormsApp
{
    public class Star : RandomPointBall
    {
        public Star(Form form) : base(form)
        {
            color = Color.White;
            radius = random.Next(1, 3);
        }
    }
}
