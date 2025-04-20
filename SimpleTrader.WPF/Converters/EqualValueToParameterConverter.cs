﻿using SimpleTrader.WPF.VVM.ViewModels;
using System.Globalization;
using System.Windows.Data;

namespace SimpleTrader.WPF.Converters
{
    public class EqualValueToParameterConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if(value is BaseViewModel baseViewModel && 
                parameter != null)
            {
                if(parameter.ToString()
                    .Equals(baseViewModel
                        .GetType().Name))
                {
                       return true;
                }
            }

            return false;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
