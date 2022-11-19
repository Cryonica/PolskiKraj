using PolskiKraj.Models;
using PolskiKraj.Services;
using PolskiKraj.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace PolskiKraj.ViewModels
{
    class VerbsViewModel : BaseViewModel
    {

        int taps = 0;
        public ICommand OpenVerbCommand { get; }


        public VerbsViewModel()
        {
            Title = "Глаголы";
            OpenVerbCommand = new Command(OnTapped);
        }

        private void OnTapped(object s)
        {
            taps++;
            
            Shell.Current.GoToAsync($"{s}");
           
        }
        public void OnAppearing()
        {
            IsBusy = true;
           
        }



    }
}
