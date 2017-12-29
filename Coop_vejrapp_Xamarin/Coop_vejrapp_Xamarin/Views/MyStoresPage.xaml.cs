using Coop_vejrapp_Xamarin.Model;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Coop_vejrapp_Xamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyStoresPage : ContentPage
    {

        public ObservableCollection<string> Items { get; set; }

        public MyStoresPage()
        {
            InitializeComponent();
            
            Items = new ObservableCollection<string>
            {
                "Item 1",
                "Item 2",
                "Item 3",
                "Item 4",
                "Item 5"
            };
			
			MyListView.ItemsSource = Items;
            MyListView.IsPullToRefreshEnabled = true;
        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            //await DisplayAlert("Item Tapped", "An item was tapped.", "OK");
            //await Navigation.PushAsync(new Storepage());

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }
    }
}
