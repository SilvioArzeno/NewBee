using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NewBeeProject.ViewModels
{
    public class BaseViewModel
    {
        INavigationService _navigationService;
        public BaseViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }
        public async Task GoBack()
        {
            await _navigationService.GoBackAsync();
        }
        public async Task AbsoluteGoToHome()
        {
            await _navigationService.NavigateAsync(new Uri($"/{NavConstants.HomeMasterDetail}/{NavConstants.Navigation}/{NavConstants.Home}", UriKind.Absolute));
        }
        public async Task RelativeGoToHome()
        {
            await _navigationService.NavigateAsync($"{NavConstants.HomeMasterDetail}/{NavConstants.Navigation}/{NavConstants.Home}");
        }
        public async Task GoToMap()
        {
            await _navigationService.NavigateAsync($"{NavConstants.Navigation}/{NavConstants.Map}");
        }
        public async Task GoToTasks()
        {
            await _navigationService.NavigateAsync($"{NavConstants.Navigation}/{NavConstants.Task}");
        }
        public async Task GoToProfile()
        {
            await _navigationService.NavigateAsync($"{NavConstants.Navigation}/{NavConstants.Profile}");
        }
        public async Task GoToRegistration()
        {
            await _navigationService.NavigateAsync($"{NavConstants.Navigation}/{NavConstants.Registration}");
        }
    }
}