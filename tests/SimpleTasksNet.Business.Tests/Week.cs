using SimpleTasksNet.Common.Helpers;
using System.Collections.Generic;

namespace SimpleTasksNet.Business.Tests
{
    public class Week
    {
        private string _title;
        private List<Day> _days;

        public Week(string title)
        {
            _title = title;
            _days = new List<Day>(7);
        }

        public int Days => _days.Count; 

        public void AddDay(Day day)
        {
            day.ThrowIfNull(nameof(day));

            _days.Add(day); 
        }
    }
}