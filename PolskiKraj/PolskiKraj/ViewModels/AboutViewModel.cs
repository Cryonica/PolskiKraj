using System.Windows.Input;
using Xamarin.Forms;

namespace PolskiKraj.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About";
            OpenWebCommand = new Command(() =>  Shell.Current.GoToAsync($"WebSite"));
        }

        public ICommand OpenWebCommand { get; }
    }
}