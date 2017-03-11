using NUnit.Framework;
using System.Linq;

namespace SimpleTasksNet.Domain.Tests
{
    [TestFixture]
    class DayTests
    {
        [Test]
        public void test_empty_day_has_no_tasks()
        {
            Day day = new Day("Monday 2017-03-13");
            Assert.That(day.TasksCount == 0); 
        }

        [Test]
        public void test_task_can_be_retrieved_from_day()
        {
            string taskTitle = "- first task";
            Day day = new Day("Monday 2017-03-13");
            day.AddTask(new CustomTask(taskTitle));

            Assert.That(day.TasksCount == 1);
            var firstTask = day.Tasks.First();

            Assert.That(firstTask.Line == taskTitle); 
        }
    }
}
