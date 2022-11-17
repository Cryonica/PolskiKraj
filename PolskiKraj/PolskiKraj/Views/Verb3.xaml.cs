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
        public Verb3()
        {
            VerbViewModel viewModel;
            InitializeComponent();
            BindingContext = viewModel = new VerbViewModel { Title = "3-ое спряжение" };
        }
    }
}