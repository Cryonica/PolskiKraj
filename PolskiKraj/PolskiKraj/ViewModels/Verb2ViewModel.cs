using PolskiKraj.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace PolskiKraj.ViewModels
{
    class Verb2ViewModel : BaseViewModel
    {
        public ObservableCollection<WordVerb> Items { get; }
        public Verb2ViewModel()
        {
            Title = "2 спряжение";
            Items = new ObservableCollection<WordVerb>();

        }
    
    }
}
