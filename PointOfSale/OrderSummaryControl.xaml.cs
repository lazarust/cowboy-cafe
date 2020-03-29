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
using PointOfSale.CustomizationScreens;
using PointOfSale.ExtensionMethods;
using CowboyCafe.Data;
using System.Linq;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderSummaryControl.xaml
    /// </summary>
    public partial class OrderSummaryControl : UserControl
    {
        public OrderSummaryControl()
        {
            InitializeComponent();
        }


        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var item = (sender as ListBox).SelectedItem;
            if (item == null) return;

            if (item is AngryChicken)
            {
                var screen = new AngryChickenCustomization();
                (screen as FrameworkElement).DataContext = item;
                var orderControl = this.FindAncestor<OrderControl>();
                orderControl?.SwapScreen(screen as FrameworkElement);
            }
            else if (item is BakedBeans)
            {
                var screen = new BakedBeansCustomization();
                (screen as FrameworkElement).DataContext = item;
                var orderControl = this.FindAncestor<OrderControl>();
                orderControl?.SwapScreen(screen as FrameworkElement);
            }
            else if (item is ChiliCheeseFries)
            {
                var screen = new ChiliCheeseFriesCustomization();
                (screen as FrameworkElement).DataContext = item;
                var orderControl = this.FindAncestor<OrderControl>();
                orderControl?.SwapScreen(screen as FrameworkElement);
            }
            else if (item is CornDodgers)
            {
                var screen = new CornDodgersCustomization();
                (screen as FrameworkElement).DataContext = item;
                var orderControl = this.FindAncestor<OrderControl>();
                orderControl?.SwapScreen(screen as FrameworkElement);
            }
            else if (item is CowboyCoffee)
            {
                var screen = new CowboyCoffeeCustomization();
                (screen as FrameworkElement).DataContext = item;
                var orderControl = this.FindAncestor<OrderControl>();
                orderControl?.SwapScreen(screen as FrameworkElement);
            }
            else if (item is CowpokeChili)
            {
                var screen = new CowpokeChiliCustomization();
                (screen as FrameworkElement).DataContext = item;
                var orderControl = this.FindAncestor<OrderControl>();
                orderControl?.SwapScreen(screen as FrameworkElement);
            }
            else if (item is DakotaDoubleBurger)
            {
                var screen = new DakotaDoubleBurgerCustomization();
                (screen as FrameworkElement).DataContext = item;
                var orderControl = this.FindAncestor<OrderControl>();
                orderControl?.SwapScreen(screen as FrameworkElement);
            }
            else if (item is JerkedSoda)
            {
                var screen = new JerkedSodaCustomization();
                (screen as FrameworkElement).DataContext = item;
                var orderControl = this.FindAncestor<OrderControl>();
                orderControl?.SwapScreen(screen as FrameworkElement);
            }
            else if (item is PanDeCampo)
            {
                var screen = new PanDeCampoCustomization();
                (screen as FrameworkElement).DataContext = item;
                var orderControl = this.FindAncestor<OrderControl>();
                orderControl?.SwapScreen(screen as FrameworkElement);
            }
            else if (item is PecosPulledPork)
            {
                var screen = new PecosPulledPorkCustomization();
                (screen as FrameworkElement).DataContext = item;
                var orderControl = this.FindAncestor<OrderControl>();
                orderControl?.SwapScreen(screen as FrameworkElement);
            }
            else if (item is TexasTea)
            {
                var screen = new TexasTeaCustomization();
                (screen as FrameworkElement).DataContext = item;
                var orderControl = this.FindAncestor<OrderControl>();
                orderControl?.SwapScreen(screen as FrameworkElement);
            }
            else if (item is TexasTripleBurger)
            {
                var screen = new TexasTripleBurgerCustomization();
                (screen as FrameworkElement).DataContext = item;
                var orderControl = this.FindAncestor<OrderControl>();
                orderControl?.SwapScreen(screen as FrameworkElement);
            }
            else if (item is TrailBurger)
            {
                var screen = new TrailBurgerCustomization();
                (screen as FrameworkElement).DataContext = item;
                var orderControl = this.FindAncestor<OrderControl>();
                orderControl?.SwapScreen(screen as FrameworkElement);
            }
            else if (item is Water)
            {
                var screen = new WaterCustomization();
                (screen as FrameworkElement).DataContext = item;
                var orderControl = this.FindAncestor<OrderControl>();
                orderControl?.SwapScreen(screen as FrameworkElement);
            }
            else
            {
                return;
            }
        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            Order items = DataContext as Order;
            var item = (e.OriginalSource as FrameworkElement).DataContext;
            items.Remove(item as IOrderItem);
            var screen = new MenuItemSelectionControl();
            var orderControl = this.FindAncestor<OrderControl>();
            orderControl?.SwapScreen(screen);
        }
    }
}
