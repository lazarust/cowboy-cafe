/*
 * Author: Thomas Lazarus
 * Class: BakedBeansPropertyChangedTests
 * Purpose: Test Baked Beans Property Changed
 */
using System.ComponentModel;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class BakedBeansPropertyChangedTests
    {
        /// <summary>
        /// Tests implementation of INotifyPropertyChanged
        /// </summary>
        [Fact]
        public void BakedBeansShouldImplementINotifyPropertyChanged()
        {
            var beans = new BakedBeans();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(beans);
        }

        /// <summary>
        /// Changing size should change price
        /// </summary>
        [Fact]
        public void ChangingSizePropertyShouldInvokePropertyChangedForPrice()
        {
            var beans = new BakedBeans();
            Assert.PropertyChanged(beans, "Price", () => {
                beans.Size = Size.Large;
            });
        }

        /// <summary>
        /// Changing size should change calories
        /// </summary>
        [Fact]
        public void ChangingSizePropertyShouldInvokeProperyChangedForCalories()
        {
            var beans = new BakedBeans();
            Assert.PropertyChanged(beans, "Calories", () => {
                beans.Size = Size.Large;
            });
        }
    }
}
