using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationOfTheOrderDocument
{
    class ExcelClient
    {
        private string _path = "";

        public ExcelClient(string path)
        {
            _path = path;
        }

        public Models.Product[] GetProducts()
        {
            Application excel = new Application();
            excel.Visible = true;
            Worksheet mainWorkSheet = excel.Workbooks.Open(_path).Sheets[1];
            Range lastCell = mainWorkSheet.Cells.SpecialCells(XlCellType.xlCellTypeLastCell);
            List<Models.Product> products = new List<Models.Product> { };
            for (int i = 2; i <= lastCell.Row; i++)
            {
                products.Add(new Models.Product(mainWorkSheet.Cells[i,1].Text.Trim(), mainWorkSheet.Cells[i, 2].Text.Trim(),
                    mainWorkSheet.Cells[i, 3].Text.Trim(), mainWorkSheet.Cells[i, 4].Text.Trim()));
            }


            excel.Quit();

            return products.ToArray();
        }
    }
}
