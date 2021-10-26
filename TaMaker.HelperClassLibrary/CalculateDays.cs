using System;

namespace TaMaker.HelperClassLibrary
{
    public class CalculateDays
    {
        public static double CalculateDay(DateTime dt, DateTime dt2, out string lbl)
        {
            double day;
            TimeSpan diff = dt2.Subtract(dt);
            double hours = diff.Hours;

            switch (hours)
            {
                case double n when n >= 12:
                    day = diff.Days + 1;
                    break;

                case double n when n >= 8:
                    day = diff.Days + 0.5;
                    break;

                case double n when n < 8:
                    day = diff.Days;
                    break;

                case double n when n == 0:
                    day = 0;
                    break;

                default:
                    day = double.Parse($"{diff.Days} . {diff.Hours}");
                    break;
            }

            if (diff.Days > 1)
            {
                lbl = ($"{diff.Days} Days {diff.Hours} Hours");
            }
            else
            {
                lbl = ($"{diff.Days} Day {diff.Hours} Hours");
            }
            return day;
        }

        public static double CalculatedDays(DateTime dt, DateTime dt2)
        {
            double day;
            TimeSpan diff = dt2.Subtract(dt);
            double hours = diff.Hours;

            switch (hours)
            {
                case double n when n >= 12:
                    day = diff.Days + 1;
                    break;

                case double n when n >= 8:
                    day = diff.Days + 0.5;
                    break;

                case double n when n < 8:
                    day = diff.Days;
                    break;

                case double n when n == 0:
                    day = 0;
                    break;

                default:
                    day = double.Parse($"{diff.Days} . {diff.Hours}");
                    break;
            }
            return day;
        }
    }
}
