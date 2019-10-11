using MonkeyCache.FileStore;
using NewBeeProject.Models;
using NewBeeProject.Services;
using Prism.Commands;
using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.ObjectModel;

namespace NewBeeProject.ViewModels
{
    public class HomePageViewModel :BaseViewModel
    {
        public Student LoggedStudent { get; set; }
        public ObservableCollection<Course> StudentCourseList { get; set; }
        public Course SelectedItem { get; set; }

        public DelegateCommand<Course> OnMoreCommand { get; set; }
        public DelegateCommand<Course> DeleteCourseCommand { get; set; }


        public HomePageViewModel(INavigationService navigationService, IAPIService APIservice, IPageDialogService dialogService) : base(navigationService)
        {

            LoggedStudent = Barrel.Current.Get<Student>("LoggedStudent");
            StudentCourseList = new ObservableCollection<Course>(LoggedStudent.StudentCoursesList);
             OnMoreCommand = new DelegateCommand<Course>(async (param) =>
            {
                SelectedItem = param;

                Barrel.Current.Add<Course>("SelectedCourse", SelectedItem,TimeSpan.FromSeconds(30));
                await navigationService.NavigateAsync($"{NavConstants.CourseDetail}");
            });

            DeleteCourseCommand = new DelegateCommand<Course>(async (param) =>
            {
                SelectedItem = (Course)param;
                if(await dialogService.DisplayAlertAsync("Confirm",$"Do you want to delete {SelectedItem.CourseName} from your schedule?", "Yes", "No"))
                {
                    await APIservice.DeleteSchedule(LoggedStudent.StudentID, SelectedItem.CourseID);
                   LoggedStudent.StudentCoursesList.Remove(SelectedItem);
                    StudentCourseList.Remove(SelectedItem);
                    Barrel.Current.Add<Student>("LoggedStudent", LoggedStudent, TimeSpan.FromMinutes(20));
                    
                }
            });

        }

       
    }
}
