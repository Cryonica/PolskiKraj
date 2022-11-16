using PolskiKraj.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

                this.Content = Global.GetWebSite;

            }
            else
            {
                this.Content = Global.GetWebSite;
                
            }
        }
    }
}