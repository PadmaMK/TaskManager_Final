using System;
using System.Collections.Generic;
using System.Linq;
using TaskManager.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaskManager.API.Controllers;
using System.Web.Http;
using System.Globalization;



namespace TaskMananger.Tests
{
    [TestClass]
    public class TaskManagerUnitTest
    {
        [TestMethod]
        public void TestAddd()
        {
            TaskManagerController taskManagerController = new TaskManagerController();
            

            taskManagerController.AddTask(new TASK() { TaskName = "Unit Testing", Startdate = DateTime.Now, task_priority = 1 });
                //Task() { Name = "Unit Testing", StartDate = DateTime.Now.ToShortDateString(), Priority = 1 });

 
    }
}
}
