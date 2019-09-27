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
        public DelegateCommand NavMapCommand { get; set; }
        public DelegateCommand NavTaskCommand { get; set; }
        public HomeMasterDetailPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            NavProfileCommand = new DelegateCommand(async () =>
            {
                await GoToProfile();
            });

            NavMapCommand = new DelegateCommand(async () =>
            {
                await GoToMap();
            });
            NavTaskCommand = new DelegateCommand(async () =>
            {
                await GoToTasks();
            });
        }
    }
}
