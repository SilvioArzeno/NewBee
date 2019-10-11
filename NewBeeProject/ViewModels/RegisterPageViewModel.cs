using NewBeeProject.Models;
using NewBeeProject.Services;
using Prism.Commands;
using Prism.Navigation;

namespace NewBeeProject.ViewModels
{
    public class RegisterPageViewModel : BaseViewModel
    {
        public Student RegisteredStudent { get; set; }
        public DelegateCommand RegisterStudentCommand { get; set; }
        public RegisterPageViewModel(INavigationService navigationService,IAPIService APIservice) : base(navigationService , APIservice)
        {
            RegisteredStudent = new Student();
            RegisterStudentCommand = new DelegateCommand(async () =>
            {
                if (await APIservice.RegisterStudent(RegisteredStudent))
                {
                    await navigationService.GoBackAsync();
                }
                else
                {
                    //TODO: Display "Registration error' message
                    await GoBack();
                }
            });
        }

    }
}
