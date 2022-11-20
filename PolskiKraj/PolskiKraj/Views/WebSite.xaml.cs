using PolskiKraj.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PolskiKraj.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WebSite : ContentPage
    {
        public WebSite()
        {
            if (Global.GetWebSite == null)
            {

                InitializeComponent();
                Global.Init();

                this.Content = Global.GetWebSite;

            }
            else
            {
                this.Content = Global.GetWebSite;
                
            }
        }
    }
}