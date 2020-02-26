/*
 * Author: Thomas Lazarus
 * Class: Order
 * Purpose: Handle the orders
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    public class Order: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private uint lastOrderNumber;

        private List<IOrderItem> items => throw new NotImplementedException();

        public IEnumerable<IOrderItem> Items { get; }

        public double Subtotal => 0;

        public uint OrderNumber { get; }

        public void Add(IOrderItem item)
        {
            items.Add(item);
        }

        public void Remove(IOrderItem item)
        {
            if (items.Contains(item))
            {
                items.Remove(item);
            }   
        }
    }
}
