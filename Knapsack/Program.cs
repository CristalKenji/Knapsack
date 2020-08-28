using ConsoleTables;
using Knapsack.Algorithmen;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Knapsack
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //List<Item> items = new List<Item>();

            //items.Add(new Item("A", 60, 10));
            //items.Add(new Item("B", 100, 20));
            //items.Add(new Item("C", 120, 30));

            //int capacity = 50;

            //KnapsackSolver.Solve(KnapsackSolver.AlgorithmType.Greedy, items, capacity);

            //KnapsackSolver.Solve(KnapsackSolver.AlgorithmType.DynamicProgramming, items, capacity);

            //KnapsackSolver.Solve(KnapsackSolver.AlgorithmType.DP_recursive, items, capacity);

            //var table = new ConsoleTable("Algorithmus", "Num Items", "Total Value");
            //table.AddRow(1, 2, 3)
            //     .AddRow("this line should be longer", "yes it is", "oh");

            //table.Write();

            InputSet set1 = InputParser.ParseInputFile("LowDimensional\\f1_4_11");
            InputSet set2 = InputParser.ParseInputFile("LowDimensional\\f2_4_20");
            //InputSet set3 = InputParser.ParseInputFile("LowDimensional\\f3_5_80");
            InputSet set4 = InputParser.ParseInputFile("LowDimensional\\f4_7_50");
            InputSet set5 = InputParser.ParseInputFile("LowDimensional\\f5_10_60");
            InputSet set6 = InputParser.ParseInputFile("LowDimensional\\f6_10_269");
            //InputSet set7 = InputParser.ParseInputFile("LowDimensional\\f7_20_878");
            //InputSet set8 = InputParser.ParseInputFile("LowDimensional\\f8_23_10000");

            //set1.printSet();
            //set2.printSet();
            //set3.printSet();
            //set4.printSet();
            //set5.printSet();
            //set6.printSet();
            //set7.printSet();
            //set8.printSet();

            //KnapsackSolver.Solve(KnapsackSolver.AlgorithmType.Greedy, set1.Items, set1.Capacity);
            //KnapsackSolver.Solve(KnapsackSolver.AlgorithmType.DynamicProgramming, set1.Items, set1.Capacity);
            //KnapsackSolver.Solve(KnapsackSolver.AlgorithmType.DP_recursive, set1.Items, set1.Capacity);

            MemoryFunction memory = new MemoryFunction();
            Console.WriteLine("Value: " + memory.Solve(set5));

            //Dynamic dynamic = new Dynamic();
            //Console.WriteLine("Value: " + dynamic.Solve(set5));
        }
    }
}