using System;

namespace Knapsack
{
    public class Item
    {
        private string name;
        private int value;
        private int weight;

        public string Name { get; set; }
        public int Weight { get; set; }
        public int Value { get; set; }

        public Item(string name, int value, int weight)
        {
            Name = name;
            Value = value;
            Weight = weight;
        }

        public override string ToString()
        {
            return Name + "\tv: " + Value + "\tw: " + Weight;
        }
    }
}