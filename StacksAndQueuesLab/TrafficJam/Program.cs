using System;
using System.Collections.Generic;

namespace TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            int carToPass = int.Parse(Console.ReadLine());

            var queue = new Queue<string>();
            var passedCars = new Queue<string>();

            string command = Console.ReadLine();

            while (command != "end")
            {
                if (command == "green")
                {
                    if (queue.Count < carToPass)
                    {
                        while (queue.Count != 0)
                        {
                            string currentCar = queue.Dequeue();
                            passedCars.Enqueue(currentCar);

                            Console.WriteLine($"{currentCar} passed!");
                        }
                    }

                    else
                    {
                        for (int i = 0; i < carToPass; i++)
                        {
                            string currentCar = queue.Dequeue();
                            passedCars.Enqueue(currentCar);

                            Console.WriteLine($"{currentCar} passed!");
                        }
                    }
                }

                else
                {
                    queue.Enqueue(command);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"{passedCars.Count} cars passed the crossroads.");
        }
    }
}
