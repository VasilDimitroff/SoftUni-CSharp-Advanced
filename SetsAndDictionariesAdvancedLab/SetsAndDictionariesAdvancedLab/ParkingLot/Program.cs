using System;
using System.Collections.Generic;

namespace ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] info = input.Split(", ");

            HashSet<string> carNumbers = new HashSet<string>();

            while (input != "END")
            {
                string command = info[0];
                string carNumber = info[1];

                if (command == "IN")
                {
                    carNumbers.Add(carNumber);
                }

                else if (command == "OUT")
                {
                    carNumbers.Remove(carNumber);
                }

                input = Console.ReadLine();
                info = input.Split(", ");
            }

            if (carNumbers.Count > 0)
            {
                foreach (var number in carNumbers)
                {
                    Console.WriteLine(number);
                }
            }

            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }


        }
    }
}