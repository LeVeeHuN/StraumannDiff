using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StraumannDiff.Classes
{
    public class Material : Entry
    {
        public Material(string material, int quantity) : base(material, quantity) { }

        public void AddEntry(Entry entry)
        {
            if (IsEntryCorresponds(entry))
            {
                quantity += entry.Quantity;
            }
        }

        public bool IsEntryCorresponds(Entry entry)
        {
            if (entry == null) return false;
            return entry.Material.Equals(this.Material);
        }

        public override bool Equals(object? obj)
        {
            if (obj == null) throw new ArgumentNullException(nameof(obj));
            if (!(obj is Material)) throw new ArgumentException();

            Material other = obj as Material;
            return other.Material.Equals(Material) && other.Quantity == this.Quantity;
        }
    }
}
