using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAndDsProgrammingProblem
{
    public class Permutation
    {
        public static void permute(String a ,int l, int r)
        {
            if (l == r)
                Console.WriteLine(a);
            else
            {
                for (int i = l; i <= r; i++)
                {
                    a = swap(a, l, i);
                    permute(a, l + 1, r);
                }
            }
        }
        public static String swap(String b, int i, int j)
        {
            char temp;
            char[] charArray = b.ToCharArray();
            temp = charArray[i];
            charArray[i] = charArray[j];
            charArray[j] = temp;
            string s = new string(charArray);
            return s;
        }
    }
}
