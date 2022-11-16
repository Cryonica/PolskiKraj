using PolskiKraj.Services;
using PolskiKraj.ViewModels;
using PolskiKraj.Views;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PolskiKraj
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            
            
            
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
            Routing.RegisterRoute(nameof(WebSite), typeof(WebSite));

           
           bool chekFileWeb = FilePresent("https://github.com/Cryonica/PolskiKraj/blob/main/sampe_data.json").Result;
            if (!chekFileWeb)
            {
                DisplayAlert("Ошибка!", "Нет связи с сервером", "OK");
            }
            else
            {
                new ItemsViewModel();
                Global.Init();
            }
           
           
            
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
