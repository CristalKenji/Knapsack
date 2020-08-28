using System;
using System.Collections.Generic;
using System.Text;

namespace Knapsack.Algorithmen
{
    public class Dynamic
    {
        private int[,] matrix;
        private List<Item> items;

        public int Solve(InputSet inputSet)
        {
            int numItems = inputSet.Items.Count;
            int capacity = inputSet.Capacity;
            items = inputSet.Items;

            matrix = new int[numItems + 1, capacity + 1];
            int leaveItem;
            int takeItem;

            for (int i = 1; i <= numItems; i++)
            {
                for (int j = 1; j <= capacity; j++)
                {
                    if (items[i - 1].Weight <= j)
                    {
                        leaveItem = matrix[i - 1, j];
                        takeItem = items[i - 1].Value + matrix[i - 1, j - items[i - 1].Weight];

                        matrix[i, j] = Math.Max(leaveItem, takeItem);
                    }
                    else
                    {
                        matrix[i, j] = matrix[i - 1, j];
                    }
                }
            }
            //for (int i = 0; i <= numItems; i++)
            //{
            //    for (int j = 0; j <= capacity; j++)
            //    {
            //        Console.Write(matrix[i, j] + "  ");
            //    }
            //    Console.WriteLine();
            //}
            return matrix[numItems, capacity];
        }
    }
}