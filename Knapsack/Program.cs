using System;
using System.Collections.Generic;

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
        }
    }
}