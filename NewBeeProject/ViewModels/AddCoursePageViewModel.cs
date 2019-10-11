using NewBeeProject.Models;
using NewBeeProject.Services;
using Prism.Commands;
using Prism.Navigation;
using Prism.Services;
using System.Collections.ObjectModel;

namespace NewBeeProject.ViewModels
{
    public class AddCoursePageViewModel: BaseViewModel
    {
        IPageDialogService _dialogService;
        public ObservableCollection<Course> AllCoursesList { get; set; }
        public Course RegisteredCourse { get; set; }
        public DelegateCommand RegisterCourseCommand { get; set; }
        public Course SelectedCourse { get; set; }

        public AddCoursePageViewModel(INavigationService navigationService, IAPIService APIservice, IPageDialogService dialogService) : base(navigationService, APIservice)
        {
            _dialogService = dialogService;

            RegisteredCourse = new Course();
            RegisterCourseCommand = new DelegateCommand(async () =>
            {
                var answer = await _dialogService.DisplayAlertAsync("Question?", $"Are you sure you want to add {SelectedCourse.CourseName}?", "Yes", "No");
                if (answer)
                {
                    //TODO: Add SelectedCourse in student courses here

                    if (await APIservice.RegisterCourse(RegisteredCourse))
                    {
                        await navigationService.GoBackAsync();
                    }
                }
            });
        }
    }
}
