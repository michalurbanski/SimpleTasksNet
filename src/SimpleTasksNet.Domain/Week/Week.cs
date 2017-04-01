using SimpleTasksNet.Common.Helpers;
using System.Collections.Generic;
using System.Linq;

namespace SimpleTasksNet.Domain
{
    public class Week
    {
        public List<Day> Days { get; private set; }
        public int DaysCount => Days.Count;
        public string Title { get; private set; }
        
        public Week(string title)
        {
            Title = title;
            Days = new List<Day>(7);
        }

        public void AddDay(Day day)
        {
            day.ThrowIfNull(nameof(day));

            Days.Add(day);
        }

        // TODO: Think about existence of this method - is it needed for any processing, or processing method can be changed? 
        /// <summary>
        /// 
        /// </summary>
        /// <returns>Reference to last day in a week</returns>
        public Day GetLastDay()
        {
            return Days.LastOrDefault();
        }
    }
}