using System;
using System.Collections.Generic;

namespace SimpleTasksNet.Business.Tests
{
    internal class TaskManager
    {
        internal List<DelayedTask> FindDelayedTasks(List<CustomTask> tasks)
        {
            if(tasks == null || tasks.Count == 0)
            {
                return new List<DelayedTask>(); 
            }

            return new List<DelayedTask>
            {
                new DelayedTask()
            };
        }
    }
}