using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo_avance
{
    class Knapsack
    {
        public  int knapSack(int W, int[] wt, int[] val, int n)
        {
            /* Explication des variables utilisées:
             * W = Capacité du sac à dos
             * wt = Le poids de l'objet
             * val = Profit
             * n = Représente l'objet
             */

            static int max(int a, int b) { return (a > b) ? a : b; }
            // Valeur max entre deux entiers affiché
            // max -> retourne la valeur maximale que peut supporter le sac à dos
            
            /* 
             * * Si le poids de l'objet est supérieur à la capacité W du sac à dos,
               * alors l'objet ne peut pas être inclus dans la solution optimale
               *          
             */

            if (n == 0 || W == 0)
                return 0;

            if (wt[n - 1] > W)
                return knapSack(W, wt, val, n - 1);

            // Retourne le maximum dans deux cases du tableau:
            // (1) Inclus dans le tableau
            // (2) Exclus dans le tableau
            else
                return max(val[n - 1]
                            + knapSack(W - wt[n - 1], wt,
                                        val, n - 1),
                        knapSack(W, wt, val, n - 1));
        }
    }
}
