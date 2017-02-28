using SimpleTasksNet.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleTasksNet.Business
{
    public class LinesToWeeksConverter
    {
        private readonly WeekParser _weekParser = new WeekParser();
        private readonly DayParser _dayParser = new DayParser();
        private readonly TaskParser _taskParser = new TaskParser(); 

        public List<Week> ConvertToWeek(IEnumerable<string> lines)
        {
            List<Week> weeks = new List<Week>();

            if (lines == null)
            {
                return weeks; 
            }

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

                // Day has tasks
                bool isTask = _taskParser.IsTask(line); 
                if(isTask)
                {
                    Day currentDay = weeks.Last().GetLastDay(); 
                    if(currentDay == null)
                    {
                        throw new ArgumentException("Task can't be added, because no day has been found.");
                    }

                    currentDay.AddTask(new CustomTask(line));
                }

                // Other types of lines are not significant - just continue if such line occurs
            }

            return weeks; 
        }
    }
}