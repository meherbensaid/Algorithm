using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    public class TriRapide
    {
        public  void DoTri(int[] tab)
        {
            if (tab.Length > 0)
            {
                triRapide(tab, 0, tab.Length - 1);
            }
            return;
        }

        public  void triRapide(int[] tab, int debut, int fin)
        {
            if (debut < fin)
            {
                int pivot = ChoosePivot(tab, debut, fin);
                triRapide(tab, debut, pivot - 1);
                triRapide(tab, pivot + 1, fin);
            }
        }

        public  int ChoosePivot(int[] tab, int debut, int fin)
        {
            int compteur = debut;
            int pivot = tab[debut];
            for (int i = debut + 1; i <= fin; i++)
            {
                if (tab[i] < pivot) 
                {
                    compteur++; 
                    int tmp = tab[i];
                    tab[i] = tab[compteur];
                    tab[compteur] = tmp;
                }
            }
            int tmp1 = tab[debut];
            tab[debut] = tab[compteur];
            tab[compteur] = tmp1;
            return compteur;
        }

        
    }
}
