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
    /// Interaction logic for ChiliCheeseFriesCustomization.xaml
    /// </summary>
    public partial class ChiliCheeseFriesCustomization : UserControl
    {
        public ChiliCheeseFriesCustomization()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Change size of fries to small
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FriesSmall_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is ChiliCheeseFries cc) cc.Size = CowboyCafe.Data.Size.Small;
        }

        /// <summary>
        /// Change size of fries to medium
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FriesMed_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is ChiliCheeseFries cc) cc.Size = CowboyCafe.Data.Size.Medium;
        }

        /// <summary>
        /// Change size of fries to large
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FriesLarge_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is ChiliCheeseFries cc) cc.Size = CowboyCafe.Data.Size.Large;
        }
    }
}
