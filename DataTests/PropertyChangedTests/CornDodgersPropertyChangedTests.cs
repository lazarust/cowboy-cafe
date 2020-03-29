/*
 * Author: Thomas Lazarus
 * Class: CornDodgersPropertyChangedTests
 * Purpose: Test Corn Dodgers Property Changed
 */
using System.ComponentModel;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class CornDodgersPropertyChangedTests
    {
        /// <summary>
        /// Test implementation of INotify Property Changed
        /// </summary>
        [Fact]
        public void CornDodgersShouldImplementINotifyPropertyChanged()
        {
            var cornDodgers = new CornDodgers();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(cornDodgers);
        }

        /// <summary>
        /// Changing size should change price
        /// </summary>
        [Fact]
        public void ChangingSizePropertyShouldInvokePropertyChangedForPrice()
        {
            var cornDodgers = new CornDodgers();
            Assert.PropertyChanged(cornDodgers, "Price", () => {
                cornDodgers.Size = Size.Large;
            });
        }

        /// <summary>
        /// Changing size should change calories
        /// </summary>
        [Fact]
        public void ChangingSizePropertyShouldInvokeProperyChangedForCalories()
        {
            var cornDodgers = new CornDodgers();
            Assert.PropertyChanged(cornDodgers, "Calories", () => {
                cornDodgers.Size = Size.Large;
            });
        }
    }
}
