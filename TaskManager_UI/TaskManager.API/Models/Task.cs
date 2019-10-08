using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace TaskManager.API.Models
{
    public class Task
    {
        public int TaskId { get; set; }
        public Nullable<int> ParentId { get; set; }
        public string Name { get; set; }
        public string ParentTaskName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Priority { get; set; }
       
    }
}