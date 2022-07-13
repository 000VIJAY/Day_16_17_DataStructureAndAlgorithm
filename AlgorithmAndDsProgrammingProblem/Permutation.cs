using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAndDsProgrammingProblem
{ 
    public class BinarySearch
    {
        public void SortingAndCalling(String sentence, String find)    
        {
            String[] word = sentence.Split(' ');        
            Array.Sort(word);
            BinarySearch.Search(word, find);                    //search function
        }
        //Binary Search
        public static void Search(String[] sentenceOne, String find)        
        {
            int minIndex = 0;
            int maxIndex = sentenceOne.Length - 1;
            int flag = 0;
            while (minIndex <= maxIndex)
            {
                int mid = (minIndex + maxIndex) / 2;
                if (sentenceOne[mid].CompareTo(find) == 0)
                {
                   flag = 1;
                    Console.WriteLine("Found at " + mid + " position ");
                    break;
                }
                else if (sentenceOne[mid].CompareTo(find) > 0)
                {
                    maxIndex = mid - 01;
                }
                else
                {
                    minIndex = mid + 1;
                }
            }
            if (flag == 0)
            {
                Console.WriteLine("Not found");
            }
        }
    }

}
