namespace Knapsack
{
    public class Item
    {
        public string Name { get; set; }
        public int Weight { get; set; }
        public int Value { get; set; }

        public Item(int weight, int value) : this("Item", weight, value)
        {
        }

        public Item(string name, int weight, int value)
        {
            Name = name;
            Weight = weight;
            Value = value;
        }

        public override string ToString()
        {
            return Name + "\tw: " + Weight + "\tv: " + Value;
        }
    }
}