using Prism.Commands;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewBeeProject.ViewModels
{
    public class LoginPageViewModel: BaseViewModel
    {
        public DelegateCommand NavHomeCommand { get; set; }
        public LoginPageViewModel(INavigationService navigationService): base (navigationService)
        {

            NavHomeCommand = new DelegateCommand(async () =>
              {
                  await AbsoluteGoToHome();
              });
        }
    }
}
