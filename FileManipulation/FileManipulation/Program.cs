using System;
using System.IO;
using FileManipulation.Entities;
using System.Globalization;
namespace FileManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = (@"C:\Users\~\Documents\csv\produtos.csv");
            string target = (@"C:\Users\~\Documents\csv\relatorios.csv");

            try
            {
                using (StreamWriter sw = File.AppendText(target))
                {
                    string[] lines = File.ReadAllLines(path);


                    foreach (string line in lines)
                    {
                        string[] field = line.Split(",");
                        string name = field[0];
                        double price = double.Parse(field[1], CultureInfo.InvariantCulture);
                        int quantity = int.Parse(field[2]);
                        Product p = new Product(name, price, quantity);

                        sw.WriteLine(p);
                    }
                }
            }catch(IOException e)
            {
                Console.WriteLine("Error " + e.Message);
            }
        }
    }
}
