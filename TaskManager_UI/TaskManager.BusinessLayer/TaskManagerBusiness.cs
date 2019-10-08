using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Entities;

namespace TaskManager.BusinessLayer
{
    public class TaskManagerBusiness
    {
        public List<task_view> ReadAllTask()
        {
            TaskManagerEnt context = new TaskManagerEnt();
            return context.ReadAllTask();
        }
        public task_view ReadTask(int Taskid)
        {
            TaskManagerEnt context = new TaskManagerEnt();
            return context.ReadTask(Taskid);
        }
        public void AddTask(TASK task)
        {
            TaskManagerEnt context = new TaskManagerEnt();
            try
            {
                context.AddTask(task);
            }
            catch(Exception ex)
            {

            }
        }
        public List<ParentTask> ReadAllParentTask()
        {
            TaskManagerEnt context = new TaskManagerEnt();
            return context.ReadAllParentTask();
        }
        public void EndTask(int taskid)
        {
            TaskManagerEnt context = new TaskManagerEnt();
            context.Endtask(context.ReadTask(taskid));
        }
        public void UpdateTask(TASK task)
        {
            TaskManagerEnt context = new TaskManagerEnt();
            context.UpdateTask(task);
        }


    }
}
