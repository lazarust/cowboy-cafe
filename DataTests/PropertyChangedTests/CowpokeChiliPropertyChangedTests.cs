/*
 * Author: Thomas Lazarus
 * Class: CowpokeChiliPropertyChangedTests
 * Purpose: Test Cowpoke Chili Property Changed
 */
using System.ComponentModel;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class CowpokeChiliPropertyChangedTests
    {
        /// <summary>
        /// Test implementation of INotify Property Changed
        /// </summary>
        [Fact]
        public void CowpokeChiliShouldImplementINotifyPropertyChanged()
        {
            var cowpokeChili = new CowpokeChili();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(cowpokeChili);
        }

        /// <summary>
        /// Changing cheese property should change cheese
        /// </summary>
        [Fact]
        public void ChangingCheesePropertyShouldInvokePropertyChangedForCheese()
        {
            var cowpokeChili = new CowpokeChili();
            Assert.PropertyChanged(cowpokeChili, "Cheese", () => {
                cowpokeChili.Cheese = false;
            });
        }

        /// <summary>
        /// Changing cheese property should change special instructions
        /// </summary>
        [Fact]
        public void ChangingCheesePropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var cowpokeChili = new CowpokeChili();
            Assert.PropertyChanged(cowpokeChili, "SpecialInstructions", () => {
                cowpokeChili.Cheese = false;
            });
        }

        /// <summary>
        /// Changing sour cream property should change sour cream
        /// </summary>
        [Fact]
        public void ChangingSourCreamPropertyShouldInvokePropertyChangedForSourCream()
        {
            var cowpokeChili = new CowpokeChili();
            Assert.PropertyChanged(cowpokeChili, "SourCream", () => {
                cowpokeChili.SourCream = false;
            });
        }

        /// <summary>
        /// Changing cheese property should change special instructions
        /// </summary>
        [Fact]
        public void ChangingSourCreamPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var cowpokeChili = new CowpokeChili();
            Assert.PropertyChanged(cowpokeChili, "SpecialInstructions", () => {
                cowpokeChili.SourCream = false;
            });
        }

        /// <summary>
        /// Changing green onions property should change green onions
        /// </summary>
        [Fact]
        public void ChangingGreenOnionsPropertyShouldInvokePropertyChangedForGreenOnions()
        {
            var cowpokeChili = new CowpokeChili();
            Assert.PropertyChanged(cowpokeChili, "GreenOnions", () => {
                cowpokeChili.GreenOnions = false;
            });
        }

        /// <summary>
        /// Changing cheese property should change special instructions
        /// </summary>
        [Fact]
        public void ChangingGreenOnionsPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var cowpokeChili = new CowpokeChili();
            Assert.PropertyChanged(cowpokeChili, "SpecialInstructions", () => {
                cowpokeChili.GreenOnions = false;
            });
        }

        /// <summary>
        /// Changing tortilla strips property should change tortilla strips
        /// </summary>
        [Fact]
        public void ChangingTortillaStripsPropertyShouldInvokePropertyChangedForTortillaStrips()
        {
            var cowpokeChili = new CowpokeChili();
            Assert.PropertyChanged(cowpokeChili, "TortillaStrips", () => {
                cowpokeChili.TortillaStrips = false;
            });
        }

        /// <summary>
        /// Changing cheese property should change special instructions
        /// </summary>
        [Fact]
        public void ChangingTortillaStripsPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var cowpokeChili = new CowpokeChili();
            Assert.PropertyChanged(cowpokeChili, "SpecialInstructions", () => {
                cowpokeChili.TortillaStrips = false;
            });
        }
    }
}
