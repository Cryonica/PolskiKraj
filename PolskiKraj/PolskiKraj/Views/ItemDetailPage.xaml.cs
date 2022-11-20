using PolskiKraj.ViewModels;
using Xamarin.Forms;

namespace PolskiKraj.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}