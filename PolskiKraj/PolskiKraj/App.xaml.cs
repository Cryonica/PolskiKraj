using PolskiKraj.Services;
using PolskiKraj.Views;
using System;
using System.Net;
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
            using (WebClient wc = new WebClient())
            {
                var json = wc.DownloadString("https://github.com/Cryonica/PolskiKraj/blob/main/sampe_data.json");
            }
            
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
