using MonkeyCache.FileStore;
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
  
        }
    }
}
