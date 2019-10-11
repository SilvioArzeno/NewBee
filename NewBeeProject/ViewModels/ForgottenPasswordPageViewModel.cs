using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Text;

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
