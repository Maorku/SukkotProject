using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShekelChange
{
    internal class ShekelChange
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {

                //input
                Console.WriteLine("Enter amount of change:");
                int change = int.Parse(Console.ReadLine());

                //calc
                int tenShekelCoins = change / 10;
                change %= 10;

                int fiveShekelCoins = change / 5;
                change %= 5;

                int oneShekelCoins = change;

                int totalCoins = tenShekelCoins + fiveShekelCoins + oneShekelCoins;

                //output
                Console.WriteLine("Number of 10₪ coins: " + tenShekelCoins);
                Console.WriteLine("Number of 5₪ coins: " + fiveShekelCoins);
                Console.WriteLine("Number of 1₪ Shekel coins: " + oneShekelCoins);
                Console.WriteLine("Total number of coins: " + totalCoins);
            }
    }
}
