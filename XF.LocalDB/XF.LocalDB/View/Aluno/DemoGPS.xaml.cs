﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;
using Plugin.Geolocator;


namespace Tp_Final
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DemoGPS : ContentPage
    {
        public DemoGPS()
        {
            InitializeComponent();
        }
        private async void GetPosition(object sender, EventArgs e)
        {
            var locator = CrossGeolocator.Current;
            locator.DesiredAccuracy = 50;

            var position = await locator.GetPositionAsync(TimeSpan.FromSeconds(10));

            LongitudeLabel.Text = string.Format("{0:0.0000000}", position.Longitude);
            LatitudeLabel.Text = string.Format("{0:0.0000000}", position.Latitude);
        }
    }
}