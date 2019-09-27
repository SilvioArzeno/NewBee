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
        public LoginPageViewModel(INavigationService navigationService): base (navigationService)
        {
            APIService service = new APIService();

            LoginCommand = new DelegateCommand(async () =>
              {
                  if (await service.CheckLogin(UserID, Password))
                  {
                      await AbsoluteGoToHome();
                  }
                  await GoToRegistration();
              });

            NavRegisterCommand = new DelegateCommand(async () =>
           {
               await GoToRegistration();
           });
        }
    }
}
