/*
 * Author: Thomas Lazarus
 * Class: BakedBeansCustomization
 * Purpose: Handle the baked beans side screen
 */
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
    /// Interaction logic for BakedBeansCustomization.xaml
    /// </summary>
    public partial class BakedBeansCustomization : UserControl
    {
        public BakedBeansCustomization()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Changes size of beans to small
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BeanSamll_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is BakedBeans bb)
            {
                bb.Size = CowboyCafe.Data.Size.Small;
            }
        }

        /// <summary>
        /// Changes  size of beans to medium
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BeanMed_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is BakedBeans bb)
            {
                bb.Size = CowboyCafe.Data.Size.Medium;
            }
        }

        /// <summary>
        /// Changes size of beans to large
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BeanLarge_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is BakedBeans bb)
            {
                bb.Size = CowboyCafe.Data.Size.Large;
            }
        }
    }
}
