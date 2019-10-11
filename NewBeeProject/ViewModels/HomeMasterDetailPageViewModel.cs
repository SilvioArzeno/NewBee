using NewBeeProject.Models;
using Prism.Navigation;
using System.Collections.ObjectModel;

namespace NewBeeProject.ViewModels
{
    public class HomeMasterDetailPageViewModel
    {
        public INavigationService _navigationService;
        
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
            await _navigationService.NavigateAsync($"/{NavConstants.Login}");
        }

        private void MenuItems()
        {
            MasterDetailMenuItems = new ObservableCollection<MasterDetailMenuItem>()
            {
                new MasterDetailMenuItem{Title = NavMenu.HomePage, TargetPage = NavConstants.Home},
                new MasterDetailMenuItem{Title = NavMenu.ProfilePage, TargetPage = NavConstants.Profile},
                new MasterDetailMenuItem{Title = NavMenu.MapPage, TargetPage = NavConstants.Map},
                new MasterDetailMenuItem{Title = NavMenu.TaskPage, TargetPage = NavConstants.Task},
                new MasterDetailMenuItem{Title = NavMenu.AddCoursePage, TargetPage = NavConstants.AddCourse},
                new MasterDetailMenuItem{Title = NavMenu.AddTaskPage, TargetPage = NavConstants.AddTask},
                new MasterDetailMenuItem{Title = NavMenu.PhoneNumbersPage, TargetPage = NavConstants.PhoneNumbers},
                new MasterDetailMenuItem{Title = NavMenu.Logout, TargetPage = NavConstants.Login}
            };
        }
    }
}
