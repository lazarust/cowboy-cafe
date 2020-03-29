/*
 * Author: Thomas Lazarus
 * Class: DakotaDoubleBurgerPropertyChangedTests
 * Purpose: Test Dakota Doulbe Burger Property Changed
 */
using System.ComponentModel;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class DakotaDoubleBurgerPropertyChangedTests
    {
        /// <summary>
        /// Test implementation of INotify Property Changed
        /// </summary>
        [Fact]
        public void DakotaDoubleBurgerShouldImplementINotifyPropertyChanged()
        {
            var dakotaDoubleBurger = new DakotaDoubleBurger();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(dakotaDoubleBurger);
        }

        /// <summary>
        /// Changing tomato property should change tomato
        /// </summary>
        [Fact]
        public void ChangingTomatoPropertyShouldInvokePropertyChangedForTomato()
        {
            var dakotaDoubleBurger = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakotaDoubleBurger, "Tomato", () => {
                dakotaDoubleBurger.Tomato = false;
            });
        }

        /// <summary>
        /// Changing tomato property should change special instructions
        /// </summary>
        [Fact]
        public void ChangingTomatoPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var dakotaDoubleBurger = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakotaDoubleBurger, "SpecialInstructions", () => {
                dakotaDoubleBurger.Tomato = false;
            });
        }

        /// <summary>
        /// Changing lettuce property should change lettuce
        /// </summary>
        [Fact]
        public void ChangingLettucePropertyShouldInvokePropertyChangedForLettuce()
        {
            var dakotaDoubleBurger = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakotaDoubleBurger, "Lettuce", () => {
                dakotaDoubleBurger.Lettuce = false;
            });
        }

        /// <summary>
        /// Changing lettuce property should change special instructions
        /// </summary>
        [Fact]
        public void ChangingLettucePropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var dakotaDoubleBurger = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakotaDoubleBurger, "SpecialInstructions", () => {
                dakotaDoubleBurger.Lettuce = false;
            });
        }

        /// <summary>
        /// Changing mayo property should change mayo
        /// </summary>
        [Fact]
        public void ChangingMayoPropertyShouldInvokePropertyChangedForMayo()
        {
            var dakotaDoubleBurger = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakotaDoubleBurger, "Mayo", () => {
                dakotaDoubleBurger.Mayo = false;
            });
        }

        /// <summary>
        /// Changing mayo property should change special instructions
        /// </summary>
        [Fact]
        public void ChangingMayoPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var dakotaDoubleBurger = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakotaDoubleBurger, "SpecialInstructions", () => {
                dakotaDoubleBurger.Mayo = false;
            });
        }

        /// <summary>
        /// Changing ketchup property should change ketchup
        /// </summary>
        [Fact]
        public void ChangingKetchupPropertyShouldInvokePropertyChangedForKetchup()
        {
            var dakotaDoubleBurger = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakotaDoubleBurger, "Ketchup", () => {
                dakotaDoubleBurger.Ketchup = false;
            });
        }

        /// <summary>
        /// Changing ketchup property should change special instructions
        /// </summary>
        [Fact]
        public void ChangingKetchupPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var dakotaDoubleBurger = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakotaDoubleBurger, "SpecialInstructions", () => {
                dakotaDoubleBurger.Ketchup = false;
            });
        }

        /// <summary>
        /// Changing mustard property should change mustard
        /// </summary>
        [Fact]
        public void ChangingMustardPropertyShouldInvokePropertyChangedForMustard()
        {
            var dakotaDoubleBurger = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakotaDoubleBurger, "Mustard", () => {
                dakotaDoubleBurger.Mustard = false;
            });
        }

        /// <summary>
        /// Changing ketchup property should change special instructions
        /// </summary>
        [Fact]
        public void ChangingMustardPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var dakotaDoubleBurger = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakotaDoubleBurger, "SpecialInstructions", () => {
                dakotaDoubleBurger.Mustard = false;
            });
        }

        /// <summary>
        /// Changing pickle property should change pickle
        /// </summary>
        [Fact]
        public void ChangingPicklePropertyShouldInvokePropertyChangedForPickle()
        {
            var dakotaDoubleBurger = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakotaDoubleBurger, "Pickle", () => {
                dakotaDoubleBurger.Pickle = false;
            });
        }

        /// <summary>
        /// Changing pickle property should change special instructions
        /// </summary>
        [Fact]
        public void ChangingPicklePropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var dakotaDoubleBurger = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakotaDoubleBurger, "SpecialInstructions", () => {
                dakotaDoubleBurger.Pickle = false;
            });
        }

        /// <summary>
        /// Changing cheese property should change cheese
        /// </summary>
        [Fact]
        public void ChangingCheesePropertyShouldInvokePropertyChangedForCheese()
        {
            var dakotaDoubleBurger = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakotaDoubleBurger, "Cheese", () => {
                dakotaDoubleBurger.Cheese = false;
            });
        }

        /// <summary>
        /// Changing pickle property should change special instructions
        /// </summary>
        [Fact]
        public void ChangingCheesePropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var dakotaDoubleBurger = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakotaDoubleBurger, "SpecialInstructions", () => {
                dakotaDoubleBurger.Cheese = false;
            });
        }

        /// <summary>
        /// Changing bun property should change bun
        /// </summary>
        [Fact]
        public void ChangingBunPropertyShouldInvokePropertyChangedForBun()
        {
            var dakotaDoubleBurger = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakotaDoubleBurger, "Bun", () => {
                dakotaDoubleBurger.Bun = false;
            });
        }

        /// <summary>
        /// Changing bun property should change special instructions
        /// </summary>
        [Fact]
        public void ChangingBunPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var dakotaDoubleBurger = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakotaDoubleBurger, "SpecialInstructions", () => {
                dakotaDoubleBurger.Bun = false;
            });
        }
    }
}
