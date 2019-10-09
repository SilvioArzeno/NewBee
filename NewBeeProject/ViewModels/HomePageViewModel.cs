using MonkeyCache.FileStore;
using NewBeeProject.Models;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewBeeProject.ViewModels
{
    public class HomePageViewModel
    {
        public Student LoggedStudent { get; set; }

        public List<Course> CourseList { get; set; }

        public Course SelectedItem { get; set; }
        public HomePageViewModel() 
        {
            LoggedStudent = Barrel.Current.Get<Student>("LoggedStudent");
            CourseList = LoggedStudent.StudentCoursesList;
        }

    }
}
