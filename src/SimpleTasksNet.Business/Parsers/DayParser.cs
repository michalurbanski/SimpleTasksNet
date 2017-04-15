using SimpleTasksNet.Common.Helpers;
using System;
using System.Linq;

namespace SimpleTasksNet.Business
{
    public class DayParser
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

        public bool IsDay(string line)
        {
            if (string.IsNullOrEmpty(line))
            {
                return false;
            }

            var splitted = line.Trim().Split(null);
            if (splitted.Length != 2)
            {
                return false;
            }

            if (!_allowedDays.Contains(splitted[0]))
            {
                return false;
            }

            DateTime? dateFormat = DayHelper.CheckIfCorrectDateFormat(splitted[1]);
            if(dateFormat == null)
            {
                return false; 
            }

            return true; 
        }
    }
}