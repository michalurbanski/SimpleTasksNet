﻿using System.Text.RegularExpressions;

namespace SimpleTasksNet.Business.Tests
{
    internal class WeekParser
    {
        internal bool IsWeek(string line)
        {
            if (string.IsNullOrEmpty(line))
            {
                return false;
            }

            Regex regex = new Regex(@"^Week\s+\d+", RegexOptions.IgnoreCase);

            return regex.IsMatch(line); 
        }
    }
}