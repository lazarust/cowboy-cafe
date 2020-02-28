/*
 * Author: Thomas Lazarus
 * Class: Entree
 * Purpose: Handle all the entree classes
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Abstract class for the Entrees
    /// </summary>
    public  abstract class Entree: IOrderItem
    {
        /// <summary>
        /// Price for the entree
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// Calories for the entree
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Special Instructions for the entree
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}
