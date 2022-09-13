﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit;
using Xamarin.CommunityToolkit.Extensions;
using Xamarin.Forms;

namespace popupCarouselCollectionViewHeight
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.ShowPopup(new MyPopup());
        }

        private void button_Clicked_1(object sender, EventArgs e)
        {
            var button = (Button)sender;
            button.IsVisible = false;
            button.IsVisible = true;
        }
    }
}
