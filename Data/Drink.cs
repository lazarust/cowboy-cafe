/*
 * Author: Thomas Lazarus
 * Class: Drink
 * Purpose: Handle all the drink classes
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public abstract class Drink
    {
        /// <summary>
        /// Price of the drink
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// Calories of the drink
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Gets the size of the side
        /// </summary>
        public virtual Size Size { get; set; }

        /// <summary>
        /// Special instructions for the drink
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }

        private bool ice = true;
        /// <summary>
        /// If the drink has ice defaults to true   
        /// </summary>
        public virtual bool Ice
        {
            get { return ice; }
            set { ice = value; }
        }
    }
}
