/*
 * Author: Thomas Lazarus
 * Class: Menu
 * Prurpose: Help convert the backend C# to the front-end web app
 */
using System.Collections.Generic;
using System.Linq;

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

        /// <summary>
        /// Search method for each of the item types
        /// </summary>
        /// <param name="items">IEnumerable of the items</param>
        /// <param name="searchTerm">Search term</param>
        /// <param name="itemType">Type of item currently being searched</param>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> Search (IEnumerable<IOrderItem> items, string searchTerm, string itemType)
        {
            if (searchTerm == null || searchTerm == "")
            {
                if (itemType == "Drink")
                {
                    return Drinks();
                } 
                else if (itemType == "Entree")
                {
                    return Entrees();
                }
                else
                {
                    return Sides();
                }
            }

            List<IOrderItem> results = new List<IOrderItem>();
       
            foreach (var item in items)
            {
                if (item.ToString().Contains(searchTerm, System.StringComparison.InvariantCultureIgnoreCase))
                {
                    results.Add(item);
                }
            }

            return results;
        }

        /// <summary>
        /// ItemTypes as a string[]
        /// </summary>
        public static string[] ItemTypes
        {
            get => new string[]
            {
                "Entree",
                "Drink",
                "Side"
            };
        }

        /// <summary>
        /// Sets the given IEnumerable to null if it is not selected
        /// </summary>
        /// <param name="items">IEnumerable of given items</param>
        /// <param name="categories">IEnumberable of strings representing the selected categories</param>
        /// <param name="itemType">The current item type</param>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> FilterByCategory(IEnumerable<IOrderItem> items, IEnumerable<string> categories, string itemType)
        {
            if (categories == null || categories.Count() == 0) return items;

            if (categories.Contains("Entree") & itemType == "Entree")
            {
                return items;
            }

            if (categories.Contains("Drink") & itemType == "Drink")
            {
                return items;
            }

            if (categories.Contains("Side") & itemType == "Side")
            {
                return items;
            }

            return null;
        }

        /// <summary>
        /// Filter the given IEnumerable as calories
        /// </summary>
        /// <param name="items">IEnumerable of items</param>
        /// <param name="min">Minimum calories</param>
        /// <param name="max">Maximum calories</param>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> FilterByCalories (IEnumerable<IOrderItem> items, int? min, int? max)
        {
            if (min == null & max == null) return items;

            var results = new List<IOrderItem>();

            if (min == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Calories <= max) results.Add(item);
                }

                return results;
            }

            if (max == null)
            {
                foreach(IOrderItem item in items)
                {
                    if (item.Calories >= min) results.Add(item);
                }

                return results;
            }

            foreach (IOrderItem item in items)
            {
                if (item.Calories >= min & item.Calories <= max)
                {
                    results.Add(item);
                }
            }

            return results;
        }

        /// <summary>
        /// Filter the given IEnumerable by Price
        /// </summary>
        /// <param name="items">IEnumerable of items</param>
        /// <param name="min">Minimum Price</param>
        /// <param name="max">Maximum Price</param>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> FilterByPrice(IEnumerable<IOrderItem> items, double? min, double? max)
        {
            if (min == null & max == null) return items;

            var results = new List<IOrderItem>();

            if (min == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Price <= max) results.Add(item);
                }

                return results;
            }

            if (max == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Price >= min) results.Add(item);
                }

                return results;
            }

            foreach (IOrderItem item in items)
            {
                if (item.Price >= min & item.Price <= max)
                {
                    results.Add(item);
                }
            }

            return results;
        }
    }
}