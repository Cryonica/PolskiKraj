using PolskiKraj.Models;
using PolskiKraj.ViewModels;
using Xamarin.Forms;

namespace PolskiKraj.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}