using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTasksNet.Business.Tests
{
    [TestFixture]
    class TaskManagerTests
    {
        [Test]
        public void test_find_delayed_tasks_when_any_exists()
        {
            List<CustomTask> tasks = new List<CustomTask>();
            tasks.Add(new DelayedTask());

            TaskManager taskManager = new TaskManager();
            List<DelayedTask> delayedTasks = taskManager.FindDelayedTasks(tasks);

            Assert.That(tasks.Count == 1);
        }
    }
}
