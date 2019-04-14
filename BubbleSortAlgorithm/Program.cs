using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                //AFTER EACH ITERATION ONE LESS ELEMENT IS NEEDED TO BE COMPAREED
                //FOR THIS REASON -i IS ADDED AS FOLLOWS
                for (int j = 0; j < numArray.Count() - 1 - i; j++)
                {
                    if (numArray[j] > numArray[j + 1])
                    {
                        //SWAPPING THE VALUES
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
            Console.WriteLine("The sorted numbers are as follows:");
            Console.WriteLine("==================================");
            for (int i = 0; i < sortArray.Count(); i++)
            {
                Console.Write("{0} ", sortArray[i]);
            }
            Console.ReadLine();
        }
    }
}
