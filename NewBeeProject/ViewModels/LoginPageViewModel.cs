using NewBeeProject.Services;
using Prism.Commands;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewBeeProject.ViewModels
{
    public class LoginPageViewModel: BaseViewModel
    {
        public DelegateCommand LoginCommand { get; set; }
        public string UserID { get; set; }
        public string Password { get; set; }
        public DelegateCommand NavRegisterCommand { get; set; }
        public LoginPageViewModel(INavigationService navigationService ,IAPIService APIservice) : base(navigationService,APIservice)
        {

            LoginCommand = new DelegateCommand(async () =>
              {
                 
                  if(!string.IsNullOrEmpty(UserID) || !string.IsNullOrEmpty(Password))
                  {
                      if (await APIservice.CheckLogin(UserID, Password))
                      {
                         
                          await AbsoluteGoToHome();
                      }

                      //TODO: Incorrect password error message
                  }
              });

            NavRegisterCommand = new DelegateCommand(async () =>
            {
               await GoToRegistration();
            });
        }
    }
}
