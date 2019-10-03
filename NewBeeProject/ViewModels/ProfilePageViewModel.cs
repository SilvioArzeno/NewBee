using Prism.Commands;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewBeeProject.ViewModels
{
    public class ProfilePageViewModel
    {
        INavigationService _navigationService;

        public DelegateCommand NavEditPtofileCommand { get; set; }

        public ProfilePageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;

            NavEditPtofileCommand = new DelegateCommand(async () =>
            {
                await GoToEditProfile();
            });
        }
        async System.Threading.Tasks.Task GoToEditProfile()
        {
            await _navigationService.NavigateAsync($"{NavConstants.EditProfile}");
        }
    }
}
