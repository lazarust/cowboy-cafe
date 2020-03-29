/*
 * Author: Thomas Lazarus
 * Class: JerkedSodaPropertyChangedTests
 * Purpose: Test Jerked Soda Property Changed
 */
using System.ComponentModel;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class JerkedSodaPropertyChangedTests
    {
        /// <summary>
        /// Test implementation of INotify Property Changed
        /// </summary>
        [Fact]
        public void JerkedSodaShouldImplementINotifyPropertyChanged()
        {
            var jerkedSoda = new JerkedSoda();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(jerkedSoda);
        }

        /// <summary>
        /// Changing size should change price
        /// </summary>
        [Fact]
        public void ChangingSizePropertyShouldInvokePropertyChangedForPrice()
        {
            var jerkedSoda = new JerkedSoda();
            Assert.PropertyChanged(jerkedSoda, "Price", () => {
                jerkedSoda.Size = Size.Large;
            });
        }

        /// <summary>
        /// Changing size should change calories
        /// </summary>
        [Fact]
        public void ChangingSizePropertyShouldInvokeProperyChangedForCalories()
        {
            var jerkedSoda = new JerkedSoda();
            Assert.PropertyChanged(jerkedSoda, "Calories", () => {
                jerkedSoda.Size = Size.Large;
            });
        }

        /// <summary>
        /// Changing ice property should invoke property changed for ice
        /// </summary>
        [Fact]
        public void ChangingIcePropertyShouldInvokePropertyChangeForIce()
        {
            var jerkedSoda = new JerkedSoda();
            Assert.PropertyChanged(jerkedSoda, "Ice", () => {
                jerkedSoda.Ice = false;
            });
        }

        /// <summary>
        /// Changing ice property should invoke property changed for special instructions
        /// </summary>
        [Fact]
        public void ChangingIcePropertyShouldInvokePropertyChangeForSpecialInstructions()
        {
            var jerkedSoda = new JerkedSoda();
            Assert.PropertyChanged(jerkedSoda, "SpecialInstructions", () => {
                jerkedSoda.Ice = false;
            });
        }

        /// <summary>
        /// Changing flavor property should invoke property changed for flavor
        /// </summary>
        [Fact]
        public void ChangingFlavorPropertyShouldInvokePropertyChangeForFlavor()
        {
            var jerkedSoda = new JerkedSoda();
            Assert.PropertyChanged(jerkedSoda, "Flavor", () => {
                jerkedSoda.Flavor = SodaFlavor.CreamSoda;
            });
        }

    }
}
