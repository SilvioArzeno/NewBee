using MonkeyCache.FileStore;
using NewBeeProject.Models;
using System.Collections.Generic;

namespace NewBeeProject.ViewModels
{
    public class HomePageViewModel
    {
        public Student LoggedStudent { get; set; }
        public List<Course> StudentCourseList { get; set; }
        public Course SelectedItem { get; set; }
        public HomePageViewModel() 
        {
            LoggedStudent = Barrel.Current.Get<Student>("LoggedStudent");
            StudentCourseList = LoggedStudent.StudentCoursesList;
        }
    }
}
