using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaskManager.API.Controllers;

namespace WebApplication1.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            TaskManagerController taskManagerController = new TaskManagerController();

            taskManagerController.AddTask(new TaskManager.Entities.TASK());
        }
    }
}
