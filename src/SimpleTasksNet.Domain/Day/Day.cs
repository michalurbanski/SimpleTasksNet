using System.Collections.Generic;

namespace SimpleTasksNet.Domain
{
    public class Day
    {
        private readonly List<CustomTask> _tasks;

        public string Title { get; private set; }
        public int TasksCount { get { return _tasks.Count; } }

        public IEnumerable<CustomTask> Tasks
        {
            get { return _tasks; }
        }

        public Day(string title)
        {
            Title = title;
            _tasks = new List<CustomTask>(); 
        }

        public void AddTask(CustomTask customTask)
        {
            _tasks.Add(customTask); 
        }
    }
}