using PolskiKraj.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PolskiKraj.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Verb4 : ContentPage
    {
        Verb4ViewModel viewModel;
        public Verb4()
        {
           
            InitializeComponent();
            BindingContext = viewModel = new Verb4ViewModel();
        }
    }
}