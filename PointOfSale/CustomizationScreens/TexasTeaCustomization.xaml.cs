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
    /// Interaction logic for TexasTeaCustomization.xaml
    /// </summary>
    public partial class TexasTeaCustomization : UserControl
    {
        public TexasTeaCustomization()
        {
            InitializeComponent();
        }

        private void TeaSmall_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is TexasTea tt) tt.Size = CowboyCafe.Data.Size.Small;
        }

        private void TeaMed_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is TexasTea tt) tt.Size = CowboyCafe.Data.Size.Medium;
        }

        private void TeaLarge_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is TexasTea tt) tt.Size = CowboyCafe.Data.Size.Large;
        }
    }
}
