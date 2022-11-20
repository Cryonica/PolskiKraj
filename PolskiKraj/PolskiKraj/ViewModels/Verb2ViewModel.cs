using PolskiKraj.Models;
using System.Collections.ObjectModel;

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
