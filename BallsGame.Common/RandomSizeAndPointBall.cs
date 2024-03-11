

namespace BallsGame.Common
{
    public class RandomSizeMoveBall : MoveBall
    {
        public RandomSizeMoveBall(Form form) : base(form)
        {
            color = Color.ForestGreen;
            radius = random.Next(3, 30);
        }
    }
}
