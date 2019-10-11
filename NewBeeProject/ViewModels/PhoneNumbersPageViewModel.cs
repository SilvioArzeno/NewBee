using MonkeyCache.FileStore;
using NewBeeProject.Models;
using NewBeeProject.Services;
using Prism.Commands;
using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace NewBeeProject.ViewModels
{
    public class PhoneNumbersPageViewModel : BaseViewModel
    {
        public ObservableCollection<Directory> DirectoryList { get; set; }
        public DelegateCommand<Directory> CallCommand { get; set; }
        public PhoneNumbersPageViewModel(INavigationService navigationService,IDeviceService deviceService, APIService APIservice) : base(navigationService)
        {

            DirectoryList = new ObservableCollection<Directory>(Barrel.Current.Get<List<Directory>>("AllDirectoriesList"));

            CallCommand = new DelegateCommand<Directory>((param) =>
            {
                deviceService.OpenUri(new Uri(uriString: $"tel:{$"{param.AreaPhoneNumber}"}"));
            });
        }
    }
}
