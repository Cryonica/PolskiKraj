using PolskiKraj.ViewModels;
using Xamarin.Forms;

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