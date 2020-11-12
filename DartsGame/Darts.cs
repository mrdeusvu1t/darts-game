using System;

namespace DartsGame
{
    public static class Darts
    {
        public static int GetScore(double x, double y)
        {
            var r = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));

            if (r <= 1)
            {
                return 10;
            }
            else if (r <= 5)
            {
                return 5;
            }
            else if (r <= 10)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
