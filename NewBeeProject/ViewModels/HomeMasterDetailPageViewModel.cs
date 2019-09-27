using Prism.Commands;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewBeeProject.ViewModels
{
    public class HomeMasterDetailPageViewModel : BaseViewModel
    {
        public DelegateCommand NavProfileCommand { get; set; }
        public HomeMasterDetailPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            NavProfileCommand = new DelegateCommand(async () =>
            {
                await GoToProfile();
            });
        }
    }
}
