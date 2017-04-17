using SimpleTasksNet.Common.Consts;
using System;
using System.Globalization;

namespace SimpleTasksNet.Common.Helpers
{
    public static class DayHelper
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="line"></param>
        /// <remarks>Day is expected to be in format: Monday 2017-04-17</remarks>
        /// <returns></returns>
        public static DateTime ExtractDate(string line)
        {
            line.ThrowIfNullOrEmpty(nameof(line));

            var splitted = line.Split();
            if(splitted.Length != 2)
            {
                throw new ArgumentException($"Incorrect line format - it should have day and date only: {line}", nameof(line)); 
            }

            DateTime? result = CheckIfCorrectDateFormat(splitted[1]); 
            if(result == null)
            {
                throw new ArgumentException($"Cannot parse date for day: {line}", nameof(line));
            }

            return result.Value; 
        }

        public static DateTime? CheckIfCorrectDateFormat(string input)
        {
            DateTime result; 
            if (!DateTime.TryParseExact(input, DateTimeFormats.DATE_TIME_FORMAT, CultureInfo.InvariantCulture, 
                DateTimeStyles.None, out result))
            {
                return null; 
            }

            return result;
        }
    }
}
