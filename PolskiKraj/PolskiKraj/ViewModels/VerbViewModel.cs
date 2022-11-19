using PolskiKraj.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

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
