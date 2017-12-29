using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Coop_vejrapp_Xamarin.Services;

using Xamarin.Forms;
using Coop_vejrapp_Xamarin.Model;
using Coop_vejrapp_Xamarin.ViewModel;

namespace Coop_vejrapp_Xamarin.Views
{
	public class LandingPage : TabbedPage
	{
		public LandingPage ()
        {
            Title = "Coop Vejrapp";
            Children.Add(new MyStoresPage());
            Children.Add(new AllStoresPage());
            Children.Add(new StoreSearchPage());

            ToolbarItem tbi = new ToolbarItem();
            tbi.Priority = 0;
            tbi.Text = "Filter";
            tbi.Icon = "../Assets/Icons/filter.png";
            tbi.Clicked += tbi_Clicked;
            this.ToolbarItems.Add(tbi);
        }

        async void tbi_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Hello World", "Shit's on fire yo!.", "OK");
        }
    }
}