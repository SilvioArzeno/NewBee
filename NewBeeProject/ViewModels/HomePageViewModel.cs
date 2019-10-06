using NewBeeProject.Models;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewBeeProject.ViewModels
{
    public class HomePageViewModel : IInitialize
    {
        public Student LoggedStudent { get; set; }

        public List<Course> CourseList { get; set; }

        public Course SelectedItem { get; set; }
        public HomePageViewModel() 
        {
           
        }

        public void Initialize(INavigationParameters parameters)
        {
                LoggedStudent = parameters["Student"] as Student;
                CourseList = LoggedStudent.StudentCoursesList;
        }
    }
}
