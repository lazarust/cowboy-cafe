/*
 * Author: Thomas Lazarus
 * Class: CowboyCoffee
 * Purpose: Handle the cowboy coffee drink
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class CowboyCoffee: Drink
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
                        return 1.6;
                    case Size.Medium:
                        return 1.1;
                    case Size.Small:
                        return .6;
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
                        return 7;
                    case Size.Medium:
                        return 5;
                    case Size.Small:
                        return 3;
                    default:
                        throw new NotImplementedException("Unknown size");
                }
            }
        }

        private bool ice = false;
        /// <summary>
        /// If it has ice
        /// </summary>
        public override bool Ice
        {
            get { return ice; }
            set { ice = value; }
        }

        private bool roomforcream = false;
        /// <summary>
        /// If the coffee should leave room for cream
        /// </summary>
        public bool RoomForCream
        {
            get { return roomforcream; }
            set { roomforcream = value; }
        }


        private bool decaf = false;

        public bool Decaf
        {
            get { return decaf; }
            set { decaf = value; }
        }
        /// <summary>
        /// Special Instructions for the drink
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (ice) instructions.Add("Add Ice");
                if (roomforcream) instructions.Add("Room for Cream");
                if (decaf) instructions.Add("Decaf");

                return instructions;
            }
        }
    }
}
