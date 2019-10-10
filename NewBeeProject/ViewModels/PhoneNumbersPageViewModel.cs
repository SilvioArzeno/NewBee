using NewBeeProject.Models;
using Prism.Commands;
using Prism.Services;
using System;

namespace NewBeeProject.ViewModels
{
    public class PhoneNumbersPageViewModel
    {
        public DelegateCommand<Directory> CallCommand { get; set; }
        public PhoneNumbersPageViewModel(IDeviceService deviceService)
        {
            CallCommand = new DelegateCommand<Directory>((param) =>
            {
                deviceService.OpenUri(new Uri(uriString: $"tel:{$"{param.AreaPhoneNumber}"}"));
            });
        }
    }
}
