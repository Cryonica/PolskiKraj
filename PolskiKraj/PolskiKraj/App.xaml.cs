using PolskiKraj.Services;
using Xamarin.Forms;


namespace PolskiKraj
{
    public partial class App : Application
    {

        public App()
        {

           
            InitializeComponent();
            DependencyService.Register<MockDataStore>();
            MainPage = new SplashPage();
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
