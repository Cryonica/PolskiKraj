using PolskiKraj.Views;
using System.Net;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PolskiKraj
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            this.Opacity = 0;
            InitializeComponent();
            
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
            Routing.RegisterRoute(nameof(WebSite), typeof(WebSite));
            Routing.RegisterRoute(nameof(Verbs), typeof(Verbs));
            Routing.RegisterRoute(nameof(Verb1), typeof(Verb1));
            Routing.RegisterRoute(nameof(Verb2), typeof(Verb2));
            Routing.RegisterRoute(nameof(Verb3), typeof(Verb3));
            Routing.RegisterRoute(nameof(Verb4), typeof(Verb4));
            

        }
        private Task<bool> FilePresent(string filename)
        {
            //return await HttpClientHelper.DoesFileExist(filename);
            
            HttpWebRequest request = WebRequest.Create(filename) as HttpWebRequest;

            // instruct the server to return headers only
            request.Method = "HEAD";

            // make the connection
            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            
            // get the status code
            HttpStatusCode status = response.StatusCode;
            return Task.FromResult(status == HttpStatusCode.OK ? true : false);

        }
        

    }
}
