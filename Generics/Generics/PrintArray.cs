using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{ // -----------WITHOUT GENERIC-------------------
    internal class PrintArray
    {
        //int[] intArrays= new int[4];
        //PrintArray pntarrys= new PrintArray();
        //int a = 0;

        public static void ToPrint(int[] intArray)
        {
            foreach(int element in intArray)
            {
                Console.WriteLine(element);
            }
        }

        public static void ToPrint(double[] doubArray)
        {
            foreach (double element in doubArray)
            {
                Console.WriteLine(element);
            }
        }

        public static void ToPrint(char[] charArray)
        {
            foreach (char element in charArray)
            {
                Console.WriteLine(element);
            }
        }
    }
}
