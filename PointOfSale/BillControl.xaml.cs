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
    /// Interaction logic for BillControl.xaml
    /// </summary>
    public partial class BillControl : UserControl
    {
        public static readonly DependencyProperty DenomProperty =
          DependencyProperty.Register("denom", typeof(Bills), typeof(BillControl), new PropertyMetadata(Bills.One));
        public Bills denom
        {
            get { return (Bills)GetValue(DenomProperty); }
            set { SetValue(DenomProperty, value); }
        }


        public static readonly DependencyProperty QuantProperty =
            DependencyProperty.Register("quant", typeof(int), typeof(BillControl), new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));

        public int quant
        {
            get { return (int)GetValue(QuantProperty); }
            set { SetValue(QuantProperty, value); }
        }

        public BillControl()
        {
            InitializeComponent();
        }

        private void DecreaseBill_Click(object sender, RoutedEventArgs e)
        {
            quant--;
            e.Handled = false;
            var cashPaymentControl = this.FindAncestor<CashPaymentControl>();
            cashPaymentControl.Button_Click(sender, e);
        }

        private void IncreaseBill_Click(object sender, RoutedEventArgs e)
        {
            quant++;
            e.Handled = false;
            var cashPaymentControl = this.FindAncestor<CashPaymentControl>();
            cashPaymentControl.Button_Click(sender, e);
        }
    }
}
