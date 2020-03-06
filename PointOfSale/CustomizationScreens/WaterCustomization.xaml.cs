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
    /// Interaction logic for WaterCustomization.xaml
    /// </summary>
    public partial class WaterCustomization : UserControl
    {
        public WaterCustomization()
        {
            InitializeComponent();
        }

        private void WaterSmall_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Water w) w.Size = CowboyCafe.Data.Size.Small;
        }

        private void WaterLarge_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Water w) w.Size = CowboyCafe.Data.Size.Large;
        }

        private void WaterMed_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Water w) w.Size = CowboyCafe.Data.Size.Medium;
        }
    }
}
