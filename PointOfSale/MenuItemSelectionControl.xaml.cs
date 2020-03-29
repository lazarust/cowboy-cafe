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
using PointOfSale.CustomizationScreens;
using PointOfSale.ExtensionMethods;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MenuItemSelectionControl.xaml
    /// </summary>
    public partial class MenuItemSelectionControl : UserControl
    {
        public MenuItemSelectionControl()
        {
            InitializeComponent();
        }

        private void AddCowpokeChilliButton_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order order) {
                var item = new CowpokeChili();
                var screen = new CowpokeChiliCustomization();
                screen.DataContext = item;
                order.Add(item);
                orderControl?.SwapScreen(screen); 
            }
        }

        private void AddRusltersRibsButton_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order order) { 
                order.Add(new RustlersRibs());
            }
        }

        private void AddPecosPulledPorkButton_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order order) {
                var item = new PecosPulledPork();
                order.Add(item);
                var screen = new PecosPulledPorkCustomization();
                screen.DataContext = item;
                orderControl?.SwapScreen(screen);
            }
        }

        private void AddTrailButton_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order order) {
                var item = new TrailBurger();
                order.Add(item);
                var screen = new TrailBurgerCustomization();
                screen.DataContext = item;
                orderControl?.SwapScreen(screen);
            }
        }

        private void AddDakotaDoubleButton_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order order) {
                var item = new DakotaDoubleBurger();
                order.Add(item);
                var screen = new DakotaDoubleBurgerCustomization();
                screen.DataContext = item;
                orderControl?.SwapScreen(screen);
            }
        }

        private void AddTexasTripleButton_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order order) {
                var item = new TexasTripleBurger();
                order.Add(item);
                var screen = new TexasTripleBurgerCustomization();
                screen.DataContext = item;
                orderControl?.SwapScreen(screen);
            }
        }

        private void AddAngryChickenButton_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order order) {
                var item = new AngryChicken();
                order.Add(item);
                var screen = new AngryChickenCustomization();
                screen.DataContext = item;
                orderControl?.SwapScreen(screen);                
            }
        }

        private void AddChiliCheeseButton_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order order) {
                var item = new ChiliCheeseFries();
                order.Add(item);
                var screen = new ChiliCheeseFriesCustomization();
                screen.DataContext = item;
                orderControl?.SwapScreen(screen);
            }
        }

        private void AddCornDodgersButton_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order order) {
                var item = new CornDodgers();
                order.Add(item);
                var screen = new CornDodgersCustomization();
                screen.DataContext = item;
                orderControl?.SwapScreen(screen);
            }
        }

        private void AddPanDeCampoButton_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order order) {
                var item = new PanDeCampo();
                order.Add(item);
                var screen = new PanDeCampoCustomization();
                screen.DataContext = item;
                orderControl?.SwapScreen(screen);
            }
        }

        private void AddBakedBeansButton_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order order) {
                var item = new BakedBeans();
                order.Add(item);
                var screen = new BakedBeansCustomization();
                screen.DataContext = item;
                orderControl?.SwapScreen(screen);
            }
        }

        private void AddJerkedSodaButton_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order order) {
                var item = new JerkedSoda();   
                order.Add(item);
                var screen = new JerkedSodaCustomization();
                screen.DataContext = item;
                orderControl?.SwapScreen(screen);
            }
        }

        private void AddTexasTeaButton_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order order) {
                var item = new TexasTea();
                order.Add(item);
                var screen = new TexasTeaCustomization();
                screen.DataContext = item;
                orderControl?.SwapScreen(screen);
            }
        }

        private void AddCowboyCoffeeButton_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order order) {
                var item = new CowboyCoffee();    
                order.Add(item);
                var screen = new CowboyCoffeeCustomization();
                screen.DataContext = item;
                orderControl?.SwapScreen(screen);
                    
            }
        }

        private void AddWaterButton_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order order) {
                var item = new Water();
                order.Add(item);
                var screen = new WaterCustomization();
                screen.DataContext = item;
                orderControl?.SwapScreen(screen);
            }
        }
    }
}
