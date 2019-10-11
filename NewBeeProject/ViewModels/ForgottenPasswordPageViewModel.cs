using Prism.Commands;

namespace NewBeeProject.ViewModels
{
    public class ForgottenPasswordPageViewModel
    {
        public DelegateCommand SendEmailCommand { get; set; }

        public ForgottenPasswordPageViewModel()
        {
            SendEmailCommand = new DelegateCommand(async () =>
            {
                //TODO: send email to recover password.
            });
        }
    }
}
