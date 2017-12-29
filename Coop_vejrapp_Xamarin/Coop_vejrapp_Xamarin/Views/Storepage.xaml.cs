using Coop_vejrapp_Xamarin.Model;
using Coop_vejrapp_Xamarin.Services;
using Coop_vejrapp_Xamarin.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Coop_vejrapp_Xamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Storepage : ContentPage
	{
        public Storepage(AllStoresViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;

            DmiApi dmi = new DmiApi();

            Butik.Datum ThisStore = viewModel.SelectedStore;

            dmi.DMICallPointModel(viewModel, ThisStore.Location.Coordinates[0], ThisStore.Location.Coordinates[1]);
            if (viewModel.SelectedStoreWeather != null) {
                BigTemperature.Text = viewModel.SelectedStoreWeather.p[0].temperature;
            }
            
        }
	}
}