using MonkeyCache.FileStore;
using NewBeeProject.Models;
using NewBeeProject.Services;
using Prism.Commands;
using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;

namespace NewBeeProject.ViewModels
{
    public class AddCoursePageViewModel: BaseViewModel, INotifyPropertyChanged
    {
        public Student LoggedStudent { get; set; }
        public string CourseFilter { get; set; }
        public ObservableCollection<Course> AllCoursesList { get; set; }
        public DelegateCommand RegisterCourseCommand { get; set; }
        public DelegateCommand SearchCourseCommand { get; set; }
        public Course SelectedCourse { get; set; }

        public AddCoursePageViewModel(INavigationService navigationService, IAPIService APIservice, IPageDialogService dialogService) : base(navigationService, APIservice)
        {
            LoggedStudent = Barrel.Current.Get<Student>("LoggedStudent");
            AllCoursesList =new ObservableCollection<Course>(Barrel.Current.Get<List<Course>>("AllCourseList"));

            RegisterCourseCommand = new DelegateCommand(async () =>
            {
                var answer = await dialogService.DisplayAlertAsync("Confirm", $"Are you sure you want to add {SelectedCourse.CourseName} to your schedule?", "Yes", "No");
                if (answer)
                {

                    if (await APIservice.RegisterCourse(LoggedStudent.StudentID,SelectedCourse.CourseID))
                    {
                        LoggedStudent.StudentCoursesList.Add(await APIservice.GetCourse(SelectedCourse.CourseID));
                        Barrel.Current.Add<Student>("LoggedStudent", LoggedStudent, TimeSpan.FromMinutes(20));
                       await dialogService.DisplayAlertAsync("Success!", $"The course {SelectedCourse.CourseName} has been added to your schedule", "Ok");
                    }
                }

            });

            SearchCourseCommand = new DelegateCommand(() => FilterList(CourseFilter));
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void FilterList(string courseFilter)
        {
            if (string.IsNullOrEmpty(courseFilter))
            {
                AllCoursesList = new ObservableCollection<Course>(Barrel.Current.Get<List<Course>>("AllCourseList"));
            }
            else
            {
                List<Course> TempList = AllCoursesList.ToList();
                foreach (Course CurrentCourse in TempList)
                {
                    if (!CurrentCourse.CourseID.Contains(courseFilter) && !CurrentCourse.CourseName.Contains(courseFilter) && !CurrentCourse.CourseTeacher.Contains(courseFilter))
                    {
                        AllCoursesList.Remove(CurrentCourse);
                    }
                }
            }

        }
    }
}
