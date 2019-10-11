using MonkeyCache.FileStore;
using NewBeeProject.Models;
using NewBeeProject.Services;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace NewBeeProject.ViewModels
{
    public class HomeMasterDetailPageViewModel
    {

        public APIService _service { get; set; }
        public INavigationService _navigationService;
       public Student LoggedStudent { get; set; }
        public string FullName { get; set; }
        public ObservableCollection<MasterDetailMenuItem> MasterDetailMenuItems { get; set; }

        MasterDetailMenuItem MenuItem;
        public MasterDetailMenuItem SelectedMenuItem
        {
            get { return MenuItem; }
            set
            {
                MenuItem = value;
                if (MenuItem != null)
                    _ = OnSelectItemAsync(MenuItem);
            }
        }

        public HomeMasterDetailPageViewModel(INavigationService navigationService, APIService service)
        {
            _navigationService = navigationService;
            _service = service;
            LoggedStudent = Barrel.Current.Get<Student>("LoggedStudent");
            FullName = $"{LoggedStudent.FirstName} {LoggedStudent.LastName}";
            MenuItems();
        }
        async System.Threading.Tasks.Task OnSelectItemAsync(MasterDetailMenuItem MenuItem)
        {
            if (MenuItem.Title.Equals(NavMenu.Logout))
                Logout();
            if (MenuItem.Title.Equals(NavMenu.AddCoursePage))
            {
                Barrel.Current.Add<List<Course>>("AllCourseList", await _service.GetAllCourses(),TimeSpan.FromMinutes(20));
            }
            if (MenuItem.Title.Equals(NavMenu.PhoneNumbersPage))
            {
                Barrel.Current.Add<List<Directory>>("AllDirectoriesList", await _service.GetAllDirectories(), TimeSpan.FromMinutes(20));
            }
           

            await _navigationService.NavigateAsync($"{NavConstants.Navigation}/{MenuItem.TargetPage}");
        }

       async void Logout()
        {
            await _navigationService.NavigateAsync($"/{NavConstants.Login}");
        }

        private void MenuItems()
        {
            
            MasterDetailMenuItems = new ObservableCollection<MasterDetailMenuItem>()
            {
                new MasterDetailMenuItem{Title = NavMenu.HomePage, TargetPage = NavConstants.Home, Icon = Icons.Home},
                new MasterDetailMenuItem{Title = NavMenu.ProfilePage, TargetPage = NavConstants.Profile, Icon = Icons.Profile},
                new MasterDetailMenuItem{Title = NavMenu.AddCoursePage, TargetPage = NavConstants.AddCourse, Icon = Icons.AddCourse},
                new MasterDetailMenuItem{Title = NavMenu.TaskPage, TargetPage = NavConstants.Task, Icon = Icons.Task},
                new MasterDetailMenuItem{Title = NavMenu.AddTaskPage, TargetPage = NavConstants.AddTask, Icon = Icons.AddTask},
                new MasterDetailMenuItem{Title = NavMenu.MapPage, TargetPage = NavConstants.Map, Icon = Icons.Map},
                new MasterDetailMenuItem{Title = NavMenu.PhoneNumbersPage, TargetPage = NavConstants.PhoneNumbers, Icon = Icons.PhoneNumbers},
                new MasterDetailMenuItem{Title = NavMenu.Logout, TargetPage = NavConstants.Login, Icon = Icons.LogOut}
            };
        }
    }
}
