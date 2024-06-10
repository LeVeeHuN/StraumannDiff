using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StraumannDiff.Classes
{
    public class ExcelTable
    {
        private DataSource source;
        public DataSource Source { get { return source; } }

        private List<Material> materials;
        public List<Material> Materials { get { return materials; } }

        public ExcelTable(DataSource source)
        {
            materials = new List<Material>();
        }

        public void AddNewEntry(Entry entry)
        {
            bool entryExists = false;
            foreach (Material material in materials)
            {
                if (material.IsEntryCorresponds(entry))
                {
                    entryExists = true;
                    material.AddEntry(entry);
                    break;
                }
            }
            if (!entryExists)
            {
                materials.Add(new Material(entry.Material, entry.Quantity));
            }
        }

        public ExcelTable CombineTable(ExcelTable otherTable)
        {
            ExcelTable newTable = new ExcelTable(source);
            foreach (Material material in materials)
            {
                newTable.AddNewEntry(material);
            }
            foreach (Material material in otherTable.Materials)
            {
                newTable.AddNewEntry(material);
            }
            return newTable;
        }

        public ExcelTable GetDifferenceTable(ExcelTable swissTable)
        {
            ExcelTable differenceTable = new ExcelTable(Source);
            foreach (Material thisMaterial in Materials)
            {
                foreach (Material otherMaterial in swissTable.Materials)
                {
                    if (thisMaterial.Material.Equals(otherMaterial.Material))
                    {
                        int diff = thisMaterial.Quantity - otherMaterial.Quantity;
                        if (diff != 0)
                        {
                            differenceTable.AddNewEntry(new Entry(thisMaterial.Material, diff));
                        }
                        break;
                    }
                }
            }
            return differenceTable;
        }
    }
}
