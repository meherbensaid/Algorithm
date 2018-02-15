using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    //complexite object(n2)
    public class TriSelection
    {

        public int[] DoTri(int[] Tab)
        {
            for (int i = 0; i < Tab.Length; i++)
            {
                var min = i;
                for (int j = i+1; j < Tab.Length; j++)
                {
                    if (Tab[j] < Tab[min])
                    {
                        min = j;
                    }
                }
                var tmp = Tab[i];
                Tab[i] = Tab[min];
                Tab[min] = tmp;
            }

            return Tab;

        }
        
    }
}
