using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationOfTheOrderDocument.Models
{
    class Product
    {
        public string BarCode { get; }

        public string Count { get;}

        public string Price { get; }

        public string Name { get;}

        public Product(string barcode, string count, string price, string name)
        {
            BarCode = barcode;
            Count = count;
            Price = price;
            name = name.Replace("&", "&amp")
                .Replace("\"", "&quot")
                .Replace("<", "&lt")
                .Replace(">", "&gt");
            Name = name;
        }
    }
}
