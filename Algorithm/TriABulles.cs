using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
   public class TriABulles
    {
        public int[] DoTri(int[] Tab )
        {
            for (int i = Tab.Length-1; i>0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (Tab[j] > Tab[j + 1])
                    {
                        var tmp = Tab[j];
                        Tab[j] = Tab[j + 1];
                        Tab[j + 1] = tmp;
                    }
                }
            }
            return Tab;
        }
    }
}
