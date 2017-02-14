using System;
using System.Collections.Generic;

namespace SimpleTasksNet.Business.Tests
{
    internal class TaskManager
    {
        internal List<DelayedTask> FindDelayedTasks(List<CustomTask> tasks)
        {
            return new List<DelayedTask>
            {
                new DelayedTask()
            };
        }
    }
}