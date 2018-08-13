using System;
using System.ComponentModel;
using System.Windows.Input;

using Xamarin.Forms;

namespace Test_LimitText.ViewModels
{
    public class AboutViewModel : BaseViewModel , INotifyPropertyChanged
    {
        public string _length;
        public string Length
        {
            get
            {
                return _length;
            }
            set
            {
                if (_length != value)
                {
                    _length = value;
                    OnPropertyChanged("Length");
                }
            }
        }

        public AboutViewModel()
        {
            Title = "About";

            OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://xamarin.com/platform")));
            ItemLongPressCommand = new Command(() => Device.OpenUri(new Uri("https://google.com")));
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand OpenWebCommand { get; }
        public ICommand ItemLongPressCommand { get; }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            var changed = PropertyChanged;
            if (changed != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    
    }
}