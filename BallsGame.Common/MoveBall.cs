

namespace BallsGame.Common
{
    public class MoveBall : RandomPointBall
    {
        public MoveBall(Form form): base(form)
        {
            vx = random.Next(-5, 6);
            vy = random.Next(-5, 6);
        }
    }
}
