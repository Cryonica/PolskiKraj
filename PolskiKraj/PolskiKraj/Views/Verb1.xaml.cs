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
    public partial class Verb1 : ContentPage
    {
        VerbViewModel verbViewModel;
        public Verb1()
        {
            InitializeComponent();
            BindingContext = verbViewModel = new VerbViewModel { Title = "1-ое спряжение" };
        }
    }
}