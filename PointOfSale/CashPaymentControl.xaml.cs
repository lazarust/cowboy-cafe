/*
 * Author: Thomas Lazarus
 * Class: CashPaymentControl
 */
using PointOfSale.ExtensionMethods;
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
using CashRegister;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CashPaymentControl.xaml
    /// </summary>
    public partial class CashPaymentControl : UserControl
    {
        public CashPaymentControl()
        {
            InitializeComponent();
            CompleteOrder.IsEnabled = false;
        }

        private double TTotal;

        /// <summary>
        /// Complete Order Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CompleteOrder_Click(object sender, RoutedEventArgs e)
        {
            Button_Click(sender, e);
            var orderControl = this.FindAncestor<OrderControl>();
            var transactionControl = orderControl.screen;
            transactionControl.cashDrawer.AddBill(Bills.One, One.quant);
            transactionControl.cashDrawer.AddBill(Bills.Two, Two.quant);
            transactionControl.cashDrawer.AddBill(Bills.Five, Five.quant);
            transactionControl.cashDrawer.AddBill(Bills.Ten, Ten.quant);
            transactionControl.cashDrawer.AddBill(Bills.Twenty, Twenty.quant);
            transactionControl.cashDrawer.AddBill(Bills.Fifty, Fifty.quant);
            transactionControl.cashDrawer.AddBill(Bills.Hundred, Hundred.quant);
            transactionControl.cashDrawer.AddCoin(Coins.Penny, Penny.quant);
            transactionControl.cashDrawer.AddCoin(Coins.Dime, Dime.quant);
            transactionControl.cashDrawer.AddCoin(Coins.Nickel, Nickel.quant);
            transactionControl.cashDrawer.AddCoin(Coins.Quarter, Quarter.quant);
            transactionControl.cashDrawer.AddCoin(Coins.HalfDollar, HalfDollar.quant);
            transactionControl.cashDrawer.AddCoin(Coins.Dollar, Dollar.quant);
            transactionControl?.PayCash(TTotal, (transactionControl.DataContext as Order).Total);
            orderControl.DataContext = new Order();
            orderControl.CompleteOrder.IsEnabled = true;
            orderControl.CancelOrder.IsEnabled = true;
            orderControl.ItemSelection.IsEnabled = true;
            orderControl?.SwapScreen(new MenuItemSelectionControl());
        }

        /// <summary>
        /// Button Click event for adding and subtracting
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Button_Click(object sender, RoutedEventArgs e)
        {
            var one = One.quant;
            var two = Two.quant * 2;
            var five = Five.quant * 5;
            var ten = Ten.quant * 10;
            var twenty = Twenty.quant * 20;
            var fifty = Fifty.quant * 50;
            var hundred = Hundred.quant * 100;
            var penny = Penny.quant * .01;
            var dime = Dime.quant * .1;
            var nickel = Nickel.quant * .5;
            var quarter = Quarter.quant * .25;
            var halfDollar = HalfDollar.quant * .5;
            var dollar = Dollar.quant;

            TTotal = one + two + five + ten + twenty + fifty + hundred + penny + dime + nickel + quarter + halfDollar + dollar;
            Total.Text = TTotal.ToString();
            var orderControl = this.FindAncestor<OrderControl>();
            if (TTotal >= (orderControl?.DataContext as Order).Total) CompleteOrder.IsEnabled = true;
        }
    }
}
