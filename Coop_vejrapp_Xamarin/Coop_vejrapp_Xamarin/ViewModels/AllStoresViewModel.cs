using Coop_vejrapp_Xamarin.Model;
using Coop_vejrapp_Xamarin.ViewModel;
using Coop_vejrapp_Xamarin.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Coop_vejrapp_Xamarin.ViewModels
{
    public class AllStoresViewModel : BaseViewModel
    {
        public AllStoresViewModel()
        {
            //Create Instance of the StoreList
            ButiksListe = ButiksListeSingleton.Instance;
        }
        //Getter & Setter
        public ButiksListeSingleton ButiksListe { get; set; }

        private Butik.Datum _selectedStore;

        public Butik.Datum SelectedStore
        {
            get { return _selectedStore; }
            set { _selectedStore = value; OnPropertyChanged();
            }
        }

        private VejrData.Datum _selectedStoreWeather;

        public VejrData.Datum SelectedStoreWeather
        {
            get { return _selectedStoreWeather; }
            set { _selectedStoreWeather = value; OnPropertyChanged(); }
        }

        String TestString
        {
            get { return "Hello World"; }
            set { TestString = value; OnPropertyChanged(); }
        }



    }
}
