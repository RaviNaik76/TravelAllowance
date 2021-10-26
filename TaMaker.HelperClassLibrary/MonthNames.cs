using System;
using System.Globalization;
using System.Windows.Forms;

namespace TaMaker.HelperClassLibrary
{
    public static class MonthNames
    {
        public static void GetMontNames(int year, ComboBox cmb)
        {
            if (year == DateTime.Today.Year)
            {
                for (int m = 1; m <= DateTime.Now.Month; m++)
                {
                    string name = DateTimeFormatInfo.CurrentInfo.GetMonthName(m);
                    cmb.Items.Add(name);
                }
            }
            else
            {
                for (int i = 1; i <= 12; i++)
                {
                    string name = DateTimeFormatInfo.CurrentInfo.GetMonthName(i);
                    cmb.Items.Add(name);
                }
            }
        }
    }
}
