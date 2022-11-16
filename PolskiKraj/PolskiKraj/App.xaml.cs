using PolskiKraj.Services;
using Newtonsoft.Json;
using PolskiKraj.Views;
using System;
using System.Net;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.Generic;
using PolskiKraj.Models;

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
                var data = wc.DownloadString("https://raw.githubusercontent.com/Cryonica/PolskiKraj/main/sampe_data.json");
                var dynObj = JsonConvert.DeserializeObject<List<WordsSusch>>(data);
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
