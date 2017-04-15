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

            DateTime result;
            if (!DateTime.TryParseExact(splitted[1], "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out result))
            {
                throw new ArgumentException($"Cannot parse date for day: {line}");
            }

            return result; 
        }
    }
}
