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
using CashRegister;
using PointOfSale.ExtensionMethods;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CoinControl.xaml
    /// </summary>
    public partial class CoinControl : UserControl
    {

        public static readonly DependencyProperty DenomProperty =
            DependencyProperty.Register("denom", typeof(Coins), typeof(CoinControl), new PropertyMetadata(Coins.Penny));
        public Coins denom
        {
            get { return (Coins)GetValue(DenomProperty); }
            set { SetValue(DenomProperty, value); }
        }


        public static readonly DependencyProperty QuantProperty =
            DependencyProperty.Register("quant", typeof(int), typeof(CoinControl), new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));

        public int quant
        {
            get { return (int)GetValue(QuantProperty); }
            set { SetValue(QuantProperty, value); }
        }

        public CoinControl()
        {
            InitializeComponent();
        }

        private void DecreaseCoin_Click(object sender, RoutedEventArgs e)
        {
            quant--;
            e.Handled = false;
            var cashPaymentControl = this.FindAncestor<CashPaymentControl>();
            cashPaymentControl.Button_Click(sender, e);
        }

        private void IncreaseCoin_Click(object sender, RoutedEventArgs e)
        {
            quant++;
            e.Handled = false;
            var cashPaymentControl = this.FindAncestor<CashPaymentControl>();
            cashPaymentControl.Button_Click(sender, e);
        }
    }
}
