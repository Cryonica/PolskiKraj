using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace PolskiKraj.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About";
            OpenWebCommand = new Command(() =>  Shell.Current.GoToAsync($"Verbs"));
        }

        public ICommand OpenWebCommand { get; }
    }
}