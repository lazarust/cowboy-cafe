/*
 * Author: Thomas Lazaurs
 * Class: ChiliCheeseFries
 * Prupose: Handle the chili cheese fies side
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Class to hand chili cheese fries side
    /// </summary>
    public class ChiliCheeseFries: Side
    {
        /// <summary>
        /// Calories for the side based off of size
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 610;
                    case Size.Medium:
                        return 524;
                    case Size.Small:
                        return 433;
                    default:
                        throw new NotImplementedException("Unknown size");
                }
            }
        }


        /// <summary>
        /// Price for the side based off of size
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 3.99;
                    case Size.Medium:
                        return 2.99;
                    case Size.Small:
                        return 1.99;
                    default:
                        throw new NotImplementedException("Unknown size");
                }
            }
        }

        /// <summary>
        /// Overides the two string method for side
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Size + " Chili Cheese Fries";
        }
    }
}
