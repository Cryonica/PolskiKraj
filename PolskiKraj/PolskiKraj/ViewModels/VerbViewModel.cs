using PolskiKraj.Models;
using System.Collections.ObjectModel;

namespace PolskiKraj.ViewModels
{
    public class VerbViewModel : BaseViewModel
    {
        public ObservableCollection<WordVerb> Items { get; }
        //internal List<WordVerb> inputVrbs;
        public string val { get; set; }
        public VerbViewModel()
        {
           

        }
    }
}
