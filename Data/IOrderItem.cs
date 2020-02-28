using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public interface IOrderItem
    {
        public double Price { get; }

        public virtual IEnumerable<string> SpecialInstructions { get { return SpecialInstructions; } }
    }
}
