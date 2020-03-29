/*
 * Author: Thomas Lazarus
 * Class: AngryChickenPropertyChangedTests
 * Purpose: Test Angry Chicken Property Changed
 */
using System.ComponentModel;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class AngryChickenPropertyChangedTests
    {
        /// <summary>
        /// Angry Chicken should implement INotify Property Changed
        /// </summary>
        [Fact]
        public void AngryChickenShouldImplementINotifyPropertyChanged()
        {
            var chicken = new AngryChicken();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(chicken);
        }

        /// <summary>
        /// Changing bread property should invoke property changed for bread
        /// </summary>
        [Fact]
        public void ChangingBreadPropertyShouldInvokePropertyChangedForBread()
        {
            var chicken = new AngryChicken();
            Assert.PropertyChanged(chicken, "Bread", () => {
                chicken.Bread = false;
            });
        }

        /// <summary>
        /// Changing bread property should invoke property changed for special instructions
        /// </summary>
        [Fact]
        public void ChangingBreadPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var chicken = new AngryChicken();
            Assert.PropertyChanged(chicken, "SpecialInstructions", () => {
                chicken.Bread = false;
            });
        }

        /// <summary>
        /// Changing pickle property should invoke property changed for pickle
        /// </summary>
        [Fact]
        public void ChangingPicklePropertyShouldInvokePropertyChangedForPickle()
        {
            var chicken = new AngryChicken();
            Assert.PropertyChanged(chicken, "Pickle", () => {
                chicken.Pickle = false;
            });
        }

        /// <summary>
        /// Changing pickle property should invoke property changed for special instructions
        /// </summary>
        [Fact]
        public void ChangingPicklePropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var chicken = new AngryChicken();
            Assert.PropertyChanged(chicken, "SpecialInstructions", () => {
                chicken.Pickle = false;
            });
        }
    }
}
