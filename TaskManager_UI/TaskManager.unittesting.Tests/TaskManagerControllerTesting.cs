using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaskManager.API.Controllers;

namespace TaskManager.unittesting.Tests
{
    [TestClass]
    public class TaskManagerControllerTesting
    {
        [TestMethod]
        public void TestMethod1()
        {
            TaskManagerController testing = new TaskManagerController();
            testing.AddTask(new Entities.TASK()
            { TaskName = "UnitTesting", task_priority = 1 }
                );



  public string TaskName { get; set; }
        public System.DateTime Startdate { get; set; }
        public Nullable<System.DateTime> Enddate { get; set; }
        public Nullable<int> task_priority
        {
            get; set

            {        }
    }
}
