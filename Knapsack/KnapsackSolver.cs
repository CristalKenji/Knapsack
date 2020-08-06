using Knapsack.Algorithmen;
using System;
using System.Collections.Generic;
using System.Text;

namespace Knapsack
{
    internal static class KnapsackSolver
    {
        public enum AlgorithmType { Greedy, DynamicProgramming, DP_recursive };

        private static void Init()
        {
            // Shuffelt den Input vor jedem run um Abhängigkeiten zwischen der Sortierung der Gegenstände und der Performance des Algorithmus vorzubeugen
        }

        public static void Solve(AlgorithmType algorithm, List<Item> items, int capacity)
        {
            Init();

            switch (algorithm)
            {
                case AlgorithmType.Greedy:
                    Console.WriteLine(algorithm + ": result " + Greedy.Solve(items, capacity));
                    break;

                case AlgorithmType.DynamicProgramming:
                    Console.WriteLine(algorithm + ": result " + DynamicProgramming.Solve(items, capacity));
                    break;

                case AlgorithmType.DP_recursive:
                    Console.WriteLine(algorithm + ": result " + DP_recursive.Solve(items, capacity));
                    break;
            }
        }
    }
}