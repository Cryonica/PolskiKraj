using PolskiKraj.Models;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace PolskiKraj.ViewModels
{
    public class Verb3ViewModel : BaseViewModel
    {
        public ObservableCollection<WordVerb> Items { get; }
        public Verb3ViewModel()
        {
            Title = "3 спряжение";
            Items = new ObservableCollection<WordVerb>();

        }

    }
}
