using NewBeeProject.Models;
using Prism.Navigation;
using System.Collections.ObjectModel;

namespace NewBeeProject.ViewModels
{
    public class HomeMasterDetailPageViewModel
    {
        INavigationService _navigationService;

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
        public ObservableCollection<MasterDetailMenuItem> MasterDetailMenuItems { get; set; }

        public HomeMasterDetailPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;

            MenuItems();
        }
        async System.Threading.Tasks.Task OnSelectItemAsync(MasterDetailMenuItem MenuItem)
        {
            if (MenuItem.Title.Equals(NavMenu.Logout))
                Logout();

            await _navigationService.NavigateAsync($"{NavConstants.Navigation}/{MenuItem.TargetPage}");
        }

       async void Logout()
        {
            string test = _navigationService.GetNavigationUriPath();
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
