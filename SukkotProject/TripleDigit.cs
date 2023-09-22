﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SukkotProject
{
    internal class TripleDigit
    {
        static void Main(string[] args)
        {

            //vars
            int num, single, ten, hundred;

            //number generation
            Random rnd = new Random();
            num = rnd.Next(100, 1000);


            Console.WriteLine($"The number is: {num}");

            //calc
            hundred = num / 100;
            ten = (num / 10) % 10;
            single = num % 10;

            Console.WriteLine(hundred);
            Console.WriteLine(ten);
            Console.WriteLine(single);

            //int reverse = single * 100 + ten * 10 + hundred;
            //Console.WriteLine(reverse);
            //^ will not work when last digit is 0

            string a, b, c;
            a = single.ToString();
            b = ten.ToString();
            c = hundred.ToString();

            Console.WriteLine($"{a}{b}{c}");

        }
    }
}