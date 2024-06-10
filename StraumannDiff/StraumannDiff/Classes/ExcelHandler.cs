using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StraumannDiff.Classes
{
    internal class ExcelHandler
    {
        public static ExcelTable ReadTable(string excelTablePath, DataSource source)
        {
            using (ExcelPackage package = new ExcelPackage(excelTablePath))
            {
                ExcelWorksheet sheet = package.Workbook.Worksheets.First();
                int materialIndex = 0;
                int quantityIndex = 0;
                for (int i = 1; i <= sheet.Dimension.End.Column; i++)
                {
                    if (sheet.Cells[1, i].Value.ToString().Equals("Material"))
                    {
                        materialIndex = i;
                    }
                    if (sheet.Cells[1, i].Value.ToString().Equals("Quantity"))
                    {
                        quantityIndex = i;
                    }
                }

                // Adatok kinyerése és ExcelTable-be rakása
                ExcelTable table = new ExcelTable(source);
                int rowCount = sheet.Dimension.End.Row;
                for (int i = 2; i <= rowCount; i++)
                {
                    string material = string.Empty;
                    int quantity = 0;
                    try
                    {
                        material = sheet.Cells[i, materialIndex].Value.ToString();
                        quantity = int.Parse(sheet.Cells[i, quantityIndex].Value.ToString());
                    }
                    catch
                    {
                        break;
                    }
                    table.AddNewEntry(new Entry(material, quantity));
                }
                return table;

            }
        }
    }
}
