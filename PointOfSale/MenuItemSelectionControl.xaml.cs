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
            if (DataContext is Order order) { order.Add(new CowpokeChili()); };
        }

        private void AddRusltersRibsButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order) { order.Add(new RustlersRibs()); };
        }

        private void AddPecosPulledPorkButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order) { order.Add(new PecosPulledPork()); };
        }

        private void AddTrailButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order) { order.Add(new TrailBurger()); };
        }

        private void AddDakotaDoubleButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order) { order.Add(new DakotaDoubleBurger()); };
        }

        private void AddTexasTripleButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order) { order.Add(new TexasTripleBurger()); };
        }

        private void AddAngryChickenButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order) { order.Add(new AngryChicken()); };
        }

        private void AddChiliCheeseButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order) { order.Add(new ChiliCheeseFries()); };
        }

        private void AddCornDodgersButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order) { order.Add(new CornDodgers()); };
        }

        private void AddPanDeCampoButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order) { order.Add(new PanDeCampo()); };
        }

        private void AddBakedBeansButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order) { order.Add(new BakedBeans()); };
        }

        private void AddJerkedSodaButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order) { order.Add(new JerkedSoda()); };
        }

        private void AddTexasTeaButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order) { order.Add(new TexasTea()); };
        }

        private void AddCowboyCoffeeButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order) { order.Add(new CowboyCoffee()); };
        }

        private void AddWaterButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order) { order.Add(new Water()); };
        }
    }
}
