using System.Collections.Generic;
using System.Linq;

namespace SimpleTasksNet.Business.Tests
{
    internal class LinesToWeeksConverter
    {
        private readonly WeekParser _weekParser = new WeekParser();
        private readonly DayParser _dayParser = new DayParser(); 

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

                bool isDay = _dayParser.IsDay(line); 
                if(isDay)
                {
                    weeks.Last().AddDay(new Day(line)); 
                }
            }

            return weeks; 
        }
    }
}