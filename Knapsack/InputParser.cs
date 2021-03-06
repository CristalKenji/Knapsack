﻿using Microsoft.VisualBasic.FileIO;

namespace Knapsack
{
    public static class InputParser
    {
        public static InputSet ParseInputFile(string InputSetName)
        {
            int fieldIndex = 0;

            InputSet inputSet = new InputSet();
            int tempWeight = 0;
            int tempValue = 0;
            int itemNameIndex = 1;
            using (TextFieldParser parser = new TextFieldParser(@"..\..\..\InputCSV\" + InputSetName + ".csv"))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(" ");
                while (!parser.EndOfData)
                {
                    //Process row
                    string[] fields = parser.ReadFields();
                    foreach (string field in fields)
                    {
                        //Process field
                        if (parser.LineNumber == 2)
                        {
                            if (fieldIndex == 0)
                            {
                                inputSet.Capacity = int.Parse(field);
                                fieldIndex++;
                            }
                            else if (fieldIndex == 1)
                            {
                                inputSet.OptimalValue = int.Parse(field);
                                fieldIndex = 0;
                            }
                        }
                        else
                        {
                            if (fieldIndex == 0)
                            {
                                tempValue = int.Parse(field);
                                fieldIndex++;
                            }
                            else if (fieldIndex == 1)
                            {
                                tempWeight = int.Parse(field);
                            }
                        }
                    }

                    if (parser.LineNumber != 2)
                    {
                        fieldIndex = 0;
                        inputSet.addItem(new Item("Item" + itemNameIndex, tempWeight, tempValue));
                        itemNameIndex++;
                    }
                }
            }
            return inputSet;
        }
    }
}