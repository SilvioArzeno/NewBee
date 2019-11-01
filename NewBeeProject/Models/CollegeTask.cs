using System;
using System.Collections.Generic;
using System.Text;

namespace NewBeeProject.Models
{
    public class CollegeTask
    {
        public int TaskID { get; set; }
        public string StudentID { get; set; }
        public string TaskName { get; set; }
        public string TaskCourse { get; set; }
        public DateTime TaskDueDate { get; set; }
        public string TaskDescription { get; set; }
        public bool TaskDone { get; set; }
    }
}
