using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice10
{
    internal class Queue<T>
    {
        public List<T> list;
        public Queue() 
        {
            list = new List<T>();
        }

        public void EnqueueToQueue(T item)
        { 
            list.Add(item);
        }

        public void DequeueToQueue()
        {
            try
            {
                if (list.Count > 0)
                {
                    list.RemoveAt(0);
                }
                else
                {
                    Console.WriteLine("Queue is empty.");
                }
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

        public T PeekQueue()
        {
            if (list.Count > 0)
            {
                return list[0];
            }
            else
            {
                throw new InvalidOperationException("Queue is empty.");
            }
        }

        public int Count()
        {
            return list.Count();
        }

        public void Show()
        {
            if (list.Count == 0)
            {
                Console.WriteLine("Queue is empty.");
                return;
            }

            foreach (T t in list)
            {
                Console.Write(t + "\t");
            }
            Console.WriteLine();

        }


    }
}
