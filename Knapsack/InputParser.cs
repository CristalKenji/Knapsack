﻿using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Knapsack
{
    internal static class InputParser
    {
        public static InputSet ParseInputFile(string InputSetName)
        {
            int fieldIndex = 0;
            int optimalValue = 0;

            InputSet inputSet = new InputSet();
            int tempWeight = 0;
            int tempValue = 0;
            int itemNameIndex = 0;

            using (TextFieldParser parser = new TextFieldParser(@"C:\HS Fulda\Semester 4\Komplexitätstheorie\Knapsack\Knapsack\InputCSV\" + InputSetName + ".csv")) //@"c:\temp\test.csv"
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(";");
                while (!parser.EndOfData)
                {
                    //Process row
                    string[] fields = parser.ReadFields();
                    foreach (string field in fields)
                    {
                        Console.WriteLine("Line " + parser.LineNumber);
                        //TODO: Process field
                        if (parser.LineNumber == 2)
                        {
                            inputSet.Capacity = int.Parse(field);
                        }
                        else
                        {
                            if (fieldIndex == 0)
                            {
                                tempWeight = int.Parse(field);
                                fieldIndex++;
                            }
                            else if (fieldIndex == 1)
                            {
                                tempValue = int.Parse(field);
                                fieldIndex++;
                            }
                            else if (fieldIndex == 2)
                            {
                                if (int.Parse(field) == 1)
                                {
                                    optimalValue += tempValue;
                                }
                            }
                        }
                        Console.WriteLine(field);
                    }

                    if (parser.LineNumber != 2)
                    {
                        fieldIndex = 0;
                        inputSet.addItem(new Item("Item" + itemNameIndex, tempWeight, tempValue));
                        inputSet.OptimalValue = optimalValue;
                        itemNameIndex++;
                    }
                    Console.WriteLine("-------------------------------------------------");
                }
            }
            return inputSet;
        }
    }
}