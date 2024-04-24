using System;
using System.Collections.Generic;

namespace Practice10
{
    internal class Stek<T>
    {
        public List<T> List;
        public Stek()
        {
            this.List = new List<T>();
        }

        public void StekPop()
        {
            if (List.Count > 0)
            {
                List.RemoveAt(List.Count - 1);
            }
            else
            {
                Console.WriteLine("Stec is empty");
            }
        }

        public void StekPush(T value)
        {
                List.Add(value);
        }

        public T StekPeek()
        {
            if (List.Count > 0)
            {
                return List[List.Count - 1];
            }
            else
            {
                throw new InvalidOperationException("Stek is empty.");
            }
        }

        public int StekCount()
        { 
            return List.Count;
        }
        public void Show()
        {
            foreach (T t in List)
            {
                Console.Write(t + "\t");
            }
        }
    }
}
