using PolskiKraj.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PolskiKraj.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Verb1 : ContentPage
    {
        Verb1ViewModel verb1ViewModel;
        public Verb1()
        {
            InitializeComponent();
            BindingContext = verb1ViewModel = new Verb1ViewModel();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            
        }
        
    }
}