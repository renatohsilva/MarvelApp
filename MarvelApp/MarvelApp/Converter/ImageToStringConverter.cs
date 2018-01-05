﻿using MarvelApp.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace MarvelApp.Converter
{
    public class ImageToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType,
                         object parameter, CultureInfo culture)
        {
            if ((ImageUrl)value == null)
                return "";

            return ((ImageUrl)value).ToString();
        }

        public object ConvertBack(object value, Type targetType,
                                  object parameter, CultureInfo culture)
        {
            ImageUrl image = new ImageUrl();

            if (value != null)
            {
                List<String> palavrasImagem = value.ToString().Split('.').ToList();

                var extensao = palavrasImagem.LastOrDefault();
                palavrasImagem.Remove(extensao);

                var path = String.Join(".", palavrasImagem);

                image = new ImageUrl(extensao, path);
            }
                


            return image;
        }
    }
}
