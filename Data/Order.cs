/*
 * Author: Thomas Lazarus
 * Class: Order
 * Purpose: Handle the orders
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Class to handle the order
    /// </summary>
    public class Order: INotifyPropertyChanged
    {
        /// <summary>
        /// Event handler to handle when a property changes
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Static uint to keep track of the last order number
        /// </summary>
        static private uint lastOrderNumber = 1;

        /// <summary>
        /// Private list of items in the order
        /// </summary>
        private List<IOrderItem> items = new List<IOrderItem>();

        /// <summary>
        /// Public list of Items in the order
        /// </summary>
        public IEnumerable<IOrderItem> Items { get { return items.ToArray(); } }

        /// <summary>
        /// Subtotal of items in the order
        /// </summary>
        public double Subtotal
        {
            get
            {
                double ret = 0;
                foreach (IOrderItem orderItem in items)
                {
                    ret = ret + orderItem.Price;
                }
                return ret;
            }
        }

        /// <summary>
        /// Current orders number
        /// </summary>
        public uint OrderNumber { get { return lastOrderNumber++; } }

        /// <summary>
        /// Add and item to the list of items in the order
        /// </summary>
        /// <param name="item"></param>
        public void Add(IOrderItem item)
        {
            items.Add(item);
            if(item is INotifyPropertyChanged pcitem) pcitem.PropertyChanged += OnItemChanged;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
        }

        /// <summary>
        /// Remove an item from the list of items in an order
        /// </summary>
        /// <param name="item"></param>
        public void Remove(IOrderItem item)
        {
            if (items.Contains(item))
            {
                items.Remove(item);
                if (item is INotifyPropertyChanged pcitem) pcitem.PropertyChanged -= OnItemChanged;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            }   
        }

        private void OnItemChanged(object sender, PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            if (e.PropertyName == "Price") PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
        }
    }
}
