using FlexGridExplorer.Data;
using System.Data;
using C1.Win.FlexGrid;

namespace Sales_Slip
{
    public partial class Form1 : Form
    {
        private DataTable data;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Fetch product sales data
            data = DataSource.GetRows("Select ProductID, ProductName, UnitPrice, UnitsInStock as Quantity, QuantityPerUnit as Unit  from Products where UnitPrice>15 and Quantity >0");
            //Add and Calculate other Columns in the Data Table based on existing Data columns
            data.Columns.Add("ProfitUnitPrice", typeof(int), " UnitPrice -8");
            data.Columns.Add("SalesAmount", typeof(int), "UnitPrice * Quantity");
            data.Columns.Add("TotalProfit", typeof(int), "ProfitUnitPrice * Quantity");
            data.Columns.Add("ProfitRate", typeof(int), "(TotalProfit / SalesAmount)*100");
            //Set FlexGrid Data Source
            c1FlexGrid1.DataSource = data;

            //Add Column Bands
            AddAdvanceColumnBands();

            //Set Theme
            c1ThemeController1.SetTheme(c1FlexGrid1, "ExpressionDark");
            c1ThemeController1.SetTheme(pdfExportButton, "ExpressionDark");
            c1ThemeController1.SetTheme(excelExportButton, "ExpressionDark");
            c1ThemeController1.SetTheme(panel1, "ExpressionDark");
            c1ThemeController1.SetTheme(tableLayoutPanel1, "ExpressionDark");
            c1ThemeController1.SetTheme(tableLayoutPanel2, "ExpressionDark");


            //Set Styling
            c1FlexGrid1.Styles.Normal.Border.Width = c1FlexGrid1.Styles.Fixed.Border.Width = 2;
            c1FlexGrid1.Styles.Normal.Border.Style = c1FlexGrid1.Styles.Fixed.Border.Style = BorderStyleEnum.Double;
            c1FlexGrid1.Styles.Fixed.Border.Color = Color.FromArgb(82,79,79);
            c1FlexGrid1.Styles.Normal.Border.Color = Color.FromArgb(82, 79, 79);
            pdfExportButton.BackColor = Color.FromArgb(59, 59, 59);
            pdfExportButton.ForeColor = Color.Snow;
            excelExportButton.BackColor = Color.FromArgb(59, 59, 59);
            excelExportButton.ForeColor = Color.Snow;
        }

        private void AddAdvanceColumnBands()
        {
            Band band1 = new Band();
            Band band2 = new Band();
            Band band3 = new Band();
            Band band4 = new Band();
            Band band5 = new Band();
            Band band6 = new Band();
            Band band7 = new Band();
            Band band8 = new Band();
            Band band9 = new Band();
            Band band10 = new Band();
            Band band11 = new Band();
            Band band12 = new Band();
            Band band13 = new Band();

            //Create Header Bands
            band1.Caption = "ID";
            band1.ColSpan = 1;
            band2.Caption = "Product Details";
            band2.ColSpan = 3;
            band3.Caption = "Price Details";
            band3.ColSpan = 3;

            //Add Child bands to band1
            band4.Caption = "ProductID";
            band4.ColSpan = 1;
            band4.Name = "ProductID";
            band1.Children.Add(band4);
            //Add Child bands to band2
            band5.Caption = "Product Name";
            band5.ColSpan = 3;
            band5.Name = "ProductName";
            band6.Caption = "Quantity";
            band6.ColSpan = 1;
            band6.Name = "Quantity";
            band7.Caption = "Unit";
            band7.ColSpan = 2;
            band7.Name = "Unit";
            band2.Children.Add(band5);
            band2.Children.Add(band6);
            band2.Children.Add(band7);
            //Add Child bands to band3
            band8.Caption = "Unit Price";
            band8.ColSpan = 1;
            band8.Name = "UnitPrice";
            band9.Caption = "Profit Unit Price";
            band9.ColSpan = 1;
            band9.Name = "ProfitUnitPrice";
            band10.Caption = "Sales Amount";
            band10.ColSpan = 1;
            band10.Name = "SalesAmount";
            band11.Caption = "Total Profit";
            band11.ColSpan = 1;
            band11.Name = "TotalProfit";
            band12.Caption = "Profit Rate";
            band12.ColSpan = 2;
            band12.Name = "ProfitRate";
            band3.Children.Add(band8);
            band3.Children.Add(band9);
            band3.Children.Add(band10);
            band3.Children.Add(band11);
            band3.Children.Add(band12);
            //Add parent bands to C1FlexGridBandedView control
            c1FlexGridBandedView1.Bands.Add(band1);
            c1FlexGridBandedView1.Bands.Add(band2);
            c1FlexGridBandedView1.Bands.Add(band3);
            //Set the existing grid to C1FlexGridBandedView
            c1FlexGridBandedView1.FlexGrid = this.c1FlexGrid1;
        }

        private void pdfExportButton_Click(object sender, EventArgs e)
        {
            var printDocument = c1FlexGrid1.PrintParameters.PrintDocument;
            c1FlexGrid1.PrintParameters.PrintGridFlags = PrintGridFlags.FitToPageWidth;
            printDocument.PrinterSettings.PrinterName = "Microsoft Print to PDF";
            // Print document into Microsoft PDF printer
            printDocument.Print();
        }

        private void excelExportButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.DefaultExt = "xlsx";
            saveFileDialog1.Filter = ".xlsx Files (*.xlsx)|*.xlsx";
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                c1FlexGrid1.SaveExcel(saveFileDialog1.FileName, FileFlags.AsDisplayed| FileFlags.IncludeMergedRanges|FileFlags.IncludeFixedCells|FileFlags.SaveMergedRanges);
            }
        }
    }
}