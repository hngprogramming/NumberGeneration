using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace NumberGeneration
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * the list, as required, contains numbers from 1 - 10000 without repetition
             * using array of int in this situation is the best approach as the list is fixed in length (10000)
             */
            int[] arr = new int[10000];
            Random r = new Random();
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            /*
             * The first loop is to fill the array with numbers from 1 - 10000 in order
             * After this loop, we'll have a list of unique numbers
             * The second loop is to mix the numbers' orders
             * A number in a random position picked and swaped with the current index in the loop.
             * Time Complexity: O(n)
             */
            for (int i = 0; i < 10000; i++)
            {
                arr[i] = i + 1;
            }
            for (int i = 0; i < 10000; i++)
            {
                int j = r.Next(i + 1);
                int tmp = arr[j];
                arr[j] = arr[i];
                arr[i] = tmp;
            }
            stopwatch.Stop();
            Console.WriteLine("Time (ms): " + stopwatch.ElapsedMilliseconds);
            Console.ReadLine();
        }
    }
}
