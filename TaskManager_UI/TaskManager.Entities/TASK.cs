//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TaskManager.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class TASK
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TASK()
        {
            this.TASK1 = new HashSet<TASK>();
        }
    
        public int Task_id { get; set; }
        public Nullable<int> parent_id { get; set; }
        public string TaskName { get; set; }
        public System.DateTime Startdate { get; set; }
        public Nullable<System.DateTime> Enddate { get; set; }
        public Nullable<int> task_priority { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TASK> TASK1 { get; set; }
        public virtual TASK TASK2 { get; set; }
    }
}
