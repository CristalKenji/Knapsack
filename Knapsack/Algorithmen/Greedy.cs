using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Knapsack.Algorithmen
{
    internal static class Greedy
    {
        public static int Solve(List<Item> items, int capacity)
        {
            items = items.OrderByDescending(o => o.Value).ToList();

            //items.ForEach(i => Console.Write("\n" + i));

            int value = 0;
            int currentCapacity = capacity;

            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].Weight <= currentCapacity)
                {
                    value += items[i].Value;
                    currentCapacity -= items[i].Weight;

                    if (currentCapacity == 0)
                    {
                        break;
                    }
                }
            }

            return value;
        }
    }
}