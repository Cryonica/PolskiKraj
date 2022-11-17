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
        ICommand openVerbCommand;
        public ICommand OpenVerbCommand
        {
            get => openVerbCommand;
        }


        public VerbsViewModel()
        {
            Title = "Глаголы";
            openVerbCommand = new Command(OnTapped);
        }
        void OnTapped(object s)
        {
            taps++;
            
            Shell.Current.GoToAsync($"{s}");
           
        }
        


    }
}
