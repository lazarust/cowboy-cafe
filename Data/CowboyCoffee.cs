/*
 * Author: Thomas Lazarus
 * Class: CowboyCoffee
 * Purpose: Handle the cowboy coffee drink
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    public class CowboyCoffee: Drink, INotifyPropertyChanged
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

        private bool ice = false;
        /// <summary>
        /// If it has ice
        /// </summary>
        public override bool Ice
        {
            get { return ice; }
            set { 
                ice = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ice"));
            }
        }

        private bool roomforcream = false;
        /// <summary>
        /// If the coffee should leave room for cream
        /// </summary>
        public bool RoomForCream
        {
            get { return roomforcream; }
            set { 
                roomforcream = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("RoomForCream"));
            }
        }


        private bool decaf = false;

        public bool Decaf
        {
            get { return decaf; }
            set { 
                decaf = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Decaf"));
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

                if (ice) instructions.Add("Add Ice");
                if (roomforcream) instructions.Add("Room for Cream");
                if (decaf) instructions.Add("Decaf");

                return instructions;
            }
        }

        public override string ToString()
        {
            string flavor = "";
            if (decaf) flavor = " Decaf";

            return Size + flavor +" Cowboy Coffee";
        }
    }
}
