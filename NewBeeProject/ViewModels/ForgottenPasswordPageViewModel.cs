using Prism.Commands;
using Prism.Navigation;
using Prism.Services;

namespace NewBeeProject.ViewModels
{
    public class ForgottenPasswordPageViewModel : BaseViewModel
    {
        public DelegateCommand SendEmailCommand { get; set; }

        public ForgottenPasswordPageViewModel(IPageDialogService userDialogService, INavigationService navigationService) : base(navigationService)
        {
            SendEmailCommand = new DelegateCommand(async () =>
            {
                await userDialogService.DisplayAlertAsync("Email sent", "Email was sent to you", "Thanks for your help");
                await GoBack();
                //TODO: send email to recover password.
            });
        }
    }
}
