using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinaCS
{
    internal class DinaCS
    {
        static void Main(string[] args)
        {
            // דינה מעוניינת לדעת את הציון הכולל שלה במדעי המחשב. ידוע כי שתי היחידות
            //הראשונות מהוות % 33 מהציון, היחידה השלישית מהווה % 17 מהציון, ושתי
            //היחידות האחרונות מהוות % 50 מהציון הכללי. פתחו אלגוריתם המגריל את שלושת
            //ציוניה של דינה במדעי המחשב(בשתי היחידות הראשונות, ביחידה השלישית ובשתי
            //היחידות האחרונות) כמספרים שלמים בין - 0 ל - 100 ומציג כפלט את ציונה הכולל.

            double grade33, grade17, grade50, totalgrd;
            Random rnd = new Random();

            grade17 = rnd.Next(0, 101);
            grade33 = rnd.Next(0, 101);
            grade50 = rnd.Next(0, 101);

            grade17 *= 0.17;
            grade33 *= 0.33;
            grade50 *= 0.50;

            Console.WriteLine("Dina's grades are");
            Console.WriteLine($"Unit 1 and 2: {grade33}");
            Console.WriteLine($"Unit 3: {grade17}");
            Console.WriteLine($"Unit 4 and 5: {grade50}");

            totalgrd = grade17 + grade33 + grade50;

            Console.WriteLine($"Dina's Computer Science grade is: {totalgrd}");
            
            
        }
    }
}
