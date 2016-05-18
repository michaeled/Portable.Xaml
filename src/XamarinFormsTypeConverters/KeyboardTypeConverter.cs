﻿using System;
using Xamarin.Forms;

namespace XamarinFormsTypeConverters
{
    public class XamlKeyboardTypeConverter : Portable.Xaml.ComponentModel.TypeConverter
    {
        private readonly KeyboardTypeConverter _converter;

        public XamlKeyboardTypeConverter()
        {
            _converter = new KeyboardTypeConverter();
        }

        public override bool CanConvertFrom(Type sourceType)
        {
            return _converter.CanConvertFrom(sourceType);
        }

        public override object ConvertFrom(object o)
        {
            return _converter.ConvertFromInvariantString(o as string);
        }

        public override bool CanConvertTo(Type destinationType)
        {
            return destinationType == typeof(string);
        }

        public override object ConvertTo(object value, Type destinationType)
        {
            var o = (Keyboard) value;
  
            if (o == Keyboard.Chat)
            {
                return "Keyboard.Chat";
            }
            if (o == Keyboard.Default)
            {
                return "Keyboard.Default";
            }
            if (o == Keyboard.Email)
            {
                return "Keyboard.Email";
            }
            if (o == Keyboard.Url)
            {
                return "Keyboard.Url";
            }
            if (o == Keyboard.Numeric)
            {
                return "Keyboard.Numeric";
            }
            if (o == Keyboard.Telephone)
            {
                return "Keyboard.Telephone";
            }
            if (o == Keyboard.Text)
            {
                return "Keyboard.Text";
            }

            return string.Empty;
        }
    }
}