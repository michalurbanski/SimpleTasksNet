using System.Collections.Generic;

namespace SimpleTasksNet.Domain
{
    public class Day
    {
        public List<CustomTask> Tasks { get; private set;}

        public string Title { get; private set; }
        public int TasksCount { get { return Tasks.Count; } }

        public Day(string title)
        {
            Title = title;
            Tasks = new List<CustomTask>(); 
        }

        public void AddTask(CustomTask customTask)
        {
            Tasks.Add(customTask); 
        }
    }
}