using BallsGame.Common;

namespace FireworkWinFormsApp
{
    public class NightSky
    {
        private static int starsNumber = 20;
        private static int moonCenterX = 50;
        private static int moonCenterY = 50;

        public static List<Ball> GetSky(Form form)
        {
            var nightSky = new List<Ball>();

            for (int i = 0; i < starsNumber; i++)
            {
                var star = new Star(form);
                nightSky.Add(star);
            }
            var moon = new Moon(form, moonCenterX, moonCenterY);
            nightSky.Add(moon);

            return nightSky;
        }
    }
}
