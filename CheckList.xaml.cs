using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace project_travel
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CheckList : Page
    {
        private ObservableCollection<Task> listOfTasksBefore = new ObservableCollection<Task>();
        private ObservableCollection<Task> listOfTasksWhile = new ObservableCollection<Task>();
        private ObservableCollection<Task> listOfTasksAfter = new ObservableCollection<Task>();

        private int beforeCheckedCount = 0;
        private int whileCheckedCount = 0;
        private int afterCheckedCount = 0;
        public CheckList()
        {
            this.InitializeComponent();
            listOfTasksBefore.Add(new Task { Name = "Get a passport" });
            listOfTasksBefore.Add(new Task { Name = "Get visa (if required)" });
            listOfTasksBefore.Add(new Task { Name = "Get all the required documents" });
            listOfTasksBefore.Add(new Task { Name = "Get tested for COVID-19 (don`t forget to get vaccinated as well) " });
            listOfTasksBefore.Add(new Task { Name = "Get enough cash for your travel" });
            listOfTasksBefore.Add(new Task { Name = "Convert your money to native country`s currency" });
            listOfTasksBefore.Add(new Task { Name = "Find a hotel" });
            listOfTasksBefore.Add(new Task { Name = "Get a flight ticket" });

            listOfTasksWhile.Add(new Task { Name = "Check in at the airport 2 hours before flight" });
            listOfTasksWhile.Add(new Task { Name = "Say `Goodbye` to your loved ones" });
            listOfTasksWhile.Add(new Task { Name = "Enjoy your flight!" });
            listOfTasksWhile.Add(new Task { Name = "Prepare your documents for passport control" });
            listOfTasksWhile.Add(new Task { Name = "Politely answer passport police`s questions" });
            listOfTasksWhile.Add(new Task { Name = "Get your baggage" });

            listOfTasksAfter.Add(new Task { Name = "Find a cab or public transit to your hotel" });
            listOfTasksAfter.Add(new Task { Name = "Lock your passport and other important documents" });
            listOfTasksAfter.Add(new Task { Name = "Quarantine for 14 days!" });
            listOfTasksWhile.Add(new Task { Name = "Get tested for COVID-19" });


            beforeList.ItemsSource = listOfTasksBefore;
            whileList.ItemsSource = listOfTasksWhile;
            afterList.ItemsSource = listOfTasksAfter;
        }

        private void beforeBtnTapped(object sender, TappedRoutedEventArgs e)
        {
            if (addBeforeTextBox.Text != "")
            {
                listOfTasksBefore.Add(new Task { Name = addBeforeTextBox.Text });
                beforeList.ItemsSource = listOfTasksBefore;
                addBeforeTextBox.Text = "";
            }
        }

        private void whileBtnTapped(object sender, TappedRoutedEventArgs e)
        {
            if (addWhileTextBox.Text != "")
            {
                listOfTasksWhile.Add(new Task { Name = addWhileTextBox.Text });
                whileList.ItemsSource = listOfTasksWhile;
                addWhileTextBox.Text = "";
            }
        }

        private void afterBtnTapped(object sender, TappedRoutedEventArgs e)
        {
            if (addAfterTextBox.Text != "")
            {
                listOfTasksAfter.Add(new Task { Name = addAfterTextBox.Text });
                afterList.ItemsSource = listOfTasksAfter;
                addAfterTextBox.Text = "";

            }
        }

        private void afterChecked(object sender, RoutedEventArgs e)
        {
            afterCheckedCount++;
        }

        private void afterUnchecked(object sender, RoutedEventArgs e)
        {
            afterCheckedCount--;
        }

        private void whileChecked(object sender, RoutedEventArgs e)
        {
            whileCheckedCount++;
        }

        private void whileUnchecked(object sender, RoutedEventArgs e)
        {
            whileCheckedCount--;
        }

        private void beforeChecked(object sender, RoutedEventArgs e)
        {
            beforeCheckedCount++;
        }

        private void beforeUnchecked(object sender, RoutedEventArgs e)
        {
            beforeCheckedCount--;
        }

        private void beforeListCompleteTapped(object sender, TappedRoutedEventArgs e)
        {
            var dialog = new MessageDialog("");
            if (beforeCheckedCount == listOfTasksBefore.Count())
            {
                dialog = new MessageDialog("Horray, you can travel!");
            }
            else
            {
                dialog = new MessageDialog("Sorry, you must check all items to be able to travel!");
            }

            dialog.ShowAsync();
        }
        private void whileListCompleteTapped(object sender, TappedRoutedEventArgs e)
        {
            var dialog = new MessageDialog("");
            if (whileCheckedCount == listOfTasksWhile.Count())
            {
                dialog = new MessageDialog("Horray, you completed all your goals!");
            }
            else
            {
                dialog = new MessageDialog("Ugggh, looks like you still have some tasks to complete.");
            }

            dialog.ShowAsync();
        }
        private void afterListCompleteTapped(object sender, TappedRoutedEventArgs e)
        {
            var dialog = new MessageDialog("");
            if (beforeCheckedCount == listOfTasksBefore.Count())
            {
                dialog = new MessageDialog("Horray, now you are all done!");
            }
            else
            {
                dialog = new MessageDialog("Oh no, you still have some tasks to complete");
            }

            dialog.ShowAsync();
        }

        private void home_button_Tapped(object sender, TappedRoutedEventArgs e)
        {
            // Navigate to MainPage
            this.Frame.Navigate(typeof(MainPage));
        }

        private void maps_button_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (MainPage.selected_country.Equals("United States of America"))
            {
                this.Frame.Navigate(typeof(usa_map));
            } else if (MainPage.selected_country.Equals("United Kingdom"))
            {
                this.Frame.Navigate(typeof(uk_map));
            }
            else if (MainPage.selected_country.Equals("Republic of Turkey"))
            {
                this.Frame.Navigate(typeof(turkey_map));
            }
        }

        private void videos_button_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (MainPage.selected_country.Equals("United States of America"))
            {
                this.Frame.Navigate(typeof(usa_videos));
            }
            else if (MainPage.selected_country.Equals("United Kingdom"))
            {
                this.Frame.Navigate(typeof(uk_videos));
            }
            else if (MainPage.selected_country.Equals("Republic of Turkey"))
            {
                this.Frame.Navigate(typeof(turkey_videos));
            }
        }

        private void about_button_Tapped(object sender, TappedRoutedEventArgs e)
        {
            // Display the information about this program
            var dialog = new MessageDialog("2021 © Deniz K. Acikbas & Mohammad. This application is designed for Bon Voyage Hackathon organized by MLH.", "About");
            dialog.ShowAsync();
        }
    }

    public class Task
    {
        public string Name { get; set; }
    }
}
