/*
 * Author: Thomas Lazarus
 * Class: OrderTests
 * Purpose: To test the order class
 */
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests
{
    public class OrderTests
    {
        public class MockOrderItem : IOrderItem
        {
            public double Price { get; set; }

            public List<string> SpecialInstructions { get; set; }

            public uint Calories { get; set; }
        }

        [Fact]
        public void ShouldBeAbleToAddItems()
        {
            var order = new Order();
            var item = new MockOrderItem();

            order.Add(item);

            Assert.Contains(item, order.Items);
        }
        
        [Fact]
        public void ShouldBeAbleToRemoveItems ()
        {
            var order = new Order();
            var item = new MockOrderItem();

            order.Add(item);
            order.Remove(item);

            Assert.DoesNotContain(item, order.Items);
        }

        [Fact]
        public void ShouldBeAbleToGetAnEnumerationOfItems()
        {
            var order = new Order();
            var item = new MockOrderItem();
            var item1 = new MockOrderItem();
            var item2 = new MockOrderItem();

            order.Add(item);
            order.Add(item1);
            order.Add(item2);

            Assert.Collection(order.Items, item3 => { Assert.Equal(item, item3); }, item => { Assert.Equal(item1, item); }, item => { Assert.Equal(item2, item); });
        }

        [Theory]
        [InlineData(new double[] { 1,2,3})]
        [InlineData(new double[] { 0,0.3,0})]
        [InlineData(new double[] { 199.34, 799})]
        [InlineData(new double[] { })]
        [InlineData(new double [] { -5})]
        [InlineData (new double[] { -4, 10, 8})]
        [InlineData (new double[] { 3.1345234262 })]
        [InlineData (new double [] { double.NaN })]
        public void SubtotalShouldBeTheSumOfItemPrices(double[] prices)
        {
            var order = new Order();
            double total = 0;

            foreach (var price in prices)
            {
                total += price;
                order.Add(new MockOrderItem() { Price = price });
            }

            Assert.Equal(total, order.Subtotal);
        }

        [Theory]
        [InlineData("Subtotal")]
        [InlineData("Items")]
        public void AddingAnItemShouldTriggerPropertyChanged(string propName)
        {
            var order = new Order();
            var item = new MockOrderItem();
            Assert.PropertyChanged(order, propName, () => { order.Add(item); });
            
        }

        [Theory]
        [InlineData("Subtotal")]
        [InlineData("Items")]
        public void RemovingAnItemShouldTriggerPropertyChanged(string propName)
        {
            var order = new Order();
            var item = new MockOrderItem();
            order.Add(item);
            Assert.PropertyChanged(order, propName, () => { order.Remove(item); });

        }

        [Fact]
        public void AutoIncrimentingOrderNumber()
        {
            var order1 = new Order();
            Assert.Equal((uint)1, order1.OrderNumber);

            var order2 = new Order();
            Assert.Equal((uint)2, order2.OrderNumber);

            var order3 = new Order();
            Assert.Equal((uint)3, order3.OrderNumber);
        }

    }
}
