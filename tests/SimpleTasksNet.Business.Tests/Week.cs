using SimpleTasksNet.Common.Helpers;
using System.Collections.Generic;

namespace SimpleTasksNet.Business.Tests
{
    public class Week
    {
        private List<Day> _days;

        public int Days => _days.Count;
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
    }
}