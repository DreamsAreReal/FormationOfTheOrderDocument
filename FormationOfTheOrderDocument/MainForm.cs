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

        string _xml = "";

        private void OnOpenExcelButtonClick(object sender, EventArgs e)
        {
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog.FileName;
                string extention = path.Split('.')[1];
                if(extention== "xls" || extention== "xlsx")
                {
                    progressBar.Value = 0;
                    ((Button)sender).Enabled = false;
                    Task.Run(() =>
                    {
                        ExcelClient excelClient = new ExcelClient(path, OnRead);
                        SetMaximumSteps(excelClient.Count);
                        Models.Product[] products = excelClient.GetProducts();
                        excelClient.CloseExcel();
                        XMLSerialization serialization = new XMLSerialization();
                        _xml = serialization.GetXML(products, OnGenerateXML);
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

        private void OnGenerateXML()
        {
            saveXMLButton.Invoke(new Action(() =>
            {
                saveXMLButton.Enabled = true;
            })); 
        }

        private void OnSaveXMLButtonClick(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                System.IO.File.WriteAllText(saveFileDialog.FileName+".xml", _xml, Encoding.GetEncoding(1251));
                openExcelButton.Enabled = true;
                saveXMLButton.Enabled = false;
            }
        }
    }
}
