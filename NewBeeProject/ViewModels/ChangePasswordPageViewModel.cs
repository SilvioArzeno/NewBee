using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Text;

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
