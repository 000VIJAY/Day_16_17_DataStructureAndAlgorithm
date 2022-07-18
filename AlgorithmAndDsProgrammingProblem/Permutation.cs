using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAndDsProgrammingProblem
{
    public class BubbleSort
    {
        public void SortBubble(params int[] num)
        {
            for (int j = 0; j < num.Length-1; j++)
            {
                for (int i = 0; i < (num.Length-j) - 1; i++)
                {
                    if (num[i] > num[i + 1])
                    {
                        int temp = num[i];
                        num[i] = num[i + 1];
                        num[i + 1] = temp;
                    }
                }
            }
           PrintArray(num);
        }
        public void PrintArray(int[] num)
        {
            for (int i = 0; i < num.Length; ++i)
                Console.Write(num[i] + " ");
            Console.WriteLine();
        }
    }
}


