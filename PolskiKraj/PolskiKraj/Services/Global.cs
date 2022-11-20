using Xamarin.Forms;

namespace PolskiKraj.Services
{
    class Global
    {
        public static void Init()
        {

            webSite = CreateWebContent("https://www.polskikraj.info/");
        }

        private static WebView webSite { get; set; }
        public static WebView GetWebSite
        {

            set => webSite = value;
            get => webSite;
        }
        private static WebView CreateWebContent(string uri)
        {


            return new Xamarin.Forms.WebView
            {
                Source = new UrlWebViewSource { Url = uri },
                // или так
                // Source = "https://devblogs.microsoft.com/xamarin/",
                VerticalOptions = LayoutOptions.FillAndExpand
            };
        }
    }
}
