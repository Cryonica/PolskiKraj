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
   
    public partial class Verb2 : CarouselPage
    {
        Verb2ViewModel viewModel;
        public Verb2()
        {
            InitializeComponent();
            BindingContext = viewModel = new Verb2ViewModel();
        }
    }
}