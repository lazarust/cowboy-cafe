﻿/*
 * Author: Thomas Lazarus
 * Class: Angry chicken entree
 * Purpose: To handle the angry chicken entree
 */
using System;
using System.Collections.Generic;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Angry Chicken entree
    /// </summary>
    public class AngryChicken: Entree
    {
        /// <summary>
        /// The price of the chicken
        /// </summary>
        public override double Price { get { return 5.99; } }

        /// <summary>
        /// The calories of the chicken
        /// </summary>
        public override uint Calories { get { return 190; } }
       
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
            set { pickle = value; }
        }

        /// <summary>
        /// Any special instructions for the chicken 
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!bread) instructions.Add("hold bread");
                if (!pickle) instructions.Add("hold pickle");

                return instructions;
            }
        }

        /// <summary>
        /// Overrides the to string method to get name
        /// </summary>
        /// <returns>Name of entree</returns>
        public override string ToString()
        {
            return "Angry Chicken";
        }
    }
}
