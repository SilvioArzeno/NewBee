using NewBeeProject.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewBeeProject.ViewModels
{
    public class HomePageViewModel
    {
        public Student LoggedStudent { get; set; }

        public List<Course> CourseList { get; set; }
        public HomePageViewModel(Student loggedStudent)
        {
            LoggedStudent = loggedStudent;
            CourseList = LoggedStudent.StudentCoursesList;
        }
    }
}
