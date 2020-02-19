/*
 * Author: Thomas Lazarus
 * Class: BakedBeans
 * Purpose: Handle the baked beans side
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Class for the baked beans side
    /// </summary>
    public class BakedBeans: Side
    {
        /// <summary>
        /// Calories of the side
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 410;
                    case Size.Medium:
                        return 378;
                    case Size.Small:
                        return 312;
                    default:
                        throw new NotImplementedException("Unknown size");
                }
            }
        }

        /// <summary>
        /// Price of the side 
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 1.99;
                    case Size.Medium:
                        return 1.79;
                    case Size.Small:
                        return 1.59;
                    default:
                        throw new NotImplementedException("Unknown size");
                }
            }
        }

        /// <summary>
        /// Overrides the to string method for the side
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Size + " Baked Beans";
        }
    }
}
