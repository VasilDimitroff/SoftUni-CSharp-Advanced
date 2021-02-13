using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace ProductShop
{
    class Program
    {
        static void Main(string[] args)
        {
            var stores = new Dictionary<string, Dictionary<string, double>>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Revision")
                {
                    break;
                }

                string[] info = input.Split(", ");

                string storeName = info[0];
                string productName = info[1];
                double price = double.Parse(info[2]);

                if (!stores.ContainsKey(storeName))
                {
                    stores.Add(storeName, new Dictionary<string, double>());
                }

                if (!stores[storeName].ContainsKey(productName))
                {
                    stores[storeName].Add(productName, 0);
                }

                stores[storeName][productName] = price;
            }

            stores = stores.OrderBy(x => x.Key).ToDictionary(x => x.Key, y => y.Value);

            foreach (var store in stores)
            {
                Console.WriteLine($"{store.Key}->");

                foreach (var product in store.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}
