using System;
using System.Collections.Generic;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Dakota Double Burger entree
    /// </summary>
    public class DakotaDoubleBurger
    {
        /// <summary>
        /// Thre price of the burger
        /// </summary>
        public double Price
        {
            get
            {
                return 5.2;
            }
        }

        /// <summary>
        /// The calories of the burger
        /// </summary>
        public uint Calories
        {
            get
            {
                return 464;
            }
        }

        private bool tomato = true;
        /// <summary>
        /// If the burger has tomato
        /// </summary>
        public bool Tomato
        {
            get { return tomato; }
            set { tomato = value; }
        }

        private bool letuce = true;
        /// <summary>
        /// If the burger has letuce
        /// </summary>
        public bool Letuce
        {
            get { return letuce; }
            set { letuce = value; }
        }

        private bool mayo = true;
        /// <summary>
        /// If the burger has mayo
        /// </summary>
        public bool Mayo
        {
            get { return mayo; }
            set { mayo = true; }
        }

        /// <summary>
        /// Special Instructions for the burger
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!tomato) instructions.Add("hold tomato");
                if (!lettuce) instructions.Add("hold lettuce");
                if (!mayo) instructions.Add("hold mayo");

                return instructions;
            }
        }
    }

}
