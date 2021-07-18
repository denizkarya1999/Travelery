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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace project_travel
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        // Create a listbox for USA, UK and Turkey
        List<string> countries_list = new List<string>();

        public static string selected_country; 
 
        public MainPage()
        {
            this.InitializeComponent();

            // Add countries to the countries_list
            countries_list.Add("United States of America");
            countries_list.Add("United Kingdom");
            countries_list.Add("Republic of Turkey");

            // Add countries to the combobox
            foreach (string country in countries_list)
            {
                countries_combobox.Items.Add(country);
            }
        }

        private void next_button_Tapped(object sender, TappedRoutedEventArgs e)
        {
            // Assign the countries to selected_country value if none of those selected display a message
            // Also navigate to maps of those countries
            if(countries_combobox.SelectedItem == "United States of America")
            {
                selected_country = "United States of America";
                this.Frame.Navigate(typeof(usa_map));
            } 
            else if (countries_combobox.SelectedItem == "United Kingdom")
            {
                selected_country = "United Kingdom";
                this.Frame.Navigate(typeof(uk_map));
            }
            else if (countries_combobox.SelectedItem == "Republic of Turkey")
            {
                selected_country = "Republic of Turkey";
                this.Frame.Navigate(typeof(turkey_map));
            }
            else
            {
                var dialog = new MessageDialog("Please select a country from the list. If your country is not on the list wait for new developments on this program.", "Error: Select Country");
                dialog.ShowAsync();
            }
        }
    }
}
