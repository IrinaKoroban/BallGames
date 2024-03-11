using BallsGame.Common;

namespace DiffusionWinFormsApp
{
    public class DiffusionBall : BilliardBall
    {
        public DiffusionBall(Form form, Color color, Side side) : base(form)
        {
            radius = 20;
            this.color = color;
            if (side == Side.Left)
            {
                centerX = random.Next(LeftSide(), form.ClientSize.Width / 2 - radius);
            }
            if (side == Side.Right)
            {
                centerX = random.Next(form.ClientSize.Width / 2 + radius, RightSide());
            }
        }
        public bool LeftOfCenter()
        {
            return centerX + radius < form.ClientSize.Width / 2;
        }
        public bool RightOfCenter() 
        {
            return centerX - radius > form.ClientSize.Width / 2;
        }
    }
}
 
