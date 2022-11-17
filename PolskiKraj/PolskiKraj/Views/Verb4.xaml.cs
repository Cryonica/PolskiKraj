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
    public partial class Verb4 : ContentPage
    {
        public Verb4()
        {
            VerbViewModel viewModel;
            InitializeComponent();
            BindingContext = viewModel = new VerbViewModel { Title = "4-ое спряжение" };
        }
    }
}