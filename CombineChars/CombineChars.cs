using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombineChars
{
    internal class CombineChars
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number as a character: ");
            char charNum1 = Console.ReadKey().KeyChar;
            Console.WriteLine();

            if (char.IsLetter(charNum1)) 
            {
                Console.WriteLine("The character should represent a digit.");
            }
            else
            {
                Console.Write("Enter the second number as a character: ");
                char charNum2 = Console.ReadKey().KeyChar;
                Console.WriteLine();

                if (char.IsDigit(charNum2))
                {
                    int num1 = int.Parse(charNum1.ToString());
                    int num2 = int.Parse(charNum2.ToString());

                    int sum = num1 + num2;

                    Console.WriteLine($"Sum of {num1} and {num2} is: {sum}");
                }
                else
                {
                    Console.WriteLine("Both characters should represent valid digits.");
                }

                

            }
            
                


        }
    }
}
