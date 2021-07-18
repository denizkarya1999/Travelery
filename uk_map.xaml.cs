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
    public sealed partial class uk_map : Page
    {
        public uk_map()
        {
            this.InitializeComponent();
        }

        private void london_button_Tapped(object sender, TappedRoutedEventArgs e)
        {
            // Navigate to London
            map_uk.Navigate(new Uri("https://www.google.com/maps/@51.5076653,-0.1289506,13.27z"));
        }

        private void manchester_button_Tapped(object sender, TappedRoutedEventArgs e)
        {
            // Navigate to Manchester
            map_uk.Navigate(new Uri("https://www.google.com/maps/@53.4789403,-2.2433585,14.38z"));
        }

        private void liverpool_button_Tapped(object sender, TappedRoutedEventArgs e)
        {
            // Navigate to Liverpool
            map_uk.Navigate(new Uri("https://www.google.com/maps/@53.4066963,-2.9833408,14.12z"));
        }

        private void birmingham_button_Tapped(object sender, TappedRoutedEventArgs e)
        {
            map_uk.Navigate(new Uri("https://www.google.com/maps/@52.4789057,-1.8924373,14.23z"));
        }

        private void about_button_Tapped(object sender, TappedRoutedEventArgs e)
        {
            // Display the information about this program
            var dialog = new MessageDialog("2021 © Deniz K. Acikbas & Mohammad. This application is designed for Bon Voyage Hackathon organized by MLH.", "About");
            dialog.ShowAsync();
        }

        private void home_button_Tapped(object sender, TappedRoutedEventArgs e)
        {
            // Navigate to MainPage
            this.Frame.Navigate(typeof(MainPage));
        }

        private void checklist_button_Tapped(object sender, TappedRoutedEventArgs e)
        {
            // Navigate to CheckList
            this.Frame.Navigate(typeof(CheckList));
        }

        private void videos_button_Tapped(object sender, TappedRoutedEventArgs e)
        {
            // Navigate to uk videos
            this.Frame.Navigate(typeof(uk_videos));
        }
    }
}
