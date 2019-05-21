using backendHackathone.PresentLayer.Models;
using OfficeOpenXml;
using System.Collections.Generic;
using System.IO;

namespace backendHackathone.PresentLayer.Excel
{
    public class ExcelParser : IExcelParser
    {
        public UserTable Parse(Stream stream)
        {
            using (var package = new ExcelPackage(stream))
            {
                var worksheet = package.Workbook.Worksheets[2];
                var rowCount = worksheet.Dimension?.Rows;
                var colCount = worksheet.Dimension?.Columns;

                if (!rowCount.HasValue || !colCount.HasValue)
                    return null;

                var userTable = new UserTable();
                for (var col = 1; col <= colCount.Value; col++)
                {
                    var headerValue = (worksheet.Cells[6, col].Value ?? worksheet.Cells[5, col].Value) as string;
                    if (headerValue == null) break;

                    userTable.Data[headerValue] = new List<object>();

                    for (var row = 7; row <= rowCount.Value; row++)
                    {
                        var value = worksheet.Cells[row, col].Value;
                        if (value == null) break;

                        userTable.Data[headerValue].Add(value);
                    }
                }

                return userTable;
            }
        }
    }
}
