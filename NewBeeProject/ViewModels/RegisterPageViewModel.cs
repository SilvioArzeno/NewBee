using NewBeeProject.Models;
using Prism.Commands;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewBeeProject.ViewModels
{

    public class RegisterPageViewModel : BaseViewModel
    {
        public Student RegisteredStudent { get; set; }
        public DelegateCommand RegisterStudent { get; set; }
        public RegisterPageViewModel(INavigationService navigationService) : base(navigationService)
        {

            RegisterStudent = new DelegateCommand(async () =>
            {

                await AbsoluteGoToHome();
            });
        }

    }
}
