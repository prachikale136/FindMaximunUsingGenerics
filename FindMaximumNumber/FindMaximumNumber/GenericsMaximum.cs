using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximumNumber
{
    internal class GenericsMaximum<T> where T : IComparable  //<T> is a palceholder which hold the type of data i.e datatype
    {
        public T[] Value;    //create one global variable of array

        public GenericsMaximum(T[] value)
        {
            this.Value = value;
        }

        public T[] Sort(T[] values)
        {
            Array.Sort(values);
            return values;
        }

        public T MaxValue(params T[] values)
        {
            var sorted_value = Sort(values);
            return sorted_value[sorted_value.Length - 1];
        }
        public T MaxMethod()
        {
            var max = MaxValue(this.Value);
            return max;
        }
       
        public void PrintValue()
        {
            var max = MaxValue(this.Value);
            Console.WriteLine("Maximum value is: " + max);
        }
        

    }
}
