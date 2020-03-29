/* 
* Author: Thomas Lazarus
* Class: WaterPropertyChangedTests
* Purpose: Test Water Property Changed
*/
using System.ComponentModel;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class WaterPropertyChangedTests
    {
        /// <summary>
        /// Test implementation of INotify Property Changed
        /// </summary>
        [Fact]
        public void WaterShouldImplementINotifyPropertyChanged()
        {
            var water = new Water();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(water);
        }

        /// <summary>
        /// Changing ice property should invoke property changed for ice
        /// </summary>
        [Fact]
        public void ChangingIcePropertyShouldInvokePropertyChangeForIce()
        {
            var water = new Water();
            Assert.PropertyChanged(water, "Ice", () => {
                water.Ice = false;
            });
        }

        /// <summary>
        /// Changing ice property should invoke property changed for special instructions
        /// </summary>
        [Fact]
        public void ChangingIcePropertyShouldInvokePropertyChangeForSpecialInstructions()
        {
            var water = new Water();
            Assert.PropertyChanged(water, "SpecialInstructions", () => {
                water.Ice = false;
            });
        }

        /// <summary>
        /// Changing lemon property should invoke property changed for lemon
        /// </summary>
        [Fact]
        public void ChangingLemonPropertyShouldInvokePropertyChangeForLemon()
        {
            var water = new Water();
            Assert.PropertyChanged(water, "Lemon", () => {
                water.Lemon = false;
            });
        }

        /// <summary>
        /// Changing lemon property should invoke property changed for special instructions
        /// </summary>
        [Fact]
        public void ChangingLemonPropertyShouldInvokePropertyChangeForSpecialInstructions()
        {
            var water = new Water();
            Assert.PropertyChanged(water, "SpecialInstructions", () => {
                water.Lemon = false;
            });
        }
    }
}
