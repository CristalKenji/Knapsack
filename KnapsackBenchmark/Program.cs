using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using Knapsack;
using Knapsack.Algorithmen;

namespace KnapsackBenchmark
{
    public class Program
    {
        private readonly Greedy greedy = new Greedy();

        private InputSet inputSet = InputParser.ParseInputFile("LowDimensional\\f1_4_11");

        [Benchmark]
        public void Greedy()
        {
            greedy.Solve(inputSet);
        }

        private static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<Program>();
        }
    }
}