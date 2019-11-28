﻿using MonkeyCache.FileStore;
using NewBeeProject.Services;
using NewBeeProject.ViewModels;
using NewBeeProject.Views;
using Prism;
using Prism.Ioc;
using Prism.Unity;
using Xamarin.Forms;

namespace NewBeeProject
{
    [AutoRegisterForNavigation]
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override void OnInitialized()
        {
            InitializeComponent();
            Barrel.ApplicationId = "NewBeeApp";
            NavigationService.NavigateAsync(NavConstants.Login);
        }
        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {

            

            //Register Instances
            containerRegistry.RegisterInstance<IAPIService>(new APIService());

            //Register Types
            containerRegistry.RegisterSingleton<IAPIService, APIService>();


            containerRegistry.RegisterForNavigation<LoginPage, LoginPageViewModel>();
            containerRegistry.RegisterForNavigation<RegisterPage, RegisterPageViewModel>();
            containerRegistry.RegisterForNavigation<MapPage, MapPageViewModel>();
            containerRegistry.RegisterForNavigation<TaskPage, TaskPageViewModel>();
            containerRegistry.RegisterForNavigation<AddCoursePage, AddCoursePageViewModel>();
            containerRegistry.RegisterForNavigation<AddTaskPage, AddTaskPageViewModel>();
            containerRegistry.RegisterForNavigation<CourseDetailPage, CourseDetailPageViewModel>();
            containerRegistry.RegisterForNavigation<ProfilePage, ProfilePageViewModel>();
            containerRegistry.RegisterForNavigation<EditProfilePage, EditProfilePageViewModel>();
            containerRegistry.RegisterForNavigation<PhoneNumbersPage, PhoneNumbersPageViewModel>();
            containerRegistry.RegisterForNavigation<HomeMasterDetailPage, HomeMasterDetailPageViewModel>();
            containerRegistry.RegisterForNavigation<HomePage, HomePageViewModel>();
            containerRegistry.RegisterForNavigation<ForgottenPasswordPage, ForgottenPasswordPageViewModel>();
            containerRegistry.RegisterForNavigation<ChangePasswordPage, ChangePasswordPageViewModel>();

        }
    }
}
