using System;
using System.Collections.Generic;
using System.Text;

namespace NewBeeProject.Models
{
   public class Schedule
    {
        public string StudentID { get; set; }
        public string CourseID { get; set; }

        public Schedule(string StudentID, string CourseID)
        {
            this.StudentID = StudentID;
            this.CourseID = CourseID;
        }
    }
}
