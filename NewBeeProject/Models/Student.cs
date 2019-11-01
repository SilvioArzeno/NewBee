using NewBeeProject.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewBeeProject.Models
{
   public class Student
       {
        public bool Active { get; set; } = true;


        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string StudentID { get; set; }

        public string Password { get; set; }

        public List<Course> StudentCoursesList { get; set; }

        public List<CollegeTask> StudentTaskList { get; set; }
    }
    
}
