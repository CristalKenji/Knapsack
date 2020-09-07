using System;
using System.Collections.Generic;

namespace Knapsack.Algorithmen
{
    public class Dynamic
    {
        private int[,] matrix;
        private List<Item> items;
        private int capacity;
        private Bag bag;

        public int Solve(InputSet inputSet)
        {
            int numItems = inputSet.Items.Count;
            capacity = inputSet.Capacity;
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
            return matrix[numItems, capacity];
        }

        public Bag getItemBag()
        {
            if (matrix == null)
            {
                return null;
            }
            bag = new Bag(capacity);
            checkItem(items.Count, capacity);
            return bag;
        }

        private void checkItem(int i, int w)
        {
            if (i <= 0 || w <= 0)
            {
                return;
            }

            if (matrix[i, w] != matrix[i - 1, w])
            {
                bag.addItem(items[i - 1]);
                checkItem(i - 1, w - items[i - 1].Weight);
            }
            else
            {
                checkItem(i - 1, w);
            }
        }
    }
}