using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaMaker.HelperClassLibrary
{
    public static class Validate
    {
        public static bool IsNumeric(string text)
        {
            return double.TryParse(text, out _);
        }

    }
}
