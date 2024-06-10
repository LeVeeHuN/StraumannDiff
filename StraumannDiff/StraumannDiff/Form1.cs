using OfficeOpenXml;
using StraumannDiff.Classes;

namespace StraumannDiff
{
    public partial class Form1 : Form
    {
        OpenFileDialog ofd;
        public Form1()
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            ofd = new OpenFileDialog();
            ofd.Filter = "excel files (*.xlsx;*.xls)|*.xlsx;*.xls";
            ofd.Multiselect = false;
            InitializeComponent();
        }

        private string? SelectExcelFile()
        {
            // Excel fájl választó dialog
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                return ofd.FileName;
            }
            return null;
        }

        private void buttonSelectOurExcel_Click(object sender, EventArgs e)
        {
            // Saját excelünk (PC) kiválasztása
            string? ourExcelPc = SelectExcelFile();
            if (ourExcelPc == null) return;

            // Ha sikeres a fájlválasztás
            labelOurExcel.Text = ourExcelPc;
        }

        private void checkBoxLaptop_CheckedChanged(object sender, EventArgs e)
        {
            // A laptop excel kiválasztásának engedélyezése a checkbox függvényében
            buttonSelectOurExcelLaptop.Enabled = checkBoxLaptop.Checked;
        }

        private void buttonSelectOurExcelLaptop_Click(object sender, EventArgs e)
        {
            // Saját excelünk (Laptop) kiválasztása
            string? ourExcelLaptop = SelectExcelFile();
            if (ourExcelLaptop == null) return;

            // Ha sikeres a fájlválasztás
            labelOurExcelLaptop.Text = ourExcelLaptop;
        }

        private void buttonSelectSwissExcel_Click(object sender, EventArgs e)
        {
            // Svájci excel kiválasztása
            string? swissExcel = SelectExcelFile();
            if (swissExcel == null) return;

            // Ha sikeres a fájlválasztás
            labelSwissExcel.Text = swissExcel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Összehasonlítás

            if (string.IsNullOrWhiteSpace(labelOurExcel.Text)) return;
            if (string.IsNullOrWhiteSpace(labelSwissExcel.Text)) return;

            ExcelTable ourTable = ExcelHandler.ReadTable(labelOurExcel.Text, DataSource.Hungary);
            ExcelTable swissTable = ExcelHandler.ReadTable(labelSwissExcel.Text, DataSource.Swiss);
            // Megnézni, hogy laptop is, vagy csak pc

            if (checkBoxLaptop.Checked)
            {
                // LAPTOP IS
                if (string.IsNullOrWhiteSpace(labelOurExcelLaptop.Text)) return;
                ExcelTable laptopTable = ExcelHandler.ReadTable(labelOurExcelLaptop.Text, DataSource.Hungary);

                ourTable = ourTable.CombineTable(laptopTable);
            }
            ExcelTable differenceTable = ourTable.GetDifferenceTable(swissTable);

            // Difference table-vel meghívni egy összegző oldalt
            DifferenceForm df = new DifferenceForm(differenceTable);
            df.ShowDialog();
        }
    }
}
