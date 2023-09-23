using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi
{
    internal class Taxi
    {
        static void Main(string[] args)
        {
            int passengers, seats, fulltaxi, leftpass;

            Console.WriteLine("How many passengers are waiting at the station?");
            passengers = int.Parse(Console.ReadLine());

            Console.WriteLine("How many seats are there in a taxi?");
            seats = int.Parse(Console.ReadLine());

            fulltaxi = passengers / seats;

            leftpass = passengers % seats;

            Console.WriteLine($"The amount of full taxis is: {fulltaxi}");
            Console.WriteLine($"{leftpass} people were left behind.");


        }
    }
}
