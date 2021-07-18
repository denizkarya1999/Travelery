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
    public sealed partial class turkey_map : Page
    {
        public turkey_map()
        {
            this.InitializeComponent();
        }

        private void istanbul_button_Tapped(object sender, TappedRoutedEventArgs e)
        {
            // Navigate to Istanbul
            map_usa.Navigate(new Uri("https://www.google.com/maps/@41.0305481,28.9839573,12.86z"));
        }

        private void ankara_button_Tapped(object sender, TappedRoutedEventArgs e)
        {
            // Navigate to Ankara
            map_usa.Navigate(new Uri("https://www.google.com/maps/@39.9352224,32.8587776,13.49z"));
        }

        private void izmir_button_Tapped(object sender, TappedRoutedEventArgs e)
        {
            // Navigate to Izmir
            map_usa.Navigate(new Uri("https://www.google.com/maps/@38.42346,27.1393985,13.76z"));
        }

        private void antalya_button_Tapped(object sender, TappedRoutedEventArgs e)
        {
            // Navigate to Antalya
            map_usa.Navigate(new Uri("https://www.google.com/maps/@36.8924769,30.7115646,13.9z"));
        }

        private void home_button_Tapped(object sender, TappedRoutedEventArgs e)
        {
            // Navigate to MainPage
            this.Frame.Navigate(typeof(MainPage));
        }

        private void about_button_Tapped(object sender, TappedRoutedEventArgs e)
        {
            // Display the information about this program
            var dialog = new MessageDialog("2021 © Deniz K. Acikbas & Mohammad. This application is designed for Bon Voyage Hackathon organized by MLH.", "About");
            dialog.ShowAsync();
        }

        private void checklist_button_Tapped(object sender, TappedRoutedEventArgs e)
        {
            // Navigate to CheckList
            this.Frame.Navigate(typeof(CheckList));
        }

        private void videos_button_Tapped(object sender, TappedRoutedEventArgs e)
        {
            // Navigate to Turkey Videos
            this.Frame.Navigate(typeof(turkey_videos));
        }
    }
}
