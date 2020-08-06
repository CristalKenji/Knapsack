using System;
using System.Collections.Generic;
using System.Text;

namespace Knapsack.Algorithmen
{
    public static class DynamicProgramming
    {
        public static int Solve(List<Item> items, int capacity)
        {
            int[,] matrix = new int[items.Count + 1, capacity + 1];

            for (int itemIndex = 0; itemIndex <= items.Count; itemIndex++)
            {
                Item currentItem = itemIndex == 0 ? null : items[itemIndex - 1];

                for (int currentCapacity = 0; currentCapacity <= capacity; currentCapacity++)
                {
                    if (currentItem == null || currentCapacity == 0)
                    {
                        matrix[itemIndex, currentCapacity] = 0;
                    }
                    else if (currentItem.Weight <= currentCapacity)
                    {
                        matrix[itemIndex, currentCapacity] = (int)Math.Max(
                            currentItem.Value + matrix[itemIndex - 1, currentCapacity - currentItem.Weight],
                            matrix[itemIndex - 1, currentCapacity]);
                    }
                    else
                    {
                        matrix[itemIndex, currentCapacity] = matrix[itemIndex - 1, currentCapacity];
                    }
                }
            }
            return matrix[items.Count, capacity];
        }
    }
}