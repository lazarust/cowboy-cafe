/*
 * Author: Thomas Lazarus
 * Class: JerkedSoda
 * Purpose: Handle the jerked soda drink
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Jerked soda drink class
    /// </summary>
    public class JerkedSoda: Drink, INotifyPropertyChanged
    {
        /// <summary>
        /// Event handler to handle when a property changes
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

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
                        return 2.59;
                    case Size.Medium:
                        return 2.10;
                    case Size.Small:
                        return 1.59;
                    default:
                        throw new NotImplementedException("Unknown size");
                }
            }
        }

        /// <summary>
        /// Calories of the drink
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 198;
                    case Size.Medium:
                        return 146;
                    case Size.Small:
                        return 110;
                    default:
                        throw new NotImplementedException("Unknown size");
                }
            }
        }

        private Size size = Size.Small;
        /// <summary>
        /// Handles the size of the drink
        /// </summary>
        public override Size Size
        {
            get { return size; }
            set
            {
                size = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
            }
        }

        private bool ice = true;
        /// <summary>
        /// Ice for the drink
        /// </summary>
        public override bool Ice
        {
            get { return ice; }
            set { ice = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ice"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        private SodaFlavor flavor;
        /// <summary>
        /// Flavor of the drink
        /// </summary>
        public SodaFlavor Flavor {
            get { return flavor; }
            set
            {
                flavor = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Flavor"));
            }
        }

        /// <summary>
        /// Special Instructions for the drink
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!Ice) instructions.Add("Hold Ice");

                return instructions;
            }
        }

        /// <summary>
        /// Override of the to string for the jerked soda.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string flavor = "";
            switch(Flavor)
            {
                case SodaFlavor.CreamSoda:
                    flavor = " Cream Soda";
                    break;
                case SodaFlavor.BirchBeer:
                    flavor = " Birch Beer";
                    break;
                case SodaFlavor.OrangeSoda:
                    flavor = " Orange Soda";
                    break;
                case SodaFlavor.Sarsparilla:
                    flavor = " Sarsparilla";
                    break;
                case SodaFlavor.RootBeer:
                    flavor = " Root Beer";
                    break;
            }       

            return Size +  flavor + " Jerked Soda";
        }
    }
}
