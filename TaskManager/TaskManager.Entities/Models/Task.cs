using System;
using System.Collections.Generic;
using System.Text;
using TaskManager.Entities.Models.Enumerations;

namespace TaskManager.Entities.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string TaskName { get; set; }
        public string TaskDescription { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastModified { get; set; }
        public TaskStatus TaskStatus { get; set; }
    }
}
