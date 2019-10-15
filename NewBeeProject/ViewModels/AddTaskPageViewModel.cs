using NewBeeProject.Models;
using System;
using System.Collections.Generic;

namespace NewBeeProject.ViewModels
{
    public class AddTaskPageViewModel
    {

        public Student LoggedStudent { get; set; }
        public List<CollegeTask> TaskLists { get; set; }
    }
}
