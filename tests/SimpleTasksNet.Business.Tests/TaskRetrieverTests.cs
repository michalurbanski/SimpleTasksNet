using NUnit.Framework;
using SimpleTasksNet.Domain;
using System.Collections.Generic;
using System.Linq;

namespace SimpleTasksNet.Business.Tests
{
    [TestFixture]
    class TaskRetrieverTests
    {
        [Test]
        public void test_week_without_days_has_no_tasks()
        {
            Week week = new Week("Week 1");

            var tasks = act(week); 
            
            Assert.That(!tasks.Any());
        }

        [Test]
        public void test_week_with_days_with_no_tasks()
        {
            Week week = new Week("Week 1");
            Day day = new Day("Monday 2017-04-03");
            week.AddDay(day);

            var tasks = act(week);

            Assert.That(!tasks.Any());
        }

        [Test]
        public void test_retrieve_tasks_from_week_single_day()
        {
            Week week = new Week("Week 1");
            Day day = new Day("Monday 2017-04-03");
            day.AddTask(new CustomTask("- First task"));
            day.AddTask(new CustomTask("- Second task"));

            week.AddDay(day);

            var tasks = act(week);

            Assert.That(tasks.Count() == 2);
        }

        [Test]
        public void test_retrieve_tasks_from_week_multiple_days()
        {
            Week week = new Week("Week 1");
            Day monday = new Day("Monday 2017-04-03");
            monday.AddTask(new CustomTask("- First task"));
            monday.AddTask(new CustomTask("- Second task"));

            Day tuesday = new Day("Tuesday 2017-04-04");
            tuesday.AddTask(new CustomTask("- Third task"));
            tuesday.AddTask(new CustomTask("- Fourth task")); 

            week.AddDay(monday);
            week.AddDay(tuesday); 

            var tasks = act(week);

            Assert.That(tasks.Count() == 4);
        }

        private IEnumerable<CustomTask> act(Week week)
        {
            TaskRetriever taskRetriever = new TaskRetriever();

            return taskRetriever.GetTasks(week);
        }
    }
}
