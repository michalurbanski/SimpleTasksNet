using System.Collections.Generic;

namespace SimpleTasksNet.Domain
{
    public class Day
    {
        private string _title;
        private List<CustomTask> _tasks = new List<CustomTask>();

        public int TasksCount { get { return _tasks.Count; } }

        public IEnumerable<CustomTask> Tasks
        {
            get { return _tasks; }
        }

        public Day(string title)
        {
            _title = title;
        }

        public void AddTask(CustomTask customTask)
        {
            _tasks.Add(customTask); 
        }
    }
}