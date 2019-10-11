using NewBeeProject.Services;
using Prism.Navigation;
using System.Threading.Tasks;

namespace NewBeeProject.ViewModels
{
    public class BaseViewModel
    {
        INavigationService _navigationService;
        IAPIService _APIservice;
        public BaseViewModel(INavigationService navigationService,IAPIService APIservice)
        {
            _navigationService = navigationService;
            _APIservice = APIservice;
           
        }
        public async Task GoBack()
        {
            await _navigationService.GoBackAsync();
        }

        public async Task NavigateTo(string TargetPage,bool Modal)
        {
            await _navigationService.NavigateAsync($"{TargetPage}",useModalNavigation:Modal);
        }
    }
}