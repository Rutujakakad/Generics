using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Program
    {

        static void Main(string[] args)
        {

            //Console.WriteLine("--------------Generic Practise-----------------");
            //int[] intArray = { 1, 2, 3, 4, 5, 6 };
            //double[] doubleArray = { 1.1, 1.2, 1.3, 1.4 };
            //char[] charArray = { 'A', 'B', 'C', 'D' };

            // appraoch-1====>PrintArray.ToPrint(intArray, doubleArray, charArray);
            // approach2==>for without generic
            //PrintArray.ToPrint(intArray);
            //PrintArray.ToPrint(doubleArray);
            //PrintArray.ToPrint(charArray);


            //with generic================================>
            //    new PrintArray<int>(intArray).ToPrint();// with generic
            //    Program.ToPrint<int>(intArray);
            //}



            //    public static void ToPrint<T>(T[] inputArray)
            //    {
            //        foreach (T element in inputArray)
            //        {
            //            Console.WriteLine(element);
            //        }
            //    }

            //=====================================>practise problem:::
            var intMaxFinder = new MaxIntFloatString<int>(13, 5, 10);
            Console.WriteLine($"Maximum of integers: {intMaxFinder.FindMax()}");

            var floatMaxFinder = new MaxIntFloatString<float>(13.3f, 5.10f, 10.3f);
            Console.WriteLine($"Maximum of floats: {floatMaxFinder.FindMax()}");

            var stringMaxFinder = new MaxIntFloatString<string>("grapes", "audi", "strings");
            Console.WriteLine($"Maximum of string: {stringMaxFinder.FindMax()}");





        }


    }
}
