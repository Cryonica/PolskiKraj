using PolskiKraj.Models;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PolskiKraj.ViewModels
{
    [QueryProperty(nameof(ItemId), nameof(ItemId))]
    public class ItemDetailViewModel : BaseViewModel
    {
        private string itemId;
        private string text;
        private string description;
        private bool life;
        private string rod;
        private string sklon;
        public string Id { get; set; }

        public string Text
        {
            get => text;
            set => SetProperty(ref text, value);
        }

        public string Description
        {
            get => description;
            set => SetProperty(ref description, value);
        }
        public bool Life
        {
            get => life;
            set => SetProperty(ref life, value);
        }
        public string Rod
        {
            get => rod;
            set => SetProperty(ref rod, value);
        }
        public string Sklon
        {
            get => sklon;
            set => SetProperty(ref sklon, value);
        }
        public string ItemId
        {
            get
            {
                return itemId;
            }
            set
            {
                itemId = value;
                LoadItemId(value);
            }
        }

        public async void LoadItemId(string ID)
        {
            try
            {
                var item = await DataStoreWordSusch.GetItemAsync(itemId);
                Id = item.ID;
                Text = item.Sample;
                Description = item.Type;
                Rod = item.Rod;
                Sklon = item.Sklon;
                Life = item.Life;
            }
            catch (Exception)
            {
                Debug.WriteLine("Failed to Load Item");
            }
        }
    }
}
