using System;
using System.Collections.Generic;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Texas Triple Burger entree
    /// </summary>
    public class TexasTripleBurger
    {
        /// <summary>
        /// The price of the burger
        /// </summary>
        public double Price
        {
            get
            {
                return 6.45;
            }
        }

        /// <summary>
        /// The calories of the burger
        /// </summary>
        public uint Calories
        {
            get
            {
                return 698;
            }
        }

        private bool bacon = true;
        /// <summary>
        /// If the burger has bacon
        /// </summary>
        public bool Bacon
        {
            get { return bacon; }
            set { bacon = value; }
        }

        private bool egg = true;
        /// <summary>
        /// If the burger has egg
        /// </summary>
        public bool Egg
        {
            get { return egg; }
            set { egg = value; }
        }
        /// <summary>
        /// Special instructions for the burger
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!bacon) instructions.Add("hold bacon");
                if (!egg) instructions.Add("hold egg");

                return instructions;
            }
        }
    }
}
