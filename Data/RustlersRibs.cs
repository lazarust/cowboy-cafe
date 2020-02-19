/*
 * Author: Thomas Lazarus
 * Class: RustlersRibs
 * Purpose: Handle the rustlers ribs entree
 */
using System;
using System.Collections.Generic;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Rustler's Ribs entree
    /// </summary>
    public class RustlersRibs : Entree
    {

        /// <summary>
        /// The price of the ribs
        /// </summary>
        public override double Price { get { return 7.5; } }

        /// <summary>
        /// The calories of the ribs
        /// </summary>
        public override uint Calories { get { return 894; } }

        /// <summary>
        /// The special instructions for the ribs
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                return instructions;
            }
        }

        /// <summary>
        /// Override to string method for this entree.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Rustler's Ribs";
        }
    }
}