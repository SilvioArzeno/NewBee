using System;
using MonkeyCache.FileStore;
using NewBeeProject.Models;
using NewBeeProject.Services;
using Prism.Commands;
using Prism.Navigation;

namespace NewBeeProject.ViewModels
{
    public class EditProfilePageViewModel : BaseViewModel
    {
        public Student LoggedStudent { get; set; }
        public Student UpdatedStudent { get; set; }
        
        public DelegateCommand SaveEditedProfileCommand { get; set; }
        public EditProfilePageViewModel(INavigationService navigationService, IAPIService APIservice) : base(navigationService)
        {
            LoggedStudent = LoggedStudent = Barrel.Current.Get<Student>("LoggedStudent");

            UpdatedStudent = LoggedStudent;


            SaveEditedProfileCommand = new DelegateCommand(async () =>
            {
                await APIservice.UpdateStudent(LoggedStudent.StudentID, UpdatedStudent);
                Barrel.Current.EmptyAll();
                Barrel.Current.Add<Student>("LoggedStudent",UpdatedStudent , TimeSpan.FromMinutes(20));
                await GoBack();
            });
        }
    }
}
