using System;
using System.Collections.Generic;

namespace SimpleTasksNet.Business.Tests
{
    internal class LinesToWeeksConverter
    {
        private readonly WeekParser _weekParser = new WeekParser(); 

        internal List<Week> ConvertToWeek(IEnumerable<string> lines)
        {
            if(lines == null)
            {
                return new List<Week>(); 
            }

            List<Week> weeks = new List<Week>(); 

            foreach(var line in lines)
            {
                bool isWeek = _weekParser.IsWeek(line); 
                if(isWeek)
                {
                    weeks.Add(new Week(line));
                }
            }

            return weeks; 
        }
    }
}