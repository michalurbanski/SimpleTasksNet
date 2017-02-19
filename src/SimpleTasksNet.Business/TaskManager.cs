using SimpleTasksNet.Domain;
using System.Collections.Generic;
using System.Linq;

namespace SimpleTasksNet.Business
{
    public class TaskManager
    {
        public IEnumerable<DelayedTask> FindDelayedTasks(List<CustomTask> tasks)
        {
            if(tasks == null || tasks.Count == 0)
            {
                return new List<DelayedTask>(); 
            }

            return tasks.OfType<DelayedTask>();
        }
    }
}