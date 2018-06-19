using Xamarin.Forms;

using Plant_Tagger.Views;
using Plant_Tagger.Services;
using Plant_Tagger.ViewModels.Base;
using System.Threading.Tasks;

namespace Plant_Tagger
{
    public partial class App : Application
    {
        ISettingsService _settingsService;

        public App()
        {
            InitializeComponent();
            InitApp();

            //MainPage = new NavigationPage(new LoginPage());
        }

        protected override async void OnStart()
        {
            // Handle when your app starts
            base.OnStart();

            if (Device.RuntimePlatform != Device.UWP)
            {
                await InitNavigation();
            }

            base.OnResume();
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

        private void InitApp()
        {
            _settingsService = ViewModelLocator.Resolve<ISettingsService>();
            //if (!_settingsService.UseMocks)
            //    ViewModelLocator.UpdateDependencies(_settingsService.UseMocks);
        }

        private Task InitNavigation()
        {
            var navigationService = ViewModelLocator.Resolve<INavigationService>();
            return navigationService.InitializeAsync();
        }
    }
}
