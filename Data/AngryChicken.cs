﻿using System;
using System.Collections.Generic;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Angry Chicken entree
    /// </summary>
    class AngryChicken
    {
        /// <summary>
        /// The price of the chicken
        /// </summary>
        public double Price
        {
            get
            {
                return 5.99;
            }
        }

        /// <summary>
        /// The calories of the chicken
        /// </summary>
        public uint Calories
        {
            get
            {
                return 190;
            }
        }

        private bool bread = true;
        /// <summary>
        /// If the chicken comes with bread
        /// </summary>
        public bool Bread
        {
            get { return bread; }
            set { bread = value; }
        }

        private bool pickle = true;
        /// <summary>
        /// If the chicken comes with pickle
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }
            set { pickle = true; }
        }

        /// <summary>
        /// Any special instructions for the chicken 
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!bread) instructions.Add("hold bread");
                if (!pickle) instructions.Add("hold pickle");

                return instructions;
            }
        }
    }
}
