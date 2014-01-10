using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solosoft.Lib.Helpers
{
    public static class StringHelpers
    {
        //Set ieder woord in een zin om in een hoofdletter
        public static string ToTitleCase(this string str)
        {
            var curCulture = new CultureInfo("nl-NL", false).TextInfo;

            return curCulture.ToTitleCase(str);
        }
    }
}
