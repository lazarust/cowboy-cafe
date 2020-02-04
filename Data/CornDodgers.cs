/*
 * Author: Thomas Lazarus
 * Class: CornDodger
 * Purpose: Handle the corn dodger side
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Class to handle corn dodger side
    /// </summary>
    public class CornDodgers: Side
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
                        return 717;
                    case Size.Medium:
                        return 685;
                    case Size.Small:
                        return 512;
                    default:
                        throw new NotImplementedException("Unknown size");
                }
            }
        }

        /// <summary>
        /// Price for the side
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
    }
}
