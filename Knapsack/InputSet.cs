using ConsoleTables;
using System;
using System.Collections.Generic;
using System.Text;

namespace Knapsack
{
    public class InputSet
    {
        private int capacity;
        private List<Item> items;
        private int optimalValue;

        public int Capacity { get => capacity; set => capacity = value; }
        public List<Item> Items { get => items; }
        public int OptimalValue { get => optimalValue; set => optimalValue = value; }

        public InputSet()
        {
            items = new List<Item>();
        }

        public void addItem(Item i)
        {
            items.Add(i);
        }

        public void printSet()
        {
            var table = new ConsoleTable("Item", "Weight", "Value");

            items.ForEach(delegate (Item i) { table.AddRow(i.Name, i.Weight, i.Value); });

            Console.ForegroundColor = ConsoleColor.Yellow;
            table.AddRow("Kapazität: " + capacity, " ", "OptimalValue: " + optimalValue);
            Console.ForegroundColor = ConsoleColor.Gray;

            table.Write();
        }
    }
}