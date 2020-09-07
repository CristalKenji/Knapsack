using System.Collections.Generic;
using System.Linq;

namespace Knapsack.Algorithmen
{
    public class Greedy
    {
        public int Solve(InputSet inputSet)
        {
            List<Item> items = inputSet.Items;
            int capacity = inputSet.Capacity;

            items = items.OrderByDescending(o => o.Value).ToList();

            int value = 0;
            int currentCapacity = capacity;

            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].Weight <= currentCapacity)
                {
                    value += items[i].Value;
                    currentCapacity -= items[i].Weight;

                    if (currentCapacity <= 0)
                    {
                        break;
                    }
                }
            }
            return value;
        }
    }
}