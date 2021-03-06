﻿using EdgeNote.UI.Constants;
using Xamarin.Forms;

namespace EdgeNote.UI.Controls
{
    public class ENButtonBar : ContentView
    {
        private StackLayout m_Buttons;

        public ENButtonBar()
        {
            BackgroundColor = Color.FromHex(UIConstants.ENButtonBarColor);

            m_Buttons = new StackLayout
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                Orientation = StackOrientation.Horizontal,
                Padding = 0,
                Spacing = 0,
            };

            if (Device.Idiom == TargetIdiom.Phone)
            {
                m_Buttons.Margin = new Thickness(0, 0, 0, 0);
            } else {
                m_Buttons.Margin = new Thickness(0, 0, 0, 0);
            }

            Content = m_Buttons;
        }

        public void Add(Button button)
        {
            m_Buttons.Children.Add(button);
        }

        public ENButton Add(string _text, LayoutOptions _horizontalOptions, int _width = 100)
        {
            ENButton button = new ENButton()
            {
                Text = _text,
                Margin = new Thickness(5, 0, 5, 0),
                HorizontalOptions = _horizontalOptions,
                VerticalOptions = LayoutOptions.Center,
                WidthRequest = _width,
                TextColor = Color.FromHex(UIConstants.ENButtonBarTextColor),
                FontAttributes = FontAttributes.Bold,
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Button))
            };

            m_Buttons.Children.Add(button);

            return button;
        }
    }
}

