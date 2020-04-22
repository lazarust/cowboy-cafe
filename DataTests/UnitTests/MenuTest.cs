/*
 * Author: Thomas Lazarus
 * Class: MenuTest
 * Purpose: Test the menu class
 */
using CowboyCafe.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace CowboyCafe.DataTests
{
    public class MenuTest
    {
        /// <summary>
        /// Test to test that the count of items returned from Menu.Entress is equal to the count of items when adding all the items to a list.
        /// </summary>
        [Fact]
        public void MenuEntrees()
        {
            List<IOrderItem> test = new List<IOrderItem>
            {
                new AngryChicken(),
                new CowpokeChili(),
                new DakotaDoubleBurger(),
                new PecosPulledPork(),
                new RustlersRibs(),
                new TexasTripleBurger(),
                new TrailBurger()
            };

            Assert.Equal(test.Count(), (Menu.Entrees()).Count());
        }

        /// <summary>
        /// Test for Menu.Sides returns all sides and sizes
        /// </summary>
        [Fact]
        public void MenuSide()
        {
            List<IOrderItem> sides = new List<IOrderItem>();

            sides.Add(new BakedBeans());
            var mBakedBeans = new BakedBeans();
            mBakedBeans.Size = Size.Medium;
            sides.Add(mBakedBeans);
            var lBakedBeans = new BakedBeans();
            lBakedBeans.Size = Size.Large;
            sides.Add(lBakedBeans);


            sides.Add(new ChiliCheeseFries());
            var mChilliCheeseFies = new ChiliCheeseFries();
            mChilliCheeseFies.Size = Size.Medium;
            sides.Add(mChilliCheeseFies);
            var lChilliCheeseFries = new ChiliCheeseFries();
            lChilliCheeseFries.Size = Size.Large;
            sides.Add(lChilliCheeseFries);

            sides.Add(new CornDodgers());
            var mCorn = new CornDodgers();
            mCorn.Size = Size.Medium;
            sides.Add(mCorn);
            var lCorn = new CornDodgers();
            lCorn.Size = Size.Large;
            sides.Add(lCorn);

            sides.Add(new PanDeCampo());
            var mPan = new PanDeCampo();
            mPan.Size = Size.Medium;
            sides.Add(mPan);
            var lPan = new PanDeCampo();
            lPan.Size = Size.Large;
            sides.Add(lPan);

            Assert.Equal(sides.Count(), Menu.Sides().Count());
        }

        /// <summary>
        /// Test for Menu.Drinks returns all drinks and sizes
        /// </summary>
        [Fact]
        public void MenuDrinks()
        {
            List<IOrderItem> drinks = new List<IOrderItem>();

            drinks.Add(new CowboyCoffee());
            var mCoffee = new CowboyCoffee();
            mCoffee.Size = Size.Medium;
            drinks.Add(mCoffee);
            var lCoffee = new CowboyCoffee();
            drinks.Add(lCoffee);

            drinks.Add(new JerkedSoda());
            var mSoda = new JerkedSoda();
            mSoda.Size = Size.Medium;
            drinks.Add(mSoda);
            var lSoda = new JerkedSoda();
            lSoda.Size = Size.Large;
            drinks.Add(lSoda);

            drinks.Add(new TexasTea());
            var mTea = new TexasTea();
            mTea.Size = Size.Medium;
            drinks.Add(mTea);
            var lTea = new TexasTea();
            lTea.Size = Size.Large;
            drinks.Add(lTea);

            drinks.Add(new Water());
            var mWater = new Water();
            mWater.Size = Size.Medium;
            drinks.Add(mWater);
            var lWater = new Water();
            lWater.Size = Size.Large;
            drinks.Add(lWater);

            Assert.Equal(drinks.Count(), Menu.Drinks().Count());

        }

        /// <summary>
        /// Test for Menu.Complete returns all items and sizes
        /// </summary>
        [Fact]
        public void MenuFull()
        {
            List<IOrderItem> test = new List<IOrderItem>
            {
                new AngryChicken(),
                new CowpokeChili(),
                new DakotaDoubleBurger(),
                new PecosPulledPork(),
                new RustlersRibs(),
                new TexasTripleBurger(),
                new TrailBurger()
            };

            test.Add(new BakedBeans());
            var mBakedBeans = new BakedBeans();
            mBakedBeans.Size = Size.Medium;
            test.Add(mBakedBeans);
            var lBakedBeans = new BakedBeans();
            lBakedBeans.Size = Size.Large;
            test.Add(lBakedBeans);


            test.Add(new ChiliCheeseFries());
            var mChilliCheeseFies = new ChiliCheeseFries();
            mChilliCheeseFies.Size = Size.Medium;
            test.Add(mChilliCheeseFies);
            var lChilliCheeseFries = new ChiliCheeseFries();
            lChilliCheeseFries.Size = Size.Large;
            test.Add(lChilliCheeseFries);

            test.Add(new CornDodgers());
            var mCorn = new CornDodgers();
            mCorn.Size = Size.Medium;
            test.Add(mCorn);
            var lCorn = new CornDodgers();
            lCorn.Size = Size.Large;
            test.Add(lCorn);

            test.Add(new PanDeCampo());
            var mPan = new PanDeCampo();
            mPan.Size = Size.Medium;
            test.Add(mPan);
            var lPan = new PanDeCampo();
            lPan.Size = Size.Large;
            test.Add(lPan);

            test.Add(new CowboyCoffee());
            var mCoffee = new CowboyCoffee();
            mCoffee.Size = Size.Medium;
            test.Add(mCoffee);
            var lCoffee = new CowboyCoffee();
            test.Add(lCoffee);

            test.Add(new JerkedSoda());
            var mSoda = new JerkedSoda();
            mSoda.Size = Size.Medium;
            test.Add(mSoda);
            var lSoda = new JerkedSoda();
            lSoda.Size = Size.Large;
            test.Add(lSoda);

            test.Add(new TexasTea());
            var mTea = new TexasTea();
            mTea.Size = Size.Medium;
            test.Add(mTea);
            var lTea = new TexasTea();
            lTea.Size = Size.Large;
            test.Add(lTea);

            test.Add(new Water());
            var mWater = new Water();
            mWater.Size = Size.Medium;
            test.Add(mWater);
            var lWater = new Water();
            lWater.Size = Size.Large;
            test.Add(lWater);

            Assert.Equal(test.Count(), Menu.CompleteMenu().Count());

        }

        /// <summary>
        /// Searches terms and makes sure the returned IEnumerable has the right count
        /// </summary>
        /// <param name="searchTerm"></param>
        /// <param name="count"></param>
        [Theory]
        [InlineData("Chicken", 1)]
        [InlineData("Drink", 0)]
        [InlineData("Burger", 3)]
        public void MenuSearch(string searchTerm, int count)
        {
            Assert.Equal(count, Menu.Search(Menu.CompleteMenu(), searchTerm, "Entree").Count());
        }

        /// <summary>
        /// Tests filters by Entree, Side, and Drink
        /// </summary>
        [Fact]
        public void FilterType()
        {
            List<string> set = new List<string> { "Entree" };

            Assert.Equal(7, Menu.FilterByCategory(Menu.Entrees(), set, "Entree").Count());

            set = new List<string> { "Side" };

            Assert.Equal(12, Menu.FilterByCategory(Menu.Sides(), set, "Side").Count());

            set = new List<string> { "Drink" };

            Assert.Equal(12, Menu.FilterByCategory(Menu.Drinks(), set, "Drink").Count());
        }
    
        /// <summary>
        /// Test to check that filtering by prices work
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <param name="count"></param>
        [Theory]
        [InlineData(0, 1, 6)]
        [InlineData(2.5, 5.5, 5)]
        [InlineData(0, 100, 31)]
        public void FilterPrice(double? min, double? max, int count)
        {
            Assert.Equal(count, Menu.FilterByPrice(Menu.CompleteMenu(), min, max).Count());
        }

        /// <summary>
        /// Test to check that filtering by calories works
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <param name="count"></param>
        [Theory]
        [InlineData(0, 10, 7)]
        [InlineData(0, 300, 17)]
        [InlineData(250, 300, 2)]
        public void FilterCalories(int? min, int? max, int count)
        {
            Assert.Equal(count, Menu.FilterByCalories(Menu.CompleteMenu(), min, max).Count());
        }

    }
}
