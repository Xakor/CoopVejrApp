using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Coop_vejrapp_Xamarin.Services;

namespace Coop_vejrapp_Xamarin.Model
{
    public class ButiksListeSingleton
    {
        //Singleton instansiation management
        private static ButiksListeSingleton _instance;
        public static ButiksListeSingleton Instance
        {
            get { return _instance ?? new ButiksListeSingleton(); }
        }
        private ButiksListeSingleton()
        {
            ButiksListe = new ObservableCollection<Butik.Datum>();
        }
        public ObservableCollection<Butik.Datum> ButiksListe { get; set; }



        /// <summary>
        /// Adds a single store to the list
        /// </summary>
        public void addButik(Butik.Datum butik)
        {
            ButiksListe.Add(butik);
        }
        /// <summary>
        /// Removed all stores in ButiksListe
        /// </summary>
        public  void removeAll()
        {
            foreach (var i in ButiksListe)
            {
                ButiksListe.Remove(i);
            }
        }
    }
}
