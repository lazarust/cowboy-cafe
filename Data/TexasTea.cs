/*
 * Author: Thomas Lazarus
 * Class: Texas Tea
 * Purpose: Handle the texas tea drink
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class TexasTea: Drink
    {
        /// <summary>
        /// Price of the drink
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 2.00;
                    case Size.Medium:
                        return 1.50;
                    case Size.Small:
                        return 1.00;
                    default:
                        throw new NotImplementedException("Unknown size");
                }
            }
        }

        /// <summary>
        /// Calories for the drink
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 36;
                    case Size.Medium:
                        return 22;
                    case Size.Small:
                        return 10;
                    default:
                        throw new NotImplementedException("Unknown size");
                }
            }
        }

        private bool sweet = true;

        public bool Sweet
        {
            get { return sweet; }
            set { sweet = value; }
        }

        private bool lemon = false;

        public bool Lemon
        {
            get { return lemon; }
            set { lemon = value; }
        }

        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!Ice) instructions.Add("Hold Ice");
                if (!sweet) instructions.Add("unsweet");
                if (lemon) instructions.Add("Add Lemon");

                return instructions;
            }
        }
    }
}
