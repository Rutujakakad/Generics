using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class PrintArray<T>
    {
        private T[] inputArray;

        public PrintArray(T[] inputArray)
        {
            this.inputArray = inputArray;
        }

        public void ToPrint()
        {
            foreach (T element in inputArray)
            {
                Console.WriteLine(element);
            }
        }
    }
}
