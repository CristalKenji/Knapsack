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
            //**************************************************************************
            // Algorithms
            //**************************************************************************
            Greedy greedy = new Greedy();
            Dynamic dynamic = new Dynamic();
            MemoryFunction memory = new MemoryFunction();
            //###############################################################################################################################################################################
            //**************************************************************************
            // LowDimensional Test-Sets
            //**************************************************************************
            List<InputSet> inputSets_ld = new List<InputSet>();
            inputSets_ld.Add(InputParser.ParseInputFile("LowDimensional\\f1_4_11"));
            inputSets_ld.Add(InputParser.ParseInputFile("LowDimensional\\f2_4_20"));
            inputSets_ld.Add(InputParser.ParseInputFile("LowDimensional\\f3_5_80"));
            inputSets_ld.Add(InputParser.ParseInputFile("LowDimensional\\f4_7_50"));
            inputSets_ld.Add(InputParser.ParseInputFile("LowDimensional\\f5_10_60"));
            inputSets_ld.Add(InputParser.ParseInputFile("LowDimensional\\f6_10_269"));
            inputSets_ld.Add(InputParser.ParseInputFile("LowDimensional\\f7_20_878"));
            inputSets_ld.Add(InputParser.ParseInputFile("LowDimensional\\f8_23_10000"));

            //**************************************************************************
            // Print LowDimensional Test-Sets
            //**************************************************************************
            //inputSets_ld.ForEach(delegate (InputSet inputSet) { inputSet.printSet(); });
            //inputSets_ld[0].printSet();

            //**************************************************************************
            // LowDimensional Test-output to Console
            //**************************************************************************
            //Test.printTest(inputSets_ld[4], 5, greedy.Solve(inputSets_ld[4]), memory.Solve(inputSets_ld[4]), dynamic.Solve(inputSets_ld[4]));

            //int setNum = 1;
            //inputSets_ld.ForEach(delegate (InputSet inputset)
            //{
            //    Test.printTest(inputset, setNum, greedy.Solve(inputset), memory.Solve(inputset), dynamic.Solve(inputset));
            //    setNum++;
            //});

            //**************************************************************************
            // LowDimensional Test-output to File
            //**************************************************************************
            //int setNum = 1;
            //inputSets_ld.ForEach(delegate (InputSet inputset)
            //{
            //    Test.writeTestToFile("LowDimensional-TestResult", inputset, setNum, greedy.Solve(inputset), memory.Solve(inputset), dynamic.Solve(inputset));
            //    setNum++;
            //});

            int setIndex = 0;
            Test.writeTestToFile("LowDimensional-TestResult", inputSets_ld[setIndex], setIndex + 1, greedy.Solve(inputSets_ld[setIndex]), memory.Solve(inputSets_ld[setIndex]), dynamic.Solve(inputSets_ld[setIndex]));
            //###############################################################################################################################################################################
            //**************************************************************************
            // LargeScale Test-Sets
            //**************************************************************************

            //**************************************************************************
            // LargeScale Test-output to File
            //**************************************************************************
        }
    }
}