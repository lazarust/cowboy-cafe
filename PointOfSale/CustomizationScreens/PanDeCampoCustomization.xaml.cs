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
    /// Interaction logic for PanDeCampoCustomization.xaml
    /// </summary>
    public partial class PanDeCampoCustomization : UserControl
    {
        public PanDeCampoCustomization()
        {
            InitializeComponent();
        }

        private void PanDeCampSmall_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is PanDeCampo pdc) pdc.Size = CowboyCafe.Data.Size.Small;
        }

        private void PanDeCampoMed_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is PanDeCampo pdc) pdc.Size = CowboyCafe.Data.Size.Medium;
        }

        private void PanDeCampoLarge_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is PanDeCampo pdc) pdc.Size = CowboyCafe.Data.Size.Large;
        }
    }
}
