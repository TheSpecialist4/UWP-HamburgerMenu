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
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace HamburgerHeaven
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            hamburgerSplitView.IsPaneOpen = !hamburgerSplitView.IsPaneOpen;
        }

        private void searchButton_Click(object sender, RoutedEventArgs e) {

        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            var listBox = sender as ListBox;
            var selectedItem = listBox.SelectedItem as ListBoxItem;
            if (selectedItem.Name == "foodItem") {
                dummyImage.Source = new BitmapImage(new Uri(BaseUri, "Assets/Food.png"));
                pageNameTxtBlock.Text = "Food";
                backArrowButton.Visibility = Visibility.Visible;
            } else {
                if (dummyImage != null) {
                    dummyImage.Source = new BitmapImage(new Uri(BaseUri, "Assets/Financial.png"));
                }
                pageNameTxtBlock.Text = "Finance";
                backArrowButton.Visibility = Visibility.Collapsed;
            }
            hamburgerSplitView.IsPaneOpen = false;
        }

        private void backArrow_Click(object sender, RoutedEventArgs e) {
            if (Frame.CanGoBack) {
                Frame.GoBack();
            }
        }
    }
}
