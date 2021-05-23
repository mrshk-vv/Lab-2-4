using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using BaseExporter.Contracts;
using BaseExporter.Entity;
using Word = Microsoft.Office.Interop.Word;

namespace WordExport.Impl
{
    public class WordExporter : IBaseExporter<WordExporter>
    {
        private object _endOfDocFlag;

        private readonly Word.ApplicationClass _wordApplication;
        private Word.Document _wordDocument;

        private readonly string _exportPath;

        public WordExporter(string exportPath)
        {
            _endOfDocFlag = "\\endofdoc";

            _wordApplication = new Word.ApplicationClass
            {
                Visible = true,
                WindowState = Word.WdWindowState.wdWindowStateMinimize
            };

            _exportPath = exportPath;

        }
        public WordExporter CreateExportDoc()
        {
            var wordApp = new Word.ApplicationClass
            {
                Visible = true,
                WindowState = Word.WdWindowState.wdWindowStateMinimize
            };

            object wordMiss = System.Reflection.Missing.Value;

            _wordDocument = wordApp.Documents.Add(ref wordMiss, ref wordMiss,
                ref wordMiss, ref wordMiss);

            return this;
        }

        public WordExporter AddTable<T>(List<T> data)
        {
            if (_wordDocument is null)
                throw new ApplicationException("Word file wasn't created");

            var tableConfig = new TableConfig<T>();

            var rows = data.Count() + 1;
            var columns = tableConfig.DisplayedColumns.Count;

            object oRng = _wordDocument.Bookmarks.get_Item
                (ref _endOfDocFlag).Range;

            Word.Paragraph objPara2 = _wordDocument.Content.Paragraphs.Add
                (ref oRng);
            objPara2.Range.Text = tableConfig.Name;
            objPara2.Format.SpaceAfter = 10;
            objPara2.Range.InsertParagraphAfter();

            Word.Range objWordRng = _wordDocument.Bookmarks.get_Item
                (ref _endOfDocFlag).Range;
            Word.Table objTab1 = _wordDocument.Tables.Add(objWordRng, rows, columns);

            objTab1.Range.ParagraphFormat.SpaceAfter = 0;

            objTab1.Borders.InsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
            objTab1.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;

            for (int i = 0; i < tableConfig.DisplayedColumns.Count; i++)
                objTab1.Cell(1, i + 1).Range.Text = tableConfig.DisplayedColumns[i];

            objTab1.Rows[1].Range.Font.Bold = 1;

            for (var row = 2; row <= rows; row++)
            {
                for (int col = 1; col <= columns; col++)
                {
                    var currentDataItem = data[row - 2];

                    var props = (from p in currentDataItem.GetType().GetProperties()
                        let attr = p.GetCustomAttributes(typeof(DisplayNameAttribute), true)
                        where attr.Length == 1
                        select new { Property = p, Attribute = attr.First() as DisplayNameAttribute }).ToList();

                    var headerValue = objTab1.Cell(1, col).Range.Text.Trim('\r', '\a');

                    var prop = props.FirstOrDefault(x => x.Attribute.DisplayName == headerValue);

                    objTab1.Cell(row, col).Range.Text = currentDataItem.GetType()
                                                                       .GetProperty(prop?.Property?.Name)
                                                                       .GetValue(currentDataItem, null)
                                                                       .ToString();
                }
            }

            _wordDocument.Words.Last.InsertBreak(Word.WdBreakType.wdPageBreak);

            return this;

        }

        public void SaveExportDoc()
        {
            _wordDocument.SaveAs2($"{_exportPath}.docx");
            _wordDocument.Close();
            _wordApplication.Quit();

            GC.Collect();
        }
    }
}
