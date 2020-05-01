using Aula3004.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Xml.Serialization;

namespace Aula3004
{
    class Program
    {
        static void Main(string[] args)

        {
            List<Product> list = new List<Product>();



            Console.Write("Enter the number products ");
            int P = int.Parse(Console.ReadLine());
            for (int i = 1; i <= P; i++)
            {
                Console.WriteLine($" Product #{i} Data");
                Console.WriteLine("Name");
                string name = Console.ReadLine();
                Console.WriteLine("Price");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Common,used or imported (c/u/i)?");
                char ch = char.Parse(Console.ReadLine());
                if (ch == 'c' || ch == 'C')
                {
                    list.Add(new Product(name, price));
                }
                else if (ch == 'i' || ch == 'I')
                {
                    Console.WriteLine("Value Custome Fee");
                    double CustomesFree = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new ImportedProduct(name, price, CustomesFree));

                }
                else
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(name, price, date));
                }


            }
            Console.WriteLine();

            Console.WriteLine("PRICE TAGS");
            Console.WriteLine();
            foreach (Product prod in list)
            {
                Console.WriteLine(prod.PriceTag());
            }


        }
    }
}
