/*
 * Author: Thomas Lazarus
 * Class: MenuTest
 * Purpose: Test the menu class
 */
using CowboyCafe.Data;
using System.Collections.Generic;
using System.Linq;
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
            Assert.Collection(Menu.Entrees(),
                (ac) => { Assert.IsType<AngryChicken>(ac); },
                (cc) => { Assert.IsType<CowpokeChili>(cc); },
                (ddb) => { Assert.IsType<DakotaDoubleBurger>(ddb); },
                (ppp) => { Assert.IsType<PecosPulledPork>(ppp); },
                (rr) => { Assert.IsType<RustlersRibs>(rr); },
                (ttb) => { Assert.IsType<TexasTripleBurger>(ttb); },
                (tb) => { Assert.IsType<TrailBurger>(tb); }
                );
        }

        /// <summary>
        /// Test for Menu.Sides returns all sides and sizes
        /// </summary>
        [Fact]
        public void MenuSide()
        {
            Assert.Collection(Menu.Sides(),
                (bb) => { Assert.IsType<BakedBeans>(bb); },
                (mbb) => { Assert.IsType<BakedBeans>(mbb); },
                (lbb) => { Assert.IsType<BakedBeans>(lbb); },
                (ccf) => { Assert.IsType<ChiliCheeseFries>(ccf);},
                (mccf) => { Assert.IsType<ChiliCheeseFries>(mccf); },
                (lccf) => { Assert.IsType<ChiliCheeseFries>(lccf); },
                (cd) => { Assert.IsType<CornDodgers>(cd); },
                (cd) => { Assert.IsType<CornDodgers>(cd); },
                (cd) => { Assert.IsType<CornDodgers>(cd); },
                (pdc) => { Assert.IsType<PanDeCampo>(pdc); },
                (pdc) => { Assert.IsType<PanDeCampo>(pdc); },
                (pdc) => { Assert.IsType<PanDeCampo>(pdc); }
                );
        }

        /// <summary>
        /// Test for Menu.Drinks returns all drinks and sizes
        /// </summary>
        [Fact]
        public void MenuDrinks()
        {
            Assert.Collection(Menu.Drinks(),
                (coffee) => { Assert.IsType<CowboyCoffee>(coffee); },
                (coffee) => { Assert.IsType<CowboyCoffee>(coffee); },
                (coffee) => { Assert.IsType<CowboyCoffee>(coffee); },
                (js) => { Assert.IsType<JerkedSoda>(js); },
                (js) => { Assert.IsType<JerkedSoda>(js); },
                (js) => { Assert.IsType<JerkedSoda>(js); },
                (tt) => { Assert.IsType<TexasTea>(tt); },
                (tt) => { Assert.IsType<TexasTea>(tt); },
                (tt) => { Assert.IsType<TexasTea>(tt); },
                (w) => { Assert.IsType<Water>(w); },
                (w) => { Assert.IsType<Water>(w); },
                (w) => { Assert.IsType<Water>(w); }
                );
        }

        /// <summary>
        /// Test for Menu.Complete returns all items and sizes
        /// </summary>
        [Fact]
        public void MenuFull()
        {
            Assert.Collection(Menu.CompleteMenu(),
                (ac) => { Assert.IsType<AngryChicken>(ac); },
                (cc) => { Assert.IsType<CowpokeChili>(cc); },
                (ddb) => { Assert.IsType<DakotaDoubleBurger>(ddb); },
                (ppp) => { Assert.IsType<PecosPulledPork>(ppp); },
                (rr) => { Assert.IsType<RustlersRibs>(rr); },
                (ttb) => { Assert.IsType<TexasTripleBurger>(ttb); },
                (tb) => { Assert.IsType<TrailBurger>(tb); },
                (bb) => { Assert.IsType<BakedBeans>(bb); },
                (mbb) => { Assert.IsType<BakedBeans>(mbb); },
                (lbb) => { Assert.IsType<BakedBeans>(lbb); },
                (ccf) => { Assert.IsType<ChiliCheeseFries>(ccf); },
                (mccf) => { Assert.IsType<ChiliCheeseFries>(mccf); },
                (lccf) => { Assert.IsType<ChiliCheeseFries>(lccf); },
                (cd) => { Assert.IsType<CornDodgers>(cd); },
                (cd) => { Assert.IsType<CornDodgers>(cd); },
                (cd) => { Assert.IsType<CornDodgers>(cd); },
                (pdc) => { Assert.IsType<PanDeCampo>(pdc); },
                (pdc) => { Assert.IsType<PanDeCampo>(pdc); },
                (pdc) => { Assert.IsType<PanDeCampo>(pdc); },
                (coffee) => { Assert.IsType<CowboyCoffee>(coffee); },
                (coffee) => { Assert.IsType<CowboyCoffee>(coffee); },
                (coffee) => { Assert.IsType<CowboyCoffee>(coffee); },
                (js) => { Assert.IsType<JerkedSoda>(js); },
                (js) => { Assert.IsType<JerkedSoda>(js); },
                (js) => { Assert.IsType<JerkedSoda>(js); },
                (tt) => { Assert.IsType<TexasTea>(tt); },
                (tt) => { Assert.IsType<TexasTea>(tt); },
                (tt) => { Assert.IsType<TexasTea>(tt); },
                (w) => { Assert.IsType<Water>(w); },
                (w) => { Assert.IsType<Water>(w); },
                (w) => { Assert.IsType<Water>(w); }
                );

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
