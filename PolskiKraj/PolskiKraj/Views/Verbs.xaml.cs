using PolskiKraj.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PolskiKraj.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Verbs : ContentPage
    {
        VerbsViewModel verbsViewModel;
        public Verbs()
        {
            InitializeComponent();
            BindingContext = verbsViewModel = new VerbsViewModel();
            
        }
    }
}