using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_to_binary_converter
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            string binaryString = StringToBinary(input);

            Console.WriteLine("Binary representation: " + binaryString);
        }

        static string StringToBinary(string input)
        {
            string binaryString = "";

            foreach (char c in input)
            {
                int asciiValue = (int)c;
                string binaryValue = Convert.ToString(asciiValue, 2).PadLeft(8, '0');
                binaryString += binaryValue + " "; // Add a space between binary values
            }

            return binaryString;
        }
    }
}
