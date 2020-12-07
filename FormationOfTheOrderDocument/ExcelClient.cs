using System;
using Microsoft.Office.Interop.Excel;
using System.Collections.Generic;

namespace FormationOfTheOrderDocument
{
    class ExcelClient : IDisposable
    {
        public int Count { get; private set; }

        private string _path = "";
        private Worksheet _mainWorkSheet;
        private Workbook _mainWorkBook;
        private Application _excel;
        private System.Action _read;

        public ExcelClient(string path, System.Action read)
        {
            _path = path;
            _excel = new Application();
            _read = read;
            _excel.Visible = false;
            _mainWorkBook = _excel.Workbooks.Open(_path);
            _mainWorkSheet = _mainWorkBook.Sheets[1];
            Range lastCell = _mainWorkSheet.Cells.SpecialCells(XlCellType.xlCellTypeLastCell);
            Count = lastCell.Row-1;
        }

        public Models.Product[] GetProducts()
        {
            
            List<Models.Product> products = new List<Models.Product> { };
            for (int i = 2; i <= Count+1; i++)
            {
                products.Add(new Models.Product(_mainWorkSheet.Cells[i,1].Text.Trim(), _mainWorkSheet.Cells[i, 2].Text.Trim(),
                    _mainWorkSheet.Cells[i, 3].Text.Trim(), _mainWorkSheet.Cells[i, 4].Text.Trim().ToString()));
                _read?.Invoke();
            }

            return products.ToArray();
        }
        

        private void ReleaseUnmanagedResources()
        {
            _mainWorkBook.Close();
            _excel.Quit();
        }

        public void Dispose()
        {
            ReleaseUnmanagedResources();
            GC.SuppressFinalize(this);
        }

        ~ExcelClient()
        {
            ReleaseUnmanagedResources();
        }
    }
}
