using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace FileManipulation.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public Product()
        {

        }

        public Product(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }
        public double Preco()
        {
            return Price * Quantity;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{Name}, {Preco().ToString("F2", CultureInfo.InvariantCulture)}");
            return sb.ToString();
        }
    }
}
