using Prism.Commands;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NewBeeProject.ViewModels
{
    public class CourseDetailPageViewModel
    {
        INavigationService _navigationService;

        public DelegateCommand MapCommand { get; set; }
        public DelegateCommand CallCommand { get; set; }

        public CourseDetailPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;

            MapCommand = new DelegateCommand(async() =>
            {
                await GoToMap();
            });

            //CallCommand = new DelegateCommand<AreaPhones>((param) =>
            //{
            //    Device.OpenUri(new Uri(String.Format("tel:{0}", $"{param.Phone}")));
            //});
        }
        public async Task GoToMap()
        {
            await _navigationService.NavigateAsync($"{NavConstants.Navigation}/{NavConstants.Map}");
        }
    }
}
