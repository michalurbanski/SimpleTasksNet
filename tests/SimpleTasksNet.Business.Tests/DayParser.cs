using System;
using System.Globalization;
using System.Linq;

namespace SimpleTasksNet.Business.Tests
{
    internal class DayParser
    {
        private readonly string[] _allowedDays = new string[]
        {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday", 
            "Friday", 
            "Saturday", 
            "Sunday"
        };

        internal bool IsDay(string line)
        {
            if (string.IsNullOrEmpty(line))
            {
                return false;
            }

            var splitted = line.Split(null);
            if (splitted.Length != 2)
            {
                return false;
            }

            if (!_allowedDays.Contains(splitted[0]))
            {
                return false;
            }

            DateTime date;
            if (!DateTime.TryParseExact(splitted[1], "yyyy-MM-dd", CultureInfo.InvariantCulture, 
                DateTimeStyles.None, out date))
            {
                return false; 
            }

            return true; 
        }
    }
}