using ConsoleTables;
using System;
using System.Collections.Generic;
using System.Text;

namespace Knapsack
{
    public class Bag
    {
        private int maxBagWeight;
        private int currItemsWeight = 0;
        private int totalValue = 0;
        private List<Item> items;
        public int TotalValue { get => totalValue; set => totalValue = value; }

        public Bag(int maxBagWeight)
        {
            this.maxBagWeight = maxBagWeight;
            items = new List<Item>();
        }

        public bool addItem(Item i)
        {
            if (currItemsWeight + i.Weight <= maxBagWeight)
            {
                currItemsWeight += i.Weight;
                TotalValue += i.Value;
                items.Add(i);
                return true;
            }
            else
            {
                // could not fit item
                return false;
            }
        }

        public void printContent()
        {
            var table = new ConsoleTable("Item", "Weight", "Value");

            items.ForEach(delegate (Item i) { table.AddRow(i.Name, i.Weight, i.Value); });

            Console.ForegroundColor = ConsoleColor.Yellow;
            table.AddRow("TotalValue:", totalValue, "");
            Console.ForegroundColor = ConsoleColor.Gray;

            table.Write();
        }
    }
}