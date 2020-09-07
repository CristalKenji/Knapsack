using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using Knapsack;
using Knapsack.Algorithmen;

namespace KnapsackBenchmark
{
    public class KnapsackSolver
    {
        private readonly InputSet inputSet = new InputSet();
        private readonly InputSet inputSet_f1; // = InputParser.ParseInputFile("LowDimensional\\f1_4_11");
        private readonly InputSet inputSet_f2; // = InputParser.ParseInputFile("LowDimensional\\f2_4_20");

        private readonly Greedy greedy = new Greedy();
        private readonly Dynamic dynamic = new Dynamic();
        private readonly MemoryFunction memory = new MemoryFunction();

        public KnapsackSolver()
        {
            inputSet_f1 = InputParser.ParseInputFile("LowDimensional\\f1_4_11");
            //inputSet_f2 = InputParser.ParseInputFile("LowDimensional\\f2_4_20");

            inputSet = inputSet_f1;
        }

        [Benchmark]
        public int Greedy() => greedy.Solve(inputSet);

        [Benchmark(Baseline = true)]
        public int Dynamic() => dynamic.Solve(inputSet);

        [Benchmark]
        public int Memory() => memory.Solve(inputSet);
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run(typeof(Program).Assembly);
        }
    }
}