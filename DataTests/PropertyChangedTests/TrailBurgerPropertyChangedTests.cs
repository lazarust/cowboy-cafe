/*
 * Author: Thomas Lazarus
 * Class: TrailBurgerPropertyChangedTests
 * Purpose: Test Trail Burger Property Changed
 */
using System.ComponentModel;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class TrailBurgerPropertyChangedTests
    {
        /// <summary>
        /// Test implementation of INotify Property Changed
        /// </summary>
        [Fact]
        public void DakotaDoubleBurgerShouldImplementINotifyPropertyChanged()
        {
            var trailBurger = new TrailBurger();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(trailBurger);
        }

        /// <summary>
        /// Changing ketchup property should change ketchup
        /// </summary>
        [Fact]
        public void ChangingKetchupPropertyShouldInvokePropertyChangedForKetchup()
        {
            var trailBurger = new TrailBurger();
            Assert.PropertyChanged(trailBurger, "Ketchup", () => {
                trailBurger.Ketchup = false;
            });
        }

        /// <summary>
        /// Changing ketchup property should change special instructions
        /// </summary>
        [Fact]
        public void ChangingKetchupPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var trailBurger = new TrailBurger();
            Assert.PropertyChanged(trailBurger, "SpecialInstructions", () => {
                trailBurger.Ketchup = false;
            });
        }

        /// <summary>
        /// Changing mustard property should change mustard
        /// </summary>
        [Fact]
        public void ChangingMustardPropertyShouldInvokePropertyChangedForMustard()
        {
            var trailBurger = new TrailBurger();
            Assert.PropertyChanged(trailBurger, "Mustard", () => {
                trailBurger.Mustard = false;
            });
        }

        /// <summary>
        /// Changing ketchup property should change special instructions
        /// </summary>
        [Fact]
        public void ChangingMustardPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var trailBurger = new TrailBurger();
            Assert.PropertyChanged(trailBurger, "SpecialInstructions", () => {
                trailBurger.Mustard = false;
            });
        }

        /// <summary>
        /// Changing pickle property should change pickle
        /// </summary>
        [Fact]
        public void ChangingPicklePropertyShouldInvokePropertyChangedForPickle()
        {
            var trailBurger = new TrailBurger();
            Assert.PropertyChanged(trailBurger, "Pickle", () => {
                trailBurger.Pickle = false;
            });
        }

        /// <summary>
        /// Changing pickle property should change special instructions
        /// </summary>
        [Fact]
        public void ChangingPicklePropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var trailBurger = new TrailBurger();
            Assert.PropertyChanged(trailBurger, "SpecialInstructions", () => {
                trailBurger.Pickle = false;
            });
        }

        /// <summary>
        /// Changing cheese property should change cheese
        /// </summary>
        [Fact]
        public void ChangingCheesePropertyShouldInvokePropertyChangedForCheese()
        {
            var trailBurger = new TrailBurger();
            Assert.PropertyChanged(trailBurger, "Cheese", () => {
                trailBurger.Cheese = false;
            });
        }

        /// <summary>
        /// Changing pickle property should change special instructions
        /// </summary>
        [Fact]
        public void ChangingCheesePropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var trailBurger = new TrailBurger();
            Assert.PropertyChanged(trailBurger, "SpecialInstructions", () => {
                trailBurger.Cheese = false;
            });
        }

        /// <summary>
        /// Changing bun property should change bun
        /// </summary>
        [Fact]
        public void ChangingBunPropertyShouldInvokePropertyChangedForBun()
        {
            var trailBurger = new TrailBurger();
            Assert.PropertyChanged(trailBurger, "Bun", () => {
                trailBurger.Bun = false;
            });
        }

        /// <summary>
        /// Changing bun property should change special instructions
        /// </summary>
        [Fact]
        public void ChangingBunPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var trailBurger = new TrailBurger();
            Assert.PropertyChanged(trailBurger, "SpecialInstructions", () => {
                trailBurger.Bun = false;
            });
        }
    }
}
