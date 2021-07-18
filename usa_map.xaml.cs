using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Popups;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace project_travel
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class usa_map : Page
    {
        public usa_map()
        {
            this.InitializeComponent();
        }

        private void new_york_button_Tapped(object sender, TappedRoutedEventArgs e)
        {
            // Navigate to New York City
            map_usa.Navigate(new Uri("https://www.google.com/maps/@40.7387837,-74.0305259,10z"));
        }

        private void chicago_button_Tapped(object sender, TappedRoutedEventArgs e)
        {
            // Navigate to Chicago
            map_usa.Navigate(new Uri("https://www.google.com/maps/@41.8707396,-87.6267203,13.04z"));
        }

        private void washington_button_Tapped(object sender, TappedRoutedEventArgs e)
        {
            // Navigate to Washington D.C
            map_usa.Navigate(new Uri("https://www.google.com/maps/@38.9019306,-77.0411827,13.75z"));
        }

        private void los_angeles_button_Tapped(object sender, TappedRoutedEventArgs e)
        {
            // Navigate to Los Angeles
            map_usa.Navigate(new Uri("https://www.google.com/maps/@34.0421644,-118.2531615,13.31z"));
        }

        private void home_button_Tapped(object sender, TappedRoutedEventArgs e)
        {
            // Navigate to MainPage
            this.Frame.Navigate(typeof(MainPage));
        }

        private void videos_button_Tapped(object sender, TappedRoutedEventArgs e)
        {
            // Navigate to US Videos Page
            this.Frame.Navigate(typeof(usa_videos));

        }

        private void checklist_button_Tapped(object sender, TappedRoutedEventArgs e)
        {
            // Navigate to Check List Page
            this.Frame.Navigate(typeof(CheckList));
        }

        private void about_button_Tapped(object sender, TappedRoutedEventArgs e)
        {
            // Display the information about this program
            var dialog = new MessageDialog("2021 © Deniz K. Acikbas & Mohammad. This application is designed for Bon Voyage Hackathon organized by MLH.", "About");
            dialog.ShowAsync();
        }
    }
}
