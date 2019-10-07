using GemBox.Spreadsheet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess
{
    public static class ExcelWriter
    {
        public static void Write(List<User> data)
        {
            SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");

            var workbook = new ExcelFile();
            ExcelWorksheet worksheet = workbook.Worksheets.Add("Writing");

            // Column width of 8, 30, 16, 20, 9, 11, 9, 9, 4 and 5 characters.
            worksheet.Columns["A"].SetWidth(30, LengthUnit.ZeroCharacterWidth); // FirstName
            worksheet.Columns["B"].SetWidth(30, LengthUnit.ZeroCharacterWidth); // Lastname
            worksheet.Columns["C"].SetWidth(30, LengthUnit.ZeroCharacterWidth); // username
            worksheet.Columns["D"].SetWidth(30, LengthUnit.ZeroCharacterWidth); // date
            worksheet.Columns["E"].SetWidth(30, LengthUnit.ZeroCharacterWidth); // Company

            worksheet.Cells.GetSubrange("A1").Merged = true;
            worksheet.Cells.GetSubrange("B1").Merged = true;
            worksheet.Cells.GetSubrange("C1").Merged = true;
            worksheet.Cells.GetSubrange("D1").Merged = true;
            worksheet.Cells.GetSubrange("E1").Merged = true;

            var style = new CellStyle();
            style.HorizontalAlignment = HorizontalAlignmentStyle.Center;
            style.VerticalAlignment = VerticalAlignmentStyle.Center;
            style.Font.Weight = ExcelFont.BoldWeight;
            style.WrapText = true;

            worksheet.Cells.GetSubrange("A1:F1").Style = style;

            worksheet.Cells[0, 0].Value = "First Name";
            worksheet.Cells[0, 1].Value = "Last Name";
            worksheet.Cells[0, 2].Value = "Username";
            worksheet.Cells[0, 3].Value = "Date Of birth";
            worksheet.Cells[0, 4].Value = "Company";

            for (int i = 1; i <= data.Count(); i++)
            {
                worksheet.Cells[i, 0].Value = data[i-1].FirstName;
                worksheet.Cells[i, 1].Value = data[i-1].LastName;
                worksheet.Cells[i, 2].Value = data[i-1].Username;
                worksheet.Cells[i, 3].Value = data[i-1].DateOfBirth;
                worksheet.Cells[i, 4].Value = data[i-1].Company.Name;
                worksheet.Cells[i, 3].Style.HorizontalAlignment = HorizontalAlignmentStyle.Center;
            }

            worksheet.PrintOptions.FitWorksheetWidthToPages = 1;

            workbook.Save("Writing.xlsx"); // will save it in the same folder with app
        }
    }
}
