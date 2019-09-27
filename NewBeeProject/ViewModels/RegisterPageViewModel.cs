using NewBeeProject.Models;
using NewBeeProject.Services;
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
        public DelegateCommand RegisterStudentCommand { get; set; }
        public RegisterPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            RegisteredStudent = new Student();
            APIService service = new APIService();
            RegisterStudentCommand = new DelegateCommand(async () =>
            {
                if (await service.RegisterStudent(RegisteredStudent))
                    await AbsoluteGoToHome();
                else
                    await GoBack();
            });
        }

    }
}
