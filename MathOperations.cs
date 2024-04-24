using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice10
{
    internal class MathOperations<T>
    {
        public static T MaxValue(T value1, T value2, T value3)
        {
            List<T> list = new List<T>();
            list.Add(value1);
            list.Add(value2);
            list.Add(value3);
            return list.Max();
        }

        public static T MinValue(T value1, T value2, T value3)
        {
            List<T> list = new List<T>();
            list.Add(value1);
            list.Add(value2);
            list.Add(value3);
            return list.Min();
        }

        public static T SumArray(T[] array)
        {
            if (array == null || array.Length == 0)
                throw new ArgumentException("Array is empty or null.");
            
            dynamic sum = array[0];

            foreach (var item in array)
            {
                sum += item;
            }
            return sum;
        }
    }
}
