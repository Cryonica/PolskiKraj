using PolskiKraj.Models;
using System.Collections.ObjectModel;

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
