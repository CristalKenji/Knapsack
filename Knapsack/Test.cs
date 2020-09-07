using ConsoleTables;
using System;
using System.IO;

namespace Knapsack
{
    public static class Test
    {
        public static void printTest(InputSet inputSet, int testNum, int greedyResult, int dynamicResult, int memoryResult)
        {
            var table = new ConsoleTable("Test-Num: " + testNum, "Items: " + inputSet.Items.Count, "Capacity: " + inputSet.Capacity);
            table.AddRow("Algorithm", "Result", "OptimalValue: " + inputSet.OptimalValue);
            table.AddRow("Greedy", greedyResult, showResultDeviation(greedyResult, inputSet.OptimalValue));
            table.AddRow("Dynamic", dynamicResult, showResultDeviation(dynamicResult, inputSet.OptimalValue));
            table.AddRow("Memory", memoryResult, showResultDeviation(memoryResult, inputSet.OptimalValue));
            table.Write();
        }

        private static string showResultDeviation(int value, int optimalValue)
        {
            return value == optimalValue ? "" : "-" + (optimalValue - value);
        }

        public static void writeTestToFile(string fileName, InputSet inputSet, int testNum, int greedyResult, int dynamicResult, int memoryResult)
        {
            FileStream ostrm;
            StreamWriter writer;
            TextWriter oldOut = Console.Out;

            try
            {
                ostrm = new FileStream("../../../OutputFile/" + fileName + ".txt", FileMode.Append, FileAccess.Write);
                writer = new StreamWriter(ostrm);
            }
            catch (Exception e)
            {
                Console.WriteLine("Cannot open Redirect.txt for writing");
                Console.WriteLine(e.Message);
                return;
            }
            Console.SetOut(writer);

            printTest(inputSet, testNum, greedyResult, dynamicResult, memoryResult);

            Console.SetOut(oldOut);
            writer.Close();
            ostrm.Close();
            Console.WriteLine("Write InputSet " + fileName + " - Done");
        }
    }
}