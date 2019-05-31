using System;
using System.Collections.Generic;
using System.Linq;

namespace BubbleSortAlgorithm
{
    public class BubbleSort
    {
        int[] numArray = new int[] { 1, 5, 3, 18, 30, 22, 37, 7, 11, 8, 12, 2, 50, 41, 15 };
        int temp;

        public int[] DoSort()
        {
            for (int i = 0; i < numArray.Count(); i++)
            {
                // After each iteration one less element is needed to be compared and for this reason -i is added as follows.
                for (int j = 0; j < numArray.Count() - 1 - i; j++)
                {
                    if (numArray[j] > numArray[j + 1])
                    {
                        // Swapping the values
                        temp = numArray[j];
                        numArray[j] = numArray[j + 1];
                        numArray[j + 1] = temp;
                    }
                }
            }

            return numArray;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BubbleSort bs = new BubbleSort();
            int[] sortArray = bs.DoSort();
            Console.WriteLine("INPUT: An array of unsorted numbers is as follows:");
            Console.WriteLine("==================================================");
            Console.WriteLine("1, 5, 3, 18, 30, 22, 37, 7, 11, 8, 12, 2, 50, 41, 15");
            Console.WriteLine();
            Console.WriteLine("OUTPUT: The sorted numbers are as follows:");
            Console.WriteLine("==========================================");           
            for (int i = 0; i < sortArray.Count(); i++)
            {
                Console.Write("{0} ", sortArray[i]);
            }

            Console.ReadLine();
        }
    }
}
