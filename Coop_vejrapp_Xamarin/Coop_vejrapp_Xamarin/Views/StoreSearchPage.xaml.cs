using Coop_vejrapp_Xamarin.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Coop_vejrapp_Xamarin.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class StoreSearchPage : ContentPage
	{
		public StoreSearchPage ()
		{
			InitializeComponent ();

            // CONNECTION TO VIEWMODEL
            BindingContext = new ViewModel.BaseViewModel();
        }

        private void MainSearchBar_SearchButtonPressed(object sender, EventArgs e)
        {
            string keyword = MainSearchBar.Text;

            //CoopApi.CallApiFreetext(keyword);
        }
    }
}