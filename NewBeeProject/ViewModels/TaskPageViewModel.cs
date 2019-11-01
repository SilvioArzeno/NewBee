using MonkeyCache.FileStore;
using NewBeeProject.Models;
using NewBeeProject.Services;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace NewBeeProject.ViewModels
{
    class TaskPageViewModel :BaseViewModel
    {

        public ObservableCollection<CollegeTask> TaskList { get; set; }
       public CollegeTask SelectedTask { get; set; }

        public Student LoggedStudent { get; set; }


        public TaskPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            LoggedStudent = Barrel.Current.Get<Student>("LoggedStudent");
            TaskList = new ObservableCollection<CollegeTask>(LoggedStudent.StudentTaskList);
        }
    }
}
