using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int foodQuantity = int.Parse(Console.ReadLine());
            int[] orders = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> allOrders = new Queue<int>(orders);
            Queue<int> unservedOrders = new Queue<int>();

            int maxOrder = int.MinValue;

            Queue<int> maxOrderQueue = new Queue<int>(allOrders);
            int iterations = maxOrderQueue.Count;

            for (int i = 0; i < iterations; i++)
            {
                if (maxOrderQueue.Peek() > maxOrder)
                {
                    maxOrder = maxOrderQueue.Peek();
                }

                maxOrderQueue.Dequeue();
            }

            Console.WriteLine(maxOrder);

            for (int i = 0; i < iterations; i++)
            {
                if (foodQuantity >= allOrders.Peek())
                {
                    foodQuantity -= allOrders.Peek();
                }

                else
                {
                    int currentOrder = allOrders.Peek();
                    unservedOrders.Enqueue(currentOrder);
                }

                allOrders.Dequeue();
            }

            if (unservedOrders.Count == 0)
            {
                Console.WriteLine("Orders complete");
            }

            else
            {
                Console.WriteLine($"Orders left: {String.Join(" ", unservedOrders)}");
            }
        }
    }
}
