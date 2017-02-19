using System.Collections.Generic;

namespace SimpleTasksNet.Business.Tests
{
    public class Day
    {
        private string _title;
        private List<CustomTask> _tasks = new List<CustomTask>();

        public int TasksCount { get { return _tasks.Count; } }

        public Day(string title)
        {
            _title = title;
        }

        internal void AddTask(CustomTask customTask)
        {
            _tasks.Add(customTask); 
        }
    }
}