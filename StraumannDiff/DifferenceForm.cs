using StraumannDiff.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StraumannDiff
{
    public partial class DifferenceForm : Form
    {
        public DifferenceForm(ExcelTable differenceTable)
        {
            InitializeComponent();
            foreach (Material material in differenceTable.Materials)
            {
                ListViewItem item = new ListViewItem();
                item.Text = $"{material.Material} : {material.Quantity}";
                item.ForeColor = Color.White;
                if (material.Quantity > 0)
                {
                    item.BackColor = Color.Blue;
                }
                else
                {
                    item.BackColor = Color.Red;
                }
                listViewDifferences.Items.Add(item);
            }
        }

        private void DifferenceForm_Load(object sender, EventArgs e)
        {

        }
    }
}
