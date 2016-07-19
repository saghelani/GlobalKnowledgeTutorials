using System;
using System.Collections.Generic;
using System.Text;

namespace BaseConversion
{
    public enum Base { Hex, Dec, Oct, Bin };

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<Base, ABase> numberBaseStrategies = new Dictionary<Base, ABase>();

            numberBaseStrategies[Base.Hex] = new Hex();
            numberBaseStrategies[Base.Dec] = new Dec();
            numberBaseStrategies[Base.Oct] = new Oct();
            numberBaseStrategies[Base.Bin] = new Bin();

            Console.Write("Enter Source Base:");
            Base sourceBase = (Base)Enum.Parse(typeof(Base), Console.ReadLine());

            Console.Write("Enter To Base:");
            Base destBase = (Base)Enum.Parse(typeof(Base), Console.ReadLine());

            ABase sourceBaseStrategy = numberBaseStrategies[sourceBase];
            ABase destBaseStrategy = numberBaseStrategies[destBase];

            while (true)
            {
                ConvertFromToBase(sourceBaseStrategy, destBaseStrategy);
            }
        }

        private static void ConvertFromToBase(ABase sourceBase, ABase destBase)
        {
            string sourceValue = GetNumericValue(sourceBase);

            int valueToConvert = sourceBase.Parse(sourceValue);

            string convertedValueAsString = destBase.ToString(valueToConvert);

            Console.WriteLine(" = {0}", convertedValueAsString);
        }

        private static string GetNumericValue(ABase numberBase)
        {
            StringBuilder valueAsString = new StringBuilder();
            ConsoleKeyInfo keyPressed = new ConsoleKeyInfo();


            while ((keyPressed = Console.ReadKey(true)).Key != ConsoleKey.Enter)
            {
                if (keyPressed.Key == ConsoleKey.Backspace)
                {
                    if (valueAsString.Length > 0)
                    {
                        valueAsString.Length--;
                        Console.CursorLeft = 0;
                        Console.Write("{0} ", valueAsString.ToString());
                        Console.CursorLeft--;
                    }
                }
                else
                {
                    if (numberBase.IsValidChar(keyPressed.KeyChar))
                    {
                        valueAsString.Append(keyPressed.KeyChar);
                        Console.Write(keyPressed.KeyChar);
                    }
                }
            }

            return valueAsString.ToString();
        }
    }
}
