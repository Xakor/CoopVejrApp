using Coop_vejrapp_Xamarin.Model;
using Coop_vejrapp_Xamarin.Services;
using Coop_vejrapp_Xamarin.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Coop_vejrapp_Xamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AllStoresPage : ContentPage
    {
        AllStoresViewModel ViewModel = new AllStoresViewModel();
        
        public AllStoresPage()
        {
            InitializeComponent();
            BindingContext = ViewModel;

            AllStoresListView.ItemsSource = ViewModel.ButiksListe.ButiksListe;
            AllStoresListView.HasUnevenRows = false;
            
            //Create instance of CoopApi
            CoopApi coopApi = new CoopApi();
            //Populate listview with items
            coopApi.CallApi(ViewModel);

            //AllStoresListView.SetBinding(ListView.SelectedItemProperty, "SelectedStore");

        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;


            //await DisplayAlert("Item Tapped", "An item was tapped.", "OK");
            await Navigation.PushAsync(new Storepage(ViewModel));

            //Deselect Item
            //((ListView)sender).SelectedItem = null;
        }

    }
}
