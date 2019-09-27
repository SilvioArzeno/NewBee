using Prism.Commands;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewBeeProject.ViewModels
{
    public class HomeMasterDetailPageViewModel : BaseViewModel
    {
        public DelegateCommand NavHomeCommand { get; set; }
        public DelegateCommand NavProfileCommand { get; set; }
        public DelegateCommand NavMapCommand { get; set; }
        public DelegateCommand NavTaskCommand { get; set; }
        public DelegateCommand NavAddCourseCommand { get; set; }
        public DelegateCommand NavAddTaskCommand { get; set; }
        public DelegateCommand NavPhoneNumbersCommand { get; set; }

        public HomeMasterDetailPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            NavHomeCommand = new DelegateCommand(async () =>
            {
                await RelativeGoToHome();
            });
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
            NavAddTaskCommand = new DelegateCommand(async () =>
            {
                await GoToAddTask();
            });
            NavAddCourseCommand = new DelegateCommand(async () =>
            {
                await GoToAddCourse();
            });
            NavPhoneNumbersCommand = new DelegateCommand(async () =>
            {
                await GoToPhoneNumbers();
            });
        }
    }
}
