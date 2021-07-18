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
    public sealed partial class turkey_videos : Page
    {
        int tapped = 0;
        int video_played = 0;
        public turkey_videos()
        {
            this.InitializeComponent();
        }

        private void turkish_flag_magic_Tapped(object sender, TappedRoutedEventArgs e)
        {
            tapped++;
            header.Text = "Welcome to Turkey";
            description.Text = "Please watch the video carefully before entering to the country";
            next_video_button.Content = "Next Video";
            if (tapped == 1)
            {
                header.Text = "Türkiye`ye Hoşgeldiniz";
                description.Text = "Ülkeye giriş yapmadan önce videoyu dikkatlice izleyiniz.";
                next_video_button.Content = "Diğer Video";
            }
            else
            {
                tapped = 0;
            }
        }

        private void next_video_button_Tapped(object sender, TappedRoutedEventArgs e)
        {
            video_played++;
            media_player.Source = new Uri("ms-appx:///Assets/turkey_turkish_airlines.mp4");
            if (video_played == 1)
            {
                media_player.Source = new Uri("ms-appx:///Assets/istanbul_experience.mp4");
            }
            else if (video_played == 2)
            {
                media_player.Source = new Uri("ms-appx:///Assets/istanbul.mp4");
            }
            else
            {
                video_played = 0;
            }
        }

        private void home_button_Tapped(object sender, TappedRoutedEventArgs e)
        {
            // Navigate to MainPage
            this.Frame.Navigate(typeof(MainPage));
        }

        private void maps_button_Tapped(object sender, TappedRoutedEventArgs e)
        {
            // Navigate to Turkey Map
            this.Frame.Navigate(typeof(turkey_map));
        }

        private void checklist_button_Tapped(object sender, TappedRoutedEventArgs e)
        {
            // Navigate to CheckList
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
