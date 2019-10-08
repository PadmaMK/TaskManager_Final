using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.Entities
{
    public class TaskManagerEnt
    {
        public void AddTask(TASK task)
        {
            // using (TaskManagerEntities1)
            //   return TaskManagerEntities1.TASKs.ToList<Task>();
            using (var context = new TaskManagerEntities1())
            {
               
                    context.TASKs.Add(task);
                    context.SaveChanges();
               

            }
        }

        public task_view ReadTask(int? Taskid)
        {
            // using (TaskManagerEntities1 TaskManagerEntities1 = new TaskManagerEntities1())
            //{
            //  return TaskManagerEntities1.TASKs.Where(t => t.Task_id == Taskid).FirstOrDefault();
            //}
            using (TaskManagerEntities1 context  = new TaskManagerEntities1())
            {
               return context.task_view.Where(t => t.TASK_ID == Taskid).FirstOrDefault();
            }
        }

        public List<task_view> ReadAllTask()
        {
            using (TaskManagerEntities1 context = new TaskManagerEntities1())
            {
                return context.task_view.ToList<task_view>();
            }
        }
        public void Endtask(task_view Endtask)
        {
            using (TaskManagerEntities1 context = new TaskManagerEntities1())
            {
                TASK task = context.TASKs.Where(T => T.Task_id == Endtask.TASK_ID).FirstOrDefault();
                task.Enddate = DateTime.Now;
                context.SaveChanges();
            }
        }
        public List<ParentTask> ReadAllParentTask()
        {
            using (TaskManagerEntities1 context = new TaskManagerEntities1())
            {
                return context.ParentTasks.ToList<ParentTask>();
            }
        }
        public void UpdateTask(TASK task)
        {
            using (TaskManagerEntities1 context = new TaskManagerEntities1())
            {
                TASK Updtask = context.TASKs.Where(t => task.Task_id == task.Task_id).FirstOrDefault();
                Updtask.parent_id = task.parent_id;
                Updtask.TaskName = task.TaskName;
                Updtask.task_priority = task.task_priority;
                Updtask.Startdate = task.Startdate;
                Updtask.Enddate = task.Enddate;
                context.SaveChanges();
            }
        }
    }
}
