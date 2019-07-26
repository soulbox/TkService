using System;
using System.Collections.Generic;
using System.Text;

namespace TekService.Data
{
    using System.Globalization;
    using Xamarin.Forms;

    class imageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return ImageSource.FromResource("TekService.images." + (value ?? ""));
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
