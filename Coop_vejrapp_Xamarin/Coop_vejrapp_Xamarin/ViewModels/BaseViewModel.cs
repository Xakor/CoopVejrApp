using System.Runtime.CompilerServices;
using System.ComponentModel;
using Coop_vejrapp_Xamarin.Model;
using System.Windows.Input;
using Coop_vejrapp_Xamarin.Common;

namespace Coop_vejrapp_Xamarin.ViewModel
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        
        public BaseViewModel()
        {
            
        }

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
