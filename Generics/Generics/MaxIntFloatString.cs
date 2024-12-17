using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class MaxIntFloatString<T> where T : IComparable<T>
        //This constraint ensures that the type T must implement the IComparable<T> interface.
        //IComparable<T>: An interface that allows objects of type T to be compared with one another.It defines a single method:



    {
        private T First { get; }
        private T Second { get; }
        private T Third { get; }


        //public MaxIntFloatString(T[] MaxIntFloatString)
        //{
        //    this.MaxIntFloatString = MaxIntFloatString;
        //}


        //Constructor to initialize 3 values
        public MaxIntFloatString(T first, T second, T third)
        {
            this.First = first;
            this.Second = second;
            this.Third = third;
        }

        public T FindMax()
        {
            T max = First;

            if (Second.CompareTo(max) > 0)
            {
                max = Second;
            }

            if (Third.CompareTo(max) > 0)
            {
                max = Third;
            }
            return max;
        }


    }
}
