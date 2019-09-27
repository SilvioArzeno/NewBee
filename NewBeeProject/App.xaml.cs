using NewBeeProject.ViewModels;
using NewBeeProject.Views;
using Prism;
using Prism.Ioc;
using Prism.Unity;
using System;
using Xamarin.Forms;

namespace NewBeeProject
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override void OnInitialized()
        {
            InitializeComponent();

            NavigationService.NavigateAsync(NavConstants.Login);
        }
        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<LoginPage, LoginPageViewModel>();
            containerRegistry.RegisterForNavigation<HomePage, HomePageViewModel>();
            containerRegistry.RegisterForNavigation<HomeMasterDetailPage, HomeMasterDetailPageViewModel>();
            containerRegistry.RegisterForNavigation<ProfilePage, ProfilePageViewModel>();
            containerRegistry.RegisterForNavigation<RegisterPage, RegisterPageViewModel>();
            containerRegistry.RegisterForNavigation<MapPage, MapPageViewModel>();
            containerRegistry.RegisterForNavigation<TaskPage, TaskPageViewModel>();
            containerRegistry.RegisterForNavigation<AddCoursePage, AddCoursePageViewModel>();
            containerRegistry.RegisterForNavigation<AddTaskPage, AddTaskPageViewModel>();
            containerRegistry.RegisterForNavigation<CourseDetailPage, CourseDetailPageViewModel>();
            containerRegistry.RegisterForNavigation<EditProfilePage, EditProfilePageViewModel>();
            containerRegistry.RegisterForNavigation<PhoneNumbersPage, PhoneNumbersPageViewModel>();



            containerRegistry.RegisterForNavigation<NavigationPage>();

        }
    }
}
