using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DSRS
{
    internal class Utility
    {
        public static bool IsNumeric(string input)
        {
            // Define a regular expression pattern to match numeric digits
            string pattern = "^[0-9]+$";

            // Use Regex.IsMatch to check if the input matches the pattern
            return Regex.IsMatch(input, pattern);
        }


        public static bool DateFormat(string inputDate, out DateTime parsedDate)
        {
            return DateTime.TryParseExact(inputDate, "dd-MM-yyyy",
                                      System.Globalization.CultureInfo.InvariantCulture,
                                      System.Globalization.DateTimeStyles.None,
                                      out parsedDate);

        }
    }
}
