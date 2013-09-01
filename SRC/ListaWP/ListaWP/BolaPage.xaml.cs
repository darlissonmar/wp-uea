using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using ListaWP.Resources;

namespace ListaWP
{
    public partial class BolaPage : PhoneApplicationPage
    {
        // Constructor
        public Bola bola;

        public BolaPage()
        {
            InitializeComponent();
            bola = new Bola("White");
            xamlBola.DataContext = bola;
            
            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        private void btnAzul_Click(object sender, RoutedEventArgs e)
        {

            bola.Cor = "Blue";
        }

        private void btnVioleta_Click(object sender, RoutedEventArgs e)
        {
            bola.Cor = "Violet";
        }

        private void btnVermelho_Click(object sender, RoutedEventArgs e)
        {
            bola.Cor = "Red";
        }

        private void btnLaranja_Click(object sender, RoutedEventArgs e)
        {
            bola.Cor = "Orange";
        }

        private void btnVerde_Click(object sender, RoutedEventArgs e)
        {
            bola.Cor = "Green";
        }

        // Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}