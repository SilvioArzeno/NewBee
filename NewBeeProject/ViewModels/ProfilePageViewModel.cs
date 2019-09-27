using Prism.Commands;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewBeeProject.ViewModels
{
    public class ProfilePageViewModel: BaseViewModel
    {
        public DelegateCommand NavEditPtofileCommand { get; set; }

        public ProfilePageViewModel(INavigationService navigationService) : base(navigationService)
        {
            NavEditPtofileCommand = new DelegateCommand(async () =>
            {
                await GoToEditProfile();
            });
        }
    }
}
