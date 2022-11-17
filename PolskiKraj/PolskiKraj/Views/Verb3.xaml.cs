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
    public partial class Verb3 : ContentPage
    {
        Verb3ViewModel Verb4ViewModel;
        public Verb3()
        {
            InitializeComponent();
            BindingContext = Verb4ViewModel = new Verb3ViewModel();
        }
    }
}