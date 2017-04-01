using System.Collections.Generic;
using System.Linq;
using SimpleTasksNet.Domain;

namespace SimpleTasksNet.Business
{
    public class TaskRetriever
    {
        public IEnumerable<CustomTask> GetTasks(Week week)
        {
            var days = week.Days;

            return days.SelectMany(s => s.Tasks);
        }
    }
}
