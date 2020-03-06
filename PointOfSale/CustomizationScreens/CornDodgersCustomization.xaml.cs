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
    /// Interaction logic for CornDodgersCustomization.xaml
    /// </summary>
    public partial class CornDodgersCustomization : UserControl
    {
        public CornDodgersCustomization()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Change size of dodgers to small
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CornMed_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is CornDodgers cd) cd.Size = CowboyCafe.Data.Size.Medium;
        }

        /// <summary>
        /// Change size of dodgers to medium
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CornSmall_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is CornDodgers cd) cd.Size = CowboyCafe.Data.Size.Small;
        }

        /// <summary>
        /// Change size of dodgers to large
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CornLarge_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is CornDodgers cd) cd.Size = CowboyCafe.Data.Size.Large;
        }
    }
}
