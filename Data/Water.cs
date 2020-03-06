/*
 * Author: Thomas Lazarus
 * Class: Water
 * Purpose: Handle water
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    public class Water: Drink, INotifyPropertyChanged
    {
        /// <summary>
        /// Event handler to handle when a property changes
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        public override double Price { get { return 0.12; } }

        public override uint Calories { get { return 0; } }

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
            set
            {
                ice = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ice"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        private bool lemon = false;
        /// <summary>
        /// Lemon for the drink
        /// </summary>
        public bool Lemon
        {
            get { return lemon; }
            set { 
                lemon = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Lemon"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!Ice) instructions.Add("Hold Ice");
                if (lemon) instructions.Add("Add Lemon");

                return instructions;
            }
        }

        /// <summary>
        /// Override for the to string method
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Size + " Water";
        }
    }
}
