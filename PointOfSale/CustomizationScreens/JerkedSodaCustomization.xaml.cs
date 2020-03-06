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
    /// Interaction logic for JerkedSodaCustomization.xaml
    /// </summary>
    public partial class JerkedSodaCustomization : UserControl
    {
        public JerkedSodaCustomization()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Sets jerked soda flavor to cream soda
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreamSoda_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is JerkedSoda js) js.Flavor = SodaFlavor.CreamSoda;
        }

        /// <summary>
        /// Sets jerked soda flavor to birch beer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BirchBeer_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is JerkedSoda js) js.Flavor = SodaFlavor.BirchBeer;
        }

        /// <summary>
        /// Sets jerked soda flavor to orange soda
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OrangeSoda_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is JerkedSoda js) js.Flavor = SodaFlavor.OrangeSoda;
        }

        /// <summary>
        /// Sets jerked soda flavor to sarsparilla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Sarsparilla_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is JerkedSoda js) js.Flavor = SodaFlavor.Sarsparilla;
        }

        /// <summary>
        /// Sets jerked soda flavor to root beer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RootBeer_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is JerkedSoda js) js.Flavor = SodaFlavor.RootBeer;
        }

        /// <summary>
        /// Sets the size of the jerked soda to small
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SodaSmall_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is JerkedSoda js) js.Size = CowboyCafe.Data.Size.Small;
        }

        /// <summary>
        /// Sets the size of the jerked soda to medium
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SodaMed_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is JerkedSoda js) js.Size = CowboyCafe.Data.Size.Medium;
        }

        /// <summary>
        /// Sets the size of the jerked soda to large
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SodaLarge_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is JerkedSoda js) js.Size = CowboyCafe.Data.Size.Large;
        }
    }
}
