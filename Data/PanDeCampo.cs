/*
 * Author: Thomas Lazarus
 * Class: Pan De Campo side
 * Purpose: Handle the pan de campo side
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Class to handle the pan de campo side
    /// </summary>
    public class PanDeCampo: Side
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
                        return 367;
                    case Size.Medium:
                        return 269;
                    case Size.Small:
                        return 227;
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
                switch(Size)
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
        /// Public override of the to string for the side.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Size + " Pan de Campo";
        }
    }
}
