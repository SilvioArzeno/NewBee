using Prism.Commands;

namespace NewBeeProject.ViewModels
{
    public class ChangePasswordPageViewModel
    {
        public DelegateCommand ChangePasswordCommand { get; set; }

        public ChangePasswordPageViewModel()
        {
            ChangePasswordCommand = new DelegateCommand(async () =>
            {
                //TODO: Change password.
            });
        }
    }
}
