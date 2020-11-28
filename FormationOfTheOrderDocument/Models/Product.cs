using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationOfTheOrderDocument.Models
{
    class Product
    {
        public string BarCode { get; private set; }

        public string Count { get; private set; }

        public string Price { get; private set; }

        public string Name { get; private set; }

        public Product(string barcode, string count, string price, string name)
        {
            BarCode = barcode;
            Count = count;
            Price = price;
            Name = name;
        }
    }
}
