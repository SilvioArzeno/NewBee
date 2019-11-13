using NewBeeProject.Services;
using Prism.Navigation;
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

        public async Task NavigateTo(string TargetPage,bool Modal)
        {
            await _navigationService.NavigateAsync($"{NavConstants.Navigation}/{TargetPage}",useModalNavigation:Modal);
        }
    }
}