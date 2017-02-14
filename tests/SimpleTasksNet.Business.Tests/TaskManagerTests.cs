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

            TaskManager taskManager = new TaskManager();
            var delayedTasks = taskManager.FindDelayedTasks(tasks);

            Assert.That(delayedTasks.Any());
        }
    }
}
