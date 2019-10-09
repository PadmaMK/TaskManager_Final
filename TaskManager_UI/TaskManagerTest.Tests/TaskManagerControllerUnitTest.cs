using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaskManager.API.Controllers;
using System.Collections.Generic;
using System.Linq;

namespace TaskManagerTest.Tests
{
    [TestClass]
    public class TaskManagerControllerUnitTest
    {
        [TestMethod]
        public void TestAdd()
        {
            TaskManagerController testing = new TaskManagerController();
            testing.AddTask(new TaskManager.Entities.TASK()
            { TaskName = "UnitTesting", task_priority = 1 } );
        }
        [TestMethod]
        public void TestGetAll()
        {
            TaskManagerController testing = new TaskManagerController();
            testing.AddTask(new TaskManager.Entities.TASK()
            { TaskName = "GetAll1", task_priority = 1 , parent_id =1008}
                );
            testing.AddTask(new TaskManager.Entities.TASK()
            { TaskName = "GetAll2", task_priority = 1, parent_id = 1008 }
               );
            IEnumerable<TaskManager.Entities.task_view> tasks = testing.ReadAllTasks();
            Assert.IsNotNull(tasks);
        



        }
        [TestMethod]
        public void TestGet()
        {
            TaskManagerController testing = new TaskManagerController();
            testing.AddTask(new TaskManager.Entities.TASK()
            { TaskName = "Get1", task_priority = 1, parent_id = 1008 }
                );
            testing.AddTask(new TaskManager.Entities.TASK()
            { TaskName = "Get2", task_priority = 1, parent_id = 1008 }
               );
            IEnumerable<TaskManager.Entities.task_view> tasks = testing.ReadAllTasks();
            Assert.IsNotNull(tasks);
            int taskid = tasks.FirstOrDefault().TASK_ID;
            TaskManager.Entities.task_view task = testing.ReadTask(taskid);
            Assert.IsNotNull(task);



        }

        [TestMethod]
        public void TestUpdate()
        {
            TaskManagerController testing = new TaskManagerController();
            testing.AddTask(new TaskManager.Entities.TASK()
            { TaskName = "UnitTesting", task_priority = 1 });
        }


    }
}
