using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaskManager.API.Controllers;

namespace TaskManagerTest.Tests
{
    [TestClass]
    public class TaskManagerControllerUnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            TaskManagerController testing = new TaskManagerController();
            testing.AddTask(new TaskManager.Entities.TASK()
            { TaskName = "UnitTesting", task_priority = 1 }
                );
        }
    }
}
