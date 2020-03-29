/*
 * Author: Thomas Lazarus
 * Class: PanDeCampoPropertyChangedTests
 * Purpose: Test Pan De Campo Property Changed
 */
using System.ComponentModel;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class PanDeCampoPropertyChangedTests
    {
        /// <summary>
        /// Test implementation of INotify Property Changed
        /// </summary>
        [Fact]
        public void PanDeCampoShouldImplementINotifyPropertyChanged()
        {
            var panDeCampo = new PanDeCampo();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(panDeCampo);
        }

        /// <summary>
        /// Changing size should change price
        /// </summary>
        [Fact]
        public void ChangingSizePropertyShouldInvokePropertyChangedForPrice()
        {
            var panDeCampo = new PanDeCampo();
            Assert.PropertyChanged(panDeCampo, "Price", () => {
                panDeCampo.Size = Size.Large;
            });
        }

        /// <summary>
        /// Changing size should change calories
        /// </summary>
        [Fact]
        public void ChangingSizePropertyShouldInvokeProperyChangedForCalories()
        {
            var panDeCampo = new PanDeCampo();
            Assert.PropertyChanged(panDeCampo, "Calories", () => {
                panDeCampo.Size = Size.Large;
            });
        }
    }
}
