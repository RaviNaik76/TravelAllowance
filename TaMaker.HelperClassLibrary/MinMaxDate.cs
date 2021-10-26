using System;
using System.Globalization;

namespace TaMaker.HelperClassLibrary
{
    public static class MinMaxDate
    {
        public static DateTime GetMinMaxDate(string mYear, out DateTime maxdate)
        {
            string[] myear = mYear.Split();
            int m = GetMonthNumber(myear[0]);
            string sdate = "01-" + m + "-" + myear[1];
            DateTime date = DateTime.Parse(sdate);

            DateTime mindate = new DateTime(date.Year, date.Month, 1);
            maxdate = new DateTime(date.Year, date.Month, DateTime.DaysInMonth(date.Year, date.Month));

            return mindate;
        }


        public static string getMonthName(int month)
        {
            return CultureInfo.CurrentCulture.
                DateTimeFormat.GetMonthName
                (month);
        }

        public static int GetMonthNumber(string monthname)
        {
            int monthNumber = DateTime.ParseExact(monthname, "MMMM", CultureInfo.CurrentCulture).Month;
            return monthNumber;
        }
    }
}
