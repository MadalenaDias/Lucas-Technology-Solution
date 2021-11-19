using Erp.MobApp.Services;
using Erp.MobApp.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Erp.MobApp
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
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
