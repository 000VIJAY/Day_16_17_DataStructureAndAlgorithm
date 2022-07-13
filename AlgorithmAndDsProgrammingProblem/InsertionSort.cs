using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AlgorithmAndDsProgrammingProblem
{
    public class Insertion
    {
        public static void InsertionSort(string sentence)
        {
            string[] word = sentence.Split(' ');
            for (int i = 1; i < (word.Length) - 1; i++)
            {
                int j = i;
                string key = word[i];


                while (word[j - 1].CompareTo(key) > 0)
                {
                    word[j] = word[j - 1];
                    j--;
                    if (j == 0)
                    {
                        break;
                    }
                }
                word[j] = key;
            }
            Console.WriteLine();
            for (int i = 0; i < word.Length; i++)
            {
                Console.WriteLine(word[i] + " ");
            }
        }
    }
}
