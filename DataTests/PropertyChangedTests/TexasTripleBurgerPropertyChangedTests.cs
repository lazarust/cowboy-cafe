/*
 * Author: Thomas Lazarus
 * Class: TexasTripleBurgerPropertyChangedTests
 * Purpose: Test Texas Triple Burger Property Changed
 */
using System.ComponentModel;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class TexasTripleBurgerPropertyChangedTests
    {
        /// <summary>
        /// Test implementation of INotify Property Changed
        /// </summary>
        [Fact]
        public void TexasTripleBurgerShouldImplementINotifyPropertyChanged()
        {
            var texasTripleBurger = new TexasTripleBurger();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(texasTripleBurger);
        }

        /// <summary>
        /// Changing tomato property should change tomato
        /// </summary>
        [Fact]
        public void ChangingTomatoPropertyShouldInvokePropertyChangedForTomato()
        {
            var texasTripleBurger = new TexasTripleBurger();
            Assert.PropertyChanged(texasTripleBurger, "Tomato", () => {
                texasTripleBurger.Tomato = false;
            });
        }

        /// <summary>
        /// Changing tomato property should change special instructions
        /// </summary>
        [Fact]
        public void ChangingTomatoPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var texasTripleBurger = new TexasTripleBurger();
            Assert.PropertyChanged(texasTripleBurger, "SpecialInstructions", () => {
                texasTripleBurger.Tomato = false;
            });
        }

        /// <summary>
        /// Changing lettuce property should change lettuce
        /// </summary>
        [Fact]
        public void ChangingLettucePropertyShouldInvokePropertyChangedForLettuce()
        {
            var texasTripleBurger = new TexasTripleBurger();
            Assert.PropertyChanged(texasTripleBurger, "Lettuce", () => {
                texasTripleBurger.Lettuce = false;
            });
        }

        /// <summary>
        /// Changing lettuce property should change special instructions
        /// </summary>
        [Fact]
        public void ChangingLettucePropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var texasTripleBurger = new TexasTripleBurger();
            Assert.PropertyChanged(texasTripleBurger, "SpecialInstructions", () => {
                texasTripleBurger.Lettuce = false;
            });
        }

        /// <summary>
        /// Changing mayo property should change mayo
        /// </summary>
        [Fact]
        public void ChangingMayoPropertyShouldInvokePropertyChangedForMayo()
        {
            var texasTripleBurger = new TexasTripleBurger();
            Assert.PropertyChanged(texasTripleBurger, "Mayo", () => {
                texasTripleBurger.Mayo = false;
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
            var texasTripleBurger = new TexasTripleBurger();
            Assert.PropertyChanged(texasTripleBurger, "Ketchup", () => {
                texasTripleBurger.Ketchup = false;
            });
        }

        /// <summary>
        /// Changing ketchup property should change special instructions
        /// </summary>
        [Fact]
        public void ChangingKetchupPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var texasTripleBurger = new TexasTripleBurger();
            Assert.PropertyChanged(texasTripleBurger, "SpecialInstructions", () => {
                texasTripleBurger.Ketchup = false;
            });
        }

        /// <summary>
        /// Changing mustard property should change mustard
        /// </summary>
        [Fact]
        public void ChangingMustardPropertyShouldInvokePropertyChangedForMustard()
        {
            var texasTripleBurger = new TexasTripleBurger();
            Assert.PropertyChanged(texasTripleBurger, "Mustard", () => {
                texasTripleBurger.Mustard = false;
            });
        }

        /// <summary>
        /// Changing ketchup property should change special instructions
        /// </summary>
        [Fact]
        public void ChangingMustardPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var texasTripleBurger = new TexasTripleBurger();
            Assert.PropertyChanged(texasTripleBurger, "SpecialInstructions", () => {
                texasTripleBurger.Mustard = false;
            });
        }

        /// <summary>
        /// Changing pickle property should change pickle
        /// </summary>
        [Fact]
        public void ChangingPicklePropertyShouldInvokePropertyChangedForPickle()
        {
            var texasTripleBurger = new TexasTripleBurger();
            Assert.PropertyChanged(texasTripleBurger, "Pickle", () => {
                texasTripleBurger.Pickle = false;
            });
        }

        /// <summary>
        /// Changing pickle property should change special instructions
        /// </summary>
        [Fact]
        public void ChangingPicklePropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var texasTripleBurger = new TexasTripleBurger();
            Assert.PropertyChanged(texasTripleBurger, "SpecialInstructions", () => {
                texasTripleBurger.Pickle = false;
            });
        }

        /// <summary>
        /// Changing cheese property should change cheese
        /// </summary>
        [Fact]
        public void ChangingCheesePropertyShouldInvokePropertyChangedForCheese()
        {
            var texasTripleBurger = new TexasTripleBurger();
            Assert.PropertyChanged(texasTripleBurger, "Cheese", () => {
                texasTripleBurger.Cheese = false;
            });
        }

        /// <summary>
        /// Changing pickle property should change special instructions
        /// </summary>
        [Fact]
        public void ChangingCheesePropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var texasTripleBurger = new TexasTripleBurger();
            Assert.PropertyChanged(texasTripleBurger, "SpecialInstructions", () => {
                texasTripleBurger.Cheese = false;
            });
        }

        /// <summary>
        /// Changing bun property should change bun
        /// </summary>
        [Fact]
        public void ChangingBunPropertyShouldInvokePropertyChangedForBun()
        {
            var texasTripleBurger = new TexasTripleBurger();
            Assert.PropertyChanged(texasTripleBurger, "Bun", () => {
                texasTripleBurger.Bun = false;
            });
        }

        /// <summary>
        /// Changing bun property should change special instructions
        /// </summary>
        [Fact]
        public void ChangingBunPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var texasTripleBurger = new TexasTripleBurger();
            Assert.PropertyChanged(texasTripleBurger, "SpecialInstructions", () => {
                texasTripleBurger.Bun = false;
            });
        }

        /// <summary>
        /// Changing bacon property should change bun
        /// </summary>
        [Fact]
        public void ChangingBaconPropertyShouldInvokePropertyChangedForBacon()
        {
            var texasTripleBurger = new TexasTripleBurger();
            Assert.PropertyChanged(texasTripleBurger, "Bacon", () => {
                texasTripleBurger.Bacon = false;
            });
        }

        /// <summary>
        /// Changing bacon property should change special instructions
        /// </summary>
        [Fact]
        public void ChangingBaconPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var texasTripleBurger = new TexasTripleBurger();
            Assert.PropertyChanged(texasTripleBurger, "SpecialInstructions", () => {
                texasTripleBurger.Bacon = false;
            });
        }

        /// <summary>
        /// Changing egg property should change bun
        /// </summary>
        [Fact]
        public void ChangingEggPropertyShouldInvokePropertyChangedForEgg()
        {
            var texasTripleBurger = new TexasTripleBurger();
            Assert.PropertyChanged(texasTripleBurger, "Egg", () => {
                texasTripleBurger.Egg = false;
            });
        }

        /// <summary>
        /// Changing bun property should change special instructions
        /// </summary>
        [Fact]
        public void ChangingEggPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var texasTripleBurger = new TexasTripleBurger();
            Assert.PropertyChanged(texasTripleBurger, "SpecialInstructions", () => {
                texasTripleBurger.Egg = false;
            });
        }
    }
}
