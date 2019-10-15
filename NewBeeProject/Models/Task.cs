using System;
using System.Collections.Generic;
using System.Text;

namespace NewBeeProject.Models
{
    public class Task
    {
        public string TaskName { get; set; }
        public string TaskCourse { get; set; }
        public DateTime TaskDueDate { get; set; }
        public string TaskDescription { get; set; }
    }
}
