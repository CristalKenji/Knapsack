namespace Knapsack
{
    internal class Item
    {
        //private string name;
        private uint _value;

        private uint _weight;

        public string Name { get; set; }

        public uint Value
        {
            get { return _value; }
            set
            {
                if (value <= 0) throw new System.ArgumentException("Parameter cannot be 0", "Value");
                _value = value;
            }
        }

        public uint Weight
        {
            get { return _weight; }
            set
            {
                if (value <= 0) throw new System.ArgumentException("Parameter cannot be 0", "Weight");
                _weight = value;
            }
        }

        public Item(string name, uint value, uint weight)
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