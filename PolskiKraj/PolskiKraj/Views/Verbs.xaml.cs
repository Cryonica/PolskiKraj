using PolskiKraj.ViewModels;
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