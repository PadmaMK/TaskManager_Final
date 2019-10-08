using System;
using System.Collections.Generic;
using System.Web.Http;
using TaskManager.API.Models;
using TaskManager.BusinessLayer;
using TaskManager.Entities;

namespace TaskManager.API.Controllers
{
    public class TaskManagerController : ApiController
    {
        [HttpGet]
        [ActionName("ReadAllTasks")]
        public IEnumerable<task_view> ReadAllTasks()
        {
            TaskManagerBusiness TBL = new TaskManagerBusiness();
            List<task_view> lsttask = new List<task_view>();
            foreach (var task in TBL.ReadAllTask())
            {
                lsttask.Add(new task_view()
                {
                    TASK_ID = task.TASK_ID,
                    TaskName = task.TaskName,
                    parent_id = task.parent_id,
                    parentName = task.parentName,
                    Startdate = task.Startdate,
                    Enddate = task.Enddate,
                    task_priority = task.task_priority
                });
            }
            return lsttask;
        }
    
    [HttpGet]
    [ActionName("ReadTask")]
        public task_view ReadTask(int taskid)
        {
            TaskManagerBusiness TBL = new TaskManagerBusiness();
            task_view task = TBL.ReadTask(taskid);
            if (task != null)
                return new task_view()
                {
                    TASK_ID = task.TASK_ID,
                    TaskName = task.TaskName,
                    parent_id = task.parent_id,
                    parentName=task.parentName,
                    Startdate = task.Startdate,
                    Enddate = task.Enddate,
                    task_priority = task.task_priority
                };

            return null;
        }

    [HttpGet]
    [ActionName("GetAllParentTasks")]
    public IEnumerable<ParentTask> GetAllParentTasks()
        {
            TaskManagerBusiness TBL = new TaskManagerBusiness();
            List<ParentTask> lstTask = new List<ParentTask>();
            foreach (var task in TBL.ReadAllParentTask())
            {
                lstTask.Add(new ParentTask()
                {
                    Task_id = task.Task_id,
                    TaskName = task.TaskName
                });
            }
            return lstTask;
        }

    [HttpPost]
    [ActionName("AddTask")]
    public void AddTask([FromBody] TASK task)
        {
            TaskManagerBusiness TBL = new TaskManagerBusiness();
            TBL.AddTask(new TASK()
            {
                Task_id = task.Task_id,
                TaskName = task.TaskName,
                parent_id = task.parent_id,
                Startdate = Convert.ToDateTime(task.Startdate),
                Enddate = Convert.ToDateTime(task.Enddate),
                task_priority = task.task_priority
            });
        }
        [HttpPost]
        [ActionName("UpdateTask")]
        public void updateTask([FromBody]TASK task)
        {
            TaskManagerBusiness TBL = new TaskManagerBusiness();
            TBL.UpdateTask(new TASK()
            {
                Task_id = task.Task_id,
                TaskName = task.TaskName,
                parent_id = task.parent_id,
                Startdate = Convert.ToDateTime(task.Startdate),
                Enddate = Convert.ToDateTime(task.Enddate),
                task_priority = task.task_priority

            });

        }

        [HttpPost]
        [ActionName("EndTask")]
        public void EndTask(int id)
        {
            TaskManagerBusiness TBL = new TaskManagerBusiness();
            TBL.EndTask(id);
        }

    }
}