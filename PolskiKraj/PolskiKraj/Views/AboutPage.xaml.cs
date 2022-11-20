using Xamarin.Forms;

namespace PolskiKraj.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
           
        }
        protected override void OnAppearing()
        {
            if (maingrid.Opacity == 1) return;
            maingrid.FadeTo(1, 1200, Easing.SinInOut);
        }
    }
}