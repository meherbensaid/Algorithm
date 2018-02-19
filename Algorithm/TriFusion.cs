using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    public class TriFusion
    {
       
        public  void triFusion(int[] tab, int début, int fin)
        {
            int milieu;
            if (début < fin)
            {
                milieu = (début + fin) / 2;
                triFusion(tab, début, milieu);
                triFusion(tab, milieu + 1, fin);
                fusionner(tab, début, milieu, fin);
            }
        }

        public  void fusionner(int[] tab, int début, int milieu, int fin)
        {
            int[] old_tab = (int[])tab.Clone();
          

            int i1 = début; 
            int i2 = milieu + 1; 
            int i = début; 

            while (i1 <= milieu && i2 <= fin)
            {
               
                if (old_tab[i1] <= old_tab[i2])
                {
                    tab[i] = old_tab[i1];
                    i1++;
                }
                else
                {
                    tab[i] = old_tab[i2];
                    i2++;
                }
                i++;
             }

            if (i <= fin)
            {
                while (i1 <= milieu)  
                {
                    tab[i] = old_tab[i1];
                    i1++;
                    i++;
                }
                while (i2 <= fin) 
                {
                    tab[i] = old_tab[i2];
                    i2++;
                    i++;
                }
            }
        }

      
    }
}
