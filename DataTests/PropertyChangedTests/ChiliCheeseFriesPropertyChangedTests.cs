/*
 * Author: Thomas Lazarus
 * Class: ChiliCheeseFriesPropertyChangedTests
 * Purpose: Test Chili Cheese Fries Property Changed
 */
using System.ComponentModel;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class ChiliCheeseFriesPropertyChangedTests
    {
        /// <summary>
        /// Test implementation of INotify Property Changed
        /// </summary>
        [Fact]
        public void ChiliCheeseFriesShouldImplementINotifyPropertyChanged()
        {
            var chiliCheeseFries = new ChiliCheeseFries();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(chiliCheeseFries);
        }

        /// <summary>
        /// Changing size should change price
        /// </summary>
        [Fact]
        public void ChangingSizePropertyShouldInvokePropertyChangedForPrice()
        {
            var chiliCheeseFries = new ChiliCheeseFries();
            Assert.PropertyChanged(chiliCheeseFries, "Price", () => {
                chiliCheeseFries.Size = Size.Large;
            });
        }

        /// <summary>
        /// Changing size should change calories
        /// </summary>
        [Fact]
        public void ChangingSizePropertyShouldInvokeProperyChangedForCalories()
        {
            var chiliCheese = new ChiliCheeseFries();
            Assert.PropertyChanged(chiliCheese, "Calories", () => {
                chiliCheese.Size = Size.Large;
            });
        }
    }
}
