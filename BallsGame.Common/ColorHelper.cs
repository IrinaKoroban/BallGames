namespace BallsGame.Common
{
    public class ColorHelper
    {
        public static Color GetRandomColor()
        {
            var ballsColors = GetCollors();
            var random = new Random();
            var colorNumber = random.Next(0, ballsColors.Count);
            return ballsColors[colorNumber];
        }
        private static List<Color> GetCollors()
        {
            var ballsColors = new List<Color>
            {
                Color.LightBlue,
                Color.LightYellow,
                Color.IndianRed,
                Color.LightCoral,
                Color.LightCyan,
                Color.White,
                Color.Pink,
                Color.LightSalmon,
                Color.LightSlateGray,
                Color.Lime,
                Color.Blue,
                Color.Orchid,
                Color.BlueViolet,
                Color.Red
            };

            return ballsColors;
        }
    }
}