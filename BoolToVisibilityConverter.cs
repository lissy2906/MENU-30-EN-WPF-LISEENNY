﻿using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace ProyectoEjerciciosWPF
{
    public class BoolToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var text = value as string;
            return string.IsNullOrWhiteSpace(text) ? Visibility.Visible : Visibility.Collapsed;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
