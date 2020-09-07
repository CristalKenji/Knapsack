using System;
using System.Collections.Generic;

namespace Knapsack.Algorithmen
{
    public class MemoryFunction
    {
        private int[,] matrix;
        private List<Item> items;

        public int Solve(InputSet inputSet)
        {
            int numItems = inputSet.Items.Count;
            int capacity = inputSet.Capacity;
            matrix = new int[numItems + 1, capacity + 1];
            items = inputSet.Items;

            for (int i = 0; i <= numItems; i++)
            {
                for (int j = 0; j <= capacity; j++)
                {
                    matrix[i, j] = 0;
                }
            }

            for (int i = 1; i <= numItems; i++)
            {
                for (int j = 1; j <= capacity; j++)
                {
                    matrix[i, j] = -1;
                }
            }
            return MemFunc(numItems, capacity);
        }

        private int MemFunc(int numItems, int capacity)
        {
            if (matrix[numItems, capacity] < 0)
            {
                int value;
                if (capacity < items[numItems - 1].Weight)
                {
                    value = MemFunc(numItems - 1, capacity);
                }
                else
                {
                    value = Math.Max(MemFunc(numItems - 1, capacity), items[numItems - 1].Value + MemFunc(numItems - 1, capacity - items[numItems - 1].Weight));
                }
                matrix[numItems, capacity] = value;
            }
            return matrix[numItems, capacity];
        }
    }
}