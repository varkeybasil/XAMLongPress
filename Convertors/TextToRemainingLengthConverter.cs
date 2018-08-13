using System;
using System.Globalization;
using Xamarin.Forms;

namespace Test_LimitText.Convertors
{
    public class TextToRemainingLengthConverter : IValueConverter
    {
        public TextToRemainingLengthConverter()
        {
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            try
            {
              if (!(value is string))
                    return 0;

                return  "You can enter " + (20 - ((string)value).Length).ToString() +" more characters";
            }
            catch (Exception ex)
            {
            }
            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
