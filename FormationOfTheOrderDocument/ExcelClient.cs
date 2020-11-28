using Microsoft.Office.Interop.Excel;
using System.Collections.Generic;

namespace FormationOfTheOrderDocument
{
    class ExcelClient
    {
        public int Count { get; private set; }

        private string _path = "";
        private Worksheet _mainWorkSheet;
        private Application _excel;
        private System.Action _read;

        public ExcelClient(string path, System.Action read)
        {
            _path = path;
            _excel = new Application();
            _excel.Visible = true;
            Worksheet mainWorkSheet = _excel.Workbooks.Open(_path).Sheets[1];
            Range lastCell = mainWorkSheet.Cells.SpecialCells(XlCellType.xlCellTypeLastCell);
            Count = lastCell.Row-1;
        }

        public Models.Product[] GetProducts()
        {
            
            List<Models.Product> products = new List<Models.Product> { };
            for (int i = 2; i <= Count+1; i++)
            {
                products.Add(new Models.Product(_mainWorkSheet.Cells[i,1].Text.Trim(), _mainWorkSheet.Cells[i, 2].Text.Trim(),
                    _mainWorkSheet.Cells[i, 3].Text.Trim(), _mainWorkSheet.Cells[i, 4].Text.Trim()));
                _read?.Invoke();
            }

            return products.ToArray();
        }

        public void CloseExcel()
        {
            _excel.Quit();
        }
    }
}
