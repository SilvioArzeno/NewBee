using MonkeyCache.FileStore;
using NewBeeProject.Models;
using Prism.Commands;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NewBeeProject.ViewModels
{
    public class CourseDetailPageViewModel:BaseViewModel
    {

        public Course CurrentCourse { get; set; }
        public DelegateCommand MapCommand { get; set; }
        public DelegateCommand CallCommand { get; set; }

        public CourseDetailPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            CurrentCourse = Barrel.Current.Get<Course>("SelectedCourse");

            MapCommand = new DelegateCommand(async() =>
            {
                await navigationService.NavigateAsync(new Uri($"/{NavConstants.HomeMasterDetail}/{NavConstants.Navigation}/{NavConstants.Map}", UriKind.Absolute));
            });

            CallCommand = new DelegateCommand(async () =>
            {
                await navigationService.NavigateAsync(new Uri($"/{NavConstants.HomeMasterDetail}/{NavConstants.Navigation}/{NavConstants.PhoneNumbers}",UriKind.Absolute));
            }
            );

        }
    }
}
