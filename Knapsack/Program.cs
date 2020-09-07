using Knapsack.Algorithmen;
using System.Collections.Generic;

namespace Knapsack
{
    internal class Program
    {
        private static Greedy greedy = new Greedy();
        private static Dynamic dynamic = new Dynamic();
        private static MemoryFunction memory = new MemoryFunction();

        private static void Main(string[] args)
        {
            // Test-Set Import
            List<InputSet> inputSets_ld = parse_LD_TestSet();  //LowDimensional
            List<InputSet> inputSets_ls = parse_LS_TestSet(); //LargeScale

            //**************************************************************************
            // Algorithmen Test
            //**************************************************************************
            printTestToConsole(inputSets_ld, false);
            printTestToConsole(inputSets_ls, true);

            // for performance reasons set inputSets_ls[6] has to be testet individually
            //int index = 6;
            //Test.printTest(inputSets_ls[index], index - 1, greedy.Solve(inputSets_ls[index]), memory.Solve(inputSets_ls[index]), dynamic.Solve(inputSets_ls[index]));

            //*************************************************
            // Get Itemlist Example
            //dynamic.Solve(inputSets_ld[3]);
            //Bag bag = dynamic.getItemBag();
            //bag.printContent();

            //*************************************************
            // Test-output to File
            //printTestToFile(inputSets_ld, "LowDimensional-TestResult", false);
            //printTestToFile(inputSets_ls, "LargeScale-TestResult", true);
            //int setIndex = 6;
            //Test.writeTestToFile("LargeScale-TestResult", inputSets_ls[setIndex], setIndex + 1, greedy.Solve(inputSets_ls[setIndex]), memory.Solve(inputSets_ls[setIndex]), dynamic.Solve(inputSets_ls[setIndex]));
        }

        private static List<InputSet> parse_LD_TestSet()
        {
            List<InputSet> inputSets_ld = new List<InputSet>();
            inputSets_ld.Add(InputParser.ParseInputFile("LowDimensional\\f1_4_11"));
            inputSets_ld.Add(InputParser.ParseInputFile("LowDimensional\\f2_4_20"));
            inputSets_ld.Add(InputParser.ParseInputFile("LowDimensional\\f3_5_80"));
            inputSets_ld.Add(InputParser.ParseInputFile("LowDimensional\\f4_7_50"));
            inputSets_ld.Add(InputParser.ParseInputFile("LowDimensional\\f5_10_60"));
            inputSets_ld.Add(InputParser.ParseInputFile("LowDimensional\\f6_10_269"));
            inputSets_ld.Add(InputParser.ParseInputFile("LowDimensional\\f7_20_878"));
            inputSets_ld.Add(InputParser.ParseInputFile("LowDimensional\\f8_23_10000"));
            return inputSets_ld;
        }

        private static List<InputSet> parse_LS_TestSet()
        {
            List<InputSet> inputSets_ls = new List<InputSet>();
            inputSets_ls.Add(InputParser.ParseInputFile("LargeScale\\f1_100_995"));
            inputSets_ls.Add(InputParser.ParseInputFile("LargeScale\\f2_200_1008"));
            inputSets_ls.Add(InputParser.ParseInputFile("LargeScale\\f3_500_2543"));
            inputSets_ls.Add(InputParser.ParseInputFile("LargeScale\\f4_1000_5002"));
            inputSets_ls.Add(InputParser.ParseInputFile("LargeScale\\f5_2000_10011"));
            inputSets_ls.Add(InputParser.ParseInputFile("LargeScale\\f6_5000_25016"));
            inputSets_ls.Add(InputParser.ParseInputFile("LargeScale\\f7_10000_49877"));
            return inputSets_ls;
        }

        private static void printTestToConsole(List<InputSet> inputsets, bool isLargeScale)
        {
            int bound = isLargeScale ? inputsets.Count - 1 : inputsets.Count;
            for (int i = 0; i < bound; i++)
            {
                Test.printTest(inputsets[i], i + 1, greedy.Solve(inputsets[i]), memory.Solve(inputsets[i]), dynamic.Solve(inputsets[i]));
            }
        }

        private static void printTestToFile(List<InputSet> inputsets, string filename, bool isLargeScale)
        {
            int bound = isLargeScale ? inputsets.Count - 1 : inputsets.Count;
            for (int i = 0; i < bound; i++)
            {
                Test.writeTestToFile(filename, inputsets[i], i + 1, greedy.Solve(inputsets[i]), memory.Solve(inputsets[i]), dynamic.Solve(inputsets[i]));
            }
        }
    }
}