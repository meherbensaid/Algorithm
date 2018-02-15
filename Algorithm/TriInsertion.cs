using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    /*Complexité au pire des cas O(n2)*/
    public class TriInsertion
    {
        public int[] DoTri(int[] Tab)
        {
            for (int i = 1; i < Tab.Length; i++)
            {
                var x = Tab[i];
                var j = i;
                while (j>0 && Tab[j-1]>x)
                {
                    Tab[j] = Tab[j - 1];
                    j--;
                }
                Tab[j] = x;
            }
            return Tab;
        }
    }
}
