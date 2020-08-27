using ConsoleTables;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Knapsack
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            List<Item> items = new List<Item>();

            items.Add(new Item("A", 60, 10));
            items.Add(new Item("B", 100, 20));
            items.Add(new Item("C", 120, 30));

            int capacity = 50;

            KnapsackSolver.Solve(KnapsackSolver.AlgorithmType.Greedy, items, capacity);

            KnapsackSolver.Solve(KnapsackSolver.AlgorithmType.DynamicProgramming, items, capacity);

            KnapsackSolver.Solve(KnapsackSolver.AlgorithmType.DP_recursive, items, capacity);

            //var table = new ConsoleTable("Algorithmus", "Num Items", "Total Value");
            //table.AddRow(1, 2, 3)
            //     .AddRow("this line should be longer", "yes it is", "oh");

            //table.Write();

            //InputSet set1 = InputParser.ParseInputFile("Set1");
            //set1.printSet();

            //KnapsackSolver.Solve(KnapsackSolver.AlgorithmType.Greedy, set1.Items, set1.Capacity);
            //KnapsackSolver.Solve(KnapsackSolver.AlgorithmType.DynamicProgramming, set1.Items, set1.Capacity);
            //KnapsackSolver.Solve(KnapsackSolver.AlgorithmType.DP_recursive, set1.Items, set1.Capacity);
        }
    }
}