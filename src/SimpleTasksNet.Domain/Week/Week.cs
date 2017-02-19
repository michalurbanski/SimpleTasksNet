using SimpleTasksNet.Common.Helpers;
using System.Collections.Generic;
using System.Linq;

namespace SimpleTasksNet.Domain
{
    public class Week
    {
        private List<Day> _days;

        public int DaysCount => _days.Count;
        public string Title { get; private set; }

        public Week(string title)
        {
            Title = title;
            _days = new List<Day>(7);
        }

        public void AddDay(Day day)
        {
            day.ThrowIfNull(nameof(day));

            _days.Add(day); 
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>Reference to last day in a week</returns>
        public Day GetLastDay()
        {
            return _days.LastOrDefault();
        }
    }
}