using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CowboyCafe.Data;

namespace PointOfSale.CustomizationScreens
{
    /// <summary>
    /// Interaction logic for CowboyCoffeeCustomization.xaml
    /// </summary>
    public partial class CowboyCoffeeCustomization : UserControl
    {
        public CowboyCoffeeCustomization()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Changes the size of the coffee to small
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CoffeeSmall_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is CowboyCoffee cc) cc.Size = CowboyCafe.Data.Size.Small;
        }

        /// <summary>
        /// Changes the size of the coffee to medium
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CoffeeMed_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is CowboyCoffee cc) cc.Size = CowboyCafe.Data.Size.Medium;
        }

        /// <summary>
        /// Change the size of the coffee to large
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CoffeeLarge_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is CowboyCoffee cc) cc.Size = CowboyCafe.Data.Size.Large;
        }
    }
}
