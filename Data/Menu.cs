/*
 * Author: Thomas Lazarus
 * Class: Menu
 * Prurpose: Help convert the backend C# to the front-end web app
 */
using System.Collections.Generic;

namespace CowboyCafe.Data
{
    public static class Menu
    {
        /// <summary>
        /// Static method to get all 
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> CompleteMenu()
        {
            
            List<IOrderItem> items = new List<IOrderItem>();

            foreach (IOrderItem entree in Entrees())
            {
                items.Add(entree);
            }
                
            foreach (IOrderItem side in Sides())
            {
                items.Add(side);
            }

            foreach(IOrderItem drink in Drinks())
            {
                items.Add(drink);
            }

            return items;

        }

        /// <summary>
        /// All entree items 
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> Entrees()
        {

            List<IOrderItem> entrees = new List<IOrderItem>();
            entrees.Add(new AngryChicken());
            entrees.Add(new CowpokeChili());
            entrees.Add(new DakotaDoubleBurger());
            entrees.Add(new PecosPulledPork());
            entrees.Add(new RustlersRibs());
            entrees.Add(new TexasTripleBurger());
            entrees.Add(new TrailBurger());
            return entrees;
        }
        
        /// <summary>
        /// All Side Items
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> Sides()
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
            
            return sides;

        }

        /// <summary>
        /// All drink items
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> Drinks()
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

            return drinks;
        }

    }
}