/*
 * Author: Thomas Lazarus
 * Class: PecosPulledPork Entree
 * Purpose: To hand the pecos pulled pork entree
 */
using System;
using System.Collections.Generic;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Pecos Pulled Pork entree
    /// </summary>
    public class PecosPulledPork: Entree
    {
        /// <summary>
        /// The price of the pork
        /// </summary>
        public override double Price { get { return 5.88; } }

        /// <summary>
        /// The calories of the pork
        /// </summary>
        public override uint Calories { get { return 528; } }
       
        private bool bread = true;
        /// <summary>
        /// If the pork has bread
        /// </summary>
        public bool Bread
        {
            get { return bread; }
            set { bread = value; }
        }

        private bool pickle = true;
        /// <summary>
        /// If the pork has pickles
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }
            set { pickle = value; }
        }

        /// <summary>
        /// Any special instructions for the pork
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
        /// Override to string method for the pulled pokr entree
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Pecos Pulled Pork";
        }
    }
}
