using aicoffi.Servicios;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace aicoffi
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            DependencyService.Register<LoginService>();
            MainPage = new NavigationPage(new MainPage());
           // MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
