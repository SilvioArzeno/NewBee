using MonkeyCache.FileStore;
using NewBeeProject.Models;
using NewBeeProject.Services;
using Prism.Commands;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewBeeProject.ViewModels
{
    public class ProfilePageViewModel : BaseViewModel
    {
        public DelegateCommand NavEditPtofileCommand { get; set; }
        public Student LoggedStudent { get; set; }
        public ProfilePageViewModel(INavigationService navigationService, APIService APIservice) : base(navigationService,APIservice)
        {
            NavEditPtofileCommand = new DelegateCommand(async () => { await NavigateTo(NavConstants.EditProfile); });
            LoggedStudent = Barrel.Current.Get<Student>("LoggedStudent");
        }
    }
}
