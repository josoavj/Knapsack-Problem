using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 3 - Implémentation du parcours inverse permettant de détailler les objets à emporter
namespace algo_avance
{    
            /* Explication des variables utilisées:
             * W = Capacité du sac à dos
             * wt = Le poids de l'objet
             * val = Profit
             * n = Représente l'objet
             */
class SacADosSolver
        {
            private int[,] mat = new int[4,10]; // Tableau pour stocker les résultats intermédiaires
            private int n; // Nombre d'objets
            private int W; // Capacité du sac
            private int[] wt; // Tableau des poids des objets
            private int[] val; // Tableau des valeurs des objets

            public SacADosSolver(int W, int[] wt, int[] val)
            {
                this.W = W;
                this.wt = wt;
                this.val = val;
                this.n = val.Length;
                this.mat = new int[n + 1, W + 1];
            }

            public int Resoudre()
            {
                for (int i = 0; i <= n; i++)
                {
                    for (int w = 0; w <= W; w++)
                    {
                        if (i == 0 || w == 0)
                            mat[i, w] = 0;
                        else if (wt[i - 1] <= w)
                            mat[i, w] = Math.Max(val[i - 1] + mat[i - 1, w - wt[i - 1]], mat[i - 1, w]);
                        else
                            mat[i, w] = mat[i - 1, w];
                    }
                }
                return mat[n, W];
            }

            public void AfficherMat()
            {
                Console.WriteLine("Matrice :");
                for (int i = 0; i <= n; i++)
                {
                    for (int w = 0; w <= W; w++)
                    {
                        Console.Write(mat[i, w] + "\t");
                    }
                    Console.WriteLine();
                }
            }
        }

    }
