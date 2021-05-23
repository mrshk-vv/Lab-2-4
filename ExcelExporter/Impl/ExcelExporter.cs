using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using BaseExporter.Contracts;
using BaseExporter.Entity;
using Excel = Microsoft.Office.Interop.Excel;

namespace ExcelExporter.Impl
{
    public class ExcelExporter : IBaseExporter<ExcelExporter>
    {
        private readonly Excel.ApplicationClass _excelApp;
        private readonly string[] ExcelColumns = new[]
        {
            "A", "B", "C", "D", "E", "F", "G", "H", "I", "K"
        };
        private Excel.Workbook _excelWorkbook;

        private readonly int _workSheetsCount;
        private readonly string _exportPath;
        private int _currentSheet = 1;


        public ExcelExporter(string exportPath, int workSheetsCount)
        {
            _excelApp = new Excel.ApplicationClass
            {
                Visible = true,
                SheetsInNewWorkbook = workSheetsCount
            };

            _exportPath = exportPath;
            _workSheetsCount = workSheetsCount;
        }
        public ExcelExporter CreateExportDoc()
        {
            _excelWorkbook = _excelApp.Workbooks.Add(Type.Missing);

            return this;
        }

        public ExcelExporter CreateSheet<T>(List<T> data)
        {
            if (_excelWorkbook is null)
                throw new ApplicationException("Excel file wasn't created");

            var tableConfig = new TableConfig<T>();

            var rows = data.Count() + 1;
            var columns = tableConfig.DisplayedColumns.Count;

            Excel.Worksheet sheet = (Excel.Worksheet)_excelWorkbook.Worksheets.get_Item(_currentSheet);

            sheet.Name = tableConfig.Name;

            for (int i = 1; i <= columns; i++)
            {
                sheet.Cells[1, i] = tableConfig.DisplayedColumns[i - 1];

                var cellRange = sheet.Cells[1, i] as Excel.Range;
                cellRange.Font.Bold = true;
                cellRange.Interior.Color = ColorTranslator.ToOle(Color.SeaGreen);
            }


            for (var row = 2; row <= rows; row++)
            {
                for (int col = 1; col <= columns; col++)
                {
                    var currentDataItem = data[row - 2];

                    var props = (from p in currentDataItem.GetType().GetProperties()
                        let attr = p.GetCustomAttributes(typeof(DisplayNameAttribute), true)
                        where attr.Length == 1
                        select new { Property = p, Attribute = attr.First() as DisplayNameAttribute }).ToList();

                    var headerValue = sheet.Cells[1, col] as Excel.Range;


                    var prop = props.FirstOrDefault(x => x.Attribute.DisplayName == headerValue?.Text as string);

                    sheet.Cells[row, col] = currentDataItem.GetType()
                        .GetProperty(prop?.Property?.Name)
                        .GetValue(currentDataItem, null)
                        .ToString();
                }
            }

            _currentSheet++;

            return this;
            
        }

        public void SaveExportDoc()
        {
            _excelApp.Application.ActiveWorkbook.SaveAs($"{_exportPath}.xlsx", Type.Missing,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing, Excel.XlSaveAsAccessMode.xlNoChange,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            _excelWorkbook.Close();
            _excelApp.Quit();

            GC.Collect();
        }
    }
}
