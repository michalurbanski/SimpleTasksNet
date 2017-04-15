using SimpleTasksNet.Common.Helpers;
using System;
using System.Collections.Generic;

namespace SimpleTasksNet.Domain
{
    public class Day
    {
        public string Title { get; private set; }
        public DateTime Date { get; private set; }

        public List<CustomTask> Tasks { get; private set;}
        public int TasksCount => Tasks.Count;

        public Day(string title)
        {
            Title = title;
            Date = DayHelper.ExtractDate(Title); 
            Tasks = new List<CustomTask>(); 
        }

        public void AddTask(CustomTask customTask)
        {
            Tasks.Add(customTask); 
        }
    }
}