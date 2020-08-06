using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Knapsack
{
    public static class DP_recursive
    {
        public static int Solve(List<Item> items, int capacity)
        {
            if (items.Count == 0 || capacity == 0) return 0;

            if (items.Count == 1)
            {
                return items[0].Weight < capacity ? items[0].Value : 0;
            }

            int best = 0;

            for (int i = 0; i < items.Count; i++)
            {
                var otherItems = items.Take(i).Concat(items.Skip(i + 1)).ToList();

                int without = Solve(otherItems, capacity);
                int with = 0;

                if (items[i].Weight <= capacity)
                {
                    with = Solve(otherItems, capacity - items[i].Weight) + items[i].Value;
                }

                int currentBest = Math.Max(without, with);

                if (currentBest > best)
                {
                    best = currentBest;
                }
            }
            return best;
        }
    }
}