using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TimeConversion
{
    public static class TimeConversion
    {
        /// <summary>
        /// Method return a new string representing the input time in 24 hour format.
        /// </summary>
        /// <param name="time12hoursFormatString">Time in format 12 hours format.</param>
        /// <returns>Time in format 24 hours format.</returns>
        public static string GetTimeConversion(string time12hoursFormatString)
        {
            if (ValidationDateString(time12hoursFormatString))
            {
                return DateTime.Parse(time12hoursFormatString).ToString("HH:mm:ss");
            }

            throw new FormatException(string.Format("Unable to parse '{0}'.", time12hoursFormatString));
        }

        /// <summary>
        /// Validation input string 12 hours format.
        /// </summary>
        /// <param name="time12hoursFormatString">Time in format 12 hours format.</param>
        /// <returns>True if 12 hours format, else false.</returns>
        private static bool ValidationDateString(string time12hoursFormatString)
        {
            var dateStringPattern = @"^(1[0-2]|0?[0-9]):([0-5]?[0-9]):([0-5]?[0-9]) ((AM)|(am)|(PM)|(pm))$";
            var regex = new Regex(dateStringPattern);
            return regex.IsMatch(time12hoursFormatString);
        }
    }
}
