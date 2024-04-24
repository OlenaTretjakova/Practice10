using System;
using System.Collections.Generic;

namespace Practice10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxVal = MathOperations<int>.MaxValue(1, 33, 100);
            int minVal = MathOperations<int>.MinValue(1, 33, 100);

            Console.WriteLine("Max value: " + maxVal);
            Console.WriteLine("Min value: " + minVal);

            int[] array = new int[] { 1, 2, 44, 17, 109 };

            int sumVal = MathOperations<int>.SumArray(array);

            Console.WriteLine($"Sum all of values: {sumVal}");

            Stek<int> stek = new Stek <int>();

            stek.StekPush(81);
            stek.StekPush(1);
            stek.StekPush(8);
            stek.StekPush(8118);
            stek.StekPush(891);
            stek.StekPush(881);

            stek.Show();
            Console.WriteLine();

            stek.StekPop();
            stek.Show();
            Console.WriteLine();

            stek.StekPush(33);
            stek.Show();
            Console.WriteLine();

            Console.WriteLine($"Top value in stek: {stek.StekPeek()}");
            Console.WriteLine($"To Stek has {stek.StekCount()} of eltments.");
            Console.WriteLine();

            Queue<int> queue = new Queue<int>();
            queue.DequeueToQueue();

            Console.WriteLine();
            queue.EnqueueToQueue(12);
            queue.EnqueueToQueue(102);
            queue.EnqueueToQueue(120);
            queue.EnqueueToQueue(142);
            queue.EnqueueToQueue(124);

            queue.Show();

            queue.DequeueToQueue();
            queue.Show();

            Console.WriteLine($"To queue is top element {queue.PeekQueue()}.");
            Console.WriteLine($"To queue are {queue.Count()} of elements.");




            Console.ReadLine();
        }
    }
}
