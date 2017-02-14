using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace SimpleTasksNet.Business.Tests
{
    [TestFixture]
    class DelayedTasksTests
    {
        [Test]
        public void test_find_delayed_tasks_when_any_exists()
        {
            List<CustomTask> tasks = new List<CustomTask>();
            tasks.Add(new DelayedTask());

            var delayedTasks = act(tasks); 

            Assert.That(delayedTasks.Count() == 1);
        }

        [Test]
        public void test_find_delayed_tasks_no_delayed_in_tasks_collection()
        {
            List<CustomTask> tasks = new List<CustomTask>();
            tasks.Add(new CustomTask());
            tasks.Add(new CustomTask());

            var delayedTasks = act(tasks);

            Assert.That(!delayedTasks.Any());
        }

        [Test]
        public void test_find_delayed_tasks_none_found_when_tasks_collection_is_empty()
        {
            List<CustomTask> tasks = new List<CustomTask>();

            var delayedTasks = act(tasks); 

            Assert.That(!delayedTasks.Any());
        }

        [Test]
        public void test_find_delayed_tasks_none_found_when_tasks_collection_is_null()
        {
            var delayedTasks = act(null);

            Assert.That(!delayedTasks.Any());
        }

        private IEnumerable<DelayedTask> act(List<CustomTask> tasks)
        {
            TaskManager taskManager = new TaskManager();

            return taskManager.FindDelayedTasks(tasks);
        }
    }
}
