using PolskiKraj.Services;
using PolskiKraj.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PolskiKraj
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();
            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
            Global.Init();
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
