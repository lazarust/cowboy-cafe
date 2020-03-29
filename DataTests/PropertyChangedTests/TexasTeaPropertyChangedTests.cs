/*
 * Author: Thomas Lazarus
 * Class: TexasTeaPropertyChangedTests
 * Purpose: Test Texas Tea Property Changed
 */
using System.ComponentModel;
using Xunit;
using CowboyCafe.Data;


namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class TexasTeaPropertyChangedTests
    {
        /// <summary>
        /// Test implementation of INotify Property Changed
        /// </summary>
        [Fact]
        public void TexasTeaShouldImplementINotifyPropertyChanged()
        {
            var texasTea = new TexasTea();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(texasTea);
        }

        /// <summary>
        /// Changing ice property should invoke property changed for ice
        /// </summary>
        [Fact]
        public void ChangingIcePropertyShouldInvokePropertyChangeForIce()
        {
            var texasTea = new TexasTea();
            Assert.PropertyChanged(texasTea, "Ice", () => {
                texasTea.Ice = false;
            });
        }

        /// <summary>
        /// Changing ice property should invoke property changed for special instructions
        /// </summary>
        [Fact]
        public void ChangingIcePropertyShouldInvokePropertyChangeForSpecialInstructions()
        {
            var texasTea = new TexasTea();
            Assert.PropertyChanged(texasTea, "SpecialInstructions", () => {
                texasTea.Ice = false;
            });
        }

        /// <summary>
        /// Changing lemon property should invoke property changed for lemon
        /// </summary>
        [Fact]
        public void ChangingLemonPropertyShouldInvokePropertyChangeForLemon()
        {
            var texasTea = new TexasTea();
            Assert.PropertyChanged(texasTea, "Lemon", () => {
                texasTea.Lemon = false;
            });
        }

        /// <summary>
        /// Changing lemon property should invoke property changed for special instructions
        /// </summary>
        [Fact]
        public void ChangingLemonPropertyShouldInvokePropertyChangeForSpecialInstructions()
        {
            var texasTea = new TexasTea();
            Assert.PropertyChanged(texasTea, "SpecialInstructions", () => {
                texasTea.Lemon = false;
            });
        }

        /// <summary>
        /// Changing sweet property should invoke property changed for sweet
        /// </summary>
        [Fact]
        public void ChangingSweetPropertyShouldInvokePropertyChangeForSweet()
        {
            var texasTea = new TexasTea();
            Assert.PropertyChanged(texasTea, "Sweet", () => {
                texasTea.Sweet = false;
            });
        }

        /// <summary>
        /// Changing lemon property should invoke property changed for special instructions
        /// </summary>
        [Fact]
        public void ChangingSweetPropertyShouldInvokePropertyChangeForSpecialInstructions()
        {
            var texasTea = new TexasTea();
            Assert.PropertyChanged(texasTea, "SpecialInstructions", () => {
                texasTea.Sweet = false;
            });
        }

    }
}
