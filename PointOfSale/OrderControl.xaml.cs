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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {
        public OrderControl()
        {
            InitializeComponent();
        }

        public TransactionControl screen = new TransactionControl();

        private void CancelOrder_Click(object sender, RoutedEventArgs e)
        {
            this.DataContext = new Order();
        }

        private void CompleteOrder_Click(object sender, RoutedEventArgs e)
        {
            screen.DataContext = this.DataContext;
            this.CompleteOrder.IsEnabled = false;
            this.CancelOrder.IsEnabled = false;
            this.ItemSelection.IsEnabled = false;
            SwapScreen(screen);
        }

        public void SwapScreen(FrameworkElement element)
        {
            Container.Child = element;
        }

        private void ItemSelection_Click(object sender, RoutedEventArgs e)
        {
            Container.Child = new MenuItemSelectionControl();
        }
    }
}
