using BallsGame.Common;

namespace AngryBirdsWinFormsApp
{
    public class Pig : Ball 
    {
        public Pig(Form form) : base(form)
        {
            centerX = random.Next(RightSide() - 200, RightSide());
            centerY = random.Next(BottomSide() - 200, BottomSide());
            color = Color.DarkGreen;
        }
    }
}
