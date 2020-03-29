/*
 * Author: Thomas Lazarus
 * Class: CowboyCoffeePropertyChangedTests
 * Purpose: Test Cowboy Coffee Property Changed
 */
using System.ComponentModel;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class CowboyCoffeePropertyChangedTests
    {
        /// <summary>
        /// Test implementation of INotify Property Changed
        /// </summary>
        [Fact]
        public void CornDodgersShouldImplementINotifyPropertyChanged()
        {
            var cowboyCoffee = new CowboyCoffee();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(cowboyCoffee);
        }

        /// <summary>
        /// Changing size should change price
        /// </summary>
        [Fact]
        public void ChangingSizePropertyShouldInvokePropertyChangedForPrice()
        {
            var cowboyCoffee = new CowboyCoffee();
            Assert.PropertyChanged(cowboyCoffee, "Price", () => {
                cowboyCoffee.Size = Size.Large;
            });
        }

        /// <summary>
        /// Changing size should change calories
        /// </summary>
        [Fact]
        public void ChangingSizePropertyShouldInvokeProperyChangedForCalories()
        {
            var cowboyCoffee = new CowboyCoffee();
            Assert.PropertyChanged(cowboyCoffee, "Calories", () => {
                cowboyCoffee.Size = Size.Large;
            });
        }

        /// <summary>
        /// Changing ice property should invoke property changed for ice
        /// </summary>
        [Fact]
        public void ChangingIcePropertyShouldInvokePropertyChangeForIce()
        {
            var cowboyCoffee = new CowboyCoffee();
            Assert.PropertyChanged(cowboyCoffee, "Ice", () => {
                cowboyCoffee.Ice = false;
            });
        }

        /// <summary>
        /// Changing ice property should invoke property changed for special instructions
        /// </summary>
        [Fact]
        public void ChangingIcePropertyShouldInvokePropertyChangeForSpecialInstructions()
        {
            var cowboyCoffee = new CowboyCoffee();
            Assert.PropertyChanged(cowboyCoffee, "SpecialInstructions", () => {
                cowboyCoffee.Ice = false;
            });
        }

        /// <summary>
        /// Changing room for cream property should invoke property changed for room for cream
        /// </summary>
        [Fact]
        public void ChangingRoomForCreamPropertyShouldInvokePropertyChangeForRoomForCream()
        {
            var cowboyCoffee = new CowboyCoffee();
            Assert.PropertyChanged(cowboyCoffee, "RoomForCream", () => {
                cowboyCoffee.RoomForCream = false;
            });
        }

        /// <summary>
        /// Changing room for cream property should invoke property changed for special instructions
        /// </summary>
        [Fact]
        public void ChangingRoomForCreamPropertyShouldInvokePropertyChangeForSpecialInstructions()
        {
            var cowboyCoffee = new CowboyCoffee();
            Assert.PropertyChanged(cowboyCoffee, "SpecialInstructions", () => {
                cowboyCoffee.RoomForCream = false;
            });
        }

        /// <summary>
        /// Changing decaf property should invoke property changed for decaf
        /// </summary>
        [Fact]
        public void ChangingDecafPropertyShouldInvokePropertyChangeForDecaf()
        {
            var cowboyCoffee = new CowboyCoffee();
            Assert.PropertyChanged(cowboyCoffee, "Decaf", () => {
                cowboyCoffee.Decaf = false;
            });
        }

        /// <summary>
        /// Changing decaf property should invoke property changed for SpecialInstructions
        /// </summary>
        [Fact]
        public void ChangingDecafPropertyShouldInvokePropertyChangeForSpecialInstructions()
        {
            var cowboyCoffee = new CowboyCoffee();
            Assert.PropertyChanged(cowboyCoffee, "SpecialInstructions", () => {
                cowboyCoffee.Decaf = false;
            });
        }
    }
}
