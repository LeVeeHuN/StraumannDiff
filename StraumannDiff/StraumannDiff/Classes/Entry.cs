using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StraumannDiff.Classes
{
    public class Entry
    {
        protected string material;
        protected int quantity;

        public string Material { get { return material; } }
        public int Quantity { get { return quantity; } }

        public Entry(string material, int quantity)
        {
            this.material = material;
            this.quantity = quantity;
        }
    }
}
