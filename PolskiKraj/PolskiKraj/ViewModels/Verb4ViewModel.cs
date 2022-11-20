using PolskiKraj.Models;
using System.Collections.ObjectModel;

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
