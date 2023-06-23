using System;
using System.IO;
using OfficeOpenXml;

namespace GenerateExcel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (ExcelPackage ExcelPkg = new ExcelPackage())
            {
                ExcelWorksheet wsSheet1 = ExcelPkg.Workbook.Worksheets.Add("Sheet1");
                ExcelWorksheet wsSheet2 = ExcelPkg.Workbook.Worksheets.Add("Sheet2");
                ExcelRange Rng1 = wsSheet1.Cells[2, 2, 2, 2];
                ExcelRange Rng2 = wsSheet2.Cells[2, 2, 2, 2];
                Rng1.Value = "Welcome to Everyday be coding - tutorials for beginners";
                Rng1.Style.Font.Size = 16;
                Rng1.Style.Font.Bold = true;
                Rng1.Style.Font.Italic = true;
                Rng2.Value = "Hello Everybody - try to code - go for advanced!";
                Rng2.Style.Font.Size = 12;
                Rng2.Style.Font.Bold = true;
                Rng2.Style.Font.Italic = false;
                wsSheet1.Protection.IsProtected = false;
                wsSheet1.Protection.AllowSelectLockedCells = false;
                wsSheet2.Protection.IsProtected = false;
                wsSheet2.Protection.AllowSelectLockedCells = false;
                ExcelPkg.SaveAs(new FileInfo("C:/Users/2107154/Demoexcel.xlsx"));
            }
        }
    }
}
