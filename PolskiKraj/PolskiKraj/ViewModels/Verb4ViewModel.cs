using PolskiKraj.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace PolskiKraj.ViewModels
{
    public class Verb4ViewModel : BaseViewModel
    {
        public ObservableCollection<WordVerb> Items { get; }
        public Verb4ViewModel()
        {
            Title = "4 спряжение";
            Items = new ObservableCollection<WordVerb>();

        }
    }
}
