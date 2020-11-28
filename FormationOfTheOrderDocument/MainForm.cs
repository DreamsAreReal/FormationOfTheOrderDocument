using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormationOfTheOrderDocument
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        Models.Product[] _products;

        private void OnOpenExcelButtonClick(object sender, EventArgs e)
        {
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog.FileName;
                string extention = path.Split('.')[1];
                if(extention== "xls" || extention== "xlsx")
                {
                    
                    Task.Run(() =>
                    {
                        ExcelClient excelClient = new ExcelClient(path, OnRead);
                        SetMaximumSteps(excelClient.Count + 1);
                        _products = excelClient.GetProducts();
                        excelClient.CloseExcel();
                    });
                }
            }
        }

        private void SetMaximumSteps(int maxstep)
        {
            progressBar.Invoke(new Action(() =>
            {
                progressBar.Maximum = maxstep;
            }));
        }

        private void OnRead()
        {
            progressBar.Invoke(new Action(()=> {
                progressBar.Value++;
            }));
        }

        private void OnSaveXMLButtonClick(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                
            }
        }
    }
}
