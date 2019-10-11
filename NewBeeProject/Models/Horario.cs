using System;
using System.Collections.Generic;
using System.Text;

namespace NewBeeProject.Models
{
   public class Horario
    {
        public string StudentID { get; set; }
        public string CourseID { get; set; }

        public Horario(string StudentID, string CourseID)
        {
            this.StudentID = StudentID;
            this.CourseID = CourseID;
        }
    }
}
